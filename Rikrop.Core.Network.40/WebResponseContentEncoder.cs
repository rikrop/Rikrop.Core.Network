using System;
using System.IO;
using System.IO.Compression;

namespace Rikrop.Core.Network
{
    public class WebResponseContentEncoder : IHttpResponseContentEncoder
    {
        public bool TryEncodeContent(IHttpResponse httpResponse, out byte[] result)
        {
            result = null;
            string contentEncoding;

            if (!httpResponse.Headers.TryGetValue(HttpRequestHeader.ContentEncoding, out contentEncoding) ||
                contentEncoding.IndexOf("gzip", StringComparison.InvariantCultureIgnoreCase) >= 0 ||
                contentEncoding.IndexOf("deflate", StringComparison.InvariantCultureIgnoreCase) >= 0)
            {
                return false;
            }

            result = GetBytes(new GZipStream(new MemoryStream(httpResponse.Content), CompressionMode.Compress));
            return true;
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
    }
}