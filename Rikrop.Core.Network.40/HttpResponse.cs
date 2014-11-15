using System;
using System.Diagnostics.Contracts;
using System.Net;

namespace Rikrop.Core.Network
{
    public class HttpResponse : IHttpResponse
    {
        private readonly IHttpHeadersCollection _headers;
        private readonly byte[] _content;
        private readonly HttpStatusCode _statusCode;

        public IHttpHeadersCollection Headers
        {
            get { return _headers; }
        }

        public byte[] Content
        {
            get { return _content; }
        }

        public HttpStatusCode StatusCode
        {
            get { return _statusCode; }
        }

        public HttpResponse(IHttpHeadersCollection headers, byte[] content, HttpStatusCode statusCode)
        {
            Contract.Requires<ArgumentNullException>(headers != null);
            Contract.Requires<ArgumentNullException>(content != null);
            _headers = headers;
            _content = content;
            _statusCode = statusCode;
        }
    }
}