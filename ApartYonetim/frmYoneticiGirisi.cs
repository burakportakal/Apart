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
using BilisimLibrary;

namespace ApartYonetim
{
    public partial class frmYoneticiGirisi : DevExpress.XtraEditors.XtraForm
    {
        public frmYoneticiGirisi()
        {
            InitializeComponent();
            
        }
        // Yonetciler tablosunu diğer nesnelerin ( sınıf veya form sayfaları) de görebilmesi için 
         public static tbl_Yoneticiler yoneticiler;
        private void btnYoneticiGirisi_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.; Initial Catalog=AYS;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_yonetici_girisi"; //Stored Procedure' ümüzün ismi
            cmd.Parameters.Add("@yonetici_adi", SqlDbType.NVarChar, 50).Value = txtYoneticiAdi.Text; //Stored procedure deki parametrelere
            cmd.Parameters.Add("@yonetici_sifresi", SqlDbType.NVarChar, 12).Value = txtYoneticiParola.Text; // textboxlardan değerleri
            cmd.Connection = con;
            con.Open();
            int usercount = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
           
            if (usercount == 0)
                MessageBox.Show("Kullanıcı adı veya parola hatalı.");  // başarısız kullanıcı girişi
            else
            {
                yoneticiler  = new tbl_Yoneticiler().FindById(usercount);
                frmAnaSayfa form = new frmAnaSayfa();
                this.Hide();
                form.Show();
            }
        }

        private void frmYoneticiGirisi_Load(object sender, EventArgs e)
        {
            txtYoneticiParola.Focus();
          
        }

        private void labelControl4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}