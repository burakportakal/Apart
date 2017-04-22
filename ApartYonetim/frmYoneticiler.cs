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
    public partial class frmYoneticiler : DevExpress.XtraEditors.XtraForm
    {
        public frmYoneticiler()
        {
            InitializeComponent();
        }
        bool YeniKayit = false;

        private void tbl_YoneticilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_YoneticilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aYSDataSet);

        }
        public void sorumluOlduguDairelerDoldur()
        {
            clbSorumluOlduguBinalar.Items.Clear();
            int ID = Convert.ToInt32(yonetici_idTextBox.Text);
            tbl_Binalar binalar = new tbl_Binalar();
            tbl_YoneticiBina yoneticiBina = new tbl_YoneticiBina();

            int count = binalar.BinaYoneticiListe(ID).Count();
            List<string> liste = binalar.BinaYoneticiListe(ID);
            for (int i = 0; i < count; i++)
            {
                clbSorumluOlduguBinalar.Items.Add(liste[i]);
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
            this.tbl_YoneticilerTableAdapter.Fill(this.aYSDataSet.tbl_Yoneticiler);
        }
        private void frmYoneticiler_Load(object sender, EventArgs e)
        {
            //  GridiDoldur();
                Doldur();
            btnVazgec_Click(null, null);
            sorumluOlduguDairelerDoldur();
        }
        private frmYoneticiler depo;
        public frmYoneticiler Bilgi
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
            yonetici_adiTextBox.Focus();
        }
       
        private void AlanBosalt()
        {
            yonetici_adiTextBox.Text = "";
            yonetici_soyadiTextBox.Text = "";
            yonetici_telefonTextBox.Text = "";
            yonetici_telefon2TextBox.Text = "";
            yonetici_emailTextBox.Text = "";
            yonetici_sifresiTextBox.Text = "";
            yonetici_aciklamaTextBox.Text = "";
         

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            AlanEnabled(false);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void gcYoneticiler_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
           
        }

        private void yonetici_idTextBox_TextChanged(object sender, EventArgs e)
        {
            sorumluOlduguDairelerDoldur();
        }
    }
}