using System;
using System.Diagnostics.Contracts;

namespace Rikrop.Core.Network
{
    public class HttpPostRequest : HttpRequest
    {
        private readonly IPostContent _postContent;

        public override string Method
        {
            get { return HttpRequestMethod.Post; }
        }

        public override IPostContent PostContent
        {
            get { return _postContent; }
        }

        public HttpPostRequest(string address, IHttpHeadersCollection headers, IPostContent postContent, TimeSpan? timeout = null, bool allowRedirects = true)
            : base(address, headers, timeout, allowRedirects)
        {
            Contract.Requires<ArgumentNullException>(postContent != null);

            _postContent = postContent;
        }
    }
}