namespace Rikrop.Core.Network.Mail
{
    public interface IEmailAccount
    {
        string Name { get; set; }
        string EmailAdress { get; set; }
        string ToAdressString();
    }
}