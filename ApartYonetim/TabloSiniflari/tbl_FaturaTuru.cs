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
    public class tbl_FaturaTuru : ModelBase
    {
        private const string PARM_FATURA_TURU_ID = "@fatura_turu_id";
        private const string PARM_FATURA_ADI = "@fatura_adi";
        public tbl_FaturaTuru()
        {
            SQLHelper.BilisimLibraryDbConnectionString = "server =.; Initial Catalog = AYS; Integrated Security = SSPI";
        }
        private int fatura_turu_id;
        public int Fatura_turu_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return fatura_turu_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { fatura_turu_id = value; }
        }
        private string fatura_adi;
        public string Fatura_adi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return fatura_adi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { fatura_adi = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.fatura_turu_id = GetInt32(reader, i++).Value;
            this.fatura_adi = GetString(reader, i++);
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                        fatura_turu_id ,
                                        fatura_adi  FROM tbl_FaturaTuru WITH (NOLOCK) WHERE fatura_turu_id = " + PARM_FATURA_TURU_ID;
        public tbl_FaturaTuru FindById(int fatura_turu_id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_FATURA_TURU_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = fatura_turu_id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_FaturaTuru bilgi = new tbl_FaturaTuru();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", fatura_turu_id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                        fatura_turu_id ,
                                        fatura_adi  FROM tbl_FaturaTuru WITH (NOLOCK) ";
        public ModelCollection<tbl_FaturaTuru> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_FaturaTuru> liste = new ModelCollection<tbl_FaturaTuru>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_FaturaTuru( 
                  fatura_adi ) VALUES (" + PARM_FATURA_ADI + @" ) SET  " + PARM_FATURA_TURU_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_FaturaTuru bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_FATURA_TURU_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_FATURA_ADI,SqlDbType.NVarChar,100),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.fatura_adi;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_FaturaTuru SET  
                  fatura_adi = " + PARM_FATURA_ADI + @" WHERE fatura_turu_id = " + PARM_FATURA_TURU_ID;
        public tbl_FaturaTuru Guncelle(tbl_FaturaTuru bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_FATURA_TURU_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_FATURA_ADI,SqlDbType.NVarChar,100),
};
            int index = 0;
            parms[index++].Value = bilgi.fatura_turu_id;
            parms[index++].Value = bilgi.fatura_adi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_FaturaTuru WHERE fatura_turu_id=" + PARM_FATURA_TURU_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_FATURA_TURU_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }
    }
}
