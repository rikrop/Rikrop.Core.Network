using System;
using System.Collections;
using System.IO;
using Rikrop.Core.Network.WebClient;
using NUnit.Framework;

namespace Rikrop.Core.Network.Tests
{
    [TestFixture]
    public class CharsetAnalizerTest
    {
        private const string HtmlPageWithCharset1 =
            "<!DOCTYPE html><html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" /></head><body></body></html>";

        private const string HtmlPageWithCharset2 =
            "<!DOCTYPE html><html><head><meta name=\"author\" value=\"me\"><!-- Maybe we should have a charset=something meta element? --><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" /></head><body></body></html>";

        private const string HtmlPageWithCharset3 =
            "<!DOCTYPE html><html><head><meta charset=\"utf-8\" /></head><body></body></html>";

        private const string HtmlPageWithoutCharset1 = "<!DOCTYPE html><html><head></head><body></body></html>";

        private const string HtmlPageWithoutCharset2 =
            "<!DOCTYPE html><html><head><meta name=\"author\" value=\"me\"><!-- Maybe we should have a charset=something meta element? --></head><body></body></html>";

        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(HtmlPageWithCharset1, "utf-8");
                yield return new TestCaseData(HtmlPageWithCharset2, "utf-8");
                yield return new TestCaseData(HtmlPageWithCharset3, "utf-8");
                yield return new TestCaseData(HtmlPageWithoutCharset1, null);
                yield return new TestCaseData(HtmlPageWithoutCharset2, null);

                var russ = File.ReadAllText("TestData/russ.ru.txt");
                yield return new TestCaseData(russ, "utf-8");
            }
        }

        [Test]
        [TestCase("TestData/utf-8.txt", "utf-8")]
        [TestCase("TestData/win1252.txt", "windows-1252")]
        [TestCase("TestData/win1252-2.txt", "windows-1252")]
        [TestCase("TestData/win1251.txt", "windows-1251")]
        public void ShouldAutodetectCharset(string filePath, string expectedCharset)
        {
            var stream = File.OpenRead(filePath);
            var analizer = new CharsetAnalizer();
            var charset = analizer.AutoDetectCharset(stream);

            Assert.AreEqual(0, string.Compare(expectedCharset, charset, StringComparison.OrdinalIgnoreCase));
        }

//        [Test]
//        [TestCase("http://www.w3.org/", "utf-8")]
        public void ShouldGetCharsetFromResponse(string url, string expectedCharset)
        {
            var analizer = new CharsetAnalizer();
            var charset = analizer.GetCharsetForUrl(url);

            Assert.AreEqual(0, string.Compare(expectedCharset, charset, StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        [TestCaseSource("TestCases")]
        public void ShouldParseMetaTag(string input, string expectedCharset)
        {
            var analizer = new CharsetAnalizer();
            var charset = analizer.GetCharsetFromMetadata(input);

            Assert.AreEqual(0, string.Compare(expectedCharset, charset, StringComparison.OrdinalIgnoreCase));
        }
    }
}