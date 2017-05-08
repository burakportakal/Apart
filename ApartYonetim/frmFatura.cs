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
            if (chkListDaire.CheckedIndices.Count<1 && fatura_AdıComboBox.Text!="İnternet")
            {
                XtraMessageBox.Show("En az bir daire seçmelisiniz!");
                return;
            }
            if (chkListDaire.CheckedIndices.Count == 1)
            {
                ortak1 = Convert.ToInt32(chkListDaire.CheckedItems[0].ToString());
            }
            if (chkListDaire.CheckedIndices.Count == 2)
            {
                ortak1 = Convert.ToInt32(chkListDaire.CheckedItems[0].ToString());
                ortak2 = Convert.ToInt32(chkListDaire.CheckedItems[1].ToString());
            }
            if (chkListDaire.CheckedIndices.Count >2)
            {
                XtraMessageBox.Show("2'den fazla ortak seçemezsiniz!");
                return;
            }
          
            if (yeniKayit)
            {
                    int sonuc = ekle.spFaturaEkle(fatura_AdıComboBox.SelectedItem.ToString(), bina_AdıComboBox.SelectedItem.ToString(), abone_NoTextEdit.Text, ortak1, ortak2);
                    if (sonuc > 0)
                        XtraMessageBox.Show("Abone no ekleme başarılı");
                    else
                        XtraMessageBox.Show("Abone no ekleme başarısız");
            }
            else
            {
                int ortakId1 = 0;
                int ortakId2 = 0;

                if (ortakLar.Count == 1)
                    ortakId1 = ortakLar[0].Id;
                else if(ortakLar.Count==2)
                {
                    ortakId1 = ortakLar[0].Id;
                    ortakId2 = ortakLar[1].Id;
                }
                int sonuc = ekle.spFaturaGuncelle(faturaAboneNo.Fatura_id,ortakId1,ortakId2, fatura_AdıComboBox.SelectedItem.ToString(), bina_AdıComboBox.SelectedItem.ToString(), abone_NoTextEdit.Text, ortak1, ortak2);
                if (sonuc > 0)
                    XtraMessageBox.Show("Abone no güncelleme başarılı");
                else
                    XtraMessageBox.Show("Abone no güncelleme başarısız");

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
            chkListDaire.Items.Clear();
            chkListDaire.Text = "";
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
                        chkListDaire.Items.Add(tempDaire.Daire_kapi_no);
                    }
                }
            }
            else
            {
                foreach (tbl_Daireler tempDaire in daireler)
                {
                    if (tempDaire.Bina_id == binaId && faturaDaire.Contains(tempDaire.Daire_no) && ortakInt.Contains(tempDaire.Daire_no))
                    {
                        chkListDaire.Items.Add(tempDaire.Daire_kapi_no,true);
                    }
                    else if(tempDaire.Bina_id == binaId && !faturaDaire.Contains(tempDaire.Daire_no))
                    {
                        chkListDaire.Items.Add(tempDaire.Daire_kapi_no);
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
            chkListDaire.Items.Clear();
            daireNolar.Clear();
            ortakLar.Clear();
            foreach (DataRow item in dt.Rows)
            {
                daireNolar.Add(Convert.ToInt32(item.ItemArray[1]));
                chkListDaire.Items.Add(item.ItemArray[0].ToString(), true);
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
            chkListDaire.Items.Clear();
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
                chkListDaire.Items.Clear();
                chkListDaire.Text = "";
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
                            chkListDaire.Items.Add(tempDaire.Daire_kapi_no);
                        }

                    }
                }
                else
                {
                    foreach (tbl_Daireler tempDaire in daireler)
                    {
                        if (tempDaire.Bina_id == binaId && faturaDaire.Contains(tempDaire.Daire_no) && ortakInt.Contains(tempDaire.Daire_no))
                        {
                            chkListDaire.Items.Add(tempDaire.Daire_kapi_no,true);
                        }
                        else if (tempDaire.Bina_id == binaId && !faturaDaire.Contains(tempDaire.Daire_no))
                        {
                            chkListDaire.Items.Add(tempDaire.Daire_kapi_no);
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
    }
}