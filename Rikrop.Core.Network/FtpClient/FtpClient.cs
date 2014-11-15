using System;
using System.IO;
using System.Net;

namespace Rikrop.Core.Network.FtpClient
{
    public class FtpClient
    {
        private const string RequestCreationErrorMessage = "Ошибка создания запроса";
        private const string TryToLoadDirectoryError = "Нельзя загрузить директорию";
        private readonly NetworkCredential _credentials;

        public FtpClient(NetworkCredential networkCredential)
        {
            _credentials = networkCredential;
        }

        public FtpDirectory GetDirectory(string uri)
        {
            var result = GetRequestInternal(uri, WebRequestMethods.Ftp.ListDirectoryDetails);
            var directory = new FtpDirectory(result.GetDirectoryList(uri));
            return directory;
        }

        public string GetFile(string uri)
        {
            return GetRequestInternal(uri, WebRequestMethods.Ftp.DownloadFile);
        }

        public string GetFile(FtpItem ftpItem)
        {
            if (ftpItem.IsDirectory)
            {
                throw new FtpException(TryToLoadDirectoryError);
            }

            return GetFile(ftpItem.Path);
        }

        private string GetRequestInternal(string uri, string method)
        {
            var response = CreateResponse(uri, method);

            var responseStream = response.GetResponseStream();

            if (responseStream == null)
            {
                return null;
            }

            var reader = new StreamReader(responseStream);

            var result = reader.ReadToEnd();
            reader.Close();
            response.Close();
            return result;
        }

        private FtpWebRequest CreateRequest(string uri, string method)
        {
            var request = (FtpWebRequest) WebRequest.Create(uri);
            request.Method = method;
            request.Credentials = _credentials;
            return request;
        }

        private FtpWebResponse CreateResponse(string uri, string method)
        {
            try
            {
                return (FtpWebResponse) CreateRequest(uri, method).GetResponse();
            }
            catch (Exception exc)
            {
                throw new FtpException(RequestCreationErrorMessage, exc);
            }
        }
    }
}