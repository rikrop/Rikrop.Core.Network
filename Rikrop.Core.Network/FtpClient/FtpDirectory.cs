using System.Collections.Generic;
using System.Linq;

namespace Rikrop.Core.Network.FtpClient
{
    public class FtpDirectory
    {
        private readonly FtpItem[] _files;

        public IEnumerable<FtpItem> Files
        {
            get { return _files; }
        }

        public FtpDirectory(IEnumerable<FtpItem> files)
        {
            _files = files.ToArray();
        }
    }
}