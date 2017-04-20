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
            griddoldur();

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
            con.Open();
            da.Fill(ds, "tbl_Kira");
            gridControl1.DataSource = ds.Tables["tbl_Kira"];
            con.Close();
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



            //if (e.RowHandle >= 0)
            //{
            //    string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Daire No"]);
            //    if (category == "16")
            //    {
            //        e.Appearance.BackColor = Color.Yellow;
            //        e.Appearance.BackColor2 = Color.SeaShell;
            //    }
            //}

        }
    }
}

        //private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        //{
        //    GridView View = sender as GridView;
        //    if (e.RowHandle >= 0)
        //    {
        //        if (View.GetRowCellDisplayText(e.RowHandle, View.Columns["[musteri_adiSoyadi]"]) != "")
        //        {
        //            //int category = Convert.ToInt32(View.GetRowCellDisplayText(e.RowHandle, View.Columns["PersonelId"]));

        //            {

        //                e.Appearance.BackColor = Color.Salmon;
        //                e.Appearance.BackColor2 = Color.SeaShell;
        //            }
        //        }
        //        else
        //        {
        //            e.Appearance.BackColor = Color.WhiteSmoke;
        //            e.Appearance.BackColor2 = Color.Cyan;
        //        }

        //    }

        //}



        //private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        //{
        //    GridView View = sender as GridView;
        //    if (e.RowHandle >= 0)
        //    {
        //        string okunma = View.GetRowCellDisplayText(e.RowHandle, View.Columns[0]);
        //        if (okunma == "Bos")
        //        {
        //            e.Appearance.BackColor = Color.Red;

        //        }
        //        else
        //        {
        //            e.Appearance.BackColor = Color.Purple;

        //        }

        //    }
        //}

       



