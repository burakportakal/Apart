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

namespace ApartYonetim
{
    public partial class frmYoneticiGirisi : DevExpress.XtraEditors.XtraForm
    {
        public frmYoneticiGirisi()
        {
            InitializeComponent();
        }
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
            if (usercount == 1)
            {
                frmAnaSayfa form = new frmAnaSayfa();
                this.Hide();
                form.Show();
            }
                
            else
                MessageBox.Show("Kullanıcı adı veya parola hatalı.");  // başarısız kullanıcı girişi
        }

        private void frmYoneticiGirisi_Load(object sender, EventArgs e)
        {

          
        }

        private void labelControl4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}