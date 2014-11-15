using System.Collections.Generic;

namespace Rikrop.Core.Network.Helpers
{
    public class MultiTagAttributeParser
    {
        public void Add(string tag, string attr)
        {
            TAs.Add(new TagAttr(tag, attr));
        }

        private List<TagAttr> TAs = new List<TagAttr>();

        private class TagAttr
        {
            public TagAttr(string tag, string attr)
            {
                LcTag = tag.ToLower();
                UcTag = tag.ToUpper();
                LcAttr = attr.ToLower();
                UcAttr = attr.ToUpper();
            }

            public string LcTag { get; set; }
            public string LcAttr { get; set; }
            public string UcTag { get; set; }
            public string UcAttr { get; set; }
        }

        public IEnumerable<string> Parse(string html)
        {
            throw new System.NotImplementedException();
        }
    }
}