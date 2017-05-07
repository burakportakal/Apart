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
        bool yeniKayit = false;
        tbl_FaturaTuru bilgi= new tbl_FaturaTuru();
        public tbl_FaturaTuru Bilgi
        {
            get { return bilgi; }
            set
            {
                if (value != null)
                {
                    bilgi = value;
                    this.tbl_FaturaTuruBindingSource.DataSource = this.bilgi;
                }
            }
        }

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
            GridiDoldur();
            AlanEnabled(false);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            AlanEnabled(true);
            fatura_adiTextEdit.Text = "";
            yeniKayit = true;
           
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
            yeniKayit = false;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            AlanEnabled(false);
            yeniKayit = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (yeniKayit)
            {
                tbl_FaturaTuru faturaTuru = new tbl_FaturaTuru();
                faturaTuru.Fatura_adi = fatura_adiTextEdit.Text;
                faturaTuru.YeniKaydet(faturaTuru);
                yeniKayit = false;
            }
            else
            {

                tbl_FaturaTuru faturaTuru = new tbl_FaturaTuru();
                bilgi.Fatura_adi = fatura_adiTextEdit.Text;
                faturaTuru.Guncelle(this.bilgi);
                yeniKayit = false;
            }
            GridiDoldur();
            AlanEnabled(false);
        }
        private void GridiDoldur()
        {
            tbl_FaturaTuru faturaTuru = new tbl_FaturaTuru();
            gcFaturaTuru.DataSource = faturaTuru.Listele().ToDataTable();
            
        }

        private void gvFaturaTuru_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvFaturaTuru.FocusedRowHandle < 0)
            {
                return;
            }
            DataRow dr = gvFaturaTuru.GetDataRow(gvFaturaTuru.FocusedRowHandle);
            tbl_FaturaTuru liste = new tbl_FaturaTuru();
            this.Bilgi = liste.FindById(Convert.ToInt32(dr["fatura_turu_id"]));
        }
    }
}