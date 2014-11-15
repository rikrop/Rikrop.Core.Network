using NUnit.Framework;

namespace Rikrop.Core.Network.Tests
{
    [TestFixture]
    internal class HttpResponseContentDecoderTest
    {
        private HttpDownloader _downloader;
        private HttpResponseContentDecoder _decoder;

        [SetUp]
        public void SetUp()
        {
            _downloader = new HttpDownloader();
            _decoder = new HttpResponseContentDecoder();
        }

        [Ignore("Slow")]
        [TestCase("http://newtimes.ru/rss/")]
        [TestCase("http://sobesednik.ru/rss.php")]
        [TestCase("http://rusnovosti.ru/news/")]
        public void MustDecodeXml(string url)
        {
            var httpResponse = _downloader.Download(new HttpGetRequest(url, new HttpHeadersCollection())).Result;
            var decodedResult = _decoder.DecodeContent(httpResponse);

            Assert.True(decodedResult != null);
        }
    }
}