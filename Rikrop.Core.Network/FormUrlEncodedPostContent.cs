using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Rikrop.Core.Network
{
    public class FormUrlEncodedPostContent : IPostContent
    {
        private readonly IEnumerable<KeyValuePair<string, string>> _data;

        public IEnumerable<KeyValuePair<string, string>> Data
        {
            get { return _data; }
        }

        public FormUrlEncodedPostContent(IEnumerable<KeyValuePair<string, string>> data)
        {
            Contract.Requires<ArgumentNullException>(data != null);

            _data = data;
        }
    }
}