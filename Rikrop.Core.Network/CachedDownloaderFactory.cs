using System;
using System.Collections.Concurrent;
using System.Diagnostics.Contracts;

namespace Rikrop.Core.Network
{
    public class CachedDownloaderFactory<TKey> : IDownloaderFactory<TKey>
    {
        private readonly IDownloaderFactory<TKey> _downloaderFactory;
        private readonly ConcurrentDictionary<TKey, IDownloader> _downloaders;

        public CachedDownloaderFactory(IDownloaderFactory<TKey> downloaderFactory)
        {
            Contract.Requires<ArgumentNullException>(downloaderFactory != null);
            _downloaderFactory = downloaderFactory;
            _downloaders = new ConcurrentDictionary<TKey, IDownloader>();
        }

        public IDownloader Create(TKey key)
        {
            return _downloaders.GetOrAdd(key, guid => _downloaderFactory.Create(key));
        }
    }
}