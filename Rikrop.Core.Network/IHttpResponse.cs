using System.Diagnostics.Contracts;
using System.Net;
using Rikrop.Core.Network.Contracts;

namespace Rikrop.Core.Network
{
    [ContractClass(typeof(ContractIHttpResponse))]
    public interface IHttpResponse
    {
        IHttpHeadersCollection Headers { get; }
        byte[] Content { get; }
        HttpStatusCode StatusCode { get; }
    }

    namespace Contracts
    {
        [ContractClassFor(typeof(IHttpResponse))]
        public abstract class ContractIHttpResponse : IHttpResponse
        {
            public IHttpHeadersCollection Headers
            {
                get
                {
                    Contract.Ensures(Contract.Result<IHttpHeadersCollection>() != null);
                    return default(IHttpHeadersCollection);
                }
            }
            public byte[] Content
            {
                get
                {
                    Contract.Ensures(Contract.Result<byte[]>() != null);
                    return default(byte[]);
                }
            }

            public abstract HttpStatusCode StatusCode { get; }
        }
    }
}