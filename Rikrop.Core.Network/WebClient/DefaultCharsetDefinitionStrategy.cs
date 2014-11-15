using System.IO;

namespace Rikrop.Core.Network.WebClient
{
    public class DefaultCharsetDefinitionStrategy : ICharsetDefinitionStrategy
    {
        private static string GetCharset(Stream stream)
        {
            stream.Seek(0, SeekOrigin.Begin);

            var sr = new StreamReader(stream);
            var text = sr.ReadToEnd();

            var analizer = new CharsetAnalizer();

            var metaCharset = analizer.GetCharsetFromMetadata(text);

            if (!string.IsNullOrEmpty(metaCharset))
            {
                return metaCharset;
            }

            stream.Seek(0, SeekOrigin.Begin);
            var autoCharset = analizer.AutoDetectCharset(stream);

            return !string.IsNullOrEmpty(autoCharset)
                       ? autoCharset
                       : null;
        }

        public string DefineCharset(Stream uncompressedStream, WebClient webClient)
        {
            string charset;

            const string defaultEnc = "ISO-8859-1";

            if (string.IsNullOrEmpty(webClient.ResponseCharset))
            {
                charset = GetCharset(uncompressedStream) ?? defaultEnc;
            }
            else
            {
                charset = webClient.ResponseCharset;
            }
            
            return charset;
        }
    }
}