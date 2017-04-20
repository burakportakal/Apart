using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class sorgula
    {
        CookieContainer _container = new CookieContainer();
        private  HttpWebRequest getRequest(string link,byte[] postData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
            request.CookieContainer = _container;
            // request.CookieContainer.Add(cookies);
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            request.ContentLength = postData.Length;
            request.AllowWriteStreamBuffering = true;
            request.ProtocolVersion = HttpVersion.Version11;
            request.AllowAutoRedirect = true;

            //post data to server
            Stream str = request.GetRequestStream();
            str.Write(postData, 0, postData.Length);
            str.Close();
            return request;
        }

        public string responseText(string link,string post)
        {
            Encoding encode = Encoding.ASCII;
            byte[] postData = encode.GetBytes(post);
            HttpWebRequest request = getRequest(link, postData);
            string responseText = "";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                responseText = (new StreamReader(response.GetResponseStream(), Encoding.Default)).ReadToEnd();
            }

            return "";
        }
    }
}
