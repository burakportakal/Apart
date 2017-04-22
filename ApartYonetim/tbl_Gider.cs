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
    public class tbl_Gider : ModelBase
    {
        private const string PARM_GIDER_ID = "@gider_id";
        private const string PARM_GIDER_TURU_ID = "@gider_turu_id";
        private const string PARM_GIDER_TUTARI = "@gider_tutari";
        private const string PARM_GIDER_TARIHI = "@gider_tarihi";
        private const string PARM_DAIRE_NO = "@daire_no";
        private const string PARM_GIDER_ACIKLAMA = "@gider_aciklama";
        private const string PARM_GIDER_KAYIT_TARIHI = "@gider_kayit_tarihi";
        private const string PARM_GIDER_KAYIT_EDEN_YONETICI_ID = "@gider_kayit_eden_yonetici_id";
        private const string PARM_GIDER_DUZENLEME_TARIHI = "@gider_duzenleme_tarihi";
        private const string PARM_GIDER_KAYIT_DUZENLEYEN_YONETICI_ID = "@gider_kayit_duzenleyen_yonetici_id";
        public tbl_Gider()
        {
            SQLHelper.BilisimLibraryDbConnectionString = "server =.; Initial Catalog = AYS; Integrated Security = SSPI";
        }
        private int gider_id;
        public int Gider_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gider_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gider_id = value; }
        }
        private int gider_turu_id;
        public int Gider_turu_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gider_turu_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gider_turu_id = value; }
        }
        private float gider_tutari;
        public float Gider_tutari
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gider_tutari; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gider_tutari = value; }
        }
        private DateTime gider_tarihi;
        public DateTime Gider_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gider_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gider_tarihi = value; }
        }
        private int daire_no;
        public int Daire_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_no = value; }
        }
        private string gider_aciklama;
        public string Gider_aciklama
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gider_aciklama; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gider_aciklama = value; }
        }
        private DateTime gider_kayit_tarihi;
        public DateTime Gider_kayit_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gider_kayit_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gider_kayit_tarihi = value; }
        }
        private int gider_kayit_eden_yonetici_id;
        public int Gider_kayit_eden_yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gider_kayit_eden_yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gider_kayit_eden_yonetici_id = value; }
        }
        private DateTime gider_duzenleme_tarihi;
        public DateTime Gider_duzenleme_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gider_duzenleme_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gider_duzenleme_tarihi = value; }
        }
        private int gider_kayit_duzenleyen_yonetici_id;
        public int Gider_kayit_duzenleyen_yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return gider_kayit_duzenleyen_yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { gider_kayit_duzenleyen_yonetici_id = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.gider_id = GetInt32(reader, i++).Value;
            this.gider_turu_id = GetInt32(reader, i++).Value;
            this.gider_tutari = (float)GetDouble(reader, i++).Value;
            this.gider_tarihi = GetDateTime(reader, i++).Value;
            this.daire_no = GetInt32(reader, i++).Value;
            this.gider_aciklama = GetString(reader, i++);
            this.gider_kayit_tarihi = GetDateTime(reader, i++).Value;
            this.gider_kayit_eden_yonetici_id = GetInt32(reader, i++).Value;
            this.gider_duzenleme_tarihi = GetDateTime(reader, i++).Value;
            this.gider_kayit_duzenleyen_yonetici_id = GetInt32(reader, i++).Value;
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                        gider_id ,
                                        gider_turu_id ,
                                        gider_tutari ,
                                        gider_tarihi ,
                                        daire_no ,
                                        gider_aciklama ,
                                        gider_kayit_tarihi ,
                                        gider_kayit_eden_yonetici_id ,
                                        gider_duzenleme_tarihi ,
                                        gider_kayit_duzenleyen_yonetici_id  FROM tbl_Gider WITH (NOLOCK) WHERE gider_id = " + PARM_GIDER_ID;
        public tbl_Gider FindById(int gider_id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_GIDER_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = gider_id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_Gider bilgi = new tbl_Gider();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", gider_id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                    gider_id ,
                                    gider_turu_id ,
                                    gider_tutari ,
                                    gider_tarihi ,
                                    daire_no ,
                                    gider_aciklama ,
                                    gider_kayit_tarihi ,
                                    gider_kayit_eden_yonetici_id ,
                                    gider_duzenleme_tarihi ,
                                    gider_kayit_duzenleyen_yonetici_id  FROM tbl_Gider WITH (NOLOCK) ";
        public ModelCollection<tbl_Gider> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_Gider> liste = new ModelCollection<tbl_Gider>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_Gider( 
                  gider_turu_id ,
                  gider_tutari ,
                  gider_tarihi ,
                  daire_no ,
                  gider_aciklama ,
                  gider_kayit_tarihi ,
                  gider_kayit_eden_yonetici_id ,
                  gider_duzenleme_tarihi ,
                  gider_kayit_duzenleyen_yonetici_id ) VALUES (" + PARM_GIDER_TURU_ID + @"," +
                          PARM_GIDER_TUTARI + @"," +
                          PARM_GIDER_TARIHI + @"," +
                          PARM_DAIRE_NO + @"," +
                          PARM_GIDER_ACIKLAMA + @"," +
                          PARM_GIDER_KAYIT_TARIHI + @"," +
                          PARM_GIDER_KAYIT_EDEN_YONETICI_ID + @"," +
                          PARM_GIDER_DUZENLEME_TARIHI + @"," +
                          PARM_GIDER_KAYIT_DUZENLEYEN_YONETICI_ID + @" ) SET  " + PARM_GIDER_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_Gider bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_GIDER_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GIDER_TURU_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GIDER_TUTARI,SqlDbType.Float,8),
                        new SqlParameter(PARM_GIDER_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_DAIRE_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_GIDER_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_GIDER_KAYIT_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_GIDER_KAYIT_EDEN_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GIDER_DUZENLEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_GIDER_KAYIT_DUZENLEYEN_YONETICI_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.gider_turu_id;
            parms[index++].Value = bilgi.gider_tutari;
            parms[index++].Value = bilgi.gider_tarihi;
            parms[index++].Value = bilgi.daire_no;
            parms[index++].Value = bilgi.gider_aciklama;
            parms[index++].Value = bilgi.gider_kayit_tarihi;
            parms[index++].Value = bilgi.gider_kayit_eden_yonetici_id;
            parms[index++].Value = bilgi.gider_duzenleme_tarihi;
            parms[index++].Value = bilgi.gider_kayit_duzenleyen_yonetici_id;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_Gider SET  
                  gider_turu_id = " + PARM_GIDER_TURU_ID + @", 
                  gider_tutari = " + PARM_GIDER_TUTARI + @", 
                  gider_tarihi = " + PARM_GIDER_TARIHI + @", 
                  daire_no = " + PARM_DAIRE_NO + @", 
                  gider_aciklama = " + PARM_GIDER_ACIKLAMA + @", 
                  gider_kayit_tarihi = " + PARM_GIDER_KAYIT_TARIHI + @", 
                  gider_kayit_eden_yonetici_id = " + PARM_GIDER_KAYIT_EDEN_YONETICI_ID + @", 
                  gider_duzenleme_tarihi = " + PARM_GIDER_DUZENLEME_TARIHI + @", 
                  gider_kayit_duzenleyen_yonetici_id = " + PARM_GIDER_KAYIT_DUZENLEYEN_YONETICI_ID + @" WHERE gider_id = " + PARM_GIDER_ID;
        public tbl_Gider Guncelle(tbl_Gider bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_GIDER_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GIDER_TURU_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GIDER_TUTARI,SqlDbType.Float,8),
                        new SqlParameter(PARM_GIDER_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_DAIRE_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_GIDER_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_GIDER_KAYIT_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_GIDER_KAYIT_EDEN_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_GIDER_DUZENLEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_GIDER_KAYIT_DUZENLEYEN_YONETICI_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi.gider_id;
            parms[index++].Value = bilgi.gider_turu_id;
            parms[index++].Value = bilgi.gider_tutari;
            parms[index++].Value = bilgi.gider_tarihi;
            parms[index++].Value = bilgi.daire_no;
            parms[index++].Value = bilgi.gider_aciklama;
            parms[index++].Value = bilgi.gider_kayit_tarihi;
            parms[index++].Value = bilgi.gider_kayit_eden_yonetici_id;
            parms[index++].Value = bilgi.gider_duzenleme_tarihi;
            parms[index++].Value = bilgi.gider_kayit_duzenleyen_yonetici_id;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_Gider WHERE gider_id=" + PARM_GIDER_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_GIDER_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }
    }
}
