namespace Rikrop.Core.Network.Mail
{
    public interface IEmailMessage
    {
        string Subject { get; set; }
        string Body { get; set; }
        bool IsBodyHtml { get; set; }
    }
}