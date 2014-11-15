using System.Collections.Generic;

namespace Rikrop.Core.Network.Mail
{
    public interface IEmailSender
    {
        void SendMessage(IEmailMessage message, IEmailAccount sender, IEmailAccount to);
        void SendMessage(IEmailMessage message, IEmailAccount sender, IEnumerable<IEmailAccount> to);
    }
}