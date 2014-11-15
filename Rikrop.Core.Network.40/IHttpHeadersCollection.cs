using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Rikrop.Core.Network.Contracts;

namespace Rikrop.Core.Network
{
    [ContractClass(typeof (ContractHttpHeadersCollection))]
    public interface IHttpHeadersCollection : IEnumerable<KeyValuePair<string, string>>
    {
        void Add(string header, string value);
        void Set(string header, string value);
        void Remove(string header);
        bool TryGetValue(string header, out string value);
    }

    namespace Contracts
    {
        [ContractClassFor(typeof (IHttpHeadersCollection))]
        public abstract class ContractHttpHeadersCollection : IHttpHeadersCollection
        {
            public abstract IEnumerator<KeyValuePair<string, string>> GetEnumerator();

            public void Add(string header, string value)
            {
                Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(header));
                Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(value));
            }

            public void Set(string header, string value)
            {
                Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(header));
                Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(value));
            }

            public void Remove(string header)
            {
                Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(header));
            }

            public bool TryGetValue(string header, out string value)
            {
                Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(header));
                value = default(string);
                return default(bool);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}