using System;
using System.Net.Mail;

namespace Rikrop.Core.Network.Mail
{
    public class EmailAccount : IEmailAccount
    {
        private string _emailAdress;
        public string Name { get; set; }

        public string EmailAdress
        {
            get { return _emailAdress; }
            set
            {
                try
                {
#pragma warning disable 168
                    var mailAdress = new MailAddress(value);
#pragma warning restore 168
                    _emailAdress = value;
                }
                catch (Exception)
                {
                    throw new FormatException("Неправильный формат Email:" + " " + _emailAdress);
                }
            }
        }

        public EmailAccount(string name, string emailAdress)
        {
            Name = name;
            EmailAdress = emailAdress;
        }

        public string ToAdressString()
        {
            return String.Concat(Name, " <", EmailAdress, ">");
        }
    }
}