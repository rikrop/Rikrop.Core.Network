namespace Rikrop.Core.Network.Mail
{
    public class EmailMessage : IEmailMessage
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }

        public EmailMessage(string subject, string body, bool isHtml)
        {
            Subject = subject;
            Body = body;
            IsBodyHtml = isHtml;
        }

        public EmailMessage(string subject, string body)
            :this(subject, body, false)
        {
        }

        public EmailMessage()
        {
            
        }
    }
}