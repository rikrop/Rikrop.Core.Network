using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace Rikrop.Core.Network
{
    public class AccessLimitedDownloader : IDownloader
    {
        private readonly IDownloader _targetDownloader;
        private readonly TimeSpan _pageLoadTimout;
        private readonly IAccessLimiter _accessLimiter;

        public AccessLimitedDownloader(IDownloader targetDownloader, TimeSpan pageLoadTimout)
        {
            Contract.Requires<ArgumentException>(pageLoadTimout != TimeSpan.Zero);
            Contract.Requires<ArgumentNullException>(targetDownloader != null);

            _targetDownloader = targetDownloader;
            _pageLoadTimout = pageLoadTimout;

            _accessLimiter = new AccessLimiter(simultaneousAccessCount: 1);
        }

        public async Task<IHttpResponse> Download(IHttpRequest httpRequest)
        {
            await _accessLimiter.WaitAsync();
            try
            {
                return await _targetDownloader.Download(httpRequest);
            }
            finally
            {
                Delay();
            }
        }

        private async void Delay()
        {
            await Task.Delay(_pageLoadTimout);
            _accessLimiter.Release();
        }
    }
}