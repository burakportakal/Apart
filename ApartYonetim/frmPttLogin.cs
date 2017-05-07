using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Net;
using ApartYonetim.Fatura;

namespace ApartYonetim
{
    public partial class frmPttLogin : DevExpress.XtraEditors.XtraForm
    {
        public Crm objCrm { get; private set; }
        public frmPttLogin()
        {
            objCrm = new Crm();
            InitializeComponent();
        }
        public bool internetHatasi()
        {
            DialogResult result = MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz", "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            if (DialogResult.Retry == result)
            {
                if (!CheckForInternetConnection())
                {
                    internetHatasi();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
                return false;
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com.tr"))
                    {
                        return true;
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Hata " + ex.Message);
                return false;
            }
            catch
            {
                return false;
            }
        }
        private bool oturumKontrol()
        {
            string path = Path.GetTempPath() + "\\cookiefile.txt";
            if (!File.Exists(path))
                return false;

            string[] cookieFile = File.ReadAllText(path).Split(' ');
            if (cookieFile.Length <= 5)
                return false;
            Cookie cook = new Cookie(cookieFile[0], cookieFile[1], cookieFile[2], cookieFile[3]);
            Cookie cook2 = new Cookie(cookieFile[4], cookieFile[5], cookieFile[6], cookieFile[7]);
            CookieContainer newContainer = new CookieContainer();
            newContainer.Add(cook);
            newContainer.Add(cook2);
            objCrm.Container = newContainer;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://pttbank.ptt.gov.tr/pttwebapproot/ipcservlet?cmd=kurumtahsilatgiristelefon");
            req.CookieContainer = objCrm.Container;
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
            string text = "";
            try
            {
                using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
                {
                    text = new StreamReader(resp.GetResponseStream(), Encoding.Default).ReadToEnd();
                    if (text.Contains("secilenHesapNumarasi"))
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckForInternetConnection())
            {
                //internet bağlantısı olmadığıda fonksiyondan çıkar ancak yeniden dene sonrası geri geldiğinde devam eder.
                if (!internetHatasi())
                    return;
            }
            //önceki cookie ile giriş yapılabiliniyor mu kontrol eder giriş başarılı ise yeniden sms şifresi göndermez.
            if (oturumKontrol())
            {
                MessageBox.Show("Giris basarili");
                //**********************//
                frmFaturaSorgula form = new frmFaturaSorgula(objCrm);
                form.MdiParent = (frmAnaSayfa)Application.OpenForms["frmAnaSayfa"];
                form.Show();
                //*******************************//
                this.Hide();
                return;
            }
            Task<bool> taskSonuc;

            if (txtMusteriNo.Text.Length != 11 || txtSifre.Text.Length != 8)
            {
                MessageBox.Show("Müsteri no 11,şifre 8 karakter uzunluğunda olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            taskSonuc = Task.Factory.StartNew(() => objCrm.login(txtMusteriNo.Text, txtSifre.Text),
                new System.Threading.CancellationToken(),TaskCreationOptions.None,TaskScheduler.Current);
            lblBekle.Text = "Giriş yapılıyor...";
            btnLogin.Enabled = false;
            bool sonuc = await taskSonuc;
            if (sonuc)
            {
                beniHatirla();
                #region gizle göster
                lblBekle.Visible = false;
                lblSifre.Visible = false;
                lblMusteri.Visible = false;
                txtMusteriNo.Visible = false;
                txtSifre.Visible = false;
                btnLogin.Visible = false;
                btnSms.Visible = true;
                btnSms.Enabled = true;
                txtSms.Visible = true;
                lblSms.Visible = true;
                txtSms.Focus();
                #endregion
                timer();
            }
            else
            {
                btnLogin.Enabled = true;
                lblBekle.Text = "Giriş başarısız";
                MessageBox.Show("Giriş yapılırken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSms_Click(object sender, EventArgs e)
        {
            if (!CheckForInternetConnection())
            {
                //internet bağlantısı olmadığıda fonksiyondan çıkar ancak yeniden dene sonrası geri geldiğinde devam eder.
                if (!internetHatasi())
                    return;
            }
            int smsSifreKontrol = 0;
            if (!int.TryParse(txtSms.Text, out smsSifreKontrol))
            {
                MessageBox.Show("Sms şifresi sadece rakamlardan oluşabilir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSms.Text == "" || txtSms.Text.Length != 6)
            {
                MessageBox.Show("Sms şifre uzunluğu 6 karakter olmalıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Task<bool> taskSonuc = Task.Run(() => objCrm.SmsApproval(txtSms.Text));
            btnSms.Enabled = false;
            lblBekle.Text = "Giriş yapılıyor...";
            bool sonuc = await taskSonuc;
            if (sonuc)
            {
                try
                {
                    //cookieler gelmeden önce bu çalıştırılmak zorunda yok girmiyor
                    objCrm.cookieKaydet();
                    lblBekle.Text = "";
                    txtSifre.Text = "";
                    tmr.Stop();
                    #region gizle göster
                    txtSms.Text = "";
                    txtSms.Visible = false;
                    btnSms.Visible = false;
                    lblSms.Visible = false;
                    btnLogin.Visible = true;
                    btnLogin.Enabled = true;
                    txtSifre.Visible = true;
                    txtMusteriNo.Visible = true;
                    lblMusteri.Visible = true;
                    lblSifre.Visible = true;
                    lblTime.Visible = false;
                    this.Hide();
                    #endregion
                    frmFaturaSorgula form = new frmFaturaSorgula(objCrm);
                    form.MdiParent = (frmAnaSayfa)Application.OpenForms["frmAnaSayfa"];
                    form.Show();
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Cookie dosyası yazılırken bir hata oluştu", ex.Message);
                }
                catch (Exception ex)
                {
                    btnSms.Enabled = true;
                    MessageBox.Show("Bilgiler gönderilirken hata oluştu " + ex.Message);
                }
            }
            else
            {
                btnSms.Enabled = true;
                MessageBox.Show("Giriş Başarısız");
            }
        }
        private void timer()
        {
            tmr.Start();
            DateTime dt = DateTime.Now.AddHours(0).AddMinutes(3).AddSeconds(0);
            lblTime.Visible = true;
            tmr.Interval = 1000;
            tmr.Tick += (sender, e) =>
            {
                TimeSpan diff = dt.Subtract(DateTime.Now);
                lblTime.Text = string.Format("{0:00}:{1:00}:{2:00}", diff.Hours, diff.Minutes, diff.Seconds);
                if (dt < DateTime.Now)
                {
                    ((System.Windows.Forms.Timer)sender).Stop();
                    MessageBox.Show("Sms şifresi giriş süreniz doldu lütfen tekrar giriş yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #region gizle göster
                    txtMusteriNo.Text = "";
                    txtSifre.Text = "";
                    txtSms.Text = "";
                    txtSms.Visible = false;
                    btnSms.Visible = false;
                    lblSms.Visible = false;
                    btnLogin.Visible = true;
                    txtSifre.Visible = true;
                    txtMusteriNo.Visible = true;
                    lblMusteri.Visible = true;
                    lblSifre.Visible = true;
                    lblTime.Visible = false;
                    btnLogin.Enabled = true;
                    btnSms.Enabled = true;
                    #endregion
                }

            };
        }

        private async void frmPttLogin_Load(object sender, EventArgs e)
        {
            if (CheckForInternetConnection())
            {
                bool oturumkontrol = await Task.Run(()=> oturumKontrol());
                if (oturumkontrol)
                {
                    frmFaturaSorgula form = new frmFaturaSorgula(objCrm);
                    form.MdiParent = (frmAnaSayfa)Application.OpenForms["frmAnaSayfa"];
                    form.Show();
                    this.Close();
                    return;
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen internet bağlantınızı kontrol edin!");
                this.Close();
                return;
            }
            txtMusteriNo.Focus();
            if (File.Exists(Path.GetTempPath() + "\\userLogin.txt"))
            {
                string path = Path.GetTempPath() + "\\userLogin.txt";
                string[] cookieFile = File.ReadAllText(path).Split(' ');
                txtMusteriNo.Text = cookieFile[0];
                txtSifre.Text = cookieFile[1];
                chkBeniHatirla.CheckState = CheckState.Checked;
            }
          

        }
        private void beniHatirla()
        {
            if (chkBeniHatirla.Checked == true)
            {
                if (File.Exists(Path.GetTempPath() + "\\userLogin.txt"))
                    File.Delete(Path.GetTempPath() + "\\userLogin.txt");

                //tekrar oluşturuyoruz
                string myTempFile = Path.Combine(Path.GetTempPath(), "userLogin.txt");
                using (StreamWriter sw = new StreamWriter(myTempFile))
                {
                    sw.Write(txtMusteriNo.Text + " " + txtSifre.Text);
                }
            }
            else if (chkBeniHatirla.Checked == false)
            {
                if (File.Exists(Path.GetTempPath() + "\\userLogin.txt"))
                    File.Delete(Path.GetTempPath() + "\\userLogin.txt");

            }
        }

        private void chkBeniHatirla_CheckedChanged(object sender, EventArgs e)
        {
            beniHatirla();
        }
    }
}