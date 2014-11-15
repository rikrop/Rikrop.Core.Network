using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using Rikrop.Core.Network.Contracts;

namespace Rikrop.Core.Network
{
    [ContractClass(typeof(ContractIAccessLimiter))]
    public interface IAccessLimiter
    {
        Task WaitAsync();
        void Release();
    }

    namespace Contracts
    {
        [ContractClassFor(typeof(IAccessLimiter))]
        public abstract class ContractIAccessLimiter : IAccessLimiter
        {
            public Task WaitAsync()
            {
                Contract.Ensures(Contract.Result<Task>() != null);
                return default(Task);
            }

            public abstract void Release();
        }
    }
}