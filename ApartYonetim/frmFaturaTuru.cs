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
    public partial class frmFaturaTuru : DevExpress.XtraEditors.XtraForm
    {
        public frmFaturaTuru()
        {
            InitializeComponent();
        }

        private void tbl_FaturaTuruBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_FaturaTuruBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aYSDataSet);

        }

        private void frmFaturaTuru_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aYSDataSet.tbl_FaturaTuru' table. You can move, or remove it, as needed.
            this.tbl_FaturaTuruTableAdapter.Fill(this.aYSDataSet.tbl_FaturaTuru);
            AlanEnabled(false);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            AlanEnabled(true);
        }
        private void AlanEnabled(bool islem)
        {
            groupFatura.Enabled = islem;
            btnYeni.Enabled = !islem;
            btnSil.Enabled = !islem;
            btnGuncelle.Enabled = !islem;
            btnVazgec.Enabled = islem;
            btnKaydet.Enabled = islem;
            gcFaturaTuru.Enabled = !islem;


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            AlanEnabled(true);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            AlanEnabled(false);
        }
    }
}