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
    public class tbl_Daireler : ModelBase
    {
        private const string PARM_DAIRE_ID = "@daire_id";
        private const string PARM_DAIRE_NO = "@daire_no";
        private const string PARM_BINA_ID = "@bina_id";
        private const string PARM_DAIRE_ODA_SAYISI = "@daire_oda_sayisi";
        private const string PARM_DAIRE_METRE_KARE = "@daire_metre_kare";
        private const string PARM_DAIRE_KAT_NO = "@daire_kat_no";
        private const string PARM_DAIRE_KAPI_NO = "@daire_kapi_no";
        private const string PARM_DAIRE_DURUMU = "@daire_durumu";
        private const string PARM_DAIRE_ACIKLAMA = "@daire_aciklama";
        private const string PARM_DAIRE_KAYIT_TARIHI = "@daire_kayit_tarihi";
        private const string PARM_DAIRE_KAYIT_EDEN_YONETICI_ID = "@daire_kayit_eden_yonetici_id";
        private const string PARM_DAIRE_DUZENLEME_TARIHI = "@daire_duzenleme_tarihi";
        private const string PARM_DAIRE_KAYIT_DUZENLEYEN_YONETICI_ID = "@daire_kayit_duzenleyen_yonetici_id";
        public tbl_Daireler()
        {
            SQLHelper.BilisimLibraryDbConnectionString = "server =.; Initial Catalog = AYS; Integrated Security = SSPI";
        }
        private int daire_id;
        public int Daire_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_id = value; }
        }
        private int daire_no;
        public int Daire_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_no = value; }
        }
        private int bina_id;
        public int Bina_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return bina_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { bina_id = value; }
        }
        private string daire_oda_sayisi;
        public string Daire_oda_sayisi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_oda_sayisi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_oda_sayisi = value; }
        }
        private int daire_metre_kare;
        public int Daire_metre_kare
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_metre_kare; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_metre_kare = value; }
        }
        private int daire_kat_no;
        public int Daire_kat_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_kat_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_kat_no = value; }
        }
        private int daire_kapi_no;
        public int Daire_kapi_no
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_kapi_no; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_kapi_no = value; }
        }
        private Boolean daire_durumu;
        public Boolean Daire_durumu
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_durumu; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_durumu = value; }
        }
        private string daire_aciklama;
        public string Daire_aciklama
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_aciklama; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_aciklama = value; }
        }
        private DateTime daire_kayit_tarihi;
        public DateTime Daire_kayit_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_kayit_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_kayit_tarihi = value; }
        }
        private int daire_kayit_eden_yonetici_id;
        public int Daire_kayit_eden_yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_kayit_eden_yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_kayit_eden_yonetici_id = value; }
        }
        private DateTime daire_duzenleme_tarihi;
        public DateTime Daire_duzenleme_tarihi
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_duzenleme_tarihi; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_duzenleme_tarihi = value; }
        }
        private int daire_kayit_duzenleyen_yonetici_id;
        public int Daire_kayit_duzenleyen_yonetici_id
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return daire_kayit_duzenleyen_yonetici_id; }
            [System.Diagnostics.DebuggerStepThrough]
            set { daire_kayit_duzenleyen_yonetici_id = value; }
        }
        public override int PopulateDataReader(System.Data.Common.DbDataReader reader)
        {
            int i = 0;
            this.daire_id = GetInt32(reader, i++).Value;
            this.daire_no = GetInt32(reader, i++).Value;
            this.bina_id = GetInt32(reader, i++).Value;
            this.daire_oda_sayisi = GetString(reader, i++);
            this.daire_metre_kare = GetInt32(reader, i++).Value;
            this.daire_kat_no = GetInt32(reader, i++).Value;
            this.daire_kapi_no = GetInt32(reader, i++).Value;
            this.daire_durumu = GetBoolean(reader, i++).Value;
            this.daire_aciklama = GetString(reader, i++);
            this.daire_kayit_tarihi = GetDateTime(reader, i++).Value;
            this.daire_kayit_eden_yonetici_id = GetInt32(reader, i++).Value;
            this.daire_duzenleme_tarihi = GetDateTime(reader, i++).Value;
            this.daire_kayit_duzenleyen_yonetici_id = GetInt32(reader, i++).Value;
            //if (GetDateTime(reader, i++).HasValue)
            //    this.daire_kayit_tarihi = GetDateTime(reader, i).Value;
            //if (GetDateTime(reader, i++).HasValue)
            //    this.daire_kayit_eden_yonetici_id = GetInt32(reader, i).Value;
            //if (GetDateTime(reader, i++).HasValue)
            //    this.daire_duzenleme_tarihi = GetDateTime(reader, i).Value;
            //if (GetDateTime(reader, i).HasValue)
            //    this.daire_kayit_duzenleyen_yonetici_id = GetInt32(reader, i++).Value;
            return i;
        }
        private static String SQL_FIND_BY_ID = @"SELECT 
                                                daire_id ,
                                                daire_no ,
                                                bina_id ,
                                                daire_oda_sayisi ,
                                                daire_metre_kare ,
                                                daire_kat_no ,
                                                daire_kapi_no ,
                                                daire_durumu ,
                                                daire_aciklama ,
                                                daire_kayit_tarihi ,
                                                daire_kayit_eden_yonetici_id ,
                                                daire_duzenleme_tarihi ,
                                                daire_kayit_duzenleyen_yonetici_id  FROM tbl_Daireler WITH (NOLOCK) WHERE daire_id = " + PARM_DAIRE_ID;
        public tbl_Daireler FindById(int daire_id)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_DAIRE_ID, SqlDbType.Int, 4),
    };
            parms[0].Value = daire_id;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_ID, parms))
            {
                if (reader.Read())
                {
                    tbl_Daireler bilgi = new tbl_Daireler();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_ID", daire_id);
                }
            }
        }
        private static String SQL_FIND_BY_DAIRE_NO = @"SELECT 
                                                daire_id ,
                                                daire_no ,
                                                bina_id ,
                                                daire_oda_sayisi ,
                                                daire_metre_kare ,
                                                daire_kat_no ,
                                                daire_kapi_no ,
                                                daire_durumu ,
                                                daire_aciklama ,
                                                daire_kayit_tarihi ,
                                                daire_kayit_eden_yonetici_id ,
                                                daire_duzenleme_tarihi ,
                                                daire_kayit_duzenleyen_yonetici_id  FROM tbl_Daireler WITH (NOLOCK) WHERE daire_no = " + PARM_DAIRE_NO;
        public tbl_Daireler FindByDaireNo(int daire_no)
        {
            SqlParameter[] parms = new SqlParameter[] {
         new SqlParameter(PARM_DAIRE_NO, SqlDbType.Int, 4),
    };
            parms[0].Value = daire_no;

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_FIND_BY_DAIRE_NO, parms))
            {
                if (reader.Read())
                {
                    tbl_Daireler bilgi = new tbl_Daireler();
                    bilgi.PopulateDataReader(reader);
                    return bilgi;
                }
                else
                {
                    throw new DBKayitBulunamadiException(this.GetType(), "SQL_FIND_BY_DAIRE_NO", daire_id);
                }
            }
        }
        private static String SQL_LISTE = @"SELECT 
                                            daire_id ,
                                            daire_no ,
                                            bina_id ,
                                            daire_oda_sayisi ,
                                            daire_metre_kare ,
                                            daire_kat_no ,
                                            daire_kapi_no ,
                                            daire_durumu ,
                                            daire_aciklama ,
                                            daire_kayit_tarihi ,
                                            daire_kayit_eden_yonetici_id ,
                                            daire_duzenleme_tarihi ,
                                            daire_kayit_duzenleyen_yonetici_id  FROM tbl_Daireler WITH (NOLOCK) ";
        public ModelCollection<tbl_Daireler> Listele()
        {
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_Daireler> liste = new ModelCollection<tbl_Daireler>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
      
        private static String SQL_LISTE2 = @"SELECT DISTINCT
                                            daire_id ,
                                            daire_no ,
                                            tbl_Daireler.bina_id,
                                            daire_oda_sayisi ,
                                            daire_metre_kare ,
                                            daire_kat_no ,
                                            daire_kapi_no ,
                                            daire_durumu ,
                                            daire_aciklama ,
                                            daire_kayit_tarihi ,
                                            daire_kayit_eden_yonetici_id ,
                                            daire_duzenleme_tarihi ,
                                            daire_kayit_duzenleyen_yonetici_id  FROM tbl_Daireler WITH (NOLOCK) 
INNER JOIN tbl_Binalar ON tbl_Binalar.bina_id=tbl_Daireler.bina_id
INNER JOIN tbl_YoneticiBina ON tbl_YoneticiBina.bina_id=tbl_Daireler.bina_id";

        public ModelCollection<tbl_Daireler> Listele2(bool yetki)
        {
            if (!yetki)
                SQL_LISTE2 = SQL_LISTE2 + " WHERE yonetici_id=" + frmYoneticiGirisi.yoneticiler.Yonetici_id;
            SqlParameter[] parms = new SqlParameter[] { };
            ModelCollection<tbl_Daireler> liste = new ModelCollection<tbl_Daireler>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_LISTE2, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        public ModelCollection<tbl_Daireler> faturaEklenenDaireler(string faturaAdi)
        {
            SqlParameter[] parms = new SqlParameter[] { };
            string sqlSorgu = "select * from tbl_Daireler where daire_no in (select tbl_OrtakFatura.daire_no from tbl_OrtakFatura INNER JOIN"+
                " tbl_FaturaAboneNo On tbl_OrtakFatura.fatura_abone_no = tbl_FaturaAboneNo.fatura_abone_no where tbl_FaturaAboneNo.fatura_turu_id = (select tbl_FaturaTuru.fatura_turu_id"+
                " from tbl_FaturaTuru where tbl_FaturaTuru.fatura_adi = '"+faturaAdi+"' ))";
            ModelCollection<tbl_Daireler> liste = new ModelCollection<tbl_Daireler>();
            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, sqlSorgu, parms))
            {
                liste.PopulateReader(reader);
            }
            return liste;
        }
        private static String SQL_YENI_KAYDET = @"INSERT INTO tbl_Daireler( 
                  daire_no ,
                  bina_id ,
                  daire_oda_sayisi ,
                  daire_metre_kare ,
                  daire_kat_no ,
                  daire_kapi_no ,
                  daire_durumu ,
                  daire_aciklama ,
                  daire_kayit_tarihi ,
                  daire_kayit_eden_yonetici_id ,
                  daire_duzenleme_tarihi ,
                  daire_kayit_duzenleyen_yonetici_id ) VALUES (" + PARM_DAIRE_NO + @"," +
                          PARM_BINA_ID + @"," +
                          PARM_DAIRE_ODA_SAYISI + @"," +
                          PARM_DAIRE_METRE_KARE + @"," +
                          PARM_DAIRE_KAT_NO + @"," +
                          PARM_DAIRE_KAPI_NO + @"," +
                          PARM_DAIRE_DURUMU + @"," +
                          PARM_DAIRE_ACIKLAMA + @"," +
                          PARM_DAIRE_KAYIT_TARIHI + @"," +
                          PARM_DAIRE_KAYIT_EDEN_YONETICI_ID + @"," +
                          PARM_DAIRE_DUZENLEME_TARIHI + @"," +
                          PARM_DAIRE_KAYIT_DUZENLEYEN_YONETICI_ID + @" ) SET  " + PARM_DAIRE_ID + "  = SCOPE_IDENTITY()";
        public int YeniKaydet(tbl_Daireler bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_DAIRE_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_BINA_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_ODA_SAYISI,SqlDbType.VarChar,25),
                        new SqlParameter(PARM_DAIRE_METRE_KARE,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_KAT_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_KAPI_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_DURUMU,SqlDbType.Bit,1),
                        new SqlParameter(PARM_DAIRE_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_DAIRE_KAYIT_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_DAIRE_KAYIT_EDEN_YONETICI_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_DUZENLEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_DAIRE_KAYIT_DUZENLEYEN_YONETICI_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Direction = ParameterDirection.Output;
            parms[index++].Value = Convert.ToInt32(bilgi.bina_id.ToString() + bilgi.daire_kat_no.ToString() + bilgi.daire_kapi_no.ToString());//bilgi.daire_no;
            parms[index++].Value = bilgi.bina_id;
            parms[index++].Value = bilgi.daire_oda_sayisi;
            parms[index++].Value = bilgi.daire_metre_kare;
            parms[index++].Value = bilgi.daire_kat_no;
            parms[index++].Value = bilgi.daire_kapi_no;
            parms[index++].Value = bilgi.daire_durumu;
            parms[index++].Value = bilgi.daire_aciklama;
            parms[index++].Value = DateTime.Now;
            parms[index++].Value = 1;
            parms[index++].Value = DateTime.Now;
            parms[index++].Value = 1;
            SQLHelper.ExecuteNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_YENI_KAYDET, parms);
            return (int)parms[0].Value;
        }
        private static readonly String SQL_GUNCELLE = @"UPDATE tbl_Daireler SET  
                  bina_id = " + PARM_BINA_ID + @", 
                  daire_oda_sayisi = " + PARM_DAIRE_ODA_SAYISI + @", 
                  daire_metre_kare = " + PARM_DAIRE_METRE_KARE + @", 
                  daire_kat_no = " + PARM_DAIRE_KAT_NO + @", 
                  daire_kapi_no = " + PARM_DAIRE_KAPI_NO + @", 
                  daire_durumu = " + PARM_DAIRE_DURUMU + @", 
                  daire_aciklama = " + PARM_DAIRE_ACIKLAMA + @", 
                  daire_duzenleme_tarihi = " + PARM_DAIRE_DUZENLEME_TARIHI + @", 
                  daire_kayit_duzenleyen_yonetici_id = " + PARM_DAIRE_KAYIT_DUZENLEYEN_YONETICI_ID + @" WHERE daire_id = " + PARM_DAIRE_ID;
        public tbl_Daireler Guncelle(tbl_Daireler bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_DAIRE_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_BINA_ID,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_ODA_SAYISI,SqlDbType.VarChar,25),
                        new SqlParameter(PARM_DAIRE_METRE_KARE,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_KAT_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_KAPI_NO,SqlDbType.Int,4),
                        new SqlParameter(PARM_DAIRE_DURUMU,SqlDbType.Bit,1),
                        new SqlParameter(PARM_DAIRE_ACIKLAMA,SqlDbType.NVarChar,1024),
                        new SqlParameter(PARM_DAIRE_DUZENLEME_TARIHI,SqlDbType.DateTime,8),
                        new SqlParameter(PARM_DAIRE_KAYIT_DUZENLEYEN_YONETICI_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi.daire_id;
            parms[index++].Value = bilgi.bina_id;
            parms[index++].Value = bilgi.daire_oda_sayisi;
            parms[index++].Value = bilgi.daire_metre_kare;
            parms[index++].Value = bilgi.daire_kat_no;
            parms[index++].Value = bilgi.daire_kapi_no;
            parms[index++].Value = bilgi.daire_durumu;
            parms[index++].Value = bilgi.daire_aciklama;
            parms[index++].Value = DateTime.Now;
            parms[index++].Value = 1;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_GUNCELLE, parms);
            return bilgi;
        }
        private static readonly String SQL_SIL = @"DELETE FROM tbl_Daireler WHERE daire_id=" + PARM_DAIRE_ID;
        public void Sil(int bilgi)
        {
            SqlParameter[] parms = new SqlParameter[] {
                        new SqlParameter(PARM_DAIRE_ID,SqlDbType.Int,4),
};
            int index = 0;
            parms[index++].Value = bilgi;
            SQLHelper.ExecuteConcurrentNonQuery(SQLHelper.BilisimLibraryDbConnectionString, CommandType.Text, SQL_SIL, parms);
        }
        public DataSet spFaturaOrtakDaire(string aboneNo)
        {
            SqlConnection cnn = new SqlConnection(SQLHelper.BilisimLibraryDbConnectionString);
            SqlCommand cmd = new SqlCommand("[spFaturaOrtakDaire]", cnn);
            cmd.Parameters.AddWithValue("@aboneNo", aboneNo);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            sda.Fill(dt, "tbl_FaturaOrtakDaire");
            cnn.Close();
            return dt;
        }

        public SqlDataReader binaListele2()
        {
            SqlConnection cnn = new SqlConnection(SQLHelper.BilisimLibraryDbConnectionString);
            string sorgu = @"SELECT tbl_Binalar.bina_id, bina_adi FROM dbo.tbl_Binalar
INNER JOIN tbl_YoneticiBina ON tbl_YoneticiBina.bina_id=tbl_Binalar.bina_id 
WHERE yonetici_id=" + frmYoneticiGirisi.yoneticiler.Yonetici_id;

            SqlCommand cmd = new SqlCommand(sorgu, cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader binaListele(bool yetki)
        {
            SqlConnection cnn = new SqlConnection(SQLHelper.BilisimLibraryDbConnectionString);
            string sorgu = @"SELECT DISTINCT tbl_Binalar.bina_id, bina_adi FROM dbo.tbl_Binalar
INNER JOIN tbl_YoneticiBina ON tbl_YoneticiBina.bina_id=tbl_Binalar.bina_id";

            if (!yetki)
                sorgu = sorgu + " WHERE yonetici_id=" + frmYoneticiGirisi.yoneticiler.Yonetici_id;

            SqlCommand cmd = new SqlCommand(sorgu, cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

    }
}
