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
    public class tbl_GelirTuru : ModelBase
    {
        private const string PARM_GELIR_TURU_ID = "@gelir_turu_id";
        private const string PARM_GELIR_ADI = "@gelir_adi";
        private int gelir_turu_id;
        public tbl_GelirTuru()
        {
            SQLHelper.BilisimLibraryDbConnectionString = "server=.; Initial Catalog=AYS;Integrated Security=SSPI";
        }
        public int Gelir_turu_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gelir_turu_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gelir_turu_id = value; }
        }
        private string gelir_adi;
        public string Gelir_adi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gelir_adi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gelir_adi = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.gelir_turu_id = GetInt32(reader, i++).Value;
            this.gelir_adi = GetString(reader, i++);
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                                gelir_turu_id ,
                                                gelir_adi  FROM tbl_GelirTuru WITH (NOLOCK) WHERE gelir_turu_id = " + PARM_GELIR_TURU_ID;
        public tbl_GelirTuru FindById(int gelir_turu_id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_GELIR_TURU_ID, SqlDbType.Int, 4),};
            parms[0].Value = gelir_turu_id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_GelirTuru bilgi = new tbl_GelirTuru();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", gelir_turu_id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                            gelir_turu_id ,
                                            gelir_adi  FROM tbl_GelirTuru WITH (NOLOCK) ";
        public ModelCollection<tbl_GelirTuru> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_GelirTuru> liste = new ModelCollection<tbl_GelirTuru>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_GelirTuru( 
                  gelir_adi ) VALUES (" + PARM_GELIR_ADI + @" ) SET  " + PARM_GELIR_TURU_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_GelirTuru bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_GELIR_TURU_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GELIR_ADI,SqlDbType.NVarChar,100),};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.gelir_adi;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_GelirTuru SET  
                  gelir_adi = " + PARM_GELIR_ADI + @" WHERE gelir_turu_id = " + PARM_GELIR_TURU_ID;
        public tbl_GelirTuru Guncelle(tbl_GelirTuru bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_GELIR_TURU_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GELIR_ADI,SqlDbType.NVarChar,100),};
            int index = 0;
            parms[index++].Value = bilgi.gelir_turu_id;
            parms[index++].Value = bilgi.gelir_adi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_GelirTuru WHERE gelir_turu_id=" + PARM_GELIR_TURU_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_GELIR_TURU_ID,SqlDbType.Int,4),};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }
    }
}
