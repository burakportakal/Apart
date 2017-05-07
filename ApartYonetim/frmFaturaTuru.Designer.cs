namespace ApartYonetim
{
    partial class frmFaturaTuru
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
            System.Windows.Forms.Label fatura_adiLabel;
            this.groupFatura = new DevExpress.XtraEditors.GroupControl();
            this.fatura_adiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tbl_FaturaTuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aYSDataSet = new ApartYonetim.AYSDataSet();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.tbl_FaturaTuruTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.tbl_FaturaTuruTableAdapter();
            this.tableAdapterManager = new ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager();
            this.tblFaturaTuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcFaturaTuru = new DevExpress.XtraGrid.GridControl();
            this.gvFaturaTuru = new DevExpress.XtraGrid.Views.Grid.GridView();
            fatura_adiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupFatura)).BeginInit();
            this.groupFatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fatura_adiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_FaturaTuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaturaTuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFaturaTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFaturaTuru)).BeginInit();
            this.SuspendLayout();
            // 
            // fatura_adiLabel
            // 
            fatura_adiLabel.AutoSize = true;
            fatura_adiLabel.Location = new System.Drawing.Point(28, 40);
            fatura_adiLabel.Name = "fatura_adiLabel";
            fatura_adiLabel.Size = new System.Drawing.Size(64, 13);
            fatura_adiLabel.TabIndex = 0;
            fatura_adiLabel.Text = "Fatura Adi :";
            // 
            // groupFatura
            // 
            this.groupFatura.Controls.Add(fatura_adiLabel);
            this.groupFatura.Controls.Add(this.fatura_adiTextEdit);
            this.groupFatura.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFatura.Location = new System.Drawing.Point(0, 0);
            this.groupFatura.Name = "groupFatura";
            this.groupFatura.Size = new System.Drawing.Size(609, 127);
            this.groupFatura.TabIndex = 0;
            this.groupFatura.Text = "Fatura Adı";
            // 
            // fatura_adiTextEdit
            // 
            this.fatura_adiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbl_FaturaTuruBindingSource, "fatura_adi", true));
            this.fatura_adiTextEdit.Location = new System.Drawing.Point(92, 37);
            this.fatura_adiTextEdit.Name = "fatura_adiTextEdit";
            this.fatura_adiTextEdit.Size = new System.Drawing.Size(100, 20);
            this.fatura_adiTextEdit.TabIndex = 1;
            // 
            // tbl_FaturaTuruBindingSource
            // 
            this.tbl_FaturaTuruBindingSource.DataMember = "tbl_FaturaTuru";
            this.tbl_FaturaTuruBindingSource.DataSource = this.aYSDataSet;
            // 
            // aYSDataSet
            // 
            this.aYSDataSet.DataSetName = "AYSDataSet";
            this.aYSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnKaydet);
            this.panelControl2.Controls.Add(this.btnVazgec);
            this.panelControl2.Controls.Add(this.btnGuncelle);
            this.panelControl2.Controls.Add(this.btnSil);
            this.panelControl2.Controls.Add(this.btnYeni);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 127);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(609, 37);
            this.panelControl2.TabIndex = 11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Location = new System.Drawing.Point(486, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 33);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.Appearance.Options.UseFont = true;
            this.btnVazgec.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVazgec.Location = new System.Drawing.Point(365, 2);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(121, 33);
            this.btnVazgec.TabIndex = 7;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuncelle.Location = new System.Drawing.Point(244, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 33);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.Location = new System.Drawing.Point(123, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 33);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            // 
            // btnYeni
            // 
            this.btnYeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYeni.Location = new System.Drawing.Point(2, 2);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(121, 33);
            this.btnYeni.TabIndex = 10;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // tbl_FaturaTuruTableAdapter
            // 
            this.tbl_FaturaTuruTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_BinalarTableAdapter = null;
            this.tableAdapterManager.tbl_DairelerTableAdapter = null;
            this.tableAdapterManager.tbl_DemirbaslarTableAdapter = null;
            this.tableAdapterManager.tbl_FaturaAboneNoTableAdapter = null;
            this.tableAdapterManager.tbl_FaturaGiderTablosuTableAdapter = null;
            this.tableAdapterManager.tbl_FaturaTuruTableAdapter = this.tbl_FaturaTuruTableAdapter;
            this.tableAdapterManager.tbl_GelirTableAdapter = null;
            this.tableAdapterManager.tbl_GelirTuruTableAdapter = null;
            this.tableAdapterManager.tbl_GiderTableAdapter = null;
            this.tableAdapterManager.tbl_GiderTuruTableAdapter = null;
            this.tableAdapterManager.tbl_KiralarTableAdapter = null;
            this.tableAdapterManager.tbl_MusterilerTableAdapter = null;
            this.tableAdapterManager.tbl_OrtakFaturaTableAdapter = null;
            this.tableAdapterManager.tbl_YoneticiBinaTableAdapter = null;
            this.tableAdapterManager.tbl_YoneticilerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblFaturaTuruBindingSource
            // 
            this.tblFaturaTuruBindingSource.DataMember = "tbl_FaturaTuru";
            this.tblFaturaTuruBindingSource.DataSource = this.aYSDataSet;
            // 
            // gcFaturaTuru
            // 
            this.gcFaturaTuru.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFaturaTuru.Location = new System.Drawing.Point(0, 168);
            this.gcFaturaTuru.MainView = this.gvFaturaTuru;
            this.gcFaturaTuru.Name = "gcFaturaTuru";
            this.gcFaturaTuru.Size = new System.Drawing.Size(607, 174);
            this.gcFaturaTuru.TabIndex = 12;
            this.gcFaturaTuru.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFaturaTuru});
            // 
            // gvFaturaTuru
            // 
            this.gvFaturaTuru.GridControl = this.gcFaturaTuru;
            this.gvFaturaTuru.Name = "gvFaturaTuru";
            this.gvFaturaTuru.OptionsView.ColumnAutoWidth = false;
            this.gvFaturaTuru.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvFaturaTuru_FocusedRowChanged);
            // 
            // frmFaturaTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 342);
            this.Controls.Add(this.gcFaturaTuru);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupFatura);
            this.Name = "frmFaturaTuru";
            this.Text = "Fatura Türü";
            this.Load += new System.EventHandler(this.frmFaturaTuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupFatura)).EndInit();
            this.groupFatura.ResumeLayout(false);
            this.groupFatura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fatura_adiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_FaturaTuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblFaturaTuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFaturaTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFaturaTuru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupFatura;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private AYSDataSet aYSDataSet;
        private System.Windows.Forms.BindingSource tbl_FaturaTuruBindingSource;
        private AYSDataSetTableAdapters.tbl_FaturaTuruTableAdapter tbl_FaturaTuruTableAdapter;
        private AYSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit fatura_adiTextEdit;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private System.Windows.Forms.BindingSource tblFaturaTuruBindingSource;
        private DevExpress.XtraGrid.GridControl gcFaturaTuru;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFaturaTuru;
    }
}