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
using System.Data.SqlClient;

namespace ApartYonetim
{
    public partial class frmYoneticiler : DevExpress.XtraEditors.XtraForm
    {
        public frmYoneticiler()
        {
            InitializeComponent();
        }
        bool YeniKayit = false;
        private tbl_Yoneticiler depo;
        public tbl_Yoneticiler Bilgi
        {
            get { return depo; }
            set
            {
                if (value != null)
                {
                    depo = value;
                    this.tbl_YoneticilerBindingSource.DataSource = this.depo;
                }
            }
        }

        private void tbl_YoneticilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_YoneticilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aYSDataSet);

        }
        public void sorumluOlduguDairelerDoldur()
        {
            lbcBinalar.Items.Clear();
            tbl_YoneticiBina yoneticiBina = new tbl_YoneticiBina();
            int ID2 = Convert.ToInt32(yonetici_idTextBox.Text);
            SqlDataReader dr = yoneticiBina.binaListele(ID2);
            while (dr.Read())
            {
                lbcBinalar.Items.Add(dr["bina_adi"]);
            }
        }
        private void GridiDoldur()
        {
            tbl_Yoneticiler yonetici = new tbl_Yoneticiler();
            gcYoneticiler.DataSource = yonetici.Listele().ToDataTable();
        }

        public void Doldur()
        {
           // this.tbl_BinalarTableAdapter.Fill(this.aYSDataSet.tbl_Binalar);
            //this.tbl_YoneticiBinaTableAdapter.Fill(this.aYSDataSet.tbl_YoneticiBina);
          //  this.tbl_YoneticilerTableAdapter.Fill(this.aYSDataSet.tbl_Yoneticiler);
        }
        private void frmYoneticiler_Load(object sender, EventArgs e)
        {
            GridiDoldur();
            btnVazgec_Click(null, null);
           // sorumluOlduguDairelerDoldur(); 
           // Doldur();
        }
        
        private void AlanEnabled(bool islem)
        {
            groupControl1.Enabled = islem;
            btnYeni.Enabled = !islem;
            btnSil.Enabled = !islem;
            btnGuncelle.Enabled = !islem;
            btnVazgec.Enabled = islem;
            btnKaydet.Enabled = islem;
            gcYoneticiler.Enabled = !islem;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniKayit = true;
            AlanEnabled(true);
            AlanBosalt();
            lbcBinalar.Items.Clear();
           // yonetici_adiTextBox.Focus();
        }
       
        private void AlanBosalt()
        {
            this.Bilgi = new tbl_Yoneticiler();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            AlanEnabled(false);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                #region Boş Alan kontrolleri yapılıyor...
                if (yonetici_adiTextBox.Text == "")
                {
                    XtraMessageBox.Show("Yonetici Adı Boş geçilemez...", "AYS",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    yonetici_adiTextBox.Focus();
                    return;
                }
                if (yonetici_soyadiTextBox.Text == "")
                {
                    XtraMessageBox.Show("Yonetici Soyadı Boş geçilemez...", "AYS",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    yonetici_soyadiTextBox.Focus();
                    return;
                }
                #endregion

                if (YeniKayit)  // muadil kod karşılığı (YeniKayit==true)
                {
                    #region Yeni Kayıt

                    tbl_Yoneticiler yeni = new tbl_Yoneticiler();
                    yeni.YeniKaydet(this.Bilgi);
                    XtraMessageBox.Show("Kayıt tamamlandı", "AYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #endregion
                }
                else
                {
                    #region Güncelleme işlemi
                    tbl_Yoneticiler yeni = new tbl_Yoneticiler();
                    yeni.Guncelle(this.Bilgi);
                    XtraMessageBox.Show("Kayıt güncellendi", "AYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #endregion
                }
                GridiDoldur();
                AlanEnabled(false);
            }
            catch (Exception hata)
            {
                XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\r\n Hata Detayı: " + hata.StackTrace,
                    "AYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gvYoneticiler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvYoneticiler.FocusedRowHandle < 0)
            {
                AlanBosalt();
                return;
            }
            DataRow dr = gvYoneticiler.GetDataRow(gvYoneticiler.FocusedRowHandle);
            tbl_Yoneticiler liste = new tbl_Yoneticiler();
            this.Bilgi = liste.FindById(Convert.ToInt32(dr["yonetici_id"]));
            sorumluOlduguDairelerDoldur(); // sorumlu olduğu daireleri checklistBox'a dolduruyoruz.
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (gvYoneticiler.FocusedRowHandle < 0)
            {
                return;
            }
            YeniKayit = false;
            AlanEnabled(true);
            yonetici_adiTextBox.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvYoneticiler.FocusedRowHandle < 0)
                    return;    // ilgili metottan dışarıya çıkılır, alttaki kod grubu çalışmaz
                DialogResult cevap = XtraMessageBox.Show("Kaydı silmek istiyor musunuz?",
                    "AYS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.No) //Kullanıcıdan Hayır seçildiyse 
                    return;
                tbl_Yoneticiler yonetici = new tbl_Yoneticiler();
                yonetici.Sil(Convert.ToInt32(yonetici_idTextBox.Text));
                GridiDoldur();
            }
            catch (Exception hata)
            {
                XtraMessageBox.Show("Hata : " + hata.Message + "\r\n Hata Açıklama:" + hata.StackTrace,
                    "AYS", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}