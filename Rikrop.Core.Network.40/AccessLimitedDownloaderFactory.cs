using System;
using System.Diagnostics.Contracts;

namespace Rikrop.Core.Network
{
    public class AccessLimitedDownloaderFactory<TKey>: IDownloaderFactory<TKey>
    {
        private readonly IDownloaderFactory<TKey> _downloaderFactory;
        private readonly TimeSpan _pageLoadTimout;

        public AccessLimitedDownloaderFactory(IDownloaderFactory<TKey> downloaderFactory, TimeSpan pageLoadTimout)
        {
            Contract.Requires<ArgumentNullException>(downloaderFactory != null);
            Contract.Requires<ArgumentException>(pageLoadTimout != TimeSpan.Zero);
            _downloaderFactory = downloaderFactory;
            _pageLoadTimout = pageLoadTimout;
        }

        public IDownloader Create(TKey key)
        {
            return new AccessLimitedDownloader(targetDownloader:_downloaderFactory.Create(key),
                                               pageLoadTimout: _pageLoadTimout);
        }
    }
}