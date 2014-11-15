using System;
using Rikrop.Core.Network.Helpers;
using NUnit.Framework;

namespace Rikrop.Core.Network.Tests
{
    [TestFixture]
    internal class UrlHandlerTest
    {
        [TestCase("project.html?projectId=project26&tab=projectOverview", "http://teamcity.braintree.local/", "http://teamcity.braintree.local/project.html?projectId=project26&tab=projectOverview")]
        [TestCase("/companies/news/8024161/vnukovo_preduprezhdaet_o_zaderzhkah_rejsov_izza_snegopada", "http://www.vedomosti.ru/companies/news/8024161/vnukovo_preduprezhdaet_o_zaderzhkah_rejsov_izza_snegopada", "http://www.vedomosti.ru/companies/news/8024161/vnukovo_preduprezhdaet_o_zaderzhkah_rejsov_izza_snegopada")]
        [TestCase("/download/attachments/16713508/%D0%9F%D0%B0%D1%83%D0%BA+%D0%B0%D0%BB%D0%B3%D0%BE%D1%80%D0%B8%D1%82%D0%BC.png?version=3&modificationDate=1358329302429", "http://confluence/pages/viewpage.action?pageId=16713508", "http://confluence/download/attachments/16713508/%D0%9F%D0%B0%D1%83%D0%BA+%D0%B0%D0%BB%D0%B3%D0%BE%D1%80%D0%B8%D1%82%D0%BC.png?version=3&modificationDate=1358329302429")]
        [TestCase("logo.png", "http://www.somesite.ru/news", "http://www.somesite.ru/logo.png")]
        [TestCase("/logo.png", "http://www.somesite.ru/news", "http://www.somesite.ru/logo.png")]
        [TestCase("page1.html", "http://www.somesite.ru/index.html", "http://www.somesite.ru/page1.html")]
        [TestCase("page1.html", "http://www.somesite.ru/news/index.html", "http://www.somesite.ru/news/page1.html")]
        public void MustRestoreAbsoluteUrl(string url, string baseUrl, string validResult)
        {
            var urlHandler = new UrlHandler();
            Assert.AreEqual(validResult, urlHandler.RestoreAbsoluteUrl(url, baseUrl));
        }

        [TestCase("asaws.asd.a")]
        public void MustThrowExceptionWhenBaseUrlIsNotValid(string baseUrl)
        {
            var urlHandler = new UrlHandler();
            Assert.Throws<UriFormatException>(() => urlHandler.RestoreAbsoluteUrl("logo.png", baseUrl));
        }
    }
}