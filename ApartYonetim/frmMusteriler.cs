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
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aYSDataSet.tbl_GelirTuru' table. You can move, or remove it, as needed.
            this.tbl_GelirTuruTableAdapter.Fill(this.aYSDataSet.tbl_GelirTuru);
            // TODO: This line of code loads data into the 'aYSDataSet.tbl_Musteriler' table. You can move, or remove it, as needed.
            this.tbl_MusterilerTableAdapter.Fill(this.aYSDataSet.tbl_Musteriler);
            //griddoldur();

        }

        void griddoldur()
        {
            con = new SqlConnection("server=.; Initial Catalog=AYS;Integrated Security=SSPI");
            da = new SqlDataAdapter("SELECT TOP 1000 "+
      "[daire_no] as 'Daire No'" +
      ",[kira_odemeTarihi] as 'Ödeme Tarihi'" +
      ",[kira_durumu] as 'Kira Durumu'" +
      "FROM[AYS].[dbo].[tbl_Kira]", con);
            ds = new DataSet();
            da.Fill(ds, "tbl_Kira");
            ds.Tables[0].Columns[0].ColumnName = ds.Tables[0].Columns[0].ColumnName.ToString().Replace('_',' ').ToUpper();
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                ds.Tables[0].Columns[i].ColumnName = ToTitleCase( ds.Tables[0].Columns[i].ColumnName.Replace('_',' '));
            }
            gridControl1.DataSource = ds.Tables["tbl_Kira"];
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

            gridView1.ClearSelection();
   
        }

        private void tbl_MusterilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_MusterilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aYSDataSet);

        }
    }
}

       



