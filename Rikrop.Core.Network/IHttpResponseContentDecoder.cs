using System;
using System.Diagnostics.Contracts;
using Rikrop.Core.Network.Contracts;

namespace Rikrop.Core.Network
{
    [ContractClass(typeof(ContractIHttpResponseContentDecoder))]
    public interface IHttpResponseContentDecoder
    {
        string DecodeContent(IHttpResponse httpResponse);
    }

    namespace Contracts
    {
        [ContractClassFor(typeof(IHttpResponseContentDecoder))]
        public abstract class ContractIHttpResponseContentDecoder : IHttpResponseContentDecoder
        {
            public string DecodeContent(IHttpResponse httpResponse)
            {
                Contract.Requires<ArgumentNullException>(httpResponse != null);
                return default(string);
            }
        }
    }
}