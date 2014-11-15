using System;
using System.Diagnostics.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace Rikrop.Core.Network
{
    public class AccessLimiter : IAccessLimiter
    {
        private readonly SemaphoreSlim _semaphore;

        public AccessLimiter(int simultaneousAccessCount)
        {
            Contract.Requires<ArgumentException>(simultaneousAccessCount > 0);
            _semaphore = new SemaphoreSlim(initialCount: simultaneousAccessCount);
        }

        public Task WaitAsync()
        {
            return _semaphore.WaitAsync();
        }

        public void Release()
        {
            _semaphore.Release();
        }
    }
}