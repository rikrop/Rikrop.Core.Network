using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Rikrop.Core.Network.WebClient;

namespace Rikrop.Core.Network
{
    public class HttpResponseContentDecoder : IHttpResponseContentDecoder
    {
        private static readonly Regex ContentTypeFormat = new Regex("(?<type>[\\w-]+)/(?<subtype>[\\w-+]+)(;|$)", RegexOptions.Compiled);

        private static readonly Regex CharsetFormat = new Regex("charset=(?<charset>[\\w-]+)(;|$)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private readonly Dictionary<string, EncodingInfo> _encodings;

        public HttpResponseContentDecoder()
        {
            _encodings = Encoding
                .GetEncodings()
                .GroupBy(o => o.Name.ToUpperInvariant())
                .Where(o => o.Count() == 1)
                .ToDictionary(o => o.First().Name.ToUpperInvariant(), o => o.First());
        }

        private static bool IsTextContent(IHttpResponse httpResponse, out string charset)
        {
            charset = null;
            string contentTypeString;
            if (!httpResponse.Headers.TryGetValue(HttpRequestHeader.ContentType, out contentTypeString))
            {
                return false;
            }

            var match = ContentTypeFormat.Match(contentTypeString);

            if (match.Success)
            {
                var type = match.Groups["type"].Value.ToLower();
                var subtype = match.Groups["subtype"].Value.ToLower();

                if (type == "text" || subtype.Contains("xml"))
                {
                    var chmatch = CharsetFormat.Match(contentTypeString);

                    if (chmatch.Success)
                    {
                        charset = chmatch.Groups["charset"].Value;
                    }

                    return true;
                }
            }

            return false;
        }

        public string DecodeContent(IHttpResponse httpResponse)
        {
            string headersCharset;
            if (!IsTextContent(httpResponse, out headersCharset))
            {
                return null;
            }

            var bytes = UnzipBytesContent(httpResponse);
            return DecodeStringContent(bytes, headersCharset);
        }

        private byte[] UnzipBytesContent(IHttpResponse httpResponse)
        {
            string contentEncoding;

            if (!httpResponse.Headers.TryGetValue(HttpRequestHeader.ContentEncoding, out contentEncoding))
            {
                return httpResponse.Content;
            }
            if (contentEncoding.IndexOf("gzip", StringComparison.InvariantCultureIgnoreCase) >= 0)
            {
                return GetBytes(new GZipStream(new MemoryStream(httpResponse.Content), CompressionMode.Decompress));
            }
            if (contentEncoding.IndexOf("deflate", StringComparison.InvariantCultureIgnoreCase) >= 0)
            {
                return GetBytes(new DeflateStream(new MemoryStream(httpResponse.Content), CompressionMode.Decompress));
            }
            return httpResponse.Content;
        }

        private byte[] GetBytes(Stream stream)
        {
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                var buf = ms.ToArray();
                return buf;
            }
        }

        private string DecodeStringContent(byte[] content, string headersCharset)
        {
            var charset = headersCharset ?? GetCharset(content) ?? "ISO-8859-1";
            switch (charset.ToLower())
            {
                case "win-1251":
                    charset = "windows-1251";
                    break;
                case "utf8":
                    charset = "utf-8";
                    break;
                case "cp1251":
                    charset = "windows-1251";
                    break;
                case "ascii":
                    charset = "us-ascii";
                    break;
            }
            EncodingInfo encodingInfo;
            if (_encodings.TryGetValue(charset.ToUpperInvariant(), out encodingInfo))
            {
                return encodingInfo.GetEncoding().GetString(content);
            }

            throw new InvalidOperationException(string.Format("Unknown charset: {0}", charset));
        }

        private string GetCharset(byte[] content)
        {
            var analizer = new CharsetAnalizer();

            var asciiStr = Encoding.ASCII.GetString(content);
            var metaCharset = analizer.GetCharsetFromMetadata(asciiStr);
            if (!string.IsNullOrEmpty(metaCharset))
            {
                return metaCharset;
            }

            using (var ms = new MemoryStream(content))
            {
                var autoCharset = analizer.AutoDetectCharset(ms);
                if (!string.IsNullOrEmpty(autoCharset))
                {
                    return autoCharset;
                }

                return null;
            }
        }
    }
}