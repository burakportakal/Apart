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
    public class tbl_Gelir : ModelBase
    {
        private const string PARM_GELIR_ID = "@gelir_id";
        private const string PARM_GELIR_TURU_ID = "@gelir_turu_id";
        private const string PARM_GELIR_TUTARI = "@gelir_tutari";
        private const string PARM_GELIR_TARIHI = "@gelir_tarihi";
        private const string PARM_MUSTERI_TC_KIMLIK_NO = "@musteri_tc_kimlik_no";
        private const string PARM_GELIR_ACIKLAMA = "@gelir_aciklama";
        private const string PARM_GELIR_KAYIT_TARIHI = "@gelir_kayit_tarihi";
        private const string PARM_GELIR_KAYIT_EDEN_YONETICI_ID = "@gelir_kayit_eden_yonetici_id";
        private const string PARM_GELIR_DUZENLEME_TARIHI = "@gelir_duzenleme_tarihi";
        private const string PARM_GELIR_KAYIT_DUZENLEYEN_YONETICI_ID = "@gelir_kayit_duzenleyen_yonetici_id";
        public tbl_Gelir()
        {
            SQLHelper.BilisimLibraryDbConnectionString = "server =.; Initial Catalog = AYS; Integrated Security = SSPI";
        }
        private int gelir_id;
        public int Gelir_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gelir_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gelir_id = value; }
        }
        private int gelir_turu_id;
        public int Gelir_turu_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gelir_turu_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gelir_turu_id = value; }
        }
        private float gelir_tutari;
        public float Gelir_tutari
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gelir_tutari; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gelir_tutari = value; }
        }
        private DateTime gelir_tarihi;
        public DateTime Gelir_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gelir_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gelir_tarihi = value; }
        }
        private string musteri_tc_kimlik_no;
        public string Musteri_tc_kimlik_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_tc_kimlik_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_tc_kimlik_no = value; }
        }
        private string gelir_aciklama;
        public string Gelir_aciklama
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gelir_aciklama; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gelir_aciklama = value; }
        }
        private DateTime gelir_kayit_tarihi;
        public DateTime Gelir_kayit_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gelir_kayit_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gelir_kayit_tarihi = value; }
        }
        private int gelir_kayit_eden_yonetici_id;
        public int Gelir_kayit_eden_yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gelir_kayit_eden_yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gelir_kayit_eden_yonetici_id = value; }
        }
        private DateTime gelir_duzenleme_tarihi;
        public DateTime Gelir_duzenleme_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gelir_duzenleme_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gelir_duzenleme_tarihi = value; }
        }
        private int gelir_kayit_duzenleyen_yonetici_id;
        public int Gelir_kayit_duzenleyen_yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gelir_kayit_duzenleyen_yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gelir_kayit_duzenleyen_yonetici_id = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.gelir_id = GetInt32(reader, i++).Value;
            this.gelir_turu_id = GetInt32(reader, i++).Value;
            this.gelir_tutari = (float)GetDouble(reader, i++).Value;
            this.gelir_tarihi = GetDateTime(reader, i++).Value;
            this.musteri_tc_kimlik_no = GetString(reader, i++);
            this.gelir_aciklama = GetString(reader, i++);
            this.gelir_kayit_tarihi = GetDateTime(reader, i++).Value;
            this.gelir_kayit_eden_yonetici_id = GetInt32(reader, i++).Value;
            this.gelir_duzenleme_tarihi = GetDateTime(reader, i++).Value;
            this.gelir_kayit_duzenleyen_yonetici_id = GetInt32(reader, i++).Value;
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                        gelir_id ,
                                        gelir_turu_id ,
                                        gelir_tutari ,
                                        gelir_tarihi ,
                                        musteri_tc_kimlik_no ,
                                        gelir_aciklama ,
                                        gelir_kayit_tarihi ,
                                        gelir_kayit_eden_yonetici_id ,
                                        gelir_duzenleme_tarihi ,
                                        gelir_kayit_duzenleyen_yonetici_id  FROM tbl_Gelir WITH (NOLOCK) WHERE gelir_id = " + PARM_GELIR_ID;
        public tbl_Gelir FindById(int gelir_id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_GELIR_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = gelir_id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_Gelir bilgi = new tbl_Gelir();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", gelir_id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                    gelir_id ,
                                    gelir_turu_id ,
                                    gelir_tutari ,
                                    gelir_tarihi ,
                                    musteri_tc_kimlik_no ,
                                    gelir_aciklama ,
                                    gelir_kayit_tarihi ,
                                    gelir_kayit_eden_yonetici_id ,
                                    gelir_duzenleme_tarihi ,
                                    gelir_kayit_duzenleyen_yonetici_id  FROM tbl_Gelir WITH (NOLOCK) ";
        public ModelCollection<tbl_Gelir> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_Gelir> liste = new ModelCollection<tbl_Gelir>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_Gelir( 
                  gelir_turu_id ,
                  gelir_tutari ,
                  gelir_tarihi ,
                  musteri_tc_kimlik_no ,
                  gelir_aciklama ,
                  gelir_kayit_tarihi ,
                  gelir_kayit_eden_yonetici_id ,
                  gelir_duzenleme_tarihi ,
                  gelir_kayit_duzenleyen_yonetici_id ) VALUES (" + PARM_GELIR_TURU_ID + @"," +
                          PARM_GELIR_TUTARI + @"," +
                          PARM_GELIR_TARIHI + @"," +
                          PARM_MUSTERI_TC_KIMLIK_NO + @"," +
                          PARM_GELIR_ACIKLAMA + @"," +
                          PARM_GELIR_KAYIT_TARIHI + @"," +
                          PARM_GELIR_KAYIT_EDEN_YONETICI_ID + @"," +
                          PARM_GELIR_DUZENLEME_TARIHI + @"," +
                          PARM_GELIR_KAYIT_DUZENLEYEN_YONETICI_ID + @" ) SET  " + PARM_GELIR_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_Gelir bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_GELIR_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GELIR_TURU_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GELIR_TUTARI,SqlDbType.Float,8),
                        new SqlParameter(PARM_GELIR_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_MUSTERI_TC_KIMLIK_NO,SqlDbType.VarChar,11),
                        new SqlParameter(PARM_GELIR_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_GELIR_KAYIT_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_GELIR_KAYIT_EDEN_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GELIR_DUZENLEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_GELIR_KAYIT_DUZENLEYEN_YONETICI_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.gelir_turu_id;
            parms[index++].Value = bilgi.gelir_tutari;
            parms[index++].Value = bilgi.gelir_tarihi;
            parms[index++].Value = bilgi.musteri_tc_kimlik_no;
            parms[index++].Value = bilgi.gelir_aciklama;
            parms[index++].Value = bilgi.gelir_kayit_tarihi;
            parms[index++].Value = bilgi.gelir_kayit_eden_yonetici_id;
            parms[index++].Value = bilgi.gelir_duzenleme_tarihi;
            parms[index++].Value = bilgi.gelir_kayit_duzenleyen_yonetici_id;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_Gelir SET  
                  gelir_turu_id = " + PARM_GELIR_TURU_ID + @", 
                  gelir_tutari = " + PARM_GELIR_TUTARI + @", 
                  gelir_tarihi = " + PARM_GELIR_TARIHI + @", 
                  musteri_tc_kimlik_no = " + PARM_MUSTERI_TC_KIMLIK_NO + @", 
                  gelir_aciklama = " + PARM_GELIR_ACIKLAMA + @", 
                  gelir_kayit_tarihi = " + PARM_GELIR_KAYIT_TARIHI + @", 
                  gelir_kayit_eden_yonetici_id = " + PARM_GELIR_KAYIT_EDEN_YONETICI_ID + @", 
                  gelir_duzenleme_tarihi = " + PARM_GELIR_DUZENLEME_TARIHI + @", 
                  gelir_kayit_duzenleyen_yonetici_id = " + PARM_GELIR_KAYIT_DUZENLEYEN_YONETICI_ID + @" WHERE gelir_id = " + PARM_GELIR_ID;
        public tbl_Gelir Guncelle(tbl_Gelir bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_GELIR_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GELIR_TURU_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GELIR_TUTARI,SqlDbType.Float,8),
                        new SqlParameter(PARM_GELIR_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_MUSTERI_TC_KIMLIK_NO,SqlDbType.VarChar,11),
                        new SqlParameter(PARM_GELIR_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_GELIR_KAYIT_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_GELIR_KAYIT_EDEN_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GELIR_DUZENLEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_GELIR_KAYIT_DUZENLEYEN_YONETICI_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi.gelir_id;
            parms[index++].Value = bilgi.gelir_turu_id;
            parms[index++].Value = bilgi.gelir_tutari;
            parms[index++].Value = bilgi.gelir_tarihi;
            parms[index++].Value = bilgi.musteri_tc_kimlik_no;
            parms[index++].Value = bilgi.gelir_aciklama;
            parms[index++].Value = bilgi.gelir_kayit_tarihi;
            parms[index++].Value = bilgi.gelir_kayit_eden_yonetici_id;
            parms[index++].Value = bilgi.gelir_duzenleme_tarihi;
            parms[index++].Value = bilgi.gelir_kayit_duzenleyen_yonetici_id;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_Gelir WHERE gelir_id=" + PARM_GELIR_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_GELIR_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }
    }
}
