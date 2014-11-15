using System;
using System.Diagnostics.Contracts;

namespace Rikrop.Core.Network
{
    public abstract class HttpRequest : IHttpRequest
    {
        private static readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(100);

        private readonly TimeSpan _timeout;
        private readonly string _address;
        private readonly IHttpHeadersCollection _headers;
        private readonly bool _allowRedirects;

        public abstract string Method { get; }

        public string Address
        {
            get { return _address; }
        }

        public IHttpHeadersCollection Headers
        {
            get { return _headers; }
        }

        public abstract IPostContent PostContent { get; }

        public TimeSpan Timeout
        {
            get { return _timeout; }
        }

        public bool AllowRedirects
        {
            get { return _allowRedirects; }
        }

        protected HttpRequest(string address, IHttpHeadersCollection headers, TimeSpan? timeout, bool allowRedirects)
        {
            Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(address));
            Contract.Requires<ArgumentNullException>(headers != null);

            _address = address;
            _headers = headers;
            _allowRedirects = allowRedirects;
            _timeout = timeout ?? DefaultTimeout;
        }
    }
}