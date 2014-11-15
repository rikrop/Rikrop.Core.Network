using System;
using System.Diagnostics.Contracts;
using System.Text;

namespace Rikrop.Core.Network
{
    public class StringPostContent : IPostContent
    {
        private readonly string _data;
        private readonly Encoding _encoding;
        private readonly string _mediaType;

        public string Data
        {
            get { return _data; }
        }

        public Encoding Encoding
        {
            get { return _encoding; }
        }

        public string MediaType
        {
            get { return _mediaType; }
        }

        public StringPostContent(string data, Encoding encoding = null, string mediaType = null)
        {
            Contract.Requires<ArgumentException>(!string.IsNullOrWhiteSpace(data));

            _data = data;
            _encoding = encoding;
            _mediaType = mediaType;
        }
    }
}