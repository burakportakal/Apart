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
    public class tbl_GiderTuru : ModelBase
    {
        private const string PARM_GIDER_TURU_ID = "@gider_turu_id";
        private const string PARM_GIDER_ADI = "@gider_adi";
        public tbl_GiderTuru()
        {
            SQLHelper.BilisimLibraryDbConnectionString = "server =.; Initial Catalog = AYS; Integrated Security = SSPI";
        }
        private int gider_turu_id;
        public int Gider_turu_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gider_turu_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gider_turu_id = value; }
        }
        private string gider_adi;
        public string Gider_adi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gider_adi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gider_adi = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.gider_turu_id = GetInt32(reader, i++).Value;
            this.gider_adi = GetString(reader, i++);
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                    gider_turu_id ,
                                    gider_adi  FROM tbl_GiderTuru WITH (NOLOCK) WHERE gider_turu_id = " + PARM_GIDER_TURU_ID;
        public tbl_GiderTuru FindById(int gider_turu_id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_GIDER_TURU_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = gider_turu_id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_GiderTuru bilgi = new tbl_GiderTuru();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", gider_turu_id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                    gider_turu_id ,
                                    gider_adi  FROM tbl_GiderTuru WITH (NOLOCK) ";
        public ModelCollection<tbl_GiderTuru> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_GiderTuru> liste = new ModelCollection<tbl_GiderTuru>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_GiderTuru( 
                  gider_adi ) VALUES (" + PARM_GIDER_ADI + @" ) SET  " + PARM_GIDER_TURU_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_GiderTuru bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_GIDER_TURU_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GIDER_ADI,SqlDbType.NVarChar,100),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.gider_adi;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_GiderTuru SET  
                  gider_adi = " + PARM_GIDER_ADI + @" WHERE gider_turu_id = " + PARM_GIDER_TURU_ID;
        public tbl_GiderTuru Guncelle(tbl_GiderTuru bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_GIDER_TURU_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GIDER_ADI,SqlDbType.NVarChar,100),
};
            int index = 0;
            parms[index++].Value = bilgi.gider_turu_id;
            parms[index++].Value = bilgi.gider_adi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_GiderTuru WHERE gider_turu_id=" + PARM_GIDER_TURU_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_GIDER_TURU_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }
    }
}
