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
    public partial class frmDemirbaslar : DevExpress.XtraEditors.XtraForm
    {
        public frmDemirbaslar()
        {
            InitializeComponent();
        }

        bool YeniKayit = false;
        private tbl_Demirbaslar depo;
        public tbl_Demirbaslar Bilgi
        {
            get { return depo; }
            set
            {
                if (value != null)
                {
                    depo = value;
                    this.tbl_DemirbaslarBindingSource.DataSource = this.depo;
                }
            }
        }

        private void GridiDoldur()
        {
            tbl_Demirbaslar demirbas = new tbl_Demirbaslar();
            gcDemirbaslar.DataSource = demirbas.Listele2(frmYoneticiGirisi.yoneticiler.Yonetici_yetki).ToDataTable();
        }
        private void AlanBosalt()
        {
            this.Bilgi = new tbl_Demirbaslar();
        }
        private void AlanEnabled(bool islem)
        {
            groupControl1.Enabled = islem;
            btnYeni.Enabled = !islem;
            btnSil.Enabled = !islem;
            btnGuncelle.Enabled = !islem;
            btnVazgec.Enabled = islem;
            btnKaydet.Enabled = islem;
            gcDemirbaslar.Enabled = !islem;
        }

        private void tbl_DemirbaslarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_DemirbaslarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aYSDataSet);

        }

        private void frmDemirbaslar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aYSDataSet3.tbl_DemirbasTur' table. You can move, or remove it, as needed.
            this.tbl_DemirbasTurTableAdapter.Fill(this.aYSDataSet3.tbl_DemirbasTur);
            // TODO: This line of code loads data into the 'aYSDataSet.tbl_Demirbaslar' table. You can move, or remove it, as needed.
          //  this.tbl_DemirbaslarTableAdapter.Fill(this.aYSDataSet.tbl_Demirbaslar);
            GridiDoldur();
            btnVazgec_Click(null, null);

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniKayit = true;
            AlanEnabled(true);
            AlanBosalt();
            daireNoGetir();
            demirbas_alis_tarihiDateTimePicker.Refresh();
        }


        private void btnVazgec_Click(object sender, EventArgs e)
        {
            AlanEnabled(false);
        }

        private void gvDemirbaslar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvDemirbaslar.FocusedRowHandle < 0)
            {
                AlanBosalt();
                return;
            }
            DataRow dr = gvDemirbaslar.GetDataRow(gvDemirbaslar.FocusedRowHandle);
            tbl_Demirbaslar liste = new tbl_Demirbaslar();
            this.Bilgi = liste.FindById(Convert.ToInt32(dr["demirbas_id"]));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvDemirbaslar.FocusedRowHandle < 0)
                    return;    // ilgili metottan dışarıya çıkılır, alttaki kod grubu çalışmaz
                DialogResult cevap = XtraMessageBox.Show("Kaydı silmek istiyor musunuz?",
                    "AYS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.No) //Kullanıcıdan Hayır seçildiyse 
                    return;
                tbl_Demirbaslar bina = new tbl_Demirbaslar();
                bina.Sil(Convert.ToInt32(demirbas_idTextBox.Text));
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
            if (gvDemirbaslar.FocusedRowHandle < 0)
            {
                return;
            }
            YeniKayit = false;
            AlanEnabled(true);
            daire_noComboBox.Focus();
            daireNoGetir();
        }
        private void daireNoGetir()
        {
            tbl_Demirbaslar demirbas = new tbl_Demirbaslar();
            //SqlDataReader dr = demirbas.daireListele();
            SqlDataReader dr = demirbas.daireListele(frmYoneticiGirisi.yoneticiler.Yonetici_yetki);
            daire_noComboBox.Items.Clear();
            while (dr.Read())
            {
                daire_noComboBox.Items.Add(dr["daire_no"]);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                #region Boş Alan kontrolleri yapılıyor...
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

                #endregion

                if (YeniKayit)  // muadil kod karşılığı (YeniKayit==true)
                {
                    #region Yeni Kayıt

                    tbl_Demirbaslar yeni = new tbl_Demirbaslar();
                    yeni.YeniKaydet(this.Bilgi);
                    XtraMessageBox.Show("Kayıt tamamlandı", "AYS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #endregion
                }
                else
                {
                    #region Güncelleme işlemi
                    tbl_Demirbaslar yeni = new tbl_Demirbaslar();
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