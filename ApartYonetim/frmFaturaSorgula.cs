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
using DevExpress.XtraGrid.Views.Grid;

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
            InitializeComponent();
            task = new SorgulaTask(objCrm, this.prgSorgulama);
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
            lblSorgulama.Text = "Sorgulama devam ediyor...";
            tbl_FaturaAboneNo faturalar = new tbl_FaturaAboneNo();
            string[] numaralar = faturalar.spBinaAdiFaturaTuru(bina_AdıComboBox.Text, fatura_AdıComboBox.Text);
            sorgulama = await task.getFatura(numaralar, fatura_AdıComboBox.Text.ToUpper());
            XtraMessageBox.Show("Sorgulama tamamlandı");
            lblSorgulama.Text = "";
            prgSorgulama.Value = 0;
            objCrm.cookieKaydet();
            tbl_FaturaGiderTablosu faturaSorgu = new tbl_FaturaGiderTablosu();
            foreach (var item in sorgulama)
            {
                if(faturaSorgu.faturaDonemiSorgusu(item.AboneNo, item.FaturaDonemi))
                {
                    faturaSorgu.spFaturaGiderEkle(item.AboneNo, item.FaturaDonemi,(float)Convert.ToDouble(item.Fiyat));
                }
            }
            gridDoldur();


        }
        private void gridDoldur()
        {
            gcFatura.DataSource = new tbl_OrtakFatura ().spFaturaGorunutle().Tables["tbl_Fatura"];
        }
        private void frmFaturaSorgula_Load(object sender, EventArgs e)
        {
            gridDoldur();
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

        private void gvFatura_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Fatura Durumu"]);
                if (category == "Indeterminate")
                {
                    e.Appearance.BackColor = Color.Yellow;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
                else if (category == "Checked")
                {
                    e.Appearance.BackColor = Color.SeaShell;
                    e.Appearance.BackColor2 = Color.Aqua;
                }
                else
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
            }

            gvFatura.ClearSelection();


        }

        private void btnGelirKaydet_Click(object sender, EventArgs e)
        {
            string aboneNo = "";
            string apartAdi = "";
            int daireKapiNo = 0;
            string faturaDonemi = "";
            foreach (int i in gvFatura.GetSelectedRows())
            {
                DataRow row = gvFatura.GetDataRow(i);
                aboneNo = row[0].ToString();
                apartAdi = row[4].ToString();
                daireKapiNo = Convert.ToInt32(row[3].ToString());
                faturaDonemi = row[7].ToString();
            }
            frmFaturaGelirKayit gelirKayit = new frmFaturaGelirKayit(faturaDonemi, apartAdi, daireKapiNo, aboneNo);
            gelirKayit.ShowDialog();
        }
    }
}