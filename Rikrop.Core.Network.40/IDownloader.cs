using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using Rikrop.Core.Network.Contracts;

namespace Rikrop.Core.Network
{
    [ContractClass(typeof(ContractIDownloader))]
    public interface IDownloader
    {
        Task<IHttpResponse> Download(IHttpRequest httpRequest);
    }

    namespace Contracts
    {
        [ContractClassFor(typeof(IDownloader))]
        public abstract class ContractIDownloader : IDownloader
        {
            public Task<IHttpResponse> Download(IHttpRequest httpRequest)
            {
                Contract.Requires<ArgumentNullException>(httpRequest != null);
                Contract.Ensures(Contract.Result<Task<IHttpResponse>>() != null);
                return default(Task<IHttpResponse>);
            }
        }
    }
}