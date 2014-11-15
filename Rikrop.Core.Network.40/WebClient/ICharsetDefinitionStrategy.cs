using System.IO;

namespace Rikrop.Core.Network.WebClient
{
    public interface ICharsetDefinitionStrategy
    {
        /// <summary>
        /// Defines Charset
        /// </summary>
        /// <param name="uncompressedStream">Uncompressed stream</param>
        /// <param name="webClient">Api web client</param>
        /// <returns></returns>
        string DefineCharset(Stream uncompressedStream, WebClient webClient);
    }
}