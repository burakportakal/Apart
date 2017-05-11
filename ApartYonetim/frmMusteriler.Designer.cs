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
            this.grSorgula = new DevExpress.XtraGrid.GridControl();
            this.gridSorgulama = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.aYSDataSet = new ApartYonetim.AYSDataSet();
            this.tbl_MusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MusterilerTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.tbl_MusterilerTableAdapter();
            this.tableAdapterManager = new ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager();
            this.tbl_GelirTuruTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.tbl_GelirTuruTableAdapter();
            this.tbl_GelirTuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbBinaAdi = new System.Windows.Forms.ComboBox();
            this.lblApartAdi = new System.Windows.Forms.Label();
            this.chkYetkili = new System.Windows.Forms.CheckBox();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDaireKapiNo = new System.Windows.Forms.ComboBox();
            this.lblDaireNo = new System.Windows.Forms.Label();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkKayitli = new System.Windows.Forms.CheckBox();
            this.chkKiraDurumu = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKiraDonemi = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGelirKayit = new DevExpress.XtraEditors.SimpleButton();
            this.btnBorclandir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grSorgula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSorgulama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MusterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GelirTuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grSorgula
            // 
            this.grSorgula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grSorgula.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grSorgula.Location = new System.Drawing.Point(0, 314);
            this.grSorgula.MainView = this.gridSorgulama;
            this.grSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grSorgula.Name = "grSorgula";
            this.grSorgula.Size = new System.Drawing.Size(1059, 354);
            this.grSorgula.TabIndex = 0;
            this.grSorgula.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSorgulama});
            // 
            // gridSorgulama
            // 
            this.gridSorgulama.GridControl = this.grSorgula;
            this.gridSorgulama.Name = "gridSorgulama";
            this.gridSorgulama.OptionsBehavior.Editable = false;
            this.gridSorgulama.OptionsBehavior.ReadOnly = true;
            this.gridSorgulama.OptionsView.ShowFooter = true;
            this.gridSorgulama.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
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
            this.tableAdapterManager.tbl_GelirTuruTableAdapter = this.tbl_GelirTuruTableAdapter;
            this.tableAdapterManager.tbl_GiderTableAdapter = null;
            this.tableAdapterManager.tbl_GiderTuruTableAdapter = null;
            this.tableAdapterManager.tbl_KiralarTableAdapter = null;
            this.tableAdapterManager.tbl_MusterilerTableAdapter = this.tbl_MusterilerTableAdapter;
            this.tableAdapterManager.tbl_OrtakFaturaTableAdapter = null;
            this.tableAdapterManager.tbl_YoneticiBinaTableAdapter = null;
            this.tableAdapterManager.tbl_YoneticilerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_GelirTuruTableAdapter
            // 
            this.tbl_GelirTuruTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_GelirTuruBindingSource
            // 
            this.tbl_GelirTuruBindingSource.DataMember = "tbl_GelirTuru";
            this.tbl_GelirTuruBindingSource.DataSource = this.aYSDataSet;
            // 
            // cmbBinaAdi
            // 
            this.cmbBinaAdi.FormattingEnabled = true;
            this.cmbBinaAdi.Location = new System.Drawing.Point(138, 62);
            this.cmbBinaAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBinaAdi.Name = "cmbBinaAdi";
            this.cmbBinaAdi.Size = new System.Drawing.Size(140, 24);
            this.cmbBinaAdi.TabIndex = 1;
            this.cmbBinaAdi.SelectedIndexChanged += new System.EventHandler(this.bina_adiComboBox_SelectedIndexChanged);
            // 
            // lblApartAdi
            // 
            this.lblApartAdi.AutoSize = true;
            this.lblApartAdi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartAdi.Location = new System.Drawing.Point(65, 62);
            this.lblApartAdi.Name = "lblApartAdi";
            this.lblApartAdi.Size = new System.Drawing.Size(68, 17);
            this.lblApartAdi.TabIndex = 2;
            this.lblApartAdi.Text = "Apart Adı:";
            // 
            // chkYetkili
            // 
            this.chkYetkili.AutoSize = true;
            this.chkYetkili.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYetkili.Location = new System.Drawing.Point(138, 126);
            this.chkYetkili.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkYetkili.Name = "chkYetkili";
            this.chkYetkili.Size = new System.Drawing.Size(146, 21);
            this.chkYetkili.TabIndex = 3;
            this.chkYetkili.Text = "Sadece yetkili kişiler";
            this.chkYetkili.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Appearance.Options.UseFont = true;
            this.btnAra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAra.Location = new System.Drawing.Point(143, 2);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(141, 46);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbDaireKapiNo
            // 
            this.cmbDaireKapiNo.FormattingEnabled = true;
            this.cmbDaireKapiNo.Location = new System.Drawing.Point(138, 92);
            this.cmbDaireKapiNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDaireKapiNo.Name = "cmbDaireKapiNo";
            this.cmbDaireKapiNo.Size = new System.Drawing.Size(140, 24);
            this.cmbDaireKapiNo.TabIndex = 5;
            // 
            // lblDaireNo
            // 
            this.lblDaireNo.AutoSize = true;
            this.lblDaireNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaireNo.Location = new System.Drawing.Point(43, 92);
            this.lblDaireNo.Name = "lblDaireNo";
            this.lblDaireNo.Size = new System.Drawing.Size(94, 17);
            this.lblDaireNo.TabIndex = 6;
            this.lblDaireNo.Text = "Daire Kapı No:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTemizle.Location = new System.Drawing.Point(2, 2);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(141, 46);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkKayitli);
            this.groupControl1.Controls.Add(this.chkKiraDurumu);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cmbKiraDonemi);
            this.groupControl1.Controls.Add(this.cmbBinaAdi);
            this.groupControl1.Controls.Add(this.lblDaireNo);
            this.groupControl1.Controls.Add(this.lblApartAdi);
            this.groupControl1.Controls.Add(this.cmbDaireKapiNo);
            this.groupControl1.Controls.Add(this.chkYetkili);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1059, 266);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Filtreleme";
            // 
            // chkKayitli
            // 
            this.chkKayitli.AutoSize = true;
            this.chkKayitli.Location = new System.Drawing.Point(138, 185);
            this.chkKayitli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkKayitli.Name = "chkKayitli";
            this.chkKayitli.Size = new System.Drawing.Size(148, 21);
            this.chkKayitli.TabIndex = 11;
            this.chkKayitli.Text = "Sadece Kayıtlı Kişiler";
            this.chkKayitli.UseVisualStyleBackColor = true;
            // 
            // chkKiraDurumu
            // 
            this.chkKiraDurumu.AutoSize = true;
            this.chkKiraDurumu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKiraDurumu.Location = new System.Drawing.Point(138, 155);
            this.chkKiraDurumu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkKiraDurumu.Name = "chkKiraDurumu";
            this.chkKiraDurumu.Size = new System.Drawing.Size(107, 21);
            this.chkKiraDurumu.TabIndex = 10;
            this.chkKiraDurumu.Text = "Kira Durumu";
            this.chkKiraDurumu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kira Dönemi:";
            // 
            // cmbKiraDonemi
            // 
            this.cmbKiraDonemi.FormattingEnabled = true;
            this.cmbKiraDonemi.Location = new System.Drawing.Point(138, 28);
            this.cmbKiraDonemi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKiraDonemi.Name = "cmbKiraDonemi";
            this.cmbKiraDonemi.Size = new System.Drawing.Size(140, 24);
            this.cmbKiraDonemi.TabIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnBorclandir);
            this.panelControl1.Controls.Add(this.btnGelirKayit);
            this.panelControl1.Controls.Add(this.btnAra);
            this.panelControl1.Controls.Add(this.btnTemizle);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 266);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1059, 50);
            this.panelControl1.TabIndex = 9;
            // 
            // btnGelirKayit
            // 
            this.btnGelirKayit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGelirKayit.Location = new System.Drawing.Point(284, 2);
            this.btnGelirKayit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGelirKayit.Name = "btnGelirKayit";
            this.btnGelirKayit.Size = new System.Drawing.Size(141, 46);
            this.btnGelirKayit.TabIndex = 8;
            this.btnGelirKayit.Text = "Gelir Kaydet";
            this.btnGelirKayit.Click += new System.EventHandler(this.btnGelirKayit_Click);
            // 
            // btnBorclandir
            // 
            this.btnBorclandir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBorclandir.Location = new System.Drawing.Point(425, 2);
            this.btnBorclandir.Name = "btnBorclandir";
            this.btnBorclandir.Size = new System.Drawing.Size(141, 46);
            this.btnBorclandir.TabIndex = 9;
            this.btnBorclandir.Text = "Borçlandır";
            this.btnBorclandir.Click += new System.EventHandler(this.btnBorclandir_Click);
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 668);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grSorgula);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMusteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grSorgula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSorgulama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MusterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GelirTuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grSorgula;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSorgulama;
        private AYSDataSet aYSDataSet;
        private System.Windows.Forms.BindingSource tbl_MusterilerBindingSource;
        private AYSDataSetTableAdapters.tbl_MusterilerTableAdapter tbl_MusterilerTableAdapter;
        private AYSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AYSDataSetTableAdapters.tbl_GelirTuruTableAdapter tbl_GelirTuruTableAdapter;
        private System.Windows.Forms.BindingSource tbl_GelirTuruBindingSource;
        private System.Windows.Forms.ComboBox cmbBinaAdi;
        private System.Windows.Forms.Label lblApartAdi;
        private System.Windows.Forms.CheckBox chkYetkili;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private System.Windows.Forms.ComboBox cmbDaireKapiNo;
        private System.Windows.Forms.Label lblDaireNo;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKiraDonemi;
        private System.Windows.Forms.CheckBox chkKiraDurumu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGelirKayit;
        private System.Windows.Forms.CheckBox chkKayitli;
        private DevExpress.XtraEditors.SimpleButton btnBorclandir;
    }
}