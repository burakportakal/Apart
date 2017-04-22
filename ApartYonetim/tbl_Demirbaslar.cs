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
    public class tbl_Demirbaslar : ModelBase
    {
        private const string PARM_DEMIRBAS_ID = "@demirbas_id";
        private const string PARM_DAIRE_NO = "@daire_no";
        private const string PARM_DEMIRBAS_ADI = "@demirbas_adi";
        private const string PARM_DEMIRBAS_ADET = "@demirbas_adet";
        private const string PARM_DEMIRBAS_ALIS_TARIHI = "@demirbas_alis_tarihi";
        private const string PARM_DEMIRBAS_FIYATI = "@demirbas_fiyati";
        private const string PARM_DEMIRBAS_ACIKLAMA = "@demirbas_aciklama";
        private const string PARM_DEMIRBAS_KAYIT_TARIHI = "@demirbas_kayit_tarihi";
        private const string PARM_DEMIRBAS_KAYIT_EDEN_YONETICI_ID = "@demirbas_kayit_eden_yonetici_id";
        private const string PARM_DEMIRBAS_DUZENLEME_TARIHI = "@demirbas_duzenleme_tarihi";
        private const string PARM_DEMIRBAS_KAYIT_DUZENLEYEN_YONETICI_ID = "@demirbas_kayit_duzenleyen_yonetici_id";
        public tbl_Demirbaslar()
        {
            SQLHelper.BilisimLibraryDbConnectionString = "server =.; Initial Catalog = AYS; Integrated Security = SSPI";
        }
        private int demirbas_id;
        public int Demirbas_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return demirbas_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { demirbas_id = value; }
        }
        private int daire_no;
        public int Daire_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_no = value; }
        }
        private string demirbas_adi;
        public string Demirbas_adi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return demirbas_adi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { demirbas_adi = value; }
        }
        private int demirbas_adet;
        public int Demirbas_adet
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return demirbas_adet; }
            [System.Diagnostics.DebuggerStepThrough]
            set { demirbas_adet = value; }
        }
        private DateTime demirbas_alis_tarihi;
        public DateTime Demirbas_alis_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return demirbas_alis_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { demirbas_alis_tarihi = value; }
        }
        private float demirbas_fiyati;
        public float Demirbas_fiyati
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return demirbas_fiyati; }
            [System.Diagnostics.DebuggerStepThrough]
            set { demirbas_fiyati = value; }
        }
        private string demirbas_aciklama;
        public string Demirbas_aciklama
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return demirbas_aciklama; }
            [System.Diagnostics.DebuggerStepThrough]
            set { demirbas_aciklama = value; }
        }
        private DateTime demirbas_kayit_tarihi;
        public DateTime Demirbas_kayit_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return demirbas_kayit_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { demirbas_kayit_tarihi = value; }
        }
        private int demirbas_kayit_eden_yonetici_id;
        public int Demirbas_kayit_eden_yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return demirbas_kayit_eden_yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { demirbas_kayit_eden_yonetici_id = value; }
        }
        private DateTime demirbas_duzenleme_tarihi;
        public DateTime Demirbas_duzenleme_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return demirbas_duzenleme_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { demirbas_duzenleme_tarihi = value; }
        }
        private int demirbas_kayit_duzenleyen_yonetici_id;
        public int Demirbas_kayit_duzenleyen_yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return demirbas_kayit_duzenleyen_yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { demirbas_kayit_duzenleyen_yonetici_id = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.demirbas_id = GetInt32(reader, i++).Value;
            this.daire_no = GetInt32(reader, i++).Value;
            this.demirbas_adi = GetString(reader, i++);
            this.demirbas_adet = GetInt32(reader, i++).Value;
            this.demirbas_alis_tarihi = GetDateTime(reader, i++).Value;
            this.demirbas_fiyati = (float)GetDouble(reader, i++).Value;
            this.demirbas_aciklama = GetString(reader, i++);
            this.demirbas_kayit_tarihi = GetDateTime(reader, i++).Value;
            this.demirbas_kayit_eden_yonetici_id = GetInt32(reader, i++).Value;
            this.demirbas_duzenleme_tarihi = GetDateTime(reader, i++).Value;
            this.demirbas_kayit_duzenleyen_yonetici_id = GetInt32(reader, i++).Value;
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                                demirbas_id ,
                                                daire_no ,
                                                demirbas_adi ,
                                                demirbas_adet ,
                                                demirbas_alis_tarihi ,
                                                demirbas_fiyati ,
                                                demirbas_aciklama ,
                                                                                            demirbas_kayit_tarihi ,
                                                demirbas_kayit_eden_yonetici_id ,
                                                demirbas_duzenleme_tarihi ,
                                                demirbas_kayit_duzenleyen_yonetici_id  FROM tbl_Demirbaslar WITH (NOLOCK) WHERE demirbas_id = " + PARM_DEMIRBAS_ID;
        public tbl_Demirbaslar FindById(int demirbas_id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_DEMIRBAS_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = demirbas_id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_Demirbaslar bilgi = new tbl_Demirbaslar();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", demirbas_id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                            demirbas_id ,
                                            daire_no ,
                                            demirbas_adi ,
                                            demirbas_adet ,
                                            demirbas_alis_tarihi ,
                                            demirbas_fiyati ,
                                            demirbas_aciklama ,
                                            demirbas_kayit_tarihi ,
                                            demirbas_kayit_eden_yonetici_id ,
                                            demirbas_duzenleme_tarihi ,
                                            demirbas_kayit_duzenleyen_yonetici_id  FROM tbl_Demirbaslar WITH (NOLOCK) ";
        public ModelCollection<tbl_Demirbaslar> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_Demirbaslar> liste = new ModelCollection<tbl_Demirbaslar>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_Demirbaslar( 
                  daire_no ,
                  demirbas_adi ,
                  demirbas_adet ,
                  demirbas_alis_tarihi ,
                  demirbas_fiyati ,
                  demirbas_aciklama ,
                  demirbas_kayit_tarihi ,
                  demirbas_kayit_eden_yonetici_id ,
                  demirbas_duzenleme_tarihi ,
                  demirbas_kayit_duzenleyen_yonetici_id ) VALUES (" + PARM_DAIRE_NO + @"," +
                          PARM_DEMIRBAS_ADI + @"," +
                          PARM_DEMIRBAS_ADET + @"," +
                          PARM_DEMIRBAS_ALIS_TARIHI + @"," +
                          PARM_DEMIRBAS_FIYATI + @"," +
                          PARM_DEMIRBAS_ACIKLAMA + @"," +
                          PARM_DEMIRBAS_KAYIT_TARIHI + @"," +
                          PARM_DEMIRBAS_KAYIT_EDEN_YONETICI_ID + @"," +
                          PARM_DEMIRBAS_DUZENLEME_TARIHI + @"," +
                          PARM_DEMIRBAS_KAYIT_DUZENLEYEN_YONETICI_ID + @" ) SET  " + PARM_DEMIRBAS_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_Demirbaslar bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_DEMIRBAS_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_DEMIRBAS_ADI,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_DEMIRBAS_ADET,SqlDbType.Int,4),
                        new SqlParameter(PARM_DEMIRBAS_ALIS_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_DEMIRBAS_FIYATI,SqlDbType.Float,8),
                        new SqlParameter(PARM_DEMIRBAS_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_DEMIRBAS_KAYIT_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_DEMIRBAS_KAYIT_EDEN_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_DEMIRBAS_DUZENLEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_DEMIRBAS_KAYIT_DUZENLEYEN_YONETICI_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.daire_no;
            parms[index++].Value = bilgi.demirbas_adi;
            parms[index++].Value = bilgi.demirbas_adet;
            parms[index++].Value = bilgi.demirbas_alis_tarihi;
            parms[index++].Value = bilgi.demirbas_fiyati;
            parms[index++].Value = bilgi.demirbas_aciklama;
            parms[index++].Value = bilgi.demirbas_kayit_tarihi;
            parms[index++].Value = bilgi.demirbas_kayit_eden_yonetici_id;
            parms[index++].Value = bilgi.demirbas_duzenleme_tarihi;
            parms[index++].Value = bilgi.demirbas_kayit_duzenleyen_yonetici_id;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_Demirbaslar SET  
                  daire_no = " + PARM_DAIRE_NO + @", 
                  demirbas_adi = " + PARM_DEMIRBAS_ADI + @", 
                  demirbas_adet = " + PARM_DEMIRBAS_ADET + @", 
                  demirbas_alis_tarihi = " + PARM_DEMIRBAS_ALIS_TARIHI + @", 
                  demirbas_fiyati = " + PARM_DEMIRBAS_FIYATI + @", 
                  demirbas_aciklama = " + PARM_DEMIRBAS_ACIKLAMA + @", 
                  demirbas_kayit_tarihi = " + PARM_DEMIRBAS_KAYIT_TARIHI + @", 
                  demirbas_kayit_eden_yonetici_id = " + PARM_DEMIRBAS_KAYIT_EDEN_YONETICI_ID + @", 
                  demirbas_duzenleme_tarihi = " + PARM_DEMIRBAS_DUZENLEME_TARIHI + @", 
                  demirbas_kayit_duzenleyen_yonetici_id = " + PARM_DEMIRBAS_KAYIT_DUZENLEYEN_YONETICI_ID + @" WHERE demirbas_id = " + PARM_DEMIRBAS_ID;
        public tbl_Demirbaslar Guncelle(tbl_Demirbaslar bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_DEMIRBAS_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_DEMIRBAS_ADI,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_DEMIRBAS_ADET,SqlDbType.Int,4),
                        new SqlParameter(PARM_DEMIRBAS_ALIS_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_DEMIRBAS_FIYATI,SqlDbType.Float,8),
                        new SqlParameter(PARM_DEMIRBAS_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_DEMIRBAS_KAYIT_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_DEMIRBAS_KAYIT_EDEN_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_DEMIRBAS_DUZENLEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_DEMIRBAS_KAYIT_DUZENLEYEN_YONETICI_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi.demirbas_id;
            parms[index++].Value = bilgi.daire_no;
            parms[index++].Value = bilgi.demirbas_adi;
            parms[index++].Value = bilgi.demirbas_adet;
            parms[index++].Value = bilgi.demirbas_alis_tarihi;
            parms[index++].Value = bilgi.demirbas_fiyati;
            parms[index++].Value = bilgi.demirbas_aciklama;
            parms[index++].Value = bilgi.demirbas_kayit_tarihi;
            parms[index++].Value = bilgi.demirbas_kayit_eden_yonetici_id;
            parms[index++].Value = bilgi.demirbas_duzenleme_tarihi;
            parms[index++].Value = bilgi.demirbas_kayit_duzenleyen_yonetici_id;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_Demirbaslar WHERE demirbas_id=" + PARM_DEMIRBAS_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_DEMIRBAS_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }
    }
}
