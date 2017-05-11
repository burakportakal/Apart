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
using DevExpress.XtraGrid.Views.Grid;
using System.Globalization;
using BilisimLibrary.Model;

namespace ApartYonetim
{
    public partial class frmMusteriler : DevExpress.XtraEditors.XtraForm
    {
        public frmMusteriler()
        {
            InitializeComponent();
            
        }
        List<tbl_Binalar> binalar;
        tbl_Daireler daire = new tbl_Daireler();
        List<tbl_Daireler> daireler;
        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aYSDataSet.tbl_GelirTuru' table. You can move, or remove it, as needed.
            this.tbl_GelirTuruTableAdapter.Fill(this.aYSDataSet.tbl_GelirTuru);
            // TODO: This line of code loads data into the 'aYSDataSet.tbl_Musteriler' table. You can move, or remove it, as needed.
            this.tbl_MusterilerTableAdapter.Fill(this.aYSDataSet.tbl_Musteriler);
            //griddoldur();
            tbl_Binalar bina = new tbl_Binalar();
            binalar = bina.Listele().ToList();
            daireler = daire.Listele().ToList();
            foreach (tbl_Binalar binaAdi in binalar)
            {
                cmbBinaAdi.Items.Add(binaAdi.Bina_adi);
            }
            griddoldur();
            DateTime time = DateTime.Now;
            string year = time.Year.ToString();
            for (int i = 1; i < 13; i++)
            {
                cmbKiraDonemi.Items.Add(year + "/" + i);
            }
            chkKayitli.Checked = true;
            chkYetkili.Checked = true;
        }

        void griddoldur()
        {
            tbl_Kiralar kira = new tbl_Kiralar();
            DateTime time = DateTime.Now;
            //string kiraDonemi = time.Year + "/" + time.Month;
            string kiraDonemi = "";
            DataSet ds = kira.spKiraSorgula(kiraDonemi,false,"",true,true,0,"spKiraSorgula");
            grSorgula.DataSource = ds.Tables["tbl_Kira"];
            grSorgula.Refresh();
        }
        public string ToTitleCase(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Kira Durumu"]);
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

            gridSorgulama.ClearSelection();
   
        }

        private void tbl_MusterilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_MusterilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aYSDataSet);

        }

        private void bina_adiComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
                if (tempDaire.Bina_id == binaId)
                {
                    cmbDaireKapiNo.Items.Add(tempDaire.Daire_kapi_no);
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            /*tbl_Binalar bina = new tbl_Binalar();
            DataSet dataSet = new DataSet() ;
            if (cmbDaireKapiNo.SelectedItem!=null)
            {
                int daireKapiNo = Convert.ToInt32(cmbDaireKapiNo.SelectedItem.ToString());
                dataSet = bina.spBinaSorgula(cmbBinaAdi.SelectedItem.ToString(), chkYetkili.Checked, daireKapiNo, "spBinaSorgula");
            }
           else
                dataSet = bina.spBinaSorgula(cmbBinaAdi.SelectedItem.ToString(), chkYetkili.Checked, 0, "spBinaSorgula");
            gridSorgulama.Columns.Clear();
            grSorgula.DataSource = dataSet.Tables["tbl_BinaMusteri"];
            grSorgula.Refresh();*/
            tbl_Kiralar kira = new tbl_Kiralar();
            bool kayitli = chkKayitli.Checked;
            string kiraDonemi = "";
            if (cmbKiraDonemi.SelectedItem != null)
                kiraDonemi = cmbKiraDonemi.SelectedItem.ToString();
            int daireKapiNo = 0;
            if (cmbDaireKapiNo.SelectedItem != null)
                daireKapiNo = Convert.ToInt32(cmbDaireKapiNo.SelectedItem.ToString());
            string binaAdi="";
            if (cmbBinaAdi.SelectedItem != null)
                binaAdi = cmbBinaAdi.SelectedItem.ToString();
            DataSet ds = kira.spKiraSorgula(kiraDonemi, chkKiraDurumu.Checked,binaAdi , chkYetkili.Checked,kayitli, daireKapiNo, "spKiraSorgula");
            grSorgula.DataSource = ds.Tables["tbl_Kira"];
            grSorgula.Refresh();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmbBinaAdi.ResetText();
            cmbBinaAdi.SelectedText = "";
            cmbKiraDonemi.ResetText();
            cmbKiraDonemi.SelectedText = "";
            cmbDaireKapiNo.SelectedText = "";
            cmbDaireKapiNo.ResetText();
            chkYetkili.Checked = true;
            chkKiraDurumu.Checked = false;
            griddoldur();
            grSorgula.Refresh();
        }

        private void btnGelirKayit_Click(object sender, EventArgs e)
        {
            string kiraDonemi="";
            string apartAdi="";
            int daireKapiNo=0;
            string tcKimlikNo = "";
            foreach (int i in gridSorgulama.GetSelectedRows())
            {
                DataRow row = gridSorgulama.GetDataRow(i);
                 kiraDonemi =row[0].ToString();
                 apartAdi = row[6].ToString();
                 daireKapiNo =Convert.ToInt32( row[7].ToString());
                tcKimlikNo = row[1].ToString();
            }
            frmGelirKayit gelir = new frmGelirKayit(kiraDonemi,apartAdi,daireKapiNo,tcKimlikNo);
            gelir.ShowDialog();
        }
    }
}

       



