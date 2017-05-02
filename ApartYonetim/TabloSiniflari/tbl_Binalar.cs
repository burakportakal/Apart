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
    public class tbl_Binalar : ModelBase
    {
        private const string PARM_BINA_ID = "@bina_id";
        private const string PARM_BINA_ADI = "@bina_adi";
        private const string PARM_BINA_ADRESI = "@bina_adresi";
        private const string PARM_BINA_DAIRE_SAYISI = "@bina_daire_sayisi";
        private const string PARM_BINA_IRTIBAT_TEL_NO = "@bina_irtibat_tel_no";
        private const string PARM_BINA_IRTIBAT_TEL_NO2 = "@bina_irtibat_tel_no2";
        private const string PARM_BINA_ACIKLAMA = "@bina_aciklama";
        private const string PARM_BINA_KAYIT_TARIHI = "@bina_kayit_tarihi";
        private const string PARM_BINA_KAYIT_EDEN_YONETICI_ID = "@bina_kayit_eden_yonetici_id";
        private const string PARM_BINA_DUZENLEME_TARIHI = "@bina_duzenleme_tarihi";
        private const string PARM_BINA_KAYIT_DUZENLEYEN_YONETICI_ID = "@bina_kayit_duzenleyen_yonetici_id";
        private int bina_id;
        public tbl_Binalar()
        {
            SQLHelper.BilisimLibraryDbConnectionString = "server =.; Initial Catalog = AYS; Integrated Security = SSPI";
        }
        public int Bina_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_id = value; }
        }
        private string bina_adi;
        public string Bina_adi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_adi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_adi = value; }
        }
        private string bina_adresi;
        public string Bina_adresi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_adresi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_adresi = value; }
        }
        private int bina_daire_sayisi;
        public int Bina_daire_sayisi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_daire_sayisi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_daire_sayisi = value; }
        }
        private string bina_irtibat_tel_no;
        public string Bina_irtibat_tel_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_irtibat_tel_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_irtibat_tel_no = value; }
        }
        private string bina_irtibat_tel_no2;
        public string Bina_irtibat_tel_no2
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_irtibat_tel_no2; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_irtibat_tel_no2 = value; }
        }
        private string bina_aciklama;
        public string Bina_aciklama
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_aciklama; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_aciklama = value; }
        }
        private DateTime bina_kayit_tarihi;
        public DateTime Bina_kayit_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_kayit_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_kayit_tarihi = value; }
        }
        private int bina_kayit_eden_yonetici_id;
        public int Bina_kayit_eden_yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_kayit_eden_yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_kayit_eden_yonetici_id = value; }
        }
        private DateTime bina_duzenleme_tarihi;
        public DateTime Bina_duzenleme_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_duzenleme_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_duzenleme_tarihi = value; }
        }
        private int bina_kayit_duzenleyen_yonetici_id;
        public int Bina_kayit_duzenleyen_yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_kayit_duzenleyen_yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_kayit_duzenleyen_yonetici_id = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.bina_id = GetInt32(reader, i++).Value;
            this.bina_adi = GetString(reader, i++);
            this.bina_adresi = GetString(reader, i++);
            this.bina_daire_sayisi = GetInt32(reader, i++).Value;
            this.bina_irtibat_tel_no = GetString(reader, i++);
            this.bina_irtibat_tel_no2 = GetString(reader, i++);
            this.bina_aciklama = GetString(reader, i++);
            this.bina_kayit_tarihi = GetDateTime(reader, i++).Value;
            this.bina_kayit_eden_yonetici_id = GetInt32(reader, i++).Value;
            this.bina_duzenleme_tarihi = GetDateTime(reader, i++).Value;
            this.bina_kayit_duzenleyen_yonetici_id = GetInt32(reader, i++).Value;
            //if (GetDateTime(reader, i++).HasValue)
            //{
            //    --i;
            //    this.bina_kayit_tarihi = GetDateTime(reader, i++).Value;
            //}
            //if (GetDateTime(reader, i++).HasValue) {
            //    --i;
            //this.bina_kayit_eden_yonetici_id = GetInt32(reader, i++).Value;
            //}
            //if (GetDateTime(reader, i++).HasValue)
            //{
            //    --i;
            //    this.bina_duzenleme_tarihi = GetDateTime(reader, i++).Value;

            //}
            //if (GetDateTime(reader, i++).HasValue)
            //{
            //    --i;
            //    this.bina_kayit_duzenleyen_yonetici_id = GetInt32(reader, i++).Value;
            //}
            return i;
        }
        private static string SQL_FIND_BY_ID = @"SELECT 
                                                bina_id ,
                                                bina_adi ,
                                                bina_adresi ,
                                                bina_daire_sayisi ,
                                                bina_irtibat_tel_no ,
                                                bina_irtibat_tel_no2 ,
                                                bina_aciklama ,
                                                bina_kayit_tarihi ,
                                                bina_kayit_eden_yonetici_id ,
                                                bina_duzenleme_tarihi ,
                                                bina_kayit_duzenleyen_yonetici_id  FROM tbl_Binalar WITH (NOLOCK) WHERE bina_id = " + PARM_BINA_ID;
        public tbl_Binalar FindById(int bina_id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_BINA_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = bina_id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_Binalar bilgi = new tbl_Binalar();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", bina_id);
                }
            }
        }
        private static string SQL_LISTE = @"SELECT 
                                            bina_id ,
                                            bina_adi ,
                                            bina_adresi ,
                                            bina_daire_sayisi ,
                                            bina_irtibat_tel_no ,
                                            bina_irtibat_tel_no2 ,
                                            bina_aciklama ,
                                            bina_kayit_tarihi ,
                                            bina_kayit_eden_yonetici_id ,
                                            bina_duzenleme_tarihi ,
                                            bina_kayit_duzenleyen_yonetici_id  FROM tbl_Binalar WITH (NOLOCK) ";
        public ModelCollection<tbl_Binalar> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_Binalar> liste = new ModelCollection<tbl_Binalar>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static string SQL_YENI_KAYDET = @"INSERT INTO tbl_Binalar( 
                  bina_adi ,
                  bina_adresi ,
                  bina_daire_sayisi ,
                  bina_irtibat_tel_no ,
                  bina_irtibat_tel_no2 ,
                  bina_aciklama ,
                  bina_kayit_tarihi ,
                  bina_kayit_eden_yonetici_id ,
                  bina_duzenleme_tarihi ,
                  bina_kayit_duzenleyen_yonetici_id ) VALUES (" + PARM_BINA_ADI + @"," +
                          PARM_BINA_ADRESI + @"," +
                          PARM_BINA_DAIRE_SAYISI + @"," +
                          PARM_BINA_IRTIBAT_TEL_NO + @"," +
                          PARM_BINA_IRTIBAT_TEL_NO2 + @"," +
                          PARM_BINA_ACIKLAMA + @"," +
                          PARM_BINA_KAYIT_TARIHI + @"," +
                          PARM_BINA_KAYIT_EDEN_YONETICI_ID + @"," +
                          PARM_BINA_DUZENLEME_TARIHI + @"," +
                          PARM_BINA_KAYIT_DUZENLEYEN_YONETICI_ID + @" ) SET  " + PARM_BINA_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_Binalar bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_BINA_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_BINA_ADI,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_BINA_ADRESI,SqlDbType.NVarChar,300),
                        new SqlParameter(PARM_BINA_DAIRE_SAYISI,SqlDbType.Int,4),
                        new SqlParameter(PARM_BINA_IRTIBAT_TEL_NO,SqlDbType.VarChar,14),
                        new SqlParameter(PARM_BINA_IRTIBAT_TEL_NO2,SqlDbType.VarChar,14),
                        new SqlParameter(PARM_BINA_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_BINA_KAYIT_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_BINA_KAYIT_EDEN_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_BINA_DUZENLEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_BINA_KAYIT_DUZENLEYEN_YONETICI_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.bina_adi;
            parms[index++].Value = bilgi.bina_adresi;
            parms[index++].Value = bilgi.bina_daire_sayisi;
            parms[index++].Value = bilgi.bina_irtibat_tel_no;
            parms[index++].Value = bilgi.bina_irtibat_tel_no2;
            parms[index++].Value = bilgi.bina_aciklama;
            parms[index++].Value = DateTime.Now;
            parms[index++].Value = 1;
            parms[index++].Value = DateTime.Now;
            parms[index++].Value = 1;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly string SQL_GUNCELLE = @"UPDATE tbl_Binalar SET  
                  bina_adi = " + PARM_BINA_ADI + @", 
                  bina_adresi = " + PARM_BINA_ADRESI + @", 
                  bina_daire_sayisi = " + PARM_BINA_DAIRE_SAYISI + @", 
                  bina_irtibat_tel_no = " + PARM_BINA_IRTIBAT_TEL_NO + @", 
                  bina_irtibat_tel_no2 = " + PARM_BINA_IRTIBAT_TEL_NO2 + @", 
                  bina_aciklama = " + PARM_BINA_ACIKLAMA + @", 
                  bina_duzenleme_tarihi = " + PARM_BINA_DUZENLEME_TARIHI + @", 
                  bina_kayit_duzenleyen_yonetici_id = " + PARM_BINA_KAYIT_DUZENLEYEN_YONETICI_ID + @" WHERE bina_id = " + PARM_BINA_ID;
        public tbl_Binalar Guncelle(tbl_Binalar bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_BINA_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_BINA_ADI,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_BINA_ADRESI,SqlDbType.NVarChar,300),
                        new SqlParameter(PARM_BINA_DAIRE_SAYISI,SqlDbType.Int,4),
                        new SqlParameter(PARM_BINA_IRTIBAT_TEL_NO,SqlDbType.VarChar,14),
                        new SqlParameter(PARM_BINA_IRTIBAT_TEL_NO2,SqlDbType.VarChar,14),
                        new SqlParameter(PARM_BINA_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_BINA_DUZENLEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_BINA_KAYIT_DUZENLEYEN_YONETICI_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi.bina_id;
            parms[index++].Value = bilgi.bina_adi;
            parms[index++].Value = bilgi.bina_adresi;
            parms[index++].Value = bilgi.bina_daire_sayisi;
            parms[index++].Value = bilgi.bina_irtibat_tel_no;
            parms[index++].Value = bilgi.bina_irtibat_tel_no2;
            parms[index++].Value = bilgi.bina_aciklama;
            parms[index++].Value = DateTime.Now;
            parms[index++].Value = 1;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly string SQL_SIL = @"DELETE FROM tbl_Binalar WHERE bina_id=" + PARM_BINA_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_BINA_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }

        public DataSet spBinaSorgula(string apartAdi, bool yetkili, int daireNo, string procName)
        {
            SqlConnection cnn = new SqlConnection(SQLHelper.BilisimLibraryDbConnectionString);
            SqlCommand cmd = new SqlCommand(procName, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@binaAdi", apartAdi);
            cmd.Parameters.AddWithValue("@yetkili", yetkili);
            cmd.Parameters.AddWithValue("@daireNo", daireNo);
            cnn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            sda.Fill(dt, "tbl_BinaMusteri");
            cnn.Close();
            return dt;
        }
    }
}
