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
    public partial class frmMusteriEkleme : DevExpress.XtraEditors.XtraForm
    {
        public frmMusteriEkleme()
        {
            InitializeComponent();
        }

        private void tbl_MusterilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_MusterilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aYSDataSet);

        }

        private void frmMusteriEkleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aYSDataSet.tbl_Musteriler' table. You can move, or remove it, as needed.
            this.tbl_MusterilerTableAdapter.Fill(this.aYSDataSet.tbl_Musteriler);

        }
    }
}