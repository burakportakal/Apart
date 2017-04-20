using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartYonetim
{
    public abstract class BaseAdapter
    {
        public virtual string primaryKey { get; set; }
        public virtual string tableName { get; set; }

        SqlConnection cnn;
        public BaseAdapter()
        {
            cnn = sqlCon();
        }
        private SqlConnection sqlCon()
        {
            string connetionString = "server=.; Initial Catalog=AYS;Integrated Security=SSPI";
            cnn = new SqlConnection(connetionString);
            return cnn;
        }
        private void openConnection()
        {
            try
            {
                cnn.Open();
            }
            catch (InvalidOperationException)
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                    openConnection();
                }
                else
                    throw new InvalidOperationException("Baglanti Hatası");
            }
        }
        public virtual SqlDataAdapter getById(string id=null)
        {
            SqlDataAdapter da;
            openConnection();
            if (id == null)
            {
                 da = new SqlDataAdapter("select * from "+tableName, cnn);
            }
            else
            {

                 da = new SqlDataAdapter("SELECT TOP 1000 " +
         "[daire_no] as 'Daire No'" +
         ",[kira_odemeTarihi] as 'Ödeme Tarihi'" +
         ",[kira_durumu] as 'Kira Durumu'" +
     "FROM[AYS].[dbo].["+tableName+"] where "+primaryKey+"="+id, cnn);
            }
            return da;

        }
    }
}
