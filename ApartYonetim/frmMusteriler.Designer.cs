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
            ((System.ComponentModel.ISupportInitialize)(this.grSorgula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSorgulama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MusterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GelirTuruBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grSorgula
            // 
            this.grSorgula.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grSorgula.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grSorgula.Location = new System.Drawing.Point(0, 203);
            this.grSorgula.MainView = this.gridSorgulama;
            this.grSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grSorgula.Name = "grSorgula";
            this.grSorgula.Size = new System.Drawing.Size(1065, 260);
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
            this.cmbBinaAdi.Location = new System.Drawing.Point(49, 51);
            this.cmbBinaAdi.Name = "cmbBinaAdi";
            this.cmbBinaAdi.Size = new System.Drawing.Size(121, 21);
            this.cmbBinaAdi.TabIndex = 1;
            this.cmbBinaAdi.SelectedIndexChanged += new System.EventHandler(this.bina_adiComboBox_SelectedIndexChanged);
            // 
            // lblApartAdi
            // 
            this.lblApartAdi.AutoSize = true;
            this.lblApartAdi.Location = new System.Drawing.Point(50, 32);
            this.lblApartAdi.Name = "lblApartAdi";
            this.lblApartAdi.Size = new System.Drawing.Size(52, 13);
            this.lblApartAdi.TabIndex = 2;
            this.lblApartAdi.Text = "Apart Adı";
            // 
            // chkYetkili
            // 
            this.chkYetkili.AutoSize = true;
            this.chkYetkili.Location = new System.Drawing.Point(50, 87);
            this.chkYetkili.Name = "chkYetkili";
            this.chkYetkili.Size = new System.Drawing.Size(120, 17);
            this.chkYetkili.TabIndex = 3;
            this.chkYetkili.Text = "Sadece yetkili kişiler";
            this.chkYetkili.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(189, 128);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(121, 29);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbDaireKapiNo
            // 
            this.cmbDaireKapiNo.FormattingEnabled = true;
            this.cmbDaireKapiNo.Location = new System.Drawing.Point(189, 51);
            this.cmbDaireKapiNo.Name = "cmbDaireKapiNo";
            this.cmbDaireKapiNo.Size = new System.Drawing.Size(121, 21);
            this.cmbDaireKapiNo.TabIndex = 5;
            // 
            // lblDaireNo
            // 
            this.lblDaireNo.AutoSize = true;
            this.lblDaireNo.Location = new System.Drawing.Point(186, 32);
            this.lblDaireNo.Name = "lblDaireNo";
            this.lblDaireNo.Size = new System.Drawing.Size(71, 13);
            this.lblDaireNo.TabIndex = 6;
            this.lblDaireNo.Text = "Daire Kapı No";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(49, 128);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(121, 29);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 463);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblDaireNo);
            this.Controls.Add(this.cmbDaireKapiNo);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.chkYetkili);
            this.Controls.Add(this.lblApartAdi);
            this.Controls.Add(this.cmbBinaAdi);
            this.Controls.Add(this.grSorgula);
            this.Name = "frmMusteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grSorgula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSorgulama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MusterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GelirTuruBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}