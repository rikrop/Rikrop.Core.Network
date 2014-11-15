using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Rikrop.Core.Network.Mail
{
    public class SmtpMailSender : IEmailSender
    {
        private readonly SmtpClient _smtpClient;
        private const string ErrorMessage = "Error sending message, see inner exception for details";

        public SmtpMailSender(string smtpHost, int smtpPort, string login, string password, string domain, bool enableSsl = false)
        {
            _smtpClient = new SmtpClient(smtpHost, smtpPort)
                              {
                                  Credentials = new NetworkCredential(login, password,domain),
                                  EnableSsl = enableSsl
                              };
        }

        public void SendMessage(IEmailMessage message, IEmailAccount sender, IEmailAccount to)
        {
            SendMessageBySmtp(message, sender, to);
        }

        public void SendMessage(IEmailMessage message, IEmailAccount sender, IEnumerable<IEmailAccount> to)
        {
            SendMessageBySmtp(message, sender, to.ToArray());
        }

        private void SendMessageBySmtp(IEmailMessage message, IEmailAccount sender, params IEmailAccount[] to)
        {
            try
            {
                var msg = new MailMessage
                {
                    BodyEncoding = Encoding.UTF8,
                    Subject = message.Subject,
                    Body = message.Body,
                    From = new MailAddress(sender.ToAdressString()),
                    IsBodyHtml = message.IsBodyHtml,
                };

                foreach (var emailRecipient in to)
                {
                    msg.To.Add(new MailAddress(emailRecipient.ToAdressString()));
                }
                
                _smtpClient.Send(msg);
            }
            catch (Exception exception)
            {
                throw new EmailException(ErrorMessage,exception);
            }
        }
    }
}