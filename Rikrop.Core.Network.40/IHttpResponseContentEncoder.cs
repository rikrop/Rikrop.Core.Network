using System;
using System.Diagnostics.Contracts;
using Rikrop.Core.Network.Contracts;

namespace Rikrop.Core.Network
{
    [ContractClass(typeof(ContractIHttpResponseContentEncoder))]
    public interface IHttpResponseContentEncoder
    {
        bool TryEncodeContent(IHttpResponse httpResponse, out byte[] result);
    }

    namespace Contracts
    {
        [ContractClassFor(typeof(IHttpResponseContentEncoder))]
        public abstract class ContractIHttpResponseContentEncoder : IHttpResponseContentEncoder
        {
            public bool TryEncodeContent(IHttpResponse httpResponse, out byte[] result)
            {
                Contract.Requires<ArgumentNullException>(httpResponse != null);

                result = new byte[] { };
                return default(bool);
            }
        }
    }
}