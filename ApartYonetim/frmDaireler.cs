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
    public partial class frmDaireler : DevExpress.XtraEditors.XtraForm
    {
        public frmDaireler()
        {
            InitializeComponent();
        }
        bool YeniKayit = false;
        private tbl_Daireler depo;
        public tbl_Daireler Bilgi
        {
            get { return depo; }
            set
            {
                if (value != null)
                {
                    depo = value;
                    this.tbl_DairelerBindingSource.DataSource = this.depo;
                }
            }
        }

        private void GridiDoldur()
        {
            tbl_Daireler bina = new tbl_Daireler();
            gcDaireler.DataSource = bina.Listele().ToDataTable();
        }
        private void AlanBosalt()
        {
            this.Bilgi = new tbl_Daireler();
        }
        private void AlanEnabled(bool islem)
        {
            groupControl1.Enabled = islem;
            btnYeni.Enabled = !islem;
            btnSil.Enabled = !islem;
            btnGuncelle.Enabled = !islem;
            btnVazgec.Enabled = islem;
            btnKaydet.Enabled = islem;
            gcDaireler.Enabled = !islem;
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniKayit = true;
            AlanEnabled(true);
            AlanBosalt();

            bina_idLookUpEdit.Enabled = true;
            daire_kat_noTextBox.Enabled = true;
            daire_kapi_noTextBox.Enabled = true;
            bina_idLookUpEdit.Focus();
        }

        private void tbl_DairelerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_DairelerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aYSDataSet);

        }

        private void frmDaireler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aYSDataSet2.tbl_Binalar' table. You can move, or remove it, as needed.
            this.tbl_BinalarTableAdapter1.Fill(this.aYSDataSet2.tbl_Binalar);
            // TODO: This line of code loads data into the 'aYSDataSet1.tbl_Binalar' table. You can move, or remove it, as needed.
            this.tbl_BinalarTableAdapter.Fill(this.aYSDataSet1.tbl_Binalar);
            // TODO: This line of code loads data into the 'aYSDataSet.tbl_Daireler' table. You can move, or remove it, as needed.
            this.tbl_DairelerTableAdapter.Fill(this.aYSDataSet.tbl_Daireler);
            GridiDoldur();
            tbl_Binalar bina = new tbl_Binalar();
            tblBinalarBindingSource.DataSource = bina.Listele();
            btnVazgec_Click(null, null);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            AlanEnabled(false);
        }

        private void gvDaireler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvDaireler.FocusedRowHandle < 0)
            {
                AlanBosalt();
                return;
            }
            DataRow dr = gvDaireler.GetDataRow(gvDaireler.FocusedRowHandle);
            tbl_Daireler liste = new tbl_Daireler();
            this.Bilgi = liste.FindById(Convert.ToInt32(dr["daire_id"]));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvDaireler.FocusedRowHandle < 0)
                    return;    // ilgili metottan dışarıya çıkılır, alttaki kod grubu çalışmaz
                DialogResult cevap = XtraMessageBox.Show("Kaydı silmek istiyor musunuz?",
                    "AYS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.No) //Kullanıcıdan Hayır seçildiyse 
                    return;
                tbl_Daireler daire = new tbl_Daireler();
                daire.Sil(Convert.ToInt32(daire_idTextBox.Text));
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
            if (gvDaireler.FocusedRowHandle < 0)
            {
                return;
            }
            YeniKayit = false;
            AlanEnabled(true);
            daire_durumuCheckBox.Focus();
            bina_idLookUpEdit.Enabled=false;
            daire_kat_noTextBox.Enabled = false;
            daire_kapi_noTextBox.Enabled = false;
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //#region Boş Alan kontrolleri yapılıyor...
                //if (bina_adiTextBox.Text == "")
                //{
                //    XtraMessageBox.Show("Bina Adı Boş geçilemez...", "AYS",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    bina_adiTextBox.Focus();
                //    return;
                //}
                //if (bina_adresiTextBox.Text == "")
                //{
                //    XtraMessageBox.Show("Bina Adresi Boş geçilemez...", "AYS",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    bina_adresiTextBox.Focus();
                //    return;
                //}
                //if (bina_daire_sayisiMaskedTextBox.Text == "")
                //{
                //    XtraMessageBox.Show("Bina Daire Sayısı Boş geçilemez...", "AYS",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    bina_daire_sayisiMaskedTextBox.Focus();
                //    return;
                //}
                //if (bina_irtibat_tel_noMaskedTextBox.Text == "")
                //{
                //    XtraMessageBox.Show("Bina irtibat Numarası Boş geçilemez...", "AYS",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    bina_irtibat_tel_noMaskedTextBox.Focus();
                //    return;
                //}


                //#endregion

                if (YeniKayit)  // muadil kod karşılığı (YeniKayit==true)
                {
                    #region Yeni Kayıt

                    tbl_Daireler yeni = new tbl_Daireler();
                    yeni.YeniKaydet(this.Bilgi);
                    XtraMessageBox.Show("Kayıt tamamlandı", "AYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #endregion
                }
                else
                {
                    #region Güncelleme işlemi
                    tbl_Daireler yeni = new tbl_Daireler();
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