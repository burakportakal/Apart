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
    public class tbl_Kiralar : ModelBase
    {
        private const string PARM_KIRA_ID = "@kira_id";
        private const string PARM_DAIRE_NO = "@daire_no";
        private const string PARM_KIRA_DONEMI = "@kira_donemi";
        private const string PARM_KIRA_ODEME_TARIHI = "@kira_odeme_tarihi";
        private const string PARM_KIRA_ACIKLAMA = "@kira_aciklama";
        private const string PARM_KIRA_ODENEN_TUTAR = "@kira_odenen_tutar";
        private const string PARM_KIRA_DURUMU = "@kira_durumu";
        public tbl_Kiralar()
        {
            SQLHelper.BilisimLibraryDbConnectionString = "server =.; Initial Catalog = AYS; Integrated Security = SSPI";
        }
        private int kira_id;
        public int Kira_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return kira_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { kira_id = value; }
        }
        private int daire_no;
        public int Daire_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_no = value; }
        }
        private string kira_donemi;
        public string Kira_donemi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return kira_donemi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { kira_donemi = value; }
        }
        private DateTime kira_odeme_tarihi;
        public DateTime Kira_odeme_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return kira_odeme_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { kira_odeme_tarihi = value; }
        }
        private string kira_aciklama;
        public string Kira_aciklama
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return kira_aciklama; }
            [System.Diagnostics.DebuggerStepThrough]
            set { kira_aciklama = value; }
        }
        private float kira_odenen_tutar;
        public float Kira_odenen_tutar
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return kira_odenen_tutar; }
            [System.Diagnostics.DebuggerStepThrough]
            set { kira_odenen_tutar = value; }
        }
        private Boolean kira_durumu;
        public Boolean Kira_durumu
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return kira_durumu; }
            [System.Diagnostics.DebuggerStepThrough]
            set { kira_durumu = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.kira_id = GetInt32(reader, i++).Value;
            this.daire_no = GetInt32(reader, i++).Value;
            this.kira_donemi = GetString(reader, i++);
            this.kira_odeme_tarihi = GetDateTime(reader, i++).Value;
            this.kira_aciklama = GetString(reader, i++);
            this.kira_odenen_tutar = (float)GetDouble(reader, i++).Value;
            this.kira_durumu = GetBoolean(reader, i++).Value;
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                        kira_id ,
                                        daire_no ,
                                        kira_donemi ,
                                        kira_odeme_tarihi ,
                                        kira_aciklama ,
                                        kira_odenen_tutar ,
                                        kira_durumu  FROM tbl_Kiralar WITH (NOLOCK) WHERE kira_id = " + PARM_KIRA_ID;
        public tbl_Kiralar FindById(int kira_id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_KIRA_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = kira_id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_Kiralar bilgi = new tbl_Kiralar();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", kira_id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                    kira_id ,
                                    daire_no ,
                                    kira_donemi ,
                                    kira_odeme_tarihi ,
                                    kira_aciklama ,
                                    kira_odenen_tutar ,
                                    kira_durumu  FROM tbl_Kiralar WITH (NOLOCK) ";
        public ModelCollection<tbl_Kiralar> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_Kiralar> liste = new ModelCollection<tbl_Kiralar>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_Kiralar( 
                  daire_no ,
                  kira_donemi ,
                  kira_odeme_tarihi ,
                  kira_aciklama ,
                  kira_odenen_tutar ,
                  kira_durumu ) VALUES (" + PARM_DAIRE_NO + @"," +
                          PARM_KIRA_DONEMI + @"," +
                          PARM_KIRA_ODEME_TARIHI + @"," +
                          PARM_KIRA_ACIKLAMA + @"," +
                          PARM_KIRA_ODENEN_TUTAR + @"," +
                          PARM_KIRA_DURUMU + @" ) SET  " + PARM_KIRA_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_Kiralar bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_KIRA_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_KIRA_DONEMI,SqlDbType.VarChar,50),
                        new SqlParameter(PARM_KIRA_ODEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_KIRA_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_KIRA_ODENEN_TUTAR,SqlDbType.Float,8),
                        new SqlParameter(PARM_KIRA_DURUMU,SqlDbType.Bit,1),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.daire_no;
            parms[index++].Value = bilgi.kira_donemi;
            parms[index++].Value = bilgi.kira_odeme_tarihi;
            parms[index++].Value = bilgi.kira_aciklama;
            parms[index++].Value = bilgi.kira_odenen_tutar;
            parms[index++].Value = bilgi.kira_durumu;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_Kiralar SET  
                  daire_no = " + PARM_DAIRE_NO + @", 
                  kira_donemi = " + PARM_KIRA_DONEMI + @", 
                  kira_odeme_tarihi = " + PARM_KIRA_ODEME_TARIHI + @", 
                  kira_aciklama = " + PARM_KIRA_ACIKLAMA + @", 
                  kira_odenen_tutar = " + PARM_KIRA_ODENEN_TUTAR + @", 
                  kira_durumu = " + PARM_KIRA_DURUMU + @" WHERE kira_id = " + PARM_KIRA_ID;
        public tbl_Kiralar Guncelle(tbl_Kiralar bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_KIRA_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_KIRA_DONEMI,SqlDbType.VarChar,50),
                        new SqlParameter(PARM_KIRA_ODEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_KIRA_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_KIRA_ODENEN_TUTAR,SqlDbType.Float,8),
                        new SqlParameter(PARM_KIRA_DURUMU,SqlDbType.Bit,1),
};
            int index = 0;
            parms[index++].Value = bilgi.kira_id;
            parms[index++].Value = bilgi.daire_no;
            parms[index++].Value = bilgi.kira_donemi;
            parms[index++].Value = bilgi.kira_odeme_tarihi;
            parms[index++].Value = bilgi.kira_aciklama;
            parms[index++].Value = bilgi.kira_odenen_tutar;
            parms[index++].Value = bilgi.kira_durumu;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_Kiralar WHERE kira_id=" + PARM_KIRA_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_KIRA_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }
        public DataSet spKiraSorgula(string procName)
        {
            SqlConnection cnn = new SqlConnection(SQLHelper.BilisimLibraryDbConnectionString);
            SqlCommand cmd = new SqlCommand(procName, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            sda.Fill(dt, "tbl_Kira");
            cnn.Close();
            return dt;
        }
    }
}
