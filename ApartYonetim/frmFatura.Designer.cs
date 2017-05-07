namespace ApartYonetim
{
    partial class frmFatura
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
            System.Windows.Forms.Label fatura_AdıLabel;
            System.Windows.Forms.Label abone_NoLabel;
            System.Windows.Forms.Label bina_AdıLabel;
            this.groupFatura = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.chkListDaire = new System.Windows.Forms.CheckedListBox();
            this.bina_AdıComboBox = new System.Windows.Forms.ComboBox();
            this.abone_NoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fatura_AdıComboBox = new System.Windows.Forms.ComboBox();
            this.aYSDataSet = new ApartYonetim.AYSDataSet();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.gcFatura = new DevExpress.XtraGrid.GridControl();
            this.gvFatura = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnFaturaTuru = new DevExpress.XtraEditors.SimpleButton();
            fatura_AdıLabel = new System.Windows.Forms.Label();
            abone_NoLabel = new System.Windows.Forms.Label();
            bina_AdıLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupFatura)).BeginInit();
            this.groupFatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abone_NoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFatura)).BeginInit();
            this.SuspendLayout();
            // 
            // fatura_AdıLabel
            // 
            fatura_AdıLabel.AutoSize = true;
            fatura_AdıLabel.Location = new System.Drawing.Point(30, 36);
            fatura_AdıLabel.Name = "fatura_AdıLabel";
            fatura_AdıLabel.Size = new System.Drawing.Size(61, 13);
            fatura_AdıLabel.TabIndex = 0;
            fatura_AdıLabel.Text = "Fatura Adı:";
            // 
            // abone_NoLabel
            // 
            abone_NoLabel.AutoSize = true;
            abone_NoLabel.Location = new System.Drawing.Point(33, 90);
            abone_NoLabel.Name = "abone_NoLabel";
            abone_NoLabel.Size = new System.Drawing.Size(58, 13);
            abone_NoLabel.TabIndex = 2;
            abone_NoLabel.Text = "Abone No:";
            // 
            // bina_AdıLabel
            // 
            bina_AdıLabel.AutoSize = true;
            bina_AdıLabel.Location = new System.Drawing.Point(42, 63);
            bina_AdıLabel.Name = "bina_AdıLabel";
            bina_AdıLabel.Size = new System.Drawing.Size(49, 13);
            bina_AdıLabel.TabIndex = 4;
            bina_AdıLabel.Text = "Bina Adı:";
            // 
            // groupFatura
            // 
            this.groupFatura.Controls.Add(this.label1);
            this.groupFatura.Controls.Add(this.chkListDaire);
            this.groupFatura.Controls.Add(bina_AdıLabel);
            this.groupFatura.Controls.Add(this.bina_AdıComboBox);
            this.groupFatura.Controls.Add(abone_NoLabel);
            this.groupFatura.Controls.Add(this.abone_NoTextEdit);
            this.groupFatura.Controls.Add(fatura_AdıLabel);
            this.groupFatura.Controls.Add(this.fatura_AdıComboBox);
            this.groupFatura.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFatura.Location = new System.Drawing.Point(0, 0);
            this.groupFatura.Name = "groupFatura";
            this.groupFatura.Size = new System.Drawing.Size(908, 221);
            this.groupFatura.TabIndex = 0;
            this.groupFatura.Text = "Fatura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ortak Kullanım:";
            // 
            // chkListDaire
            // 
            this.chkListDaire.FormattingEnabled = true;
            this.chkListDaire.Location = new System.Drawing.Point(325, 33);
            this.chkListDaire.Name = "chkListDaire";
            this.chkListDaire.Size = new System.Drawing.Size(89, 100);
            this.chkListDaire.TabIndex = 6;
            // 
            // bina_AdıComboBox
            // 
            this.bina_AdıComboBox.FormattingEnabled = true;
            this.bina_AdıComboBox.Location = new System.Drawing.Point(97, 60);
            this.bina_AdıComboBox.Name = "bina_AdıComboBox";
            this.bina_AdıComboBox.Size = new System.Drawing.Size(121, 21);
            this.bina_AdıComboBox.TabIndex = 5;
            this.bina_AdıComboBox.SelectedIndexChanged += new System.EventHandler(this.bina_AdıComboBox_SelectedIndexChanged);
            // 
            // abone_NoTextEdit
            // 
            this.abone_NoTextEdit.Location = new System.Drawing.Point(97, 87);
            this.abone_NoTextEdit.Name = "abone_NoTextEdit";
            this.abone_NoTextEdit.Size = new System.Drawing.Size(121, 20);
            this.abone_NoTextEdit.TabIndex = 3;
            // 
            // fatura_AdıComboBox
            // 
            this.fatura_AdıComboBox.FormattingEnabled = true;
            this.fatura_AdıComboBox.Location = new System.Drawing.Point(97, 33);
            this.fatura_AdıComboBox.Name = "fatura_AdıComboBox";
            this.fatura_AdıComboBox.Size = new System.Drawing.Size(121, 21);
            this.fatura_AdıComboBox.TabIndex = 1;
            this.fatura_AdıComboBox.SelectedIndexChanged += new System.EventHandler(this.fatura_AdıComboBox_SelectedIndexChanged);
            // 
            // aYSDataSet
            // 
            this.aYSDataSet.DataSetName = "AYSDataSet";
            this.aYSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnFaturaTuru);
            this.panelControl1.Controls.Add(this.btnKaydet);
            this.panelControl1.Controls.Add(this.btnVazgec);
            this.panelControl1.Controls.Add(this.btnGuncelle);
            this.panelControl1.Controls.Add(this.btnSil);
            this.panelControl1.Controls.Add(this.btnYeni);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 221);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(908, 37);
            this.panelControl1.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Location = new System.Drawing.Point(458, 2);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(114, 33);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVazgec.Location = new System.Drawing.Point(344, 2);
            this.btnVazgec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(114, 33);
            this.btnVazgec.TabIndex = 3;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuncelle.Location = new System.Drawing.Point(230, 2);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(114, 33);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.Location = new System.Drawing.Point(116, 2);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 33);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            // 
            // btnYeni
            // 
            this.btnYeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYeni.Location = new System.Drawing.Point(2, 2);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(114, 33);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni ";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // gcFatura
            // 
            this.gcFatura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFatura.Location = new System.Drawing.Point(0, 261);
            this.gcFatura.MainView = this.gvFatura;
            this.gcFatura.Name = "gcFatura";
            this.gcFatura.Size = new System.Drawing.Size(908, 298);
            this.gcFatura.TabIndex = 4;
            this.gcFatura.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFatura});
            // 
            // gvFatura
            // 
            this.gvFatura.GridControl = this.gcFatura;
            this.gvFatura.Name = "gvFatura";
            this.gvFatura.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvFatura_FocusedRowChanged);
            // 
            // btnFaturaTuru
            // 
            this.btnFaturaTuru.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFaturaTuru.Location = new System.Drawing.Point(572, 2);
            this.btnFaturaTuru.Name = "btnFaturaTuru";
            this.btnFaturaTuru.Size = new System.Drawing.Size(114, 33);
            this.btnFaturaTuru.TabIndex = 5;
            this.btnFaturaTuru.Text = "Fatura Türü Ekle";
            this.btnFaturaTuru.Click += new System.EventHandler(this.btnFaturaTuru_Click);
            // 
            // frmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 555);
            this.Controls.Add(this.gcFatura);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupFatura);
            this.Name = "frmFatura";
            this.Text = "Fatura İşlemleri";
            this.Load += new System.EventHandler(this.frmFatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupFatura)).EndInit();
            this.groupFatura.ResumeLayout(false);
            this.groupFatura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abone_NoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupFatura;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraGrid.GridControl gcFatura;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFatura;
        private AYSDataSet aYSDataSet;
        private System.Windows.Forms.ComboBox bina_AdıComboBox;
        private DevExpress.XtraEditors.TextEdit abone_NoTextEdit;
        private System.Windows.Forms.ComboBox fatura_AdıComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListDaire;
        private DevExpress.XtraEditors.SimpleButton btnFaturaTuru;
    }
}