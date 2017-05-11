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
    public partial class frmSikayet : DevExpress.XtraEditors.XtraForm
    {
        Dictionary<string, Sikayet> Sikayet;
        public frmSikayet(Dictionary<string, Sikayet> sikayet)
        {
            this.Sikayet = sikayet;
            InitializeComponent();
        }

        private void frmSikayet_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Sikayet Eden");
            table.Columns.Add("Daire No");
            table.Columns.Add("Şikayeti");
            table.Columns.Add("Tarih");
            string apartAdi;
            string isim;
            string daire;
            string telefon;

            foreach (var item in Sikayet)
            {
                apartAdi = item.Value.Apart_Adi;
                isim = item.Value.Name;
                daire = item.Value.Daire;
                telefon = item.Value.Telefon;
                foreach (var sikayet in item.Value.Sikayetler)
                {
                    DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    DateTime date = start.AddMilliseconds(sikayet.Value.Tarih).ToLocalTime();
                    table.Rows.Add(isim,daire,sikayet.Value.Sikayet,date.ToString());
                }
            }
            
            gridControl1.DataSource = table;
            gridView1.Columns["Tarih"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;


        }
    }
}