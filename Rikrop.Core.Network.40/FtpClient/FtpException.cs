using System;
using System.Runtime.Serialization;

namespace Rikrop.Core.Network.FtpClient
{
    public class FtpException : Exception
    {
        public FtpException(string message)
            : base(message)
        {
        }

        public FtpException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected FtpException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}