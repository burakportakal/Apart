namespace ApartYonetim
{
    partial class frmMusteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.aYSDataSet = new ApartYonetim.AYSDataSet();
            this.tbl_MusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MusterilerTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.tbl_MusterilerTableAdapter();
            this.tableAdapterManager = new ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tblMusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colmusteri_tc_kimlik_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_soyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_telefon_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_telefon_no2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_sehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_adres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldaire_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_kayit_tarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_duzenleme_tarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmuster_kayit_duzenleyen_yonetici_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_kayit_eden_yonetici_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_kontrat_baslangic_tarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_kontrat_bitis_tarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_kira_tutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_yetki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusteri_durumu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MusterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusterilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aYSDataSet
            // 
            this.aYSDataSet.DataSetName = "AYSDataSet";
            this.aYSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_MusterilerBindingSource
            // 
            this.tbl_MusterilerBindingSource.DataMember = "tbl_Musteriler";
            this.tbl_MusterilerBindingSource.DataSource = this.aYSDataSet;
            // 
            // tbl_MusterilerTableAdapter
            // 
            this.tbl_MusterilerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_BinalarTableAdapter = null;
            this.tableAdapterManager.tbl_DairelerTableAdapter = null;
            this.tableAdapterManager.tbl_DemirbaslarTableAdapter = null;
            this.tableAdapterManager.tbl_FaturaAboneNoTableAdapter = null;
            this.tableAdapterManager.tbl_FaturaGiderTablosuTableAdapter = null;
            this.tableAdapterManager.tbl_FaturaTuruTableAdapter = null;
            this.tableAdapterManager.tbl_GelirTableAdapter = null;
            this.tableAdapterManager.tbl_GelirTuruTableAdapter = null;
            this.tableAdapterManager.tbl_GiderTableAdapter = null;
            this.tableAdapterManager.tbl_GiderTuruTableAdapter = null;
            this.tableAdapterManager.tbl_KiralarTableAdapter = null;
            this.tableAdapterManager.tbl_MusterilerTableAdapter = this.tbl_MusterilerTableAdapter;
            this.tableAdapterManager.tbl_OrtakFaturaTableAdapter = null;
            this.tableAdapterManager.tbl_YoneticiBinaTableAdapter = null;
            this.tableAdapterManager.tbl_YoneticilerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblMusterilerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 203);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1065, 260);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmusteri_tc_kimlik_no,
            this.colmusteri_adi,
            this.colmusteri_soyadi,
            this.colmusteri_telefon_no,
            this.colmusteri_telefon_no2,
            this.colmusteri_email,
            this.colmusteri_sehir,
            this.colmusteri_adres,
            this.coldaire_no,
            this.colmusteri_aciklama,
            this.colmusteri_kayit_tarihi,
            this.colmusteri_duzenleme_tarihi,
            this.colmuster_kayit_duzenleyen_yonetici_id,
            this.colmusteri_kayit_eden_yonetici_id,
            this.colmusteri_kontrat_baslangic_tarihi,
            this.colmusteri_kontrat_bitis_tarihi,
            this.colmusteri_kira_tutari,
            this.colmusteri_yetki,
            this.colmusteri_durumu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // tblMusterilerBindingSource
            // 
            this.tblMusterilerBindingSource.DataMember = "tbl_Musteriler";
            this.tblMusterilerBindingSource.DataSource = this.aYSDataSet;
            // 
            // colmusteri_tc_kimlik_no
            // 
            this.colmusteri_tc_kimlik_no.Caption = "TC Kimlik No";
            this.colmusteri_tc_kimlik_no.FieldName = "musteri_tc_kimlik_no";
            this.colmusteri_tc_kimlik_no.Name = "colmusteri_tc_kimlik_no";
            this.colmusteri_tc_kimlik_no.Visible = true;
            this.colmusteri_tc_kimlik_no.VisibleIndex = 0;
            this.colmusteri_tc_kimlik_no.Width = 43;
            // 
            // colmusteri_adi
            // 
            this.colmusteri_adi.FieldName = "musteri_adi";
            this.colmusteri_adi.Name = "colmusteri_adi";
            this.colmusteri_adi.Visible = true;
            this.colmusteri_adi.VisibleIndex = 1;
            this.colmusteri_adi.Width = 97;
            // 
            // colmusteri_soyadi
            // 
            this.colmusteri_soyadi.FieldName = "musteri_soyadi";
            this.colmusteri_soyadi.Name = "colmusteri_soyadi";
            this.colmusteri_soyadi.Visible = true;
            this.colmusteri_soyadi.VisibleIndex = 2;
            this.colmusteri_soyadi.Width = 20;
            // 
            // colmusteri_telefon_no
            // 
            this.colmusteri_telefon_no.FieldName = "musteri_telefon_no";
            this.colmusteri_telefon_no.Name = "colmusteri_telefon_no";
            this.colmusteri_telefon_no.Visible = true;
            this.colmusteri_telefon_no.VisibleIndex = 3;
            this.colmusteri_telefon_no.Width = 20;
            // 
            // colmusteri_telefon_no2
            // 
            this.colmusteri_telefon_no2.FieldName = "musteri_telefon_no2";
            this.colmusteri_telefon_no2.Name = "colmusteri_telefon_no2";
            this.colmusteri_telefon_no2.Visible = true;
            this.colmusteri_telefon_no2.VisibleIndex = 4;
            this.colmusteri_telefon_no2.Width = 20;
            // 
            // colmusteri_email
            // 
            this.colmusteri_email.FieldName = "musteri_email";
            this.colmusteri_email.Name = "colmusteri_email";
            this.colmusteri_email.Visible = true;
            this.colmusteri_email.VisibleIndex = 5;
            this.colmusteri_email.Width = 20;
            // 
            // colmusteri_sehir
            // 
            this.colmusteri_sehir.FieldName = "musteri_sehir";
            this.colmusteri_sehir.Name = "colmusteri_sehir";
            this.colmusteri_sehir.Visible = true;
            this.colmusteri_sehir.VisibleIndex = 6;
            this.colmusteri_sehir.Width = 20;
            // 
            // colmusteri_adres
            // 
            this.colmusteri_adres.FieldName = "musteri_adres";
            this.colmusteri_adres.Name = "colmusteri_adres";
            this.colmusteri_adres.Visible = true;
            this.colmusteri_adres.VisibleIndex = 7;
            this.colmusteri_adres.Width = 20;
            // 
            // coldaire_no
            // 
            this.coldaire_no.FieldName = "daire_no";
            this.coldaire_no.Name = "coldaire_no";
            this.coldaire_no.Visible = true;
            this.coldaire_no.VisibleIndex = 8;
            this.coldaire_no.Width = 20;
            // 
            // colmusteri_aciklama
            // 
            this.colmusteri_aciklama.FieldName = "musteri_aciklama";
            this.colmusteri_aciklama.Name = "colmusteri_aciklama";
            this.colmusteri_aciklama.Visible = true;
            this.colmusteri_aciklama.VisibleIndex = 9;
            this.colmusteri_aciklama.Width = 20;
            // 
            // colmusteri_kayit_tarihi
            // 
            this.colmusteri_kayit_tarihi.FieldName = "musteri_kayit_tarihi";
            this.colmusteri_kayit_tarihi.Name = "colmusteri_kayit_tarihi";
            this.colmusteri_kayit_tarihi.Visible = true;
            this.colmusteri_kayit_tarihi.VisibleIndex = 10;
            this.colmusteri_kayit_tarihi.Width = 20;
            // 
            // colmusteri_duzenleme_tarihi
            // 
            this.colmusteri_duzenleme_tarihi.FieldName = "musteri_duzenleme_tarihi";
            this.colmusteri_duzenleme_tarihi.Name = "colmusteri_duzenleme_tarihi";
            this.colmusteri_duzenleme_tarihi.Visible = true;
            this.colmusteri_duzenleme_tarihi.VisibleIndex = 11;
            this.colmusteri_duzenleme_tarihi.Width = 20;
            // 
            // colmuster_kayit_duzenleyen_yonetici_id
            // 
            this.colmuster_kayit_duzenleyen_yonetici_id.FieldName = "muster_kayit_duzenleyen_yonetici_id";
            this.colmuster_kayit_duzenleyen_yonetici_id.Name = "colmuster_kayit_duzenleyen_yonetici_id";
            this.colmuster_kayit_duzenleyen_yonetici_id.Visible = true;
            this.colmuster_kayit_duzenleyen_yonetici_id.VisibleIndex = 12;
            this.colmuster_kayit_duzenleyen_yonetici_id.Width = 20;
            // 
            // colmusteri_kayit_eden_yonetici_id
            // 
            this.colmusteri_kayit_eden_yonetici_id.FieldName = "musteri_kayit_eden_yonetici_id";
            this.colmusteri_kayit_eden_yonetici_id.Name = "colmusteri_kayit_eden_yonetici_id";
            this.colmusteri_kayit_eden_yonetici_id.Visible = true;
            this.colmusteri_kayit_eden_yonetici_id.VisibleIndex = 13;
            this.colmusteri_kayit_eden_yonetici_id.Width = 20;
            // 
            // colmusteri_kontrat_baslangic_tarihi
            // 
            this.colmusteri_kontrat_baslangic_tarihi.FieldName = "musteri_kontrat_baslangic_tarihi";
            this.colmusteri_kontrat_baslangic_tarihi.Name = "colmusteri_kontrat_baslangic_tarihi";
            this.colmusteri_kontrat_baslangic_tarihi.Visible = true;
            this.colmusteri_kontrat_baslangic_tarihi.VisibleIndex = 14;
            this.colmusteri_kontrat_baslangic_tarihi.Width = 20;
            // 
            // colmusteri_kontrat_bitis_tarihi
            // 
            this.colmusteri_kontrat_bitis_tarihi.FieldName = "musteri_kontrat_bitis_tarihi";
            this.colmusteri_kontrat_bitis_tarihi.Name = "colmusteri_kontrat_bitis_tarihi";
            this.colmusteri_kontrat_bitis_tarihi.Visible = true;
            this.colmusteri_kontrat_bitis_tarihi.VisibleIndex = 15;
            this.colmusteri_kontrat_bitis_tarihi.Width = 20;
            // 
            // colmusteri_kira_tutari
            // 
            this.colmusteri_kira_tutari.FieldName = "musteri_kira_tutari";
            this.colmusteri_kira_tutari.Name = "colmusteri_kira_tutari";
            this.colmusteri_kira_tutari.Visible = true;
            this.colmusteri_kira_tutari.VisibleIndex = 16;
            this.colmusteri_kira_tutari.Width = 20;
            // 
            // colmusteri_yetki
            // 
            this.colmusteri_yetki.FieldName = "musteri_yetki";
            this.colmusteri_yetki.Name = "colmusteri_yetki";
            this.colmusteri_yetki.Visible = true;
            this.colmusteri_yetki.VisibleIndex = 17;
            this.colmusteri_yetki.Width = 20;
            // 
            // colmusteri_durumu
            // 
            this.colmusteri_durumu.FieldName = "musteri_durumu";
            this.colmusteri_durumu.Name = "colmusteri_durumu";
            this.colmusteri_durumu.Visible = true;
            this.colmusteri_durumu.VisibleIndex = 18;
            this.colmusteri_durumu.Width = 20;
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 463);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmMusteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MusterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusterilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AYSDataSet aYSDataSet;
        private System.Windows.Forms.BindingSource tbl_MusterilerBindingSource;
        private AYSDataSetTableAdapters.tbl_MusterilerTableAdapter tbl_MusterilerTableAdapter;
        private AYSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource tblMusterilerBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_tc_kimlik_no;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_adi;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_soyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_telefon_no;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_telefon_no2;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_email;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_sehir;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_adres;
        private DevExpress.XtraGrid.Columns.GridColumn coldaire_no;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_kayit_tarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_duzenleme_tarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colmuster_kayit_duzenleyen_yonetici_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_kayit_eden_yonetici_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_kontrat_baslangic_tarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_kontrat_bitis_tarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_kira_tutari;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_yetki;
        private DevExpress.XtraGrid.Columns.GridColumn colmusteri_durumu;
    }
}