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
    public class tbl_OrtakFatura : ModelBase
    {
        private const string PARM_ID = "@id";
        private const string PARM_FATURA_ABONE_NO = "@fatura_abone_no";
        private const string PARM_DAIRE_NO = "@daire_no";
        public tbl_OrtakFatura()
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
        private int daire_no;
        public int Daire_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_no = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.id = GetInt32(reader, i++).Value;
            this.fatura_abone_no = GetString(reader, i++);
            this.daire_no = GetInt32(reader, i++).Value;
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                         id ,
                                         fatura_abone_no ,
                                         daire_no  FROM tbl_OrtakFatura WITH (NOLOCK) WHERE id = " + PARM_ID;
        public tbl_OrtakFatura FindById(int id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_OrtakFatura bilgi = new tbl_OrtakFatura();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", id);
                }
            }
        }
        public tbl_OrtakFatura FindByAboneNoDaireNo(string aboneNo,string daireNo)
        {
            string commanText = "select * from tbl_OrtakFatura where fatura_abone_no='"+aboneNo+"' and daire_no='"+daireNo+"'";
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, commanText, parms))
            {
                if (reader.Read())
                {
                    tbl_OrtakFatura bilgi = new tbl_OrtakFatura();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "FindByAboneNoDaireNo", id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                         id ,
                                         fatura_abone_no ,
                                         daire_no  FROM tbl_OrtakFatura WITH (NOLOCK) ";
        public ModelCollection<tbl_OrtakFatura> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_OrtakFatura> liste = new ModelCollection<tbl_OrtakFatura>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_OrtakFatura( 
                  fatura_abone_no ,
                  daire_no ) VALUES (" + PARM_FATURA_ABONE_NO + @"," +
                          PARM_DAIRE_NO + @" ) SET  " + PARM_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_OrtakFatura bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_FATURA_ABONE_NO,SqlDbType.VarChar,50),
                        new SqlParameter(PARM_DAIRE_NO,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.fatura_abone_no;
            parms[index++].Value = bilgi.daire_no;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_OrtakFatura SET  
                  fatura_abone_no = " + PARM_FATURA_ABONE_NO + @", 
                  daire_no = " + PARM_DAIRE_NO + @" WHERE id = " + PARM_ID;
        public tbl_OrtakFatura Guncelle(tbl_OrtakFatura bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_FATURA_ABONE_NO,SqlDbType.VarChar,50),
                        new SqlParameter(PARM_DAIRE_NO,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi.id;
            parms[index++].Value = bilgi.fatura_abone_no;
            parms[index++].Value = bilgi.daire_no;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_OrtakFatura WHERE id=" + PARM_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }
    }
}
