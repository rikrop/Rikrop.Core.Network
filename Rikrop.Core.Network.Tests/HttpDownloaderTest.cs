using System;
using System.Net;
using NUnit.Framework;

namespace Rikrop.Core.Network.Tests
{
    [TestFixture]
    internal class HttpDownloaderTest
    {
        [Ignore("Slow")]
        [TestCase("http://mis.ru")]
        [TestCase("http://google.com")]
        public void MustGetValidResponse(string url)
        {
            var downloader = new HttpDownloader();
            var response = downloader.Download(new HttpGetRequest(url, new HttpHeadersCollection())).Result;

            Assert.True(response != null);
        }

        [Ignore("Slow")]
        [TestCase("http://google.ru")]
        public void CookieContainerCanParseSetCookieHeader(string url)
        {
            var downloader = new HttpDownloader();
            var response = downloader.Download(new HttpGetRequest(url, new HttpHeadersCollection())).Result;

            var cookieContainer = new CookieContainer();
            var uri = new Uri(url);

            string setCookieHeader;
            response.Headers.TryGetValue("Set-Cookie",out setCookieHeader);
            cookieContainer.SetCookies(uri, setCookieHeader);

            Assert.DoesNotThrow(() => cookieContainer.GetCookieHeader(uri));
        }
    }
}