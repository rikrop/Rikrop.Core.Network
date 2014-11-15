using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Rikrop.Core.Network
{
    public class HttpHeadersCollection : IHttpHeadersCollection
    {
        private readonly Dictionary<string, string> _headers;

        public HttpHeadersCollection()
        {
            _headers = new Dictionary<string, string>();
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return _headers.GetEnumerator();
        }

        public void Add(string header, string value)
        {
            Contract.Assume(!_headers.ContainsKey(header), string.Format("Headers in {0} already contains a key: {1}", typeof(HttpHeadersCollection).Name, header));
            
            Set(header, value);
        }

        public void Set(string header, string value)
        {
            _headers[header] = value;
        }

        public void Remove(string header)
        {
            _headers.Remove(header);
        }

        public bool TryGetValue(string header, out string value)
        {
            return _headers.TryGetValue(header, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}