using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using BilisimLibrary.Model;
using BilisimLibrary.Exceptions;
namespace ApartYonetim
{
    public class tbl_FaturaAboneNo : ModelBase
    {
        private const string PARM_FATURA_ID = "@fatura_id";
        private const string PARM_FATURA_ABONE_NO = "@fatura_abone_no";
        private const string PARM_BINA_ID = "@bina_id";
        private const string PARM_FATURA_TURU_ID = "@fatura_turu_id";
        public tbl_FaturaAboneNo()
        {
            SQLHelper.BilisimLibraryDbConnectionString = "server =.; Initial Catalog = AYS; Integrated Security = SSPI";
        }
        private int fatura_id;
        public int Fatura_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return fatura_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { fatura_id = value; }
        }
        private string fatura_abone_no;
        public string Fatura_abone_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return fatura_abone_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { fatura_abone_no = value; }
        }
        private int bina_id;
        public int Bina_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_id = value; }
        }
        private int fatura_turu_id;
        public int Fatura_turu_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return fatura_turu_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { fatura_turu_id = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.fatura_id = GetInt32(reader, i++).Value;
            this.fatura_abone_no = GetString(reader, i++);
            this.bina_id = GetInt32(reader, i++).Value;
            this.fatura_turu_id = GetInt32(reader, i++).Value;
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                                fatura_id ,
                                                fatura_abone_no ,
                                                bina_id ,
                                                fatura_turu_id  FROM tbl_FaturaAboneNo WITH (NOLOCK) WHERE fatura_id = " + PARM_FATURA_ID;
        public tbl_FaturaAboneNo FindById(int fatura_id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_FATURA_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = fatura_id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_FaturaAboneNo bilgi = new tbl_FaturaAboneNo();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", fatura_id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                                fatura_id ,
                                                fatura_abone_no ,
                                                bina_id ,
                                                fatura_turu_id  FROM tbl_FaturaAboneNo WITH (NOLOCK) ";
        public ModelCollection<tbl_FaturaAboneNo> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_FaturaAboneNo> liste = new ModelCollection<tbl_FaturaAboneNo>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_FaturaAboneNo( 
                  fatura_abone_no ,
                  bina_id ,
                  fatura_turu_id ) VALUES (" + PARM_FATURA_ABONE_NO + @"," +
                          PARM_BINA_ID + @"," +
                          PARM_FATURA_TURU_ID + @" ) SET  " + PARM_FATURA_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_FaturaAboneNo bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_FATURA_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_FATURA_ABONE_NO,SqlDbType.VarChar,50),
                        new SqlParameter(PARM_BINA_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_FATURA_TURU_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.fatura_abone_no;
            parms[index++].Value = bilgi.bina_id;
            parms[index++].Value = bilgi.fatura_turu_id;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_FaturaAboneNo SET  
                  fatura_abone_no = " + PARM_FATURA_ABONE_NO + @", 
                  bina_id = " + PARM_BINA_ID + @", 
                  fatura_turu_id = " + PARM_FATURA_TURU_ID + @" WHERE fatura_id = " + PARM_FATURA_ID;
        public tbl_FaturaAboneNo Guncelle(tbl_FaturaAboneNo bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_FATURA_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_FATURA_ABONE_NO,SqlDbType.VarChar,50),
                        new SqlParameter(PARM_BINA_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_FATURA_TURU_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi.fatura_id;
            parms[index++].Value = bilgi.fatura_abone_no;
            parms[index++].Value = bilgi.bina_id;
            parms[index++].Value = bilgi.fatura_turu_id;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_FaturaAboneNo WHERE fatura_id=" + PARM_FATURA_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_FATURA_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }
        public int spFaturaEkle(string faturaTuru, string binaAdi, string aboneNo,int ortak1,int ortak2)
            {
            SqlConnection cnn = new SqlConnection(SQLHelper.BilisimLibraryDbConnectionString);
            SqlCommand cmd = new SqlCommand("spFaturaEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@faturaTuru", faturaTuru);
            cmd.Parameters.AddWithValue("@binaAdi", binaAdi);
            cmd.Parameters.AddWithValue("@aboneNo", aboneNo);
            cmd.Parameters.AddWithValue("@ortak1", ortak1);
            cmd.Parameters.AddWithValue("@ortak2", ortak2);
            SqlParameter retval = cmd.Parameters.Add("@sonuc", SqlDbType.Int);
            retval.Direction = ParameterDirection.Output;
            cnn.Open();
            cmd.ExecuteNonQuery();
            int sonuc = (int)cmd.Parameters["@sonuc"].Value;
            cnn.Close();
            return sonuc;
        }
        public DataSet spFatura()
        {
            SqlConnection cnn = new SqlConnection(SQLHelper.BilisimLibraryDbConnectionString);
            SqlCommand cmd = new SqlCommand("spFatura", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            sda.Fill(dt, "tbl_Fatura");
            cnn.Close();
            return dt;
        }
        public int spFaturaGuncelle(int faturaId,int ortak1Id,int ortak2Id,string faturaTuru, string binaAdi, string aboneNo, int ortak1, int ortak2)
        {
            SqlConnection cnn = new SqlConnection(SQLHelper.BilisimLibraryDbConnectionString);
            SqlCommand cmd = new SqlCommand("spFaturaGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@faturaId", faturaId);
            cmd.Parameters.AddWithValue("@ortak1Id", ortak1Id);
            cmd.Parameters.AddWithValue("@ortak2Id", ortak2Id);
            cmd.Parameters.AddWithValue("@faturaTuru", faturaTuru);
            cmd.Parameters.AddWithValue("@binaAdi", binaAdi);
            cmd.Parameters.AddWithValue("@aboneNo", aboneNo);
            cmd.Parameters.AddWithValue("@ortak1", ortak1);
            cmd.Parameters.AddWithValue("@ortak2", ortak2);
            SqlParameter retval = cmd.Parameters.Add("@sonuc", SqlDbType.Int);
            retval.Direction = ParameterDirection.Output;
            cnn.Open();
            cmd.ExecuteNonQuery();
            int sonuc = (int)cmd.Parameters["@sonuc"].Value;
            cnn.Close();
            return sonuc;
        }
        public string[] spBinaAdiFaturaTuru (string apartAdi,string faturaTuru)
        {
            List<string> tempList = new List<string>();
            SqlConnection cnn = new SqlConnection(SQLHelper.BilisimLibraryDbConnectionString);
            SqlCommand cmd = new SqlCommand("spBinaAdiFaturaTuru", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@apartAdi", apartAdi);
            cmd.Parameters.AddWithValue("@faturaTuru", faturaTuru);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                tempList.Add(reader["Abone No"].ToString());
            }
            cnn.Close();
            reader.Close();
            string[] values = new string[tempList.Count];
            values = tempList.ToArray();
            return values;
        }
    }
}
