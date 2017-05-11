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
    public partial class frmFaturaGelirKayit : DevExpress.XtraEditors.XtraForm
    {

        string FaturaDonemi;
        string ApartAdi;
        int DaireKapiNo;
        string AboneNo;
        public frmFaturaGelirKayit(string faturaDonemi, string apartAdi, int daireKapiNo, string aboneNo)
        {
            FaturaDonemi = faturaDonemi;
            ApartAdi = apartAdi;
            DaireKapiNo = daireKapiNo;
            AboneNo = aboneNo;
            InitializeComponent();
        }
        List<tbl_Binalar> binalar;
        tbl_Daireler daire = new tbl_Daireler();
        List<tbl_Daireler> daireler;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tbl_Gelir gelir = new tbl_Gelir();
            if (String.IsNullOrEmpty(txtGelirTutari.Text))
            {
                XtraMessageBox.Show("Gelir tutarını girmelisiniz", "Hata");
                return;
            }
            if (String.IsNullOrEmpty(txtAboneNo.Text))
            {
                XtraMessageBox.Show("TC No alanı boş geçilemez", "Hata");
                return;
            }
            AboneNo = txtAboneNo.Text;
            float gelirTutari = (float)Convert.ToDouble(txtGelirTutari.Text);
            DateTime gelirTarihi = DateTime.Now;
            int daireKapiNo = Convert.ToInt32(cmbDaireKapiNo.SelectedItem.ToString());
            string binaAdi = cmbBinaAdi.SelectedItem.ToString();
            DateTime gelirKayitTarihi = DateTime.Now;
            int gelirKayitEdenYoneticiId = 1;
            string kiraDonemi = cmbKiraDonemi.SelectedItem.ToString();


            string procName = "spGelirKaydet";
            //sonuc spGelirKaydetten geri dönüyor bir işlem yapılacaksa ordan yapılmalı
            int sonuc = gelir.spFaturaGelirKaydet(AboneNo, gelirTutari, gelirTarihi,
                daireKapiNo,
                binaAdi,
                gelirKayitEdenYoneticiId,
                kiraDonemi);
            if (sonuc == 1)
                XtraMessageBox.Show("Gelir kaydı başarılı");
            else
                XtraMessageBox.Show("Gelir kaydı başarısız");
            gcGelir.Refresh();
        }

        private void frmFaturaGelirKayit_Load(object sender, EventArgs e)
        {
            tbl_Binalar bina = new tbl_Binalar();
            binalar = bina.Listele().ToList();
            daireler = daire.Listele().ToList();
            foreach (tbl_Binalar binaAdi in binalar)
            {
                cmbBinaAdi.Items.Add(binaAdi.Bina_adi);
            }
            DateTime time = DateTime.Now;
            string year = time.Year.ToString();
            for (int i = 1; i < 13; i++)
            {
                cmbKiraDonemi.Items.Add(year + "/" + i);
            }
            cmbKiraDonemi.SelectedItem = FaturaDonemi;
            cmbBinaAdi.SelectedItem = ApartAdi;
            cmbDaireKapiNo.SelectedItem = DaireKapiNo;
            txtAboneNo.Text = AboneNo;
            griddoldur();
        }
        void griddoldur()
        {
            tbl_Gelir gelir = new tbl_Gelir();
            DataSet ds = gelir.spFaturaGelirListesi();
            gcGelir.DataSource = ds.Tables["tbl_FaturaGelir"];
            gcGelir.Refresh();
        }

        private void cmbBinaAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string binaAdi = cmbBinaAdi.SelectedItem.ToString();
            int binaId = 0;
            cmbDaireKapiNo.Items.Clear();
            cmbDaireKapiNo.Text = "";
            foreach (tbl_Binalar bina in binalar)
            {
                if (binaAdi == bina.Bina_adi)
                    binaId = bina.Bina_id;
            }
            foreach (tbl_Daireler tempDaire in daireler)
            {
                if (tempDaire.Bina_id == binaId && tempDaire.Daire_durumu)
                {
                    cmbDaireKapiNo.Items.Add(tempDaire.Daire_kapi_no);
                }
            }
        }
    }
}