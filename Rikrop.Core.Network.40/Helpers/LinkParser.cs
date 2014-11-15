using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rikrop.Core.Network.Helpers
{
    public static class LinkParser
    {
        public static List<string> ParseHtmlRawLinks(string html)
        {
            //Welcome to India
            const string hrefConst = "href=\"";
            const string HREFConst = "HREF=\"";
            const string srcConst = "src=\"";
            const string SRCConst = "SRC=\"";
            var hrefLen = hrefConst.Length;
            var srcLen = srcConst.Length;

            var list = new List<string>();

            int index = -1;
            int startIndex = -1;

            bool tag_A_activated = false;
            bool tag_IMG_activated = false;

            for (int i = 0; i < html.Length; i++)
            {
                if (i < html.Length - 10 && html[i] == '<') //<a href=""/> - min length ~10
                {
                    switch (html[i + 1])
                    {
                        case 'a':
                        case 'A':
                            tag_A_activated = true;
                            break;
                        case 'i':
                        case 'I':
                            var m = html[i + 2];
                            var g = html[i + 3];
                            if ((m == 'm' || m == 'M') && (g == 'g' || g == 'G'))
                                tag_IMG_activated = true;
                            break;
                    }
                }

                if (tag_A_activated)
                {
                    for (int j = 0; j < hrefLen && index == -1; j++)
                    {
                        if (html[i + j] == hrefConst[j] || html[i + j] == HREFConst[j])
                        {
                            if (j == hrefLen - 1)
                            {
                                index = i;
                                startIndex = index + hrefLen;
                                i = startIndex;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (tag_IMG_activated)
                {
                    for (int j = 0; j < srcLen && index == -1; j++)
                    {
                        if (html[i + j] == srcConst[j] || html[i + j] == SRCConst[j])
                        {
                            if (j == srcLen - 1)
                            {
                                index = i;
                                startIndex = index + srcLen;
                                i = startIndex;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (html[i] == '"' && index != -1 && (tag_A_activated || tag_IMG_activated))
                {
                    int end = i - startIndex;

                    var href = html.Substring(startIndex, end);
                    list.Add(href);

                    index = -1;
                    tag_A_activated = false;
                    tag_IMG_activated = false;
                }
            }
            return list;
        }

        public const String UrlTemplate = "http://{0}{1}";
        // Работает примерно в 1.2 раза быстрее чем RestoreAbsoluteUrlCorrect, но не всегда корректно!!!
        public static string RestoreAbsoluteUrlFast(string path, string host)
        {
            try
            {
                if (path.StartsWith("http://"))
                {
                    return path;
                }

                return String.Format(UrlTemplate, host, path);
            }
            catch(Exception ex)
            {
                Console.WriteLine("RAUF " + ex.Message);
                return string.Empty;
            }
        }

        // Работает медленне RestoreAbsoluteUrlFast, но гарантирует корректность
        public static string RestoreAbsoluteUrlCorrect(string path, string baseUrl)
        {
            try
            {
                var baseUri = new Uri(baseUrl);
                var relUri = new Uri(path, UriKind.RelativeOrAbsolute);
                var absUri = new Uri(baseUri, relUri);
                return absUri.AbsoluteUri;
            }
            catch(Exception ex)
            {
                Console.WriteLine("RAUC " + ex.Message);
                //var incLink = RestoreAbsoluteUrlFast(path, baseUrl);
                return string.Empty;
            }
        }

        private static readonly Regex LinkFormat = new Regex("https?://(?<host>[^/]+)/", RegexOptions.Compiled);
        public static bool IsUrlInDomain(string url, string domain)
        {
            var host = LinkFormat.Match(url).Groups["host"].Value;

            return host.EndsWith(domain);
        }

        public static string[] DefineLinks(string link, string host, string html)
        {
            var links = ParseHtmlRawLinks(html);

            var linksInDomain = FilterNotDomainLinks(links, new Uri(link), host);
            return linksInDomain.Select(RemoveAnchor).ToArray();
        }

        public static string RemoveAnchor(string link)
        {
            var octothorpIndex = link.IndexOf('#');
            if (octothorpIndex != -1)
                return link.Substring(0, octothorpIndex);
            
            return link;
        }

        public static IEnumerable<string> FilterNotDomainLinks(IEnumerable<string> links, Uri linkUri, string host)
        {
            return from t in links
                   select RestoreAbsoluteUrlCorrect(t, linkUri.Scheme + "://" + linkUri.Host + linkUri.AbsolutePath) into absLink
                   where IsUrlInDomain(absLink, host)
                   select absLink;
        }

    }
}
