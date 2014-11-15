using System;

namespace Rikrop.Core.Network.Helpers
{
    public class UrlHandler : IUrlHandler
    {
        //private static bool TryCreateUrl(string url, out Uri result)
        //{
        //    return Uri.TryCreate(url, UriKind.Absolute, out result) && result.Scheme.StartsWith("http", StringComparison.InvariantCultureIgnoreCase);
        //}

        public string RestoreAbsoluteUrl(string targetUrl, string baseUrl)
        {
            Uri uri;
            if(!Uri.TryCreate(new Uri(baseUrl), targetUrl, out uri ))
                throw new UriFormatException("baseUrl является не корректным Url");
            
            return uri.AbsoluteUri;
        }
    }
}