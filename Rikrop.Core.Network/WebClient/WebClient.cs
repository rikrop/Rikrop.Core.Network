using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Rikrop.Core.Network.WebClient
{
    public class WebClient : System.Net.WebClient
    {
        private static readonly Regex ContentTypeFormat = new Regex("(?<type>[\\w-]+)/(?<subtype>[\\w-+]+)(;|$)", RegexOptions.Compiled);
        private static readonly EncodingInfo[] Encodings = Encoding.GetEncodings();
        private readonly ICharsetDefinitionStrategy _charsetDefinitionStrategy;
        public String ContentType { get; private set; }
        public string ContentSubType { get; private set; }
        public string Charset { get; private set; }
        public string Html { get; private set; }
        public byte[] Data { get; private set; }
        public CompressionType CompressionType { get; set; }

        public string UserAgent { get; set; }
        public string Accept { get; set; }
        public string ResponseCharset { get; set; }


        public WebClient():this(new DefaultCharsetDefinitionStrategy())
        {
            UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:10.0.2) Gecko/20100101 Firefox/10.0.2";
            Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
        }

        public WebClient(ICharsetDefinitionStrategy charsetDefinitionStrategy)
        {
            _charsetDefinitionStrategy = charsetDefinitionStrategy;
        }

        protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult ar)
        {
            var sw = Stopwatch.StartNew();
            var response = base.GetWebResponse(request, ar) as HttpWebResponse;
            sw.Stop();

            if (response != null)
            {
                var contentType = response.Headers["Content-Type"];
                var hasCharsetHeader = !String.IsNullOrEmpty(contentType) && contentType.IndexOf("charset", StringComparison.InvariantCultureIgnoreCase) >= 0;

                if (hasCharsetHeader)
                {
                    ResponseCharset = response.CharacterSet;
                }

                var match = ContentTypeFormat.Match(response.ContentType);
                if (match.Success)
                {
                    ContentType = match.Groups["type"].Value.ToLower();
                    ContentSubType = match.Groups["subtype"].Value.ToLower();
                }

                if (response.ContentEncoding.IndexOf("gzip", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    CompressionType = CompressionType.GZip;
                }
                else if (response.ContentEncoding.IndexOf("deflate", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    CompressionType = CompressionType.Deflate;
                }
                else
                {
                    CompressionType = CompressionType.None;
                }
            }

            return response;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var req = base.GetWebRequest(address) as HttpWebRequest;

            if (req != null)
            {
                req.AllowAutoRedirect = false;
                req.ServicePoint.ConnectionLeaseTimeout = 0;
                req.KeepAlive = false;
                req.Pipelined = true;
                req.UserAgent = UserAgent;
                req.Accept = Accept;
            }

            return req;
        }

        protected override void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                base.OnDownloadStringCompleted(e);
            }
        }

        protected override void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                base.OnDownloadDataCompleted(e);
                return;
            }

            using (var stream = new MemoryStream())
            {
                stream.Write(e.Result, 0, e.Result.Length);
                using (var uncompressedStream = GetUncompressedStream(stream))
                {
                    Data = uncompressedStream.ToArray();

                    if (!IsValidContentType())
                    {
                        base.OnDownloadDataCompleted(e);
                        return;
                    }

                    Charset = _charsetDefinitionStrategy.DefineCharset(uncompressedStream, this);


                    switch (Charset.ToLower())
                    {
                        case "win-1251":
                            Charset = "windows-1251";
                            break;
                        case "utf8":
                            Charset = "utf-8";
                            break;
                        case "cp1251":
                            Charset = "windows-1251";
                            break;
                    }

                    if (!String.IsNullOrEmpty(Charset))
                    {
                        SetHtml(Charset);
                    }
                }
            }

            base.OnDownloadDataCompleted(e);
        }

        private bool IsValidContentType()
        {
            return ContentType == "text" || (ContentType == "application" && (ContentSubType.EndsWith("xml") || ContentSubType.StartsWith("xml")));
        }

        private void SetHtml(string charset)
        {
            var info = Encodings.FirstOrDefault(encodingInfo => String.Compare(encodingInfo.Name, charset, StringComparison.InvariantCultureIgnoreCase) == 0);

            if (info != null)
            {
                Html = info.GetEncoding().GetString(Data);
            }
        }

        private MemoryStream GetUncompressedStream(MemoryStream compressedStream)
        {
            compressedStream.Seek(0, SeekOrigin.Begin);
            Stream stream;
            switch (CompressionType)
            {
                case CompressionType.None:
                    return compressedStream;
                case CompressionType.GZip:
                    stream = new GZipStream(compressedStream, CompressionMode.Decompress);
                    break;
                case CompressionType.Deflate:
                    stream = new DeflateStream(compressedStream, CompressionMode.Decompress);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var memStream = new MemoryStream();
            stream.CopyTo(memStream);

            return memStream;
        }
    }
}