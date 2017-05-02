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
        private void binaListele()
        {
            clbBinaListesi.Items.Clear();
            tbl_YoneticiBina yoneticiBina = new tbl_YoneticiBina();
            SqlDataReader dr = yoneticiBina.binaListele();
            while (dr.Read())
            {
                string binaAdi = dr["bina_adi"].ToString();
                if (clbBinaYetkListesi.FindString(binaAdi) < 0)
                    clbBinaListesi.Items.Add(dr["bina_id"], dr["bina_adi"].ToString());
            }
        }
        public void sorumluOlduguDairelerDoldur()
        {
            clbBinaYetkListesi.Items.Clear();
            tbl_YoneticiBina yoneticiBina = new tbl_YoneticiBina();
            int ID2 = Convert.ToInt32(yonetici_idTextBox.Text);
            SqlDataReader dr = yoneticiBina.binaListele(ID2);
            while (dr.Read())
                clbBinaYetkListesi.Items.Add(dr["bina_id"], dr["bina_adi"].ToString());
        }
        private void GridiDoldur()
        {
            tbl_Yoneticiler yonetici = new tbl_Yoneticiler();
            gcYoneticiler.DataSource = yonetici.Listele().ToDataTable();
        }
        private void frmYoneticiler_Load(object sender, EventArgs e)
        {
            GridiDoldur();
            btnVazgec_Click(null, null);
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
            clbBinaYetkListesi.Items.Clear();
            binaListele();

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

                if (YeniKayit)
                {
                    #region Yeni Kayıt

                    tbl_Yoneticiler yeni = new tbl_Yoneticiler();
                    yeni.YeniKaydet(this.Bilgi);
                    XtraMessageBox.Show("Kayıt tamamlandı", "AYS", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    #region Yönetici Yetki Düzenle
                    // Yöneticilere hangi binayı yöneticek onun yetkisi veriliyor.
                    tbl_YoneticiBina yoneticiBina = new tbl_YoneticiBina();
                    SqlDataReader dr = yoneticiBina.newYoneticiID();
                    dr.Read();
                    yoneticiBina.Yonetici_id = Convert.ToInt32(dr["newYoneticiID"]); // burada ilk kayıt olduğu için yöneticinin ID'si bilinmiyor bu yüzden SonID'yi getiren metod yazıldı.

                    int lastIndex = clbBinaYetkListesi.Items.Count - 1;
                    for (int i = 0; i <= lastIndex; i++)
                    {
                        yoneticiBina.Bina_id = Convert.ToInt32(clbBinaYetkListesi.Items[i].Value);
                        yoneticiBina.YeniKaydet(yoneticiBina);
                    }
                    #endregion

                    #endregion
                }
                else
                {
                    #region Güncelleme işlemi
                    tbl_Yoneticiler yeni = new tbl_Yoneticiler();
                    yeni.Guncelle(this.Bilgi);
                    XtraMessageBox.Show("Kayıt güncellendi", "AYS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    #region Yönetici Yetki Düzenle
                    tbl_YoneticiBina yoneticiBina = new tbl_YoneticiBina();
                    yoneticiBina.yetkiSil(this.Bilgi.Yonetici_id);
                    yoneticiBina.Yonetici_id = this.Bilgi.Yonetici_id;

                    int lastIndex = clbBinaYetkListesi.Items.Count - 1;
                    for (int i = 0; i <= lastIndex; i++)
                    {
                        yoneticiBina.Bina_id = Convert.ToInt32(clbBinaYetkListesi.Items[i].Value);
                        yoneticiBina.YeniKaydet(yoneticiBina);
                    }
                    #endregion

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
            binaListele();
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
        private void btnYetkiVer_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(clbBinaListesi.Items[0].Value.ToString());
            int lastIndex = clbBinaListesi.Items.Count - 1;
            for (int i = lastIndex; i >= 0; i--)
            {
                if (clbBinaListesi.GetItemCheckState(i) == CheckState.Checked)
                {
                    clbBinaYetkListesi.Items.Add(clbBinaListesi.Items[i].Value, clbBinaListesi.Items[i].ToString());
                    clbBinaListesi.Items.RemoveAt(i);

                }
            }
        }
        private void btnYetkiKaldir_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(clbBinaYetkListesi.Items[0].Value.ToString());
            int lastIndex = clbBinaYetkListesi.Items.Count - 1;
            for (int i = lastIndex; i >= 0; i--)
            {
                if (clbBinaYetkListesi.GetItemCheckState(i) == CheckState.Checked)
                {
                    clbBinaListesi.Items.Add(clbBinaYetkListesi.Items[i].Value, clbBinaYetkListesi.Items[i].ToString());
                    clbBinaYetkListesi.Items.RemoveAt(i);

                }
            }
        }
        private void clbBinaListesi_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            btnYetkiVer.Enabled = true;
            btnYetkiKaldir.Enabled = false;
        }
        private void clbBinaYetkListesi_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
            btnYetkiVer.Enabled = false;
            btnYetkiKaldir.Enabled = true;
        }
    }
}