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
    public class tbl_Musteriler : ModelBase
    {
        private const string PARM_MUSTERI_ID = "@musteri_id";
        private const string PARM_MUSTERI_TC_KIMLIK_NO = "@musteri_tc_kimlik_no";
        private const string PARM_MUSTERI_ADI = "@musteri_adi";
        private const string PARM_MUSTERI_SOYADI = "@musteri_soyadi";
        private const string PARM_MUSTERI_TELEFON_NO = "@musteri_telefon_no";
        private const string PARM_MUSTERI_TELEFON_NO2 = "@musteri_telefon_no2";
        private const string PARM_MUSTERI_EMAIL = "@musteri_email";
        private const string PARM_MUSTERI_SEHIR = "@musteri_sehir";
        private const string PARM_MUSTERI_ADRES = "@musteri_adres";
        private const string PARM_DAIRE_NO = "@daire_no";
        private const string PARM_MUSTERI_ACIKLAMA = "@musteri_aciklama";
        private const string PARM_MUSTERI_KAYIT_TARIHI = "@musteri_kayit_tarihi";
        private const string PARM_MUSTERI_DUZENLEME_TARIHI = "@musteri_duzenleme_tarihi";
        private const string PARM_MUSTER_KAYIT_DUZENLEYEN_YONETICI_ID = "@muster_kayit_duzenleyen_yonetici_id";
        private const string PARM_MUSTERI_KAYIT_EDEN_YONETICI_ID = "@musteri_kayit_eden_yonetici_id";
        private const string PARM_MUSTERI_KONTRAT_BASLANGIC_TARIHI = "@musteri_kontrat_baslangic_tarihi";
        private const string PARM_MUSTERI_KONTRAT_BITIS_TARIHI = "@musteri_kontrat_bitis_tarihi";
        private const string PARM_MUSTERI_KIRA_TUTARI = "@musteri_kira_tutari";
        private const string PARM_MUSTERI_YETKI = "@musteri_yetki";
        private const string PARM_MUSTERI_DURUMU = "@musteri_durumu";
        public tbl_Musteriler()
        {
            SQLHelper.BilisimLibraryDbConnectionString = "server =.; Initial Catalog = AYS; Integrated Security = SSPI";
        }
        private int musteri_id;
        public int Musteri_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_id = value; }
        }
        private string musteri_tc_kimlik_no;
        public string Musteri_tc_kimlik_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_tc_kimlik_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_tc_kimlik_no = value; }
        }
        private string musteri_adi;
        public string Musteri_adi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_adi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_adi = value; }
        }
        private string musteri_soyadi;
        public string Musteri_soyadi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_soyadi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_soyadi = value; }
        }
        private string musteri_telefon_no;
        public string Musteri_telefon_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_telefon_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_telefon_no = value; }
        }
        private string musteri_telefon_no2;
        public string Musteri_telefon_no2
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_telefon_no2; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_telefon_no2 = value; }
        }
        private string musteri_email;
        public string Musteri_email
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_email; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_email = value; }
        }
        private string musteri_sehir;
        public string Musteri_sehir
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_sehir; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_sehir = value; }
        }
        private string musteri_adres;
        public string Musteri_adres
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_adres; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_adres = value; }
        }
        private int daire_no;
        public int Daire_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_no = value; }
        }
        private string musteri_aciklama;
        public string Musteri_aciklama
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_aciklama; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_aciklama = value; }
        }
        private DateTime musteri_kayit_tarihi;
        public DateTime Musteri_kayit_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_kayit_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_kayit_tarihi = value; }
        }
        private DateTime musteri_duzenleme_tarihi;
        public DateTime Musteri_duzenleme_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_duzenleme_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_duzenleme_tarihi = value; }
        }
        private int muster_kayit_duzenleyen_yonetici_id;
        public int Muster_kayit_duzenleyen_yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return muster_kayit_duzenleyen_yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { muster_kayit_duzenleyen_yonetici_id = value; }
        }
        private int musteri_kayit_eden_yonetici_id;
        public int Musteri_kayit_eden_yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_kayit_eden_yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_kayit_eden_yonetici_id = value; }
        }
        private DateTime musteri_kontrat_baslangic_tarihi;
        public DateTime Musteri_kontrat_baslangic_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_kontrat_baslangic_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_kontrat_baslangic_tarihi = value; }
        }
        private DateTime musteri_kontrat_bitis_tarihi;
        public DateTime Musteri_kontrat_bitis_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_kontrat_bitis_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_kontrat_bitis_tarihi = value; }
        }
        private float musteri_kira_tutari;
        public float Musteri_kira_tutari
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_kira_tutari; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_kira_tutari = value; }
        }
        private Boolean musteri_yetki;
        public Boolean Musteri_yetki
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_yetki; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_yetki = value; }
        }
        private Boolean musteri_durumu;
        public Boolean Musteri_durumu
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return musteri_durumu; }
            [System.Diagnostics.DebuggerStepThrough]
            set { musteri_durumu = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.musteri_id = GetInt32(reader, i++).Value;
            this.musteri_tc_kimlik_no = GetString(reader, i++);
            this.musteri_adi = GetString(reader, i++);
            this.musteri_soyadi = GetString(reader, i++);
            this.musteri_telefon_no = GetString(reader, i++);
            this.musteri_telefon_no2 = GetString(reader, i++);
            this.musteri_email = GetString(reader, i++);
            this.musteri_sehir = GetString(reader, i++);
            this.musteri_adres = GetString(reader, i++);
            this.daire_no = GetInt32(reader, i++).Value;
            this.musteri_aciklama = GetString(reader, i++);
            this.musteri_kayit_tarihi = GetDateTime(reader, i++).Value;
            this.musteri_duzenleme_tarihi = GetDateTime(reader, i++).Value;
            this.muster_kayit_duzenleyen_yonetici_id = GetInt32(reader, i++).Value;
            this.musteri_kayit_eden_yonetici_id = GetInt32(reader, i++).Value;
            this.musteri_kontrat_baslangic_tarihi = GetDateTime(reader, i++).Value;
            this.musteri_kontrat_bitis_tarihi = GetDateTime(reader, i++).Value;
            this.musteri_kira_tutari =(float) GetDouble(reader, i++).Value;
            this.musteri_yetki = GetBoolean(reader, i++).Value;
            this.musteri_durumu = GetBoolean(reader, i++).Value;
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                        musteri_id ,
                                        musteri_tc_kimlik_no ,
                                        musteri_adi ,
                                        musteri_soyadi ,
                                        musteri_telefon_no ,
                                        musteri_telefon_no2 ,
                                        musteri_email ,
                                        musteri_sehir ,
                                        musteri_adres ,
                                        daire_no ,
                                        musteri_aciklama ,
                                        musteri_kayit_tarihi ,
                                        musteri_duzenleme_tarihi ,
                                        muster_kayit_duzenleyen_yonetici_id ,
                                        musteri_kayit_eden_yonetici_id ,
                                        musteri_kontrat_baslangic_tarihi ,
                                        musteri_kontrat_bitis_tarihi ,
                                        musteri_kira_tutari ,
                                        musteri_yetki ,
                                        musteri_durumu  FROM tbl_Musteriler WITH (NOLOCK) WHERE musteri_id = " + PARM_MUSTERI_ID;
        public tbl_Musteriler FindById(int musteri_id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_MUSTERI_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = musteri_id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_Musteriler bilgi = new tbl_Musteriler();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", musteri_id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                    musteri_id ,
                                    musteri_tc_kimlik_no ,
                                    musteri_adi ,
                                    musteri_soyadi ,
                                    musteri_telefon_no ,
                                    musteri_telefon_no2 ,
                                    musteri_email ,
                                    musteri_sehir ,
                                    musteri_adres ,
                                    daire_no ,
                                    musteri_aciklama ,
                                    musteri_kayit_tarihi ,
                                    musteri_duzenleme_tarihi ,
                                    muster_kayit_duzenleyen_yonetici_id ,
                                    musteri_kayit_eden_yonetici_id ,
                                    musteri_kontrat_baslangic_tarihi ,
                                    musteri_kontrat_bitis_tarihi ,
                                    musteri_kira_tutari ,
                                    musteri_yetki ,
                                    musteri_durumu  FROM tbl_Musteriler WITH (NOLOCK) ";
        public ModelCollection<tbl_Musteriler> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_Musteriler> liste = new ModelCollection<tbl_Musteriler>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_Musteriler( 
                  musteri_tc_kimlik_no ,
                  musteri_adi ,
                  musteri_soyadi ,
                  musteri_telefon_no ,
                  musteri_telefon_no2 ,
                  musteri_email ,
                  musteri_sehir ,
                  musteri_adres ,
                  daire_no ,
                  musteri_aciklama ,
                  musteri_kayit_tarihi ,
                  musteri_duzenleme_tarihi ,
                  muster_kayit_duzenleyen_yonetici_id ,
                  musteri_kayit_eden_yonetici_id ,
                  musteri_kontrat_baslangic_tarihi ,
                  musteri_kontrat_bitis_tarihi ,
                  musteri_kira_tutari ,
                  musteri_yetki ,
                  musteri_durumu ) VALUES (" + PARM_MUSTERI_TC_KIMLIK_NO + @"," +
                          PARM_MUSTERI_ADI + @"," +
                          PARM_MUSTERI_SOYADI + @"," +
                          PARM_MUSTERI_TELEFON_NO + @"," +
                          PARM_MUSTERI_TELEFON_NO2 + @"," +
                          PARM_MUSTERI_EMAIL + @"," +
                          PARM_MUSTERI_SEHIR + @"," +
                          PARM_MUSTERI_ADRES + @"," +
                          PARM_DAIRE_NO + @"," +
                          PARM_MUSTERI_ACIKLAMA + @"," +
                          PARM_MUSTERI_KAYIT_TARIHI + @"," +
                          PARM_MUSTERI_DUZENLEME_TARIHI + @"," +
                          PARM_MUSTER_KAYIT_DUZENLEYEN_YONETICI_ID + @"," +
                          PARM_MUSTERI_KAYIT_EDEN_YONETICI_ID + @"," +
                          PARM_MUSTERI_KONTRAT_BASLANGIC_TARIHI + @"," +
                          PARM_MUSTERI_KONTRAT_BITIS_TARIHI + @"," +
                          PARM_MUSTERI_KIRA_TUTARI + @"," +
                          PARM_MUSTERI_YETKI + @"," +
                          PARM_MUSTERI_DURUMU + @" ) SET  " + PARM_MUSTERI_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_Musteriler bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_MUSTERI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_MUSTERI_TC_KIMLIK_NO,SqlDbType.VarChar,11),
                        new SqlParameter(PARM_MUSTERI_ADI,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_MUSTERI_SOYADI,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_MUSTERI_TELEFON_NO,SqlDbType.VarChar,11),
                        new SqlParameter(PARM_MUSTERI_TELEFON_NO2,SqlDbType.VarChar,11),
                        new SqlParameter(PARM_MUSTERI_EMAIL,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_MUSTERI_SEHIR,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_MUSTERI_ADRES,SqlDbType.NVarChar,300),
                        new SqlParameter(PARM_DAIRE_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_MUSTERI_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_MUSTERI_KAYIT_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_MUSTERI_DUZENLEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_MUSTER_KAYIT_DUZENLEYEN_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_MUSTERI_KAYIT_EDEN_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_MUSTERI_KONTRAT_BASLANGIC_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_MUSTERI_KONTRAT_BITIS_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_MUSTERI_KIRA_TUTARI,SqlDbType.Float,8),
                        new SqlParameter(PARM_MUSTERI_YETKI,SqlDbType.Bit,1),
                        new SqlParameter(PARM_MUSTERI_DURUMU,SqlDbType.Bit,1),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = bilgi.musteri_tc_kimlik_no;
            parms[index++].Value = bilgi.musteri_adi;
            parms[index++].Value = bilgi.musteri_soyadi;
            parms[index++].Value = bilgi.musteri_telefon_no;
            parms[index++].Value = bilgi.musteri_telefon_no2;
            parms[index++].Value = bilgi.musteri_email;
            parms[index++].Value = bilgi.musteri_sehir;
            parms[index++].Value = bilgi.musteri_adres;
            parms[index++].Value = bilgi.daire_no;
            parms[index++].Value = bilgi.musteri_aciklama;
            parms[index++].Value = bilgi.musteri_kayit_tarihi;
            parms[index++].Value = bilgi.musteri_duzenleme_tarihi;
            parms[index++].Value = bilgi.muster_kayit_duzenleyen_yonetici_id;
            parms[index++].Value = bilgi.musteri_kayit_eden_yonetici_id;
            parms[index++].Value = bilgi.musteri_kontrat_baslangic_tarihi;
            parms[index++].Value = bilgi.musteri_kontrat_bitis_tarihi;
            parms[index++].Value = bilgi.musteri_kira_tutari;
            parms[index++].Value = bilgi.musteri_yetki;
            parms[index++].Value = bilgi.musteri_durumu;
            return  SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
          
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_Musteriler SET  
                  musteri_tc_kimlik_no = " + PARM_MUSTERI_TC_KIMLIK_NO + @", 
                  musteri_adi = " + PARM_MUSTERI_ADI + @", 
                  musteri_soyadi = " + PARM_MUSTERI_SOYADI + @", 
                  musteri_telefon_no = " + PARM_MUSTERI_TELEFON_NO + @", 
                  musteri_telefon_no2 = " + PARM_MUSTERI_TELEFON_NO2 + @", 
                  musteri_email = " + PARM_MUSTERI_EMAIL + @", 
                  musteri_sehir = " + PARM_MUSTERI_SEHIR + @", 
                  musteri_adres = " + PARM_MUSTERI_ADRES + @", 
                  daire_no = " + PARM_DAIRE_NO + @", 
                  musteri_aciklama = " + PARM_MUSTERI_ACIKLAMA + @", 
                  musteri_duzenleme_tarihi = " + PARM_MUSTERI_DUZENLEME_TARIHI + @", 
                  muster_kayit_duzenleyen_yonetici_id = " + PARM_MUSTER_KAYIT_DUZENLEYEN_YONETICI_ID + @", 
                  musteri_kontrat_baslangic_tarihi = " + PARM_MUSTERI_KONTRAT_BASLANGIC_TARIHI + @", 
                  musteri_kontrat_bitis_tarihi = " + PARM_MUSTERI_KONTRAT_BITIS_TARIHI + @", 
                  musteri_kira_tutari = " + PARM_MUSTERI_KIRA_TUTARI + @", 
                  musteri_yetki = " + PARM_MUSTERI_YETKI + @", 
                  musteri_durumu = " + PARM_MUSTERI_DURUMU + @" WHERE musteri_tc_kimlik_no = " + PARM_MUSTERI_TC_KIMLIK_NO;
        public tbl_Musteriler Guncelle(tbl_Musteriler bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_MUSTERI_TC_KIMLIK_NO,SqlDbType.VarChar,11),
                        new SqlParameter(PARM_MUSTERI_ADI,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_MUSTERI_SOYADI,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_MUSTERI_TELEFON_NO,SqlDbType.VarChar,11),
                        new SqlParameter(PARM_MUSTERI_TELEFON_NO2,SqlDbType.VarChar,11),
                        new SqlParameter(PARM_MUSTERI_EMAIL,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_MUSTERI_SEHIR,SqlDbType.NVarChar,100),
                        new SqlParameter(PARM_MUSTERI_ADRES,SqlDbType.NVarChar,300),
                        new SqlParameter(PARM_DAIRE_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_MUSTERI_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_MUSTERI_DUZENLEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_MUSTER_KAYIT_DUZENLEYEN_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_MUSTERI_KONTRAT_BASLANGIC_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_MUSTERI_KONTRAT_BITIS_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_MUSTERI_KIRA_TUTARI,SqlDbType.Float,8),
                        new SqlParameter(PARM_MUSTERI_YETKI,SqlDbType.Bit,1),
                        new SqlParameter(PARM_MUSTERI_DURUMU,SqlDbType.Bit,1),
};
            int index = 0;
            parms[index++].Value = bilgi.musteri_tc_kimlik_no;
            parms[index++].Value = bilgi.musteri_adi;
            parms[index++].Value = bilgi.musteri_soyadi;
            parms[index++].Value = bilgi.musteri_telefon_no;
            parms[index++].Value = bilgi.musteri_telefon_no2;
            parms[index++].Value = bilgi.musteri_email;
            parms[index++].Value = bilgi.musteri_sehir;
            parms[index++].Value = bilgi.musteri_adres;
            parms[index++].Value = bilgi.daire_no;
            parms[index++].Value = bilgi.musteri_aciklama;
            parms[index++].Value = bilgi.musteri_duzenleme_tarihi;
            parms[index++].Value = bilgi.muster_kayit_duzenleyen_yonetici_id;
            parms[index++].Value = bilgi.musteri_kontrat_baslangic_tarihi;
            parms[index++].Value = bilgi.musteri_kontrat_bitis_tarihi;
            parms[index++].Value = bilgi.musteri_kira_tutari;
            parms[index++].Value = bilgi.musteri_yetki;
            parms[index++].Value = bilgi.musteri_durumu;
            int sonuc = SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_Musteriler WHERE musteri_id=" + PARM_MUSTERI_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_MUSTERI_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }
    }
}
