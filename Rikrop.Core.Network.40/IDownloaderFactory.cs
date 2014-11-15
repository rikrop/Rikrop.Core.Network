using System;
using System.Diagnostics.Contracts;
using Rikrop.Core.Network.Contracts;

namespace Rikrop.Core.Network
{
    [ContractClass(typeof(ContractIDownloaderFactory<>))]
    public interface IDownloaderFactory<in TKey>
    {
        IDownloader Create(TKey key);
    }

    namespace Contracts
    {
        [ContractClassFor(typeof(IDownloaderFactory<>))]
        public abstract class ContractIDownloaderFactory<TKey> : IDownloaderFactory<TKey>
        {
            public IDownloader Create(TKey key)
            {
                Contract.Requires<ArgumentNullException>(!Equals(key, null));
                Contract.Ensures(Contract.Result<IDownloader>() != null);
                return default(IDownloader);
            }
        }
    }
}