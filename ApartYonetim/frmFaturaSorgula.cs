using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ApartYonetim.Fatura;

namespace ApartYonetim
{
    public partial class frmFaturaSorgula : DevExpress.XtraEditors.XtraForm
    {
        Crm objCrm;
        public SorgulaTask task { get; private set; }
        List<Faturalar> sorgulama;
        public frmFaturaSorgula(Crm obj)
        {
            objCrm = obj;
            task = new SorgulaTask(objCrm, this.prgSorgulama);
            objCrm.cookieKaydet();
            InitializeComponent();
        }

        private async void btnSorgula_Click(object sender, EventArgs e)
        {
            if (!frmPttLogin.CheckForInternetConnection())
            {
                MessageBox.Show("İnternet bağlantınızı kontrol edin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!task.oturumKontrol())
            {
                MessageBox.Show("Oturumunuz kapatılmış yeniden oturum açınız");
                this.Hide();
                Form f = Application.OpenForms["frmPttLogin"];
                ((frmPttLogin)f).Show();
                return;
            }
            if (task.telStatus == TelTaskStatus.Running)
            {
                MessageBox.Show("Zaten çalışan bir sorgulama işlemi var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbl_FaturaAboneNo faturalar = new tbl_FaturaAboneNo();
            string[] numaralar = faturalar.spBinaAdiFaturaTuru(bina_AdıComboBox.Text, fatura_AdıComboBox.Text);
            sorgulama = await task.getFatura(numaralar, fatura_AdıComboBox.Text.ToUpper());
            objCrm.cookieKaydet();
        }

        private void frmFaturaSorgula_Load(object sender, EventArgs e)
        {
            tbl_FaturaTuru faturaTuru = new tbl_FaturaTuru();
            List<tbl_FaturaTuru> liste = faturaTuru.Listele().ToList();
            foreach (var item in liste)
            {
                fatura_AdıComboBox.Items.Add(item.Fatura_adi);
            }
            tbl_Binalar bina = new tbl_Binalar();
            List<tbl_Binalar> binalar= bina.Listele().ToList(); 
            foreach (var item in binalar)
            {
                bina_AdıComboBox.Items.Add(item.Bina_adi);
            }
        }
    }
}