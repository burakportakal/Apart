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
        public Faturalar telefonFatura(string numara, CancellationToken tokenTel)
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
                    string post = "kurumId=63&kurumKod=2&kurumAd=TURKTELEKOM&" +
                       "kurumParaCinsiId=3&kurumParaCinsiText=Yeni+T%FCrk+Liras%FD&kurumJspAdi=ipc%2FIPCTurkTelekomTahsilatGiris.jsp&" +
                       "kurumTahsilatTipi=TELEFON&kurumMesajTipi=500&kurumIslemTuru=TELEFON&kurumAciklama=TÜRK TELEKOM EV ÝÞ TELEFONU&kurumParaCinsiKod=TL&" +
                       "kurumOnlineDurum=0&selectedKayitID=&hesapno=" + List["hesapno"] + "&hesapSahibi=+" + List["hesapSahibi"] + "&bakiye=" + List["bakiye"] + "&hesapTuru=" + List["hesapTuru"] +
                       "&meslekkodu=" + List["meslekkodu"] + "&aciklama=" + List["aciklama"] + "&hesapdurumkodu=" + List["hesapdurumkodu"] + "&erisimTipi=1&erisimNo=" + numara + "&cmd=telefontahsilatfaturasorgula&h_PageValidation=ON";
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
        public Faturalar suFatura(string aboneNo, CancellationToken tokenTel)
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
                    string post = "kurumId=77&kurumKod=DENIZLISU&kurumAd=DENIZLISU&" +
                       "kurumParaCinsiId=3&kurumParaCinsiText=Yeni+T%FCrk+Liras%FD&kurumJspAdi=ipc%2FIPCKurumTahsilatFaturaSorguGiris.jsp&" +
                       "kurumTahsilatTipi=SU&kurumGirisTipi=1&kurumMesajTipi=0&kurumIslemTuru=SU&kurumAciklama=DENIZLI+SU+TAHSILAT&kurumParaCinsiKod=TL&" +
                       "kurumOnlineDurum=1&selectedKayitID=&hesapno=" + List["hesapno"] + "&hesapSahibi=+" + List["hesapSahibi"] + "&bakiye="
                       + List["bakiye"] + "&hesapTuru=" + List["hesapTuru"] +
                       "&meslekkodu=" + List["meslekkodu"] + "&aciklama=" + List["aciklama"] + "&hesapdurumkodu=" + List["hesapdurumkodu"] + "&aboneNumarasi="
                       + aboneNo + "&cmd=kurumtahsilatfaturasorgula&h_PageValidation=ON";
                    string post2 = "kurumId=77&" +
                       "kurumKod=DENIZLISU" +
                       "&kurumAd=DENIZLISU" +
                       "&kurumParaCinsiId=3" +
                       "&kurumParaCinsiText=Yeni+T%FCrk+Liras%FD" +
                       "&kurumJspAdi=ipc%2FIPCKurumTahsilatFaturaSorguGiris.jsp" +
                       "&kurumTahsilatTipi=SU" +
                       "&kurumGirisTipi=1" +
                       "&kurumMesajTipi=0" +
                       "&kurumIslemTuru=SU" +
                       "&kurumOnlineDurum=1" +
                       "&kurumAciklama=DENIZLI+SU+TAHSILATI" +
                       "&kurumParaCinsiKod=TL" +
                       "&selectedKayitID=" +
                       "&kullanilabilirbakiye=0.00" +
                       "&kullanilabilirkmh=0.00" +
                       "&kmhdurum=H" +
                       "&hesapno=13523986" +
                       "&hesapSahibi=BURAK++++++++++++++++PORTAKAL++++++++++++" +
                       "&bakiye=0.00" +
                       "&hesapTuru=1" +
                       "&meslekkodu=015" +
                       "&aciklama=00" +
                       "&hesapdurumkodu=YATOD" +
                       "&aciklama=00" +
                       "&aboneNumarasi=25223" +
                       "&cmd=kurumtahsilatfaturasorgula" +
                       "&h_PageValidation=ON";
                    byte[] postData = encode.GetBytes(post);
                    HttpWebRequest request2 = getRequest(postData);
                    string responseHtml = "";
                    using (HttpWebResponse response = (HttpWebResponse)request2.GetResponse())
                    {
                        responseHtml = (new StreamReader(response.GetResponseStream(), Encoding.Default).ReadToEnd());
                    }
                    tokenTel.ThrowIfCancellationRequested();

                    return getFatura(aboneNo, responseHtml);
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
        public Faturalar adslFatura(string numara, CancellationToken tokenAdsl)
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
                    //server post data
                    string post = "kurumId=60&kurumKod=5&kurumAd=TURKTELEKOM&" +
                        "kurumParaCinsiId=3&kurumParaCinsiText=Yeni+T%FCrk+Liras%FD&kurumJspAdi=ipc%2FIPCTurkTelekomTahsilatGiris.jsp&" +
                        "kurumTahsilatTipi=TELEFON&kurumMesajTipi=510&kurumIslemTuru=TELEFON&kurumAciklama=T%DCRK+TELEKOM+%DDNTERNET+%28TTNET%29&kurumParaCinsiKod=TL&" +
                        "kurumOnlineDurum=0&selectedKayitID=&hesapno=" + List["hesapno"] + "&hesapSahibi=+" + List["hesapSahibi"] + "&bakiye=" + List["bakiye"] + "&hesapTuru=" + List["hesapTuru"] +
                        "&meslekkodu=" + List["meslekkodu"] + "&aciklama=" + List["aciklama"] + "&hesapdurumkodu=" + List["hesapdurumkodu"] + "&erisimTipi=1&erisimNo=" + numara + "&cmd=telefontahsilatfaturasorgula&h_PageValidation=ON";
                    byte[] postData = encode.GetBytes(post);

                    HttpWebRequest request2 = getRequest(postData);
                    string responseHtml = "";
                    //########################################//
                    using (HttpWebResponse response = (HttpWebResponse)request2.GetResponse())
                    {
                        responseHtml = (new StreamReader(response.GetResponseStream(), Encoding.Default).ReadToEnd());
                    }
                    tokenAdsl.ThrowIfCancellationRequested();
                    //########################################//
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
                    string isim = name; string faturaDonemi = sonuc[2]; string fiyat = sonuc[1];
                    Faturalar fatura = new Faturalar(numara, isim, faturaDonemi, fiyat);
                    return fatura;
                }
                else if (htmlDoc.Contains("ELEKTRIK"))
                {
                    var inputName = doc.DocumentNode.SelectSingleNode("/html[1]/body[1]/input[15]/@value[1]");
                    string name = inputName.Attributes[2].Value;
                    inputName = doc.DocumentNode.SelectSingleNode("/html[1]/body[1]/input[16]/@value[1]");
                    name += " " + inputName.Attributes[2].Value;
                    string isim = name; string faturaDonemi = sonuc[3]; string fiyat = sonuc[1];
                    Faturalar fatura = new Faturalar(numara, isim, faturaDonemi, fiyat);
                    return fatura;
                }
                else if (htmlDoc.Contains("SUPERONLINE"))
                {
                    string isim = sonuc[10]; string faturaDonemi = sonuc[2]; string fiyat = sonuc[1];
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
