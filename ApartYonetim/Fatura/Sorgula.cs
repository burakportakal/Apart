using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ApartYonetim.Fatura
{
    class Sorgula
    {

        public Sorgula()
        {

        }
        CookieContainer _container = new CookieContainer();

        Dictionary<string, string> list = new Dictionary<string, string>();

        public CookieContainer Container
        {
            get
            {
                return _container;
            }

            set
            {
                _container = value;
            }
        }

        public Dictionary<string, string> List
        {
            get
            {
                return list;
            }

            set
            {
                list = value;
            }
        }

        private HttpWebRequest getRequest(byte[] data)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://pttbank.ptt.gov.tr/pttwebapproot/ipcservlet");
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
            request.CookieContainer = _container;
            // request.CookieContainer.Add(cookies);
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            request.ContentLength = data.Length;
            request.AllowWriteStreamBuffering = true;
            request.ProtocolVersion = HttpVersion.Version11;
            request.AllowAutoRedirect = true;

            //post data to server
            Stream str = request.GetRequestStream();
            str.Write(data, 0, data.Length);
            str.Close();
            return request;
        }
        public Faturalar faturaSorgula(string numara, string post, CancellationToken tokenTel)
        {
            try
            {
                Encoding encode = Encoding.ASCII;
                string fields = "";
                foreach (var key in List)
                {
                    fields += key.Key + "=" + key.Value + "&";
                }
                fields = fields.Remove(fields.Length - 1, 1);
                byte[] data = encode.GetBytes(fields);

                HttpWebRequest request = getRequest(data);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    string responseText = (new StreamReader(response.GetResponseStream(), Encoding.Default)).ReadToEnd();
                }
                if (list.Count > 15)
                {
                    byte[] postData = encode.GetBytes(post);
                    HttpWebRequest request2 = getRequest(postData);
                    string responseHtml = "";
                    using (HttpWebResponse response = (HttpWebResponse)request2.GetResponse())
                    {
                        responseHtml = (new StreamReader(response.GetResponseStream(), Encoding.Default).ReadToEnd());
                    }
                    tokenTel.ThrowIfCancellationRequested();

                    return getFatura(numara, responseHtml);
                }
                else
                    return null;
            }
            catch (OperationCanceledException)
            {
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Faturalar getFatura(string numara, string htmlDoc)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlDoc);

            var node = doc.GetElementbyId("Table3");
            string sonucText = "";
            var nodes = doc.DocumentNode.SelectNodes("//input");
            if (nodes != null)
            {
                foreach (var item in nodes)
                {
                    if (item.OuterHtml.Contains("checkbox"))
                    {
                        sonucText = item.OuterHtml.ToString();
                    }
                }
            }
            string[] sonuc = sonucText.Split('@');
            if (sonuc.Length >= 10)
            {
                if (htmlDoc.Contains("DENIZLISU"))
                {
                    var inputName = doc.DocumentNode.SelectSingleNode("/html[1]/body[1]/input[15]/@value[1]");
                    string name = inputName.Attributes[2].Value;
                    inputName = doc.DocumentNode.SelectSingleNode("/html[1]/body[1]/input[16]/@value[1]");
                    name += " " + inputName.Attributes[2].Value;
                    string isim = name; string faturaDonemi = sonuc[2]; double fiyat   = Convert.ToDouble(sonuc[1].Replace('.',','));
                    Faturalar fatura = new Faturalar(numara, isim, faturaDonemi, fiyat);
                    return fatura;
                }
                else if (htmlDoc.Contains("ELEKTRIK"))
                {
                    var inputName = doc.DocumentNode.SelectSingleNode("/html[1]/body[1]/input[15]/@value[1]");
                    string name = inputName.Attributes[2].Value;
                    inputName = doc.DocumentNode.SelectSingleNode("/html[1]/body[1]/input[16]/@value[1]");
                    name += " " + inputName.Attributes[2].Value;
                    string isim = name; string faturaDonemi = sonuc[3]; double fiyat  = Convert.ToDouble(sonuc[1].Replace('.', ','));
                    Faturalar fatura = new Faturalar(numara, isim, faturaDonemi, fiyat);
                    return fatura;
                }
                else if (htmlDoc.Contains("SUPERONLINE"))
                {
                    string isim = sonuc[10]; string faturaDonemi = sonuc[2]; double fiyat = Convert.ToDouble(sonuc[1].Replace('.', ','));
                    Faturalar fatura = new Faturalar(numara, isim, faturaDonemi, fiyat);
                    return fatura;
                }
                else
                    throw new Exception("Fatura sorgulanırken hata oluştu");
            }
            else
                return null;
        }
    }
}
