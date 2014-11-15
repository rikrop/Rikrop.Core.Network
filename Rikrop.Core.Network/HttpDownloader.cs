using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rikrop.Core.Network
{
    public class HttpDownloader : IDownloader
    {
        private static bool TryCreateHeaderValue(KeyValuePair<string, IEnumerable<string>> header, out string headerValue)
        {
            const string baseSeparator = " ";
            const string cookieSeparator = ";, ";

            var separator = header.Key.StartsWith("Set-Cookie", StringComparison.OrdinalIgnoreCase)
                                ? cookieSeparator
                                : baseSeparator;

            headerValue = string.Join(separator, header.Value);

            if (!string.IsNullOrWhiteSpace(headerValue))
            {
                return true;
            }

            headerValue = null;
            return false;
        }

        private static void ValidateResponse(HttpResponseMessage responseMessage)
        {
            if (responseMessage.StatusCode != HttpStatusCode.Found)
            {
                responseMessage.EnsureSuccessStatusCode();
            }
        }


        private static HttpHeadersCollection GetResponseHeader(HttpResponseMessage responseMessage)
        {
            var headers = new HttpHeadersCollection();

            foreach (var header in responseMessage.Headers)
            {
                string headerValue;

                if (TryCreateHeaderValue(header, out headerValue))
                {
                    headers.Add(header.Key, headerValue);
                }
            }

            foreach (var header in responseMessage.Content.Headers)
            {
                string headerValue;

                if (TryCreateHeaderValue(header, out headerValue))
                {
                    headers.Add(header.Key, headerValue);
                }
            }
            return headers;
        }

        public async Task<IHttpResponse> Download(IHttpRequest httpRequest)
        {
            Contract.Assume(httpRequest.Method == HttpRequestMethod.Get || httpRequest.Method == HttpRequestMethod.Post);

            var handler = new HttpClientHandler
                              {
                                  AllowAutoRedirect = httpRequest.AllowRedirects,
                                  UseCookies = false
                              };

            var client = new HttpClient(handler) {Timeout = httpRequest.Timeout};

            foreach (var header in httpRequest.Headers)
            {
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }

            HttpResponseMessage responseMessage;

            if (httpRequest.Method == HttpRequestMethod.Get)
            {
                responseMessage = await client.GetAsync(httpRequest.Address);
            }
            else
            {
                responseMessage = await client.PostAsync(httpRequest.Address, GetHttpContent(httpRequest.PostContent));
            }

            ValidateResponse(responseMessage);

            var headers = GetResponseHeader(responseMessage);

            var bytes = await responseMessage.Content.ReadAsByteArrayAsync();

            return new HttpResponse(headers, bytes, responseMessage.StatusCode);
        }

        private HttpContent GetHttpContent(IPostContent postContent)
        {
            if (postContent.GetType() == typeof (StringPostContent))
            {
                var stringPostContent = (StringPostContent) postContent;
                return new StringContent(stringPostContent.Data, stringPostContent.Encoding, stringPostContent.MediaType);
            }
            if (postContent.GetType() == typeof (FormUrlEncodedPostContent))
            {
                return new FormUrlEncodedContent(((FormUrlEncodedPostContent) postContent).Data);
            }

            throw new NotSupportedException(String.Format("Unknown post content type: {0}", postContent.GetType()));
        }
    }
}