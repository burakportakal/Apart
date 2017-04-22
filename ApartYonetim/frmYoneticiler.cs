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

        private void tbl_YoneticilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_YoneticilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aYSDataSet);

        }

        private void frmYoneticiler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aYSDataSet.tbl_YoneticiBina' table. You can move, or remove it, as needed.
            this.tbl_YoneticiBinaTableAdapter.Fill(this.aYSDataSet.tbl_YoneticiBina);
            // TODO: This line of code loads data into the 'aYSDataSet.tbl_Yoneticiler' table. You can move, or remove it, as needed.
            this.tbl_YoneticilerTableAdapter.Fill(this.aYSDataSet.tbl_Yoneticiler);

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
            yonetici_idTextBox.Text = "0";

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            AlanEnabled(false);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}