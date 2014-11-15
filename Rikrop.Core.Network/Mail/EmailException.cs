using System;

namespace Rikrop.Core.Network.Mail
{
    public class EmailException : Exception
    {
        public EmailException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}