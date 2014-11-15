using System;

namespace Rikrop.Core.Network.FtpClient
{
    public class FtpItem
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsDirectory { get; set; }
        public ulong Size { get; set; }
        public string Flags { get; set; }
        public bool IsSymLink { get; set; }
        public string Owner { get; set; }
        public string Group { get; set; }
        public string SymLinkTargetPath { get; set; }
    }
}