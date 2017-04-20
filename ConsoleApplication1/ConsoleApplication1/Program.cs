using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding encode = Encoding.ASCII;
            string link = "https://www.faturasorgulamax.com/dsmart_fatura_sorgulama.html";
            string post= "aboneno=29284332&sorgula=+FATURA+SORGULA+";
            byte[] postData = encode.GetBytes(post);
            sorgula sorg = new sorgula();
            HttpWebRequest request = sorg.getRequest(link,postData);
            string responseText = "";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                 responseText = (new StreamReader(response.GetResponseStream(), Encoding.Default)).ReadToEnd();
            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(responseText);
            HtmlNode node = doc.GetElementbyId("tutar_0");
            Console.WriteLine(node.InnerText);
            Console.ReadLine();


        }
    }
}
