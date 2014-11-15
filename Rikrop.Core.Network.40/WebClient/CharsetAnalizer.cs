using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Ude;

namespace Rikrop.Core.Network.WebClient
{
    /* RFC 2616 
     * 3.7.1
       ... When no explicit charset
           parameter is provided by the sender, media subtypes of the "text"
           type are defined to have a default charset value of "ISO-8859-1" when
           received via HTTP. Data in character sets other than "ISO-8859-1" or
           its subsets MUST be labeled with an appropriate charset value. See
           section 3.4.1 for compatibility problems.
     
     * 3.4.1 Missing Charset
           Some HTTP/1.0 software has interpreted a Content-Type header without
           charset parameter incorrectly to mean "recipient should guess."
           Senders wishing to defeat this behavior MAY include a charset
           parameter even when the charset is ISO-8859-1 and SHOULD do so when
           it is known that it will not confuse the recipient.

           Unfortunately, some older HTTP/1.0 clients did not deal properly with
           an explicit charset parameter. HTTP/1.1 recipients MUST respect the
           charset label provided by the sender; and those user agents that have
           a provision to "guess" a charset MUST use the charset from the
           content-type field if they support that charset, rather than the
           recipient's preference, when initially displaying a document. See
           section 3.7.1.
     * 
     * В стандарте HTTP все красиво - есть в ответе кодировка - юзайте ее, нет - ISO-8859-1
     * Но часто в заголовках ответа и в реальной странице кодировка может отличаться
     * Например http://www-archive.mozilla.org/projects/intl/UniversalCharsetDetection.html
     * 
     * Спецификация HTML
       The HTTP protocol ([RFC2616], section 3.7.1) mentions ISO-8859-1 as a default character encoding when the "charset" parameter is absent from the "Content-Type" header field.
       In practice, this recommendation has proved useless because some servers don't allow a "charset" parameter to be sent, and others may not be configured to send the parameter. 
       Therefore, user agents must not assume any default value for the "charset" parameter.
       To address server or configuration limitations, HTML documents may include explicit information about the document's character encoding;
       the  META element can be used to provide user agents with this information.
     * 
     * Но на практике в html документах этот тег тоже часто отсутствует.
     * Поэтому рекомендуемый workflow такой:
     * 1) Пробуем определить кодировку по метаданным (GetCharsetFromMetadata)
     * 2) Если не получилось - пробуем автодетектор (AutoDetectCharset)
     * 3) Если не получилось - смотрим заголовки ответа (GetCharsetForUrl)
     * 4) Если не получилось - считаем что кодировка ISO-8859-1 
     */

    public class CharsetAnalizer
    {
        private static readonly Regex MetaCharsetRegex = new Regex("<meta(?!\\s*(?:name|value)\\s*=)[^>]*?charset\\s*=[\\s\"']*(?<charset>[^;\\s\"'/>]*)",
                                                                   RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private static readonly Regex XmlCharsetRegex = new Regex("<\\?xml(?!\\s*(?:name|value)\\s*=)[^>]*?encoding\\s*=[\\s\"']*(?<charset>[^;\\s\"'/>]*)",
                                                                  RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public string GetCharsetFromMetadata(string input)
        {
            var match = MetaCharsetRegex.Match(input);

            if (!match.Success)
            {
                match = XmlCharsetRegex.Match(input);
            }

            return !match.Success
                       ? null
                       : match.Groups["charset"].Value;
        }

        public string AutoDetectCharset(Stream input)
        {
            try
            {
                var cdet = new CharsetDetector();
                cdet.Feed(input);
                cdet.DataEnd();

                return cdet.Charset;
            }
            catch
            {
                return null;
            }
        }

        public string GetCharsetForUrl(string url)
        {
            var request = WebRequest.Create(url) as HttpWebRequest;
            if (request != null)
            {
                var response = request.GetResponse() as HttpWebResponse;
                return GetCharsetFromResponse(response);
            }

            return null;
        }

        public string GetCharsetFromResponse(HttpWebResponse response)
        {
            Contract.Requires<ArgumentNullException>(response != null);

            return response.CharacterSet;
        }
    }
}