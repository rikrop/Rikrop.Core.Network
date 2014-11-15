using System;

namespace Rikrop.Core.Network
{
    public class HttpGetRequest : HttpRequest
    {
        public override string Method
        {
            get { return HttpRequestMethod.Get; }
        }

        public override IPostContent PostContent
        {
            get { throw new NotSupportedException(); }
        }

        public HttpGetRequest(string address, IHttpHeadersCollection headers, TimeSpan? timeout = null, bool allowRedirects = true)
            : base(address, headers, timeout, allowRedirects)
        {
        }
    }
}