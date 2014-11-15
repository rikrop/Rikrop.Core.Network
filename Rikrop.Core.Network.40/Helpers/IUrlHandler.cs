namespace Rikrop.Core.Network.Helpers
{
    public interface IUrlHandler
    {
        /// <summary>
        /// Востанавливает абсолютный Url для параметра url используя базовый url (baseUrl)
        /// </summary>
        /// <param name="targetUrl">исходный url</param>
        /// <param name="baseUrl">базовый url</param>
        /// <returns>абсолютный url для параметра targetUrl</returns>
        string RestoreAbsoluteUrl(string targetUrl, string baseUrl);
    }
}