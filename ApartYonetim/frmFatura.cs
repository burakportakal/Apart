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
    public partial class frmFatura : DevExpress.XtraEditors.XtraForm
    {
        List<tbl_Binalar> binalar;
        List<tbl_Daireler> daireler;
        List<int> daireNolar=new List<int>();
        tbl_FaturaAboneNo faturaAboneNo = new tbl_FaturaAboneNo();
        List<tbl_OrtakFatura> ortakLar = new List<tbl_OrtakFatura>();
        bool yeniKayit = false;
        public frmFatura()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tbl_FaturaAboneNo ekle = new tbl_FaturaAboneNo();
            int ortak1 = 0;
            int ortak2 = 0;
            if(fatura_AdıComboBox.SelectedItem==null)
            {
                XtraMessageBox.Show("Fatura adını seçmelisiniz!");
                return;
            }
            if (bina_AdıComboBox.SelectedItem==null)
            {
                XtraMessageBox.Show("Bina adını seçmelisiniz!");
                return;
            }
            if (String.IsNullOrEmpty(abone_NoTextEdit.Text))
            {
                XtraMessageBox.Show("Abone no girmelisiniz!");
                return;
            }
            if (clbOrtakListesi.ItemCount<1 && fatura_AdıComboBox.Text!="İnternet")
            {
                XtraMessageBox.Show("En az bir daire seçmelisiniz!");
                return;
            }
            if (clbOrtakListesi.ItemCount == 1)
            {
                ortak1 = Convert.ToInt32(clbOrtakListesi.Items[0].ToString());
            }
            if (clbOrtakListesi.ItemCount == 2)
            {
                ortak1 = Convert.ToInt32(clbOrtakListesi.Items[0].ToString());
                ortak2 = Convert.ToInt32(clbOrtakListesi.Items[1].ToString());
            }
            
            if (clbOrtakListesi.ItemCount > 2)
            {
                XtraMessageBox.Show("2'den fazla ortak seçemezsiniz!");
                return;
            }
            int[] ortakTemp = new int[] { ortak1, ortak2 };
            if (yeniKayit)
            {
                    int sonuc = ekle.spFaturaEkle(fatura_AdıComboBox.SelectedItem.ToString(),
                        bina_AdıComboBox.SelectedItem.ToString(), 
                        abone_NoTextEdit.Text, ortak1, ortak2);
                    if (sonuc > 0)
                        XtraMessageBox.Show("Fatura ekleme başarılı");
                    else
                        XtraMessageBox.Show("Fatura ekleme başarısız");
            }
            else
            {
                tbl_OrtakFatura ortak = new tbl_OrtakFatura();
                foreach (var item in daireNolar)
                {
                    ortak.ortakSil(abone_NoTextEdit.Text, item);
                }
                tbl_FaturaAboneNo aboneGuncelle = new tbl_FaturaAboneNo();
                aboneGuncelle.spFaturaGuncelle(faturaAboneNo.Fatura_id, fatura_AdıComboBox.Text, bina_AdıComboBox.Text, abone_NoTextEdit.Text);
                ortak.spFaturaOrtakEkle(bina_AdıComboBox.Text, abone_NoTextEdit.Text, ortak1, ortak2);

            }
            gridDoldur();
            AlanEnabled(false);
        }

        private void frmFatura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aYSDataSet.spFatura' table. You can move, or remove it, as needed.

            gridDoldur();
            tbl_FaturaTuru faturaTuru = new tbl_FaturaTuru();
            List<tbl_FaturaTuru> liste= faturaTuru.Listele().ToList();
            foreach (var item in liste)
            {
                fatura_AdıComboBox.Items.Add(item.Fatura_adi);
            }
            tbl_Binalar bina = new tbl_Binalar();
             binalar = bina.Listele().ToList();
            foreach (var item in binalar)
            {
                bina_AdıComboBox.Items.Add(item.Bina_adi);
            }
            tbl_Daireler daire = new tbl_Daireler();
            daireler = daire.Listele().ToList();
            AlanEnabled(false);
        }
        private void gridDoldur()
        {
            gcFatura.DataSource = new tbl_FaturaAboneNo().spFatura().Tables["tbl_Fatura"];
        }
        //zaten fatura abone no eklenmiş daireleri getirmez
        private void bina_AdıComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<tbl_Daireler> faturaEklenenDaireler = new List<tbl_Daireler>();
            faturaEklenenDaireler = new tbl_Daireler().faturaEklenenDaireler(fatura_AdıComboBox.Text).ToList();
            int[] faturaDaire = new int[faturaEklenenDaireler.Count];
            for (int i = 0; i < faturaEklenenDaireler.Count; i++)
            {
                
                faturaDaire[i] = faturaEklenenDaireler[i].Daire_no;
            }
            int[] ortakInt = new int[ortakLar.Count];
            for (int i = 0; i <ortakInt.Length; i++)
            {
                ortakInt[i] = ortakLar[i].Daire_no;
            }
            string binaAdi = bina_AdıComboBox.SelectedItem.ToString();
            int binaId = 0;
            clbOrtakListesi.Items.Clear();
            clbDaireListesi.Items.Clear();
            foreach (tbl_Binalar bina in binalar)
            {
                if (binaAdi == bina.Bina_adi)
                    binaId = bina.Bina_id;
            }
            if (yeniKayit)
            {
                foreach (tbl_Daireler tempDaire in daireler)
                {
                    if (tempDaire.Bina_id == binaId && !faturaDaire.Contains(tempDaire.Daire_no))
                    {
                        clbDaireListesi.Items.Add(tempDaire.Daire_kapi_no);
                    }
                }
            }
            else
            {
                foreach (tbl_Daireler tempDaire in daireler)
                {
                    if (tempDaire.Bina_id == binaId && faturaDaire.Contains(tempDaire.Daire_no) && ortakInt.Contains(tempDaire.Daire_no))
                    {
                        clbOrtakListesi.Items.Add(tempDaire.Daire_kapi_no);
                    }
                    else if(tempDaire.Bina_id == binaId && !faturaDaire.Contains(tempDaire.Daire_no))
                    {
                        clbDaireListesi.Items.Add(tempDaire.Daire_kapi_no);
                    }
                }
            }
        }

        private void gvFatura_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvFatura.FocusedRowHandle < 0)
            {
                return;
            }
            fatura_AdıComboBox.Text=gvFatura.GetFocusedRowCellValue("Fatura Adı").ToString();
            bina_AdıComboBox.Text = gvFatura.GetFocusedRowCellValue("Apart Adı").ToString();
            abone_NoTextEdit.Text = gvFatura.GetFocusedRowCellValue("Abone No").ToString();

            tbl_Daireler daire = new tbl_Daireler();
            DataRow dr = gvFatura.GetDataRow(gvFatura.FocusedRowHandle);
            faturaAboneNo = faturaAboneNo.FindById(Convert.ToInt32(dr["Fatura Id"]));

            DataTable dt = daire.spFaturaOrtakDaire(abone_NoTextEdit.Text).Tables["tbl_FaturaOrtakDaire"];
            clbOrtakListesi.Items.Clear();
            daireNolar.Clear();
            ortakLar.Clear();
            foreach (DataRow item in dt.Rows)
            {
                daireNolar.Add(Convert.ToInt32(item.ItemArray[1]));
                clbOrtakListesi.Items.Add(item.ItemArray[0].ToString());
            }
            try
            {
                foreach (int item in daireNolar)
                {
                    tbl_OrtakFatura ortak = new tbl_OrtakFatura().FindByAboneNoDaireNo(faturaAboneNo.Fatura_abone_no, item.ToString());
                    ortakLar.Add(ortak);
                }
            }
            catch (Exception)
            {

            }
       
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            AlanEnabled(true);
            fatura_AdıComboBox.Text = "";
            abone_NoTextEdit.Text = "";
            bina_AdıComboBox.Text = "";
            clbOrtakListesi.Items.Clear();
            yeniKayit = true;
            fatura_AdıComboBox.Enabled = true;
        }
        private void AlanEnabled(bool islem)
        {
            groupFatura.Enabled = islem;
            btnYeni.Enabled = !islem;
            btnSil.Enabled = !islem;
            btnGuncelle.Enabled = !islem;
            btnVazgec.Enabled = islem;
            btnKaydet.Enabled = islem;
            gcFatura.Enabled = !islem;
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            yeniKayit = false;
            AlanEnabled(true);
            fatura_AdıComboBox.Enabled = false;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            yeniKayit = false;
            AlanEnabled(false);
            gridDoldur();
            gcFatura.Refresh();
            gvFatura.RefreshData();
        }

        private void fatura_AdıComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bina_AdıComboBox.Text != "")
            {
                List<tbl_Daireler> faturaEklenenDaireler = new List<tbl_Daireler>();
                faturaEklenenDaireler = new tbl_Daireler().faturaEklenenDaireler(fatura_AdıComboBox.Text).ToList();
                int[] faturaDaire = new int[faturaEklenenDaireler.Count];
                for (int i = 0; i < faturaEklenenDaireler.Count; i++)
                {
                    faturaDaire[i] = faturaEklenenDaireler[i].Daire_no;
                }
                int[] ortakInt = new int[ortakLar.Count];
                for (int i = 0; i < ortakInt.Length; i++)
                {
                    ortakInt[i] = ortakLar[i].Daire_no;
                }
                string binaAdi = bina_AdıComboBox.Text;
                int binaId = 0;
                foreach (tbl_Binalar bina in binalar)
                {
                    if (binaAdi == bina.Bina_adi)
                        binaId = bina.Bina_id;
                }
                clbOrtakListesi.Items.Clear();
                clbDaireListesi.Items.Clear();
                foreach (tbl_Binalar bina in binalar)
                {
                    if (binaAdi == bina.Bina_adi)
                        binaId = bina.Bina_id;
                }
                if (yeniKayit)
                {
                    foreach (tbl_Daireler tempDaire in daireler)
                    {
                        if (tempDaire.Bina_id == binaId && !faturaDaire.Contains(tempDaire.Daire_no))
                        {
                            clbDaireListesi.Items.Add(tempDaire.Daire_kapi_no);
                        }
                    }
                }
                else
                {
                    foreach (tbl_Daireler tempDaire in daireler)
                    {
                        if (tempDaire.Bina_id == binaId && faturaDaire.Contains(tempDaire.Daire_no) && ortakInt.Contains(tempDaire.Daire_no))
                        {
                            clbOrtakListesi.Items.Add(tempDaire.Daire_kapi_no);
                        }
                        else if (tempDaire.Bina_id == binaId && !faturaDaire.Contains(tempDaire.Daire_no))
                        {
                            clbDaireListesi.Items.Add(tempDaire.Daire_kapi_no);
                        }
                    }
                }
            }
        }

        private void btnFaturaTuru_Click(object sender, EventArgs e)
        {
            frmFaturaTuru frm = new frmFaturaTuru();
            frm.ShowDialog();
        }

        private void clbDaireListesi_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            btnYetkiVer.Enabled = true;
            btnYetkiKaldir.Enabled = false;
        }

        private void clbOrtakListesi_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
            btnYetkiVer.Enabled = false;
            btnYetkiKaldir.Enabled = true;
        }

        private void btnYetkiVer_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(clbBinaListesi.Items[0].Value.ToString());
            int lastIndex = clbDaireListesi.Items.Count - 1;
            for (int i = lastIndex; i >= 0; i--)
            {
                if (clbDaireListesi.GetItemCheckState(i) == CheckState.Checked)
                {
                    clbOrtakListesi.Items.Add(clbDaireListesi.Items[i].Value, clbDaireListesi.Items[i].ToString());
                    clbDaireListesi.Items.RemoveAt(i);

                }
            }
        }

        private void btnYetkiKaldir_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(clbBinaYetkListesi.Items[0].Value.ToString());
            int lastIndex = clbOrtakListesi.Items.Count - 1;
            for (int i = lastIndex; i >= 0; i--)
            {
                if (clbOrtakListesi.GetItemCheckState(i) == CheckState.Checked)
                {
                    clbDaireListesi.Items.Add(clbOrtakListesi.Items[i].Value, clbOrtakListesi.Items[i].ToString());
                    clbOrtakListesi.Items.RemoveAt(i);

                }
            }
        }
    }
}