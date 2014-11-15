using System;
using System.Diagnostics.Contracts;
using Rikrop.Core.Network.Contracts;

namespace Rikrop.Core.Network
{
    [ContractClass(typeof (ContractIHttpRequest))]
    public interface IHttpRequest
    {
        string Method { get; }
        string Address { get; }
        IHttpHeadersCollection Headers { get; }
        IPostContent PostContent { get; }
        TimeSpan Timeout { get; }
        bool AllowRedirects { get; }
    }

    namespace Contracts
    {
        [ContractClassFor(typeof (IHttpRequest))]
        public abstract class ContractIHttpRequest : IHttpRequest
        {
            public string Method
            {
                get
                {
                    Contract.Ensures(!string.IsNullOrWhiteSpace(Contract.Result<string>()));
                    return default(string);
                }
            }

            public string Address
            {
                get
                {
                    Contract.Ensures(!string.IsNullOrWhiteSpace(Contract.Result<string>()));
                    return default(string);
                }
            }

            public IHttpHeadersCollection Headers
            {
                get
                {
                    Contract.Ensures(Contract.Result<IHttpHeadersCollection>() != null);
                    return default(IHttpHeadersCollection);
                }
            }

            public abstract IPostContent PostContent { get; }

            public TimeSpan Timeout
            {
                get
                {
                    return default(TimeSpan);
                }
            }

            public abstract bool AllowRedirects { get; }
        }
    }
}