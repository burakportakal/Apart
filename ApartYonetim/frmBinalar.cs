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

namespace ApartYonetim
{
    public partial class frmBinalar : DevExpress.XtraEditors.XtraForm
    {
        public frmBinalar()
        {
            InitializeComponent();
        }

        bool YeniKayit = false;
        private tbl_Binalar depo;
        public tbl_Binalar Bilgi
        {
            get { return depo; }
            set
            {
                if (value != null)
                {
                    depo = value;
                    this.tbl_BinalarBindingSource.DataSource = this.depo;
                }
            }
        }
        private void GridiDoldur()
        {
            tbl_Binalar bina = new tbl_Binalar();
            gcBinalar.DataSource = bina.Listele().ToDataTable();
        }
        private void AlanBosalt()
        {
            this.Bilgi = new tbl_Binalar();
        }
        private void AlanEnabled(bool islem)
        {
            groupControl1.Enabled = islem;
            btnYeni.Enabled = !islem;
            btnSil.Enabled = !islem;
            btnGuncelle.Enabled = !islem;
            btnVazgec.Enabled = islem;
            btnKaydet.Enabled = islem;
            gcBinalar.Enabled = !islem;
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniKayit = true;
            AlanEnabled(true);
            AlanBosalt();
        }

        private void tbl_BinalarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_BinalarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aYSDataSet);

        }

        private void frmBinalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aYSDataSet.tbl_Binalar' table. You can move, or remove it, as needed.
            // this.tbl_BinalarTableAdapter.Fill(this.aYSDataSet.tbl_Binalar);
            GridiDoldur();
            btnVazgec_Click(null, null);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            AlanEnabled(false);
        }

        private void gvBinalar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvBinalar.FocusedRowHandle < 0)
            {
                AlanBosalt();
                return;
            }
            DataRow dr = gvBinalar.GetDataRow(gvBinalar.FocusedRowHandle);
            tbl_Binalar liste = new tbl_Binalar();
            this.Bilgi = liste.FindById(Convert.ToInt32(dr["bina_id"]));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvBinalar.FocusedRowHandle < 0)
                    return;    // ilgili metottan dışarıya çıkılır, alttaki kod grubu çalışmaz
                DialogResult cevap = XtraMessageBox.Show("Kaydı silmek istiyor musunuz?",
                    "AYS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.No) //Kullanıcıdan Hayır seçildiyse 
                    return;
                tbl_Binalar yonetici = new tbl_Binalar();
                yonetici.Sil(Convert.ToInt32(bina_idTextBox.Text));
                GridiDoldur();
            }
            catch (Exception hata)
            {
                XtraMessageBox.Show("Hata : " + hata.Message + "\r\n Hata Açıklama:" + hata.StackTrace,
                    "AYS", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (gvBinalar.FocusedRowHandle < 0)
            {
                return;
            }
            YeniKayit = false;
            AlanEnabled(true);
            bina_adiTextBox.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                #region Boş Alan kontrolleri yapılıyor...
                if (bina_adiTextBox.Text == "")
                {
                    XtraMessageBox.Show("Bina Adı Boş geçilemez...", "AYS",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bina_adiTextBox.Focus();
                    return;
                }
                if (bina_adresiTextBox.Text == "")
                {
                    XtraMessageBox.Show("Bina Adresi Boş geçilemez...", "AYS",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bina_adresiTextBox.Focus();
                    return;
                }
                if (bina_daire_sayisiMaskedTextBox.Text == "")
                {
                    XtraMessageBox.Show("Bina Daire Sayısı Boş geçilemez...", "AYS",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bina_daire_sayisiMaskedTextBox.Focus();
                    return;
                }
                if (bina_irtibat_tel_noMaskedTextBox.Text == "")
                {
                    XtraMessageBox.Show("Bina irtibat Numarası Boş geçilemez...", "AYS",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bina_irtibat_tel_noMaskedTextBox.Focus();
                    return;
                }


                #endregion

                if (YeniKayit)  // muadil kod karşılığı (YeniKayit==true)
                {
                    #region Yeni Kayıt

                    tbl_Binalar yeni = new tbl_Binalar();
                    yeni.YeniKaydet(this.Bilgi);
                    XtraMessageBox.Show("Kayıt tamamlandı", "AYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #endregion
                }
                else
                {
                    #region Güncelleme işlemi
                    tbl_Binalar yeni = new tbl_Binalar();
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
    }
}