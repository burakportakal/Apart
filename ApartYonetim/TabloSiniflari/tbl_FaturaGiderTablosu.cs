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
    public class tbl_FaturaGiderTablosu : ModelBase
    {
        private const string PARM_ID = "@id";
        private const string PARM_FATURA_ABONE_NO = "@fatura_abone_no";
        private const string PARM_FATURA_TUTARI = "@fatura_tutari";
        public tbl_FaturaGiderTablosu()
        {
            SQLHelper.BilisimLibraryDbConnectionString = "server =.; Initial Catalog = AYS; Integrated Security = SSPI";
        }
        private int id;
        public int Id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { id = value; }
        }
        private string fatura_abone_no;
        public string Fatura_abone_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return fatura_abone_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { fatura_abone_no = value; }
        }
        private float fatura_tutari;
        public float Fatura_tutari
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return fatura_tutari; }
            [System.Diagnostics.DebuggerStepThrough]
            set { fatura_tutari = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.id = GetInt32(reader, i++).Value;
            this.fatura_abone_no = GetString(reader, i++);
            this.fatura_tutari = (float)GetDouble(reader, i++).Value;
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                        id ,
                                        fatura_abone_no ,
                                        fatura_tutari  FROM tbl_FaturaGiderTablosu WITH (NOLOCK) WHERE id = " + PARM_ID;
        public tbl_FaturaGiderTablosu FindById(int id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_FaturaGiderTablosu bilgi = new tbl_FaturaGiderTablosu();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                        id ,
                                        fatura_abone_no ,
                                        fatura_tutari  FROM tbl_FaturaGiderTablosu WITH (NOLOCK) ";
        public ModelCollection<tbl_FaturaGiderTablosu> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_FaturaGiderTablosu> liste = new ModelCollection<tbl_FaturaGiderTablosu>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_FaturaGiderTablosu( 
                  fatura_abone_no ,
                  fatura_tutari ) VALUES (" + PARM_FATURA_ABONE_NO + @"," +
                          PARM_FATURA_TUTARI + @" ) SET  " + PARM_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_FaturaGiderTablosu bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_FATURA_ABONE_NO,SqlDbType.VarChar,50),
                        new SqlParameter(PARM_FATURA_TUTARI,SqlDbType.Float,8),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.fatura_abone_no;
            parms[index++].Value = bilgi.fatura_tutari;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_FaturaGiderTablosu SET  
                  fatura_abone_no = " + PARM_FATURA_ABONE_NO + @", 
                  fatura_tutari = " + PARM_FATURA_TUTARI + @" WHERE id = " + PARM_ID;
        public tbl_FaturaGiderTablosu Guncelle(tbl_FaturaGiderTablosu bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_FATURA_ABONE_NO,SqlDbType.VarChar,50),
                        new SqlParameter(PARM_FATURA_TUTARI,SqlDbType.Float,8),
};
            int index = 0;
            parms[index++].Value = bilgi.id;
            parms[index++].Value = bilgi.fatura_abone_no;
            parms[index++].Value = bilgi.fatura_tutari;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_FaturaGiderTablosu WHERE id=" + PARM_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }

        public bool faturaDonemiSorgusu(string aboneNo,string faturaDonemi)
        {
            SqlConnection cnn = new SqlConnection(SQLHelper.BilisimLibraryDbConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select id from tbl_FaturaGiderTablosu where fatura_abone_no='"+aboneNo+"' and fatura_donemi='"+faturaDonemi+"'",cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 0)
                return true;
            else
                return false;
        }
        public int spFaturaGiderEkle(string aboneNo,string faturaDonemi,float tutar)
        {
            SqlConnection cnn = new SqlConnection(SQLHelper.BilisimLibraryDbConnectionString);
            SqlCommand cmd = new SqlCommand("spFaturaGiderEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@aboneNo", aboneNo);
            cmd.Parameters.AddWithValue("@faturaDonemi", faturaDonemi);
            cmd.Parameters.AddWithValue("@tutar", tutar);
            cnn.Open();
            int sonuc =cmd.ExecuteNonQuery();
            cnn.Close();
            return sonuc;
        }
    }
}
