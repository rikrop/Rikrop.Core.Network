using System;
using System.Collections.Generic;
using System.Linq;

namespace Rikrop.Core.Network.Helpers
{
    public class TagAttributeParser
    {
        //private readonly string _lcAttribute;
        //private readonly string _ucAttribute;
        //private readonly string _lcTag;
        //private readonly string _ucTag;

        private const string Postfix = "=\"";

        private static readonly List<TagAttr> TagAttrs = new List<TagAttr>();

        public TagAttributeParser(Dictionary<string, string> tagattrdict)
        {
            if (tagattrdict == null || tagattrdict.Count == 0)
            {
                throw new InvalidOperationException("Parameter 'tagattrdict' cannot be empty.");
            }

            foreach (var keypair in tagattrdict)
            {
                var tagattr = new TagAttr(keypair.Key, keypair.Value + Postfix);
                TagAttrs.Add(tagattr);
            }
        }

        public TagAttributeParser(string tag, string attribute)
        {
            TagAttrs.Add(new TagAttr(tag, attribute + Postfix));

            //_lcAttribute = attribute.ToLower() + Postfix;
            //_ucAttribute = attribute.ToUpper() + Postfix;
            //_lcTag = tag.ToLower();
            //_ucTag = tag.ToUpper();
        }

        public Dictionary<string, string[]> Parse(string html)
        {
            var dict = new Dictionary<string, string[]>();

            foreach (var tagAttr in TagAttrs)
            {
                dict[tagAttr.LcTag] = Parse(html, tagAttr);
            }

            return dict;
        }

        private string[] Parse(string html, TagAttr tagattr)
        {
            var attrLen = tagattr.LcAttr.Length;
            var tagLen = tagattr.LcTag.Length;

            var list = new List<string>();

            var index = -1;
            var startIndex = -1;

            var tagActivated = false;

            for (var i = 0; i < html.Length; i++)
            {
                if (i < html.Length - tagLen - 2 && html[i] == '<')
                {
                    for (var j = 0; j < tagLen && index == -1; j++)
                    {
                        if (html[i + j + 1] == tagattr.LcTag[j] || html[i + j + 1] == tagattr.UcTag[j])
                        {
                            if (j == tagLen - 1)
                            {
                                tagActivated = true;
                                i += tagLen;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                for (var j = 0; j < attrLen && index == -1 && tagActivated; j++)
                {
                    if (html[i + j] == tagattr.LcAttr[j] || html[i + j] == tagattr.UcAttr[j])
                    {
                        if (j == attrLen - 1)
                        {
                            index = i;
                            startIndex = index + attrLen;
                            i = startIndex;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (html[i] == '"' && index != -1 && tagActivated)
                {
                    var end = i - startIndex;

                    var attrValue = html.Substring(startIndex, end);
                    list.Add(attrValue);

                    index = -1;
                    tagActivated = false;
                }
            }
            return list.Distinct().ToArray();
        }

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
    }
}