using System;
using System.Diagnostics.Contracts;

namespace Rikrop.Core.Network
{
    public class GenericDownloaderFactory<TKey> : IDownloaderFactory<TKey>
    {
        private readonly Func<TKey, IDownloader> _creationDelegate;

        public GenericDownloaderFactory(Func<TKey, IDownloader> creationDelegate)
        {
            Contract.Requires<ArgumentNullException>(creationDelegate != null);

            _creationDelegate = creationDelegate;
        }

        public IDownloader Create(TKey key)
        {
            return _creationDelegate(key);
        }
    }
}