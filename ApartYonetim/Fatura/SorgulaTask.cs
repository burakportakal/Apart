using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartYonetim.Fatura
{
    public enum TelTaskStatus
    {
        Waiting,
        Running,
        Cancelled,
        Completed,
    };
    public enum AdslTaskStatus
    {
        Waiting,
        Running,
        Cancelled,
        Completed,
    };
   public  class SorgulaTask
    {

        public TelTaskStatus telStatus = TelTaskStatus.Waiting;

        public AdslTaskStatus adslStatus = AdslTaskStatus.Waiting;

        List<Faturalar> faturalar;

        public Crm objCrm { get; private set; }

        ProgressBar progressBar1;

        private readonly static object state = new object();
        public CancellationTokenSource sourceTel { get; private set; }
        public CancellationToken tokenTel { get; private set; }
        public SorgulaTask(Crm objCrm, ProgressBar bar)
        {
            this.progressBar1 = bar;
            this.objCrm = objCrm;
        }
        public bool oturumKontrol()
        {
            //oturumun açık olması gereken link adresi oturum kapalıysa uyarı sayfasına yönlendirir açıksa bazı bilgiler yer alır
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://pttbank.ptt.gov.tr/pttwebapproot/ipcservlet?cmd=kurumtahsilatgiristelefon");
            req.CookieContainer = objCrm.Container;
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
            string text = "";

            using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
            {
                text = new StreamReader(resp.GetResponseStream(), Encoding.Default).ReadToEnd();
                if (text.Contains("secilenHesapNumarasi"))
                    return true;
                else
                    return false;
            }
        }
        public async Task<List<Faturalar>> getFatura(string[] numaralar, string faturaAdi)
        {
            faturalar = new List<Faturalar>();
            List<Task> taskList = new List<Task>();
            sourceTel = new CancellationTokenSource();
            tokenTel = new CancellationToken();
            tokenTel = sourceTel.Token;

            float progress = (float)100 / (float)numaralar.Length;
            Dictionary<string, string> List = objCrm.getHesapNo();
            if (List.Count < 15)
            {
                throw new Exception("Oturumunuz kapatılmış lütfen oturum açın");
            }
            int i = 0;
            foreach (var numara in numaralar)
            {
                string post = "";
                switch (faturaAdi)
                {
                    case "SU":
                        #region su faturası post bilgileri
                        post = "kurumId=77&" +
                            "kurumKod=DENIZLISU&" +
                            "kurumAd=DENIZLISU&" +
                            "kurumParaCinsiId=3&" +
                            "kurumParaCinsiText=Yeni+T%FCrk+Liras%FD&" +
                            "kurumJspAdi=ipc%2FIPCKurumTahsilatFaturaSorguGiris.jsp&" +
                            "kurumTahsilatTipi=SU&" +
                            "kurumGirisTipi=1&" +
                            "kurumMesajTipi=0&" +
                            "kurumIslemTuru=SU&" +
                            "kurumAciklama=DENIZLI+SU+TAHSILAT&" +
                            "kurumParaCinsiKod=TL&" +
                            "kurumOnlineDurum=1&" +
                            "selectedKayitID=&" +
                            "hesapno=" + List["hesapno"] +
                            "&hesapSahibi=" + List["hesapSahibi"] +
                            "&bakiye=" + List["bakiye"] +
                            "&hesapTuru=" + List["hesapTuru"] +
                            "&meslekkodu=" + List["meslekkodu"] +
                            "&aciklama=" + List["aciklama"] +
                            "&hesapdurumkodu=" + List["hesapdurumkodu"] +
                            "&aboneNumarasi=" + numara +
                            "&cmd=kurumtahsilatfaturasorgula&h_PageValidation=ON";
                        #endregion
                        break;
                    case "ELEKTRİK":
                        #region elektrik faturası post bilgileri
                        post = "kurumId=96&" +
                                "kurumKod=293&" +
                                "kurumAd=AYDEM&" +
                                "kurumParaCinsiId=3&" +
                                "kurumParaCinsiText=Yeni+T%FCrk+Liras%FD&" +
                                "kurumJspAdi=ipc%2FIPCKurumTahsilatFaturaSorguGiris.jsp&" +
                                "kurumTahsilatTipi=ELEKTRIK&kurumGirisTipi=2&" +
                                "kurumMesajTipi=0&" +
                                "kurumIslemTuru=ELEKTRIK&" +
                                "kurumOnlineDurum=1&" +
                                "kurumAciklama=Aydem+Enerji+Satis+AS&" +
                                "kurumParaCinsiKod=TL&" +
                                "selectedKayitID=&" +
                                "kullanilabilirbakiye=" + List["kullanilabirbakiye"] +
                                "&kullanilabilirkmh=" + List["kullanilabilirkmh"] +
                                "&kmhdurum=" + List["kmhdurum"] +
                                "&hesapno=" + List["hesapno"] +
                                "&hesapSahibi=" + List["hesapSahibi"] +
                                "&bakiye=" + List["bakiye"] +
                                "&hesapTuru=" + List["hesapTuru"] +
                                "&meslekkodu=" + List["meslekkodu"] +
                                "&aciklama=" + List["aciklama"] +
                                "&hesapdurumkodu=" + List["hesapdurumkodu"] +
                                "&aciklama=" + List["aciklama"] +
                                "&isletmeKod1=020&" +
                                "isletmeKod2=00&" +
                                "isletmeKod3=00&" +
                                "isletmeKod4=00&" +
                                "isletmeKod5=00&" +
                                "aboneNumarasi=" + numara +
                                "&cmd=kurumtahsilatfaturasorgula&" +
                                "h_PageValidation=ON";
                        #endregion
                        break;
                    case "İNTERNET":
                        #region superonline faturası post bilgileri
                        post = "kurumId=58" +
                                "&kurumKod=SUPERONLINE" +
                                "&kurumAd=SUPERONLINE&kurumParaCinsiId=3" +
                                "&kurumParaCinsiText=Yeni+T%FCrk+Liras%FD" +
                                "&kurumJspAdi=ipc%2FIPCKurumTahsilatFaturaSorguGiris.jsp" +
                                "&kurumTahsilatTipi=TELEFON" +
                                "&kurumGirisTipi=1&kurumMesajTipi=0" +
                                "&kurumIslemTuru=INTERNET&kurumOnlineDurum=1" +
                                "&kurumAciklama=SUPERONLINE+FATURA+TAHSILATI&kurumParaCinsiKod=TL" +
                                "&selectedKayitID=" +
                                "&kullanilabilirbakiye=" + List["kullanilabirbakiye"] +
                                "&kullanilabilirkmh=" + List["kullanilabilirkmh"] +
                                "&kmhdurum=" + List["kmhdurum"] +
                                "&hesapno=" + List["hesapno"] +
                                "&hesapSahibi=" + List["hesapSahibi"] +
                                "&bakiye=" + List["bakiye"] +
                                "&hesapTuru=" + List["hesapTuru"] +
                                "&meslekkodu=" + List["meslekkodu"] +
                                "&aciklama=" + List["aciklama"] +
                                "&hesapdurumkodu=" + List["hesapdurumkodu"] +
                                "&aciklama=" + List["aciklama"] +
                                "&aboneNumarasi=" + numara +
                                "&cmd=kurumtahsilatfaturasorgula" +
                                "&h_PageValidation=ON";
                        #endregion
                        break;
                }
                Sorgula objSorgula = new Sorgula();
                objSorgula.Container = objCrm.Container;
                objSorgula.List = List;
                var sonTask = Task.Run(() => objSorgula.faturaSorgula(numara, post, tokenTel), tokenTel).ContinueWith(async (t) => {
                    string aboneNo = numara;
                    await t;
                    i++;
                    progressBar1.Value = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(progress * i)));

                    lock (state)
                    {
                        Faturalar fatura = t.Result;
                        if (fatura != null)
                        {
                            faturalar.Add(fatura);
                        }
                        else
                        {
                            Faturalar bosFatura = new Faturalar(aboneNo, "---", "---", 0);
                        }
                    }

                }, TaskScheduler.FromCurrentSynchronizationContext()
                   );
                taskList.Add(sonTask);
                if (taskList.Count % 50 == 0)
                {
                    await Task.WhenAll(taskList);
                }
            }
            await Task.WhenAll(taskList);
            return faturalar;
        }
    }
}
