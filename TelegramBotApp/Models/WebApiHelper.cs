using System.IO;
using System.Net;
using System.Text;

namespace TelegramBotApp.Models
{
    internal static class WebApiHelper
    {
        public static string Get(string url)
        {
            WebRequest request = WebRequest.Create(@url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Headers.Add("Accept-Charset", "utf-8");
            ((HttpWebRequest)request).KeepAlive = true;
            ((HttpWebRequest)request).Proxy = null; // it is necessary! this speeds up the connection
            ((HttpWebRequest)request).Accept = "application/json";

            //TODO: протестировать, т.к. сервер может вернуть ошибки: 400, 401, 500
            WebResponse response = request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8")))
            {
                return reader.ReadToEnd();
            }
        }
    }
}