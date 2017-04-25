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
    public class tbl_Yoneticiler : ModelBase
    {
        private const string PARM_YONETICI_ID = "@yonetici_id";
        private const string PARM_YONETICI_ADI = "@yonetici_adi";
        private const string PARM_YONETICI_SOYADI = "@yonetici_soyadi";
        private const string PARM_YONETICI_TELEFON = "@yonetici_telefon";
        private const string PARM_YONETICI_TELEFON2 = "@yonetici_telefon2";
        private const string PARM_YONETICI_EMAIL = "@yonetici_email";
        private const string PARM_YONETICI_ACIKLAMA = "@yonetici_aciklama";
        private const string PARM_YONETICI_SIFRESI = "@yonetici_sifresi";
        public tbl_Yoneticiler()
        {
             SQLHelper.BilisimLibraryDbConnectionString = "server =.; Initial Catalog = AYS; Integrated Security = SSPI";
           /* SQLHelper.BilisimLibraryDbConnectionString = "server =192.168.1.36; Initial Catalog = AYS; User id=sa; Password = sqlpass7.;";*/
        }
        private int yonetici_id;
        public int Yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { yonetici_id = value; }
        }
        private string yonetici_adi;
        public string Yonetici_adi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return yonetici_adi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { yonetici_adi = value; }
        }
        private string yonetici_soyadi;
        public string Yonetici_soyadi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return yonetici_soyadi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { yonetici_soyadi = value; }
        }
        private string yonetici_telefon;
        public string Yonetici_telefon
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return yonetici_telefon; }
            [System.Diagnostics.DebuggerStepThrough]
            set { yonetici_telefon = value; }
        }
        private string yonetici_telefon2;
        public string Yonetici_telefon2
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return yonetici_telefon2; }
            [System.Diagnostics.DebuggerStepThrough]
            set { yonetici_telefon2 = value; }
        }
        private string yonetici_email;
        public string Yonetici_email
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return yonetici_email; }
            [System.Diagnostics.DebuggerStepThrough]
            set { yonetici_email = value; }
        }
        private string yonetici_aciklama;
        public string Yonetici_aciklama
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return yonetici_aciklama; }
            [System.Diagnostics.DebuggerStepThrough]
            set { yonetici_aciklama = value; }
        }
        private string yonetici_sifresi;
        public string Yonetici_sifresi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return yonetici_sifresi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { yonetici_sifresi = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.yonetici_id = GetInt32(reader, i++).Value;
            this.yonetici_adi = GetString(reader, i++);
            this.yonetici_soyadi = GetString(reader, i++);
            this.yonetici_telefon = GetString(reader, i++);
            this.yonetici_telefon2 = GetString(reader, i++);
            this.yonetici_email = GetString(reader, i++);
            this.yonetici_aciklama = GetString(reader, i++);
            this.yonetici_sifresi = GetString(reader, i++);
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                        yonetici_id ,
                                        yonetici_adi ,
                                        yonetici_soyadi ,
                                        yonetici_telefon ,
                                        yonetici_telefon2 ,
                                        yonetici_email ,
                                        yonetici_aciklama ,
                                        yonetici_sifresi  FROM tbl_Yoneticiler WITH (NOLOCK) WHERE yonetici_id = " + PARM_YONETICI_ID;
        public tbl_Yoneticiler FindById(int yonetici_id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_YONETICI_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = yonetici_id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_Yoneticiler bilgi = new tbl_Yoneticiler();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", yonetici_id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                    yonetici_id ,
                                    yonetici_adi ,
                                    yonetici_soyadi ,
                                    yonetici_telefon ,
                                    yonetici_telefon2 ,
                                    yonetici_email ,
                                    yonetici_aciklama ,
                                    yonetici_sifresi  FROM tbl_Yoneticiler WITH (NOLOCK) ";
        public ModelCollection<tbl_Yoneticiler> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_Yoneticiler> liste = new ModelCollection<tbl_Yoneticiler>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_Yoneticiler( 
                  yonetici_adi ,
                  yonetici_soyadi ,
                  yonetici_telefon ,
                  yonetici_telefon2 ,
                  yonetici_email ,
                  yonetici_aciklama ,
                  yonetici_sifresi ) VALUES (" + PARM_YONETICI_ADI + @"," +
                          PARM_YONETICI_SOYADI + @"," +
                          PARM_YONETICI_TELEFON + @"," +
                          PARM_YONETICI_TELEFON2 + @"," +
                          PARM_YONETICI_EMAIL + @"," +
                          PARM_YONETICI_ACIKLAMA + @"," +
                          PARM_YONETICI_SIFRESI + @" ) SET  " + PARM_YONETICI_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_Yoneticiler bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_YONETICI_ADI,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_YONETICI_SOYADI,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_YONETICI_TELEFON,SqlDbType.VarChar,11),
                        new SqlParameter(PARM_YONETICI_TELEFON2,SqlDbType.VarChar,11),
                        new SqlParameter(PARM_YONETICI_EMAIL,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_YONETICI_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_YONETICI_SIFRESI,SqlDbType.NVarChar,24),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.yonetici_adi;
            parms[index++].Value = bilgi.yonetici_soyadi;
            parms[index++].Value = bilgi.yonetici_telefon;
            parms[index++].Value = bilgi.yonetici_telefon2;
            parms[index++].Value = bilgi.yonetici_email;
            parms[index++].Value = bilgi.yonetici_aciklama;
            parms[index++].Value = bilgi.yonetici_sifresi;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_Yoneticiler SET  
                  yonetici_adi = " + PARM_YONETICI_ADI + @", 
                  yonetici_soyadi = " + PARM_YONETICI_SOYADI + @", 
                  yonetici_telefon = " + PARM_YONETICI_TELEFON + @", 
                  yonetici_telefon2 = " + PARM_YONETICI_TELEFON2 + @", 
                  yonetici_email = " + PARM_YONETICI_EMAIL + @", 
                  yonetici_aciklama = " + PARM_YONETICI_ACIKLAMA + @", 
                  yonetici_sifresi = " + PARM_YONETICI_SIFRESI + @" WHERE yonetici_id = " + PARM_YONETICI_ID;
        public tbl_Yoneticiler Guncelle(tbl_Yoneticiler bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_YONETICI_ADI,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_YONETICI_SOYADI,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_YONETICI_TELEFON,SqlDbType.VarChar,11),
                        new SqlParameter(PARM_YONETICI_TELEFON2,SqlDbType.VarChar,11),
                        new SqlParameter(PARM_YONETICI_EMAIL,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_YONETICI_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_YONETICI_SIFRESI,SqlDbType.NVarChar,24),
};
            int index = 0;
            parms[index++].Value = bilgi.yonetici_id;
            parms[index++].Value = bilgi.yonetici_adi;
            parms[index++].Value = bilgi.yonetici_soyadi;
            parms[index++].Value = bilgi.yonetici_telefon;
            parms[index++].Value = bilgi.yonetici_telefon2;
            parms[index++].Value = bilgi.yonetici_email;
            parms[index++].Value = bilgi.yonetici_aciklama;
            parms[index++].Value = bilgi.yonetici_sifresi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_Yoneticiler WHERE yonetici_id=" + PARM_YONETICI_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_YONETICI_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }
    }
}
