using System.Net;

namespace Rikrop.Core.Network.Helpers
{
    public class ContentTypeAnalizer
    {
        public string GetType(string url)
        {
            var contentType = "application/octet-stream"; // rfc 2616 7.2.1
            var request = WebRequest.Create(url) as HttpWebRequest;
            if (request != null)
            {
                var response = request.GetResponse() as HttpWebResponse;
                if (response != null)
                    contentType = response.ContentType;
            }

            return contentType;
        }

        public bool IsHtml(string url)
        {
            var type = GetType(url);
            return type.Contains("text/html");
        }
    }
}