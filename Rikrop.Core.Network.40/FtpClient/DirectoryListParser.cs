using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Rikrop.Core.Network.FtpClient
{
    internal static class DirectoryListParser
    {
        private const string UnixSymLinkPathSeparator = " -> ";
        private const string ParsingErrorMessage = "Не получилось распарсить содержание директории";
        private static readonly CultureInfo CultureInfo = CultureInfo.GetCultureInfo("en-US");

        public static IEnumerable<FtpItem> GetDirectoryList(this string datastring, string uri)
        {
            try
            {
                if (!uri.EndsWith("/"))
                {
                    uri = uri + "/";
                }

                var directoryList = new List<FtpItem>();
                var dataRecords = datastring.Split('\n');

                var directoryListStyle = GuessDirectoryListingStyle(dataRecords);

                foreach (var s in dataRecords)
                {
                    if (directoryListStyle == DirectoryListingStyle.Unknown || s == "")
                    {
                        continue;
                    }

                    var f = new FtpItem {Name = ".."};

                    switch (directoryListStyle)
                    {
                        case DirectoryListingStyle.UnixStyle:
                            f = ParseFtpFileFromUnixStyleRecord(s);
                            break;
                        case DirectoryListingStyle.WindowsStyle:
                            f = ParseFtpFileFromWindowsStyleRecord(s);
                            break;
                    }
                    if (!(f == null || f.Name == "." || f.Name == ".."))
                    {
                        f.Path = uri + f.Name;
                        directoryList.Add(f);
                    }
                }
                return directoryList;
            }
            catch (Exception ex)
            {
                throw new FtpException(ParsingErrorMessage, ex);
            }
        }

        private static FtpItem ParseFtpFileFromWindowsStyleRecord(string record)
        {
            //Assuming the record style as
            // 02-03-04  07:46PM       <DIR>          Append

            var f = new FtpItem();
            var processstr = record.Trim();
            var dateStr = processstr.Substring(0, 8);
            processstr = (processstr.Substring(8, processstr.Length - 8)).Trim();
            var timeStr = processstr.Substring(0, 7);
            processstr = (processstr.Substring(7, processstr.Length - 7)).Trim();

            f.CreationTime = DateTime.Parse(dateStr + " " + timeStr, CultureInfo);
            if (processstr.Substring(0, 5) == "<DIR>")
            {
                f.IsDirectory = true;
                processstr = (processstr.Substring(5, processstr.Length - 5)).Trim();
            }
            else
            {
                f.IsDirectory = false;

                var i = processstr.IndexOf(' ');
                f.Size = ulong.Parse(processstr.Substring(0, i));

                processstr = processstr.Substring(i + 1);
            }

            f.Name = processstr; //Rest is name   
            return f;
        }

        private static DirectoryListingStyle GuessDirectoryListingStyle(IEnumerable<string> recordList)
        {
            foreach (var s in recordList)
            {
                if (s.Length > 10
                    && Regex.IsMatch(s.Substring(0, 10), "(-|d)(-|r)(-|w)(-|x)(-|r)(-|w)(-|x)(-|r)(-|w)(-|x)"))
                {
                    return DirectoryListingStyle.UnixStyle;
                }

                if (s.Length > 8
                    && Regex.IsMatch(s.Substring(0, 8), "[0-9][0-9]-[0-9][0-9]-[0-9][0-9]"))
                {
                    return DirectoryListingStyle.WindowsStyle;
                }
            }
            return DirectoryListingStyle.Unknown;
        }

        private static FtpItem ParseFtpFileFromUnixStyleRecord(string record)
        {
            //Assuming record style as
            // dr-xr-xr-x   1 owner    group               0 Nov 25  2002 bussys

            // Mac OS X - tnftpd returns the total on the first line
            if (record.ToLower().StartsWith("total "))
            {
                return null;
            }

            var f = new FtpItem();
            var processstr = record.Trim();
            f.Flags = processstr.Substring(0, 9);
            f.IsDirectory = (f.Flags[0] == 'd');

            // Note: there is no way to determine here if the symlink refers to a dir or a file
            f.IsSymLink = (f.Flags[0] == 'l');
            processstr = (processstr.Substring(11)).Trim();
            CutSubstringFromStringWithTrim(ref processstr, " ", 0); //skip one part
            f.Owner = CutSubstringFromStringWithTrim(ref processstr, " ", 0);
            f.Group = CutSubstringFromStringWithTrim(ref processstr, " ", 0);
            f.Size = ulong.Parse(CutSubstringFromStringWithTrim(ref processstr, " ", 0));

            var creationTimeStr = CutSubstringFromStringWithTrim(ref processstr, " ", 8);
            var dateFormat = creationTimeStr.IndexOf(':') < 0
                                 ? "MMM dd yyyy"
                                 : "MMM dd H:mm";

            // Some servers (e.g.: Mac OS X 10.5 - tnftpd) return days < 10 without a leading 0 
            if (creationTimeStr[4] == ' ')
            {
                creationTimeStr = creationTimeStr.Substring(0, 4) + "0" + creationTimeStr.Substring(5);
            }

            f.CreationTime = DateTime.ParseExact(creationTimeStr, dateFormat, CultureInfo, DateTimeStyles.AllowWhiteSpaces);

            if (f.IsSymLink && processstr.IndexOf(UnixSymLinkPathSeparator, StringComparison.Ordinal) > 0)
            {
                f.Name = CutSubstringFromStringWithTrim(ref processstr, UnixSymLinkPathSeparator, 0);
                f.SymLinkTargetPath = processstr;
            }
            else
            {
                f.Name = processstr; //Rest of the part is name
            }
            return f;
        }

        private static string CutSubstringFromStringWithTrim(ref string s, string str, int startIndex)
        {
            var pos1 = s.IndexOf(str, startIndex, StringComparison.Ordinal);
            var retString = s.Substring(0, pos1);
            s = (s.Substring(pos1 + str.Length)).Trim();
            return retString;
        }

        private enum DirectoryListingStyle
        {
            UnixStyle,
            WindowsStyle,
            Unknown
        }
    }
}