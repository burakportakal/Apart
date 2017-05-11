namespace ApartYonetim
{
    partial class frmFaturaGelirKayit
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
            this.gridGelir = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcGelir = new DevExpress.XtraGrid.GridControl();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAboneNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKiraDonemi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGelirTutari = new System.Windows.Forms.TextBox();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDaireKapiNo = new System.Windows.Forms.ComboBox();
            this.cmbBinaAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridGelir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGelir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridGelir
            // 
            this.gridGelir.GridControl = this.gcGelir;
            this.gridGelir.Name = "gridGelir";
            // 
            // gcGelir
            // 
            this.gcGelir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcGelir.Location = new System.Drawing.Point(0, 213);
            this.gcGelir.MainView = this.gridGelir;
            this.gcGelir.Name = "gcGelir";
            this.gcGelir.Size = new System.Drawing.Size(783, 204);
            this.gcGelir.TabIndex = 14;
            this.gcGelir.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGelir});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Abone No:";
            // 
            // txtAboneNo
            // 
            this.txtAboneNo.Location = new System.Drawing.Point(117, 61);
            this.txtAboneNo.Name = "txtAboneNo";
            this.txtAboneNo.Size = new System.Drawing.Size(121, 21);
            this.txtAboneNo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dönemi:";
            // 
            // cmbKiraDonemi
            // 
            this.cmbKiraDonemi.FormattingEnabled = true;
            this.cmbKiraDonemi.Location = new System.Drawing.Point(117, 88);
            this.cmbKiraDonemi.Name = "cmbKiraDonemi";
            this.cmbKiraDonemi.Size = new System.Drawing.Size(121, 21);
            this.cmbKiraDonemi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gelir Tutarı:";
            // 
            // txtGelirTutari
            // 
            this.txtGelirTutari.Location = new System.Drawing.Point(117, 116);
            this.txtGelirTutari.Name = "txtGelirTutari";
            this.txtGelirTutari.Size = new System.Drawing.Size(121, 21);
            this.txtGelirTutari.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Location = new System.Drawing.Point(123, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 33);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTemizle.Location = new System.Drawing.Point(2, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(121, 33);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnKaydet);
            this.panelControl2.Controls.Add(this.btnTemizle);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 172);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(783, 37);
            this.panelControl2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Daire Kapi No:";
            // 
            // cmbDaireKapiNo
            // 
            this.cmbDaireKapiNo.FormattingEnabled = true;
            this.cmbDaireKapiNo.Location = new System.Drawing.Point(117, 34);
            this.cmbDaireKapiNo.Name = "cmbDaireKapiNo";
            this.cmbDaireKapiNo.Size = new System.Drawing.Size(121, 21);
            this.cmbDaireKapiNo.TabIndex = 1;
            // 
            // cmbBinaAdi
            // 
            this.cmbBinaAdi.FormattingEnabled = true;
            this.cmbBinaAdi.Location = new System.Drawing.Point(117, 7);
            this.cmbBinaAdi.Name = "cmbBinaAdi";
            this.cmbBinaAdi.Size = new System.Drawing.Size(121, 21);
            this.cmbBinaAdi.TabIndex = 0;
            this.cmbBinaAdi.SelectedIndexChanged += new System.EventHandler(this.cmbBinaAdi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apart Adi:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.txtAboneNo);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.cmbKiraDonemi);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtGelirTutari);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbDaireKapiNo);
            this.panelControl1.Controls.Add(this.cmbBinaAdi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(783, 172);
            this.panelControl1.TabIndex = 12;
            // 
            // frmFaturaGelirKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 420);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcGelir);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmFaturaGelirKayit";
            this.Text = "frmFaturaGelirKayit";
            this.Load += new System.EventHandler(this.frmFaturaGelirKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGelir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGelir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridGelir;
        private DevExpress.XtraGrid.GridControl gcGelir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAboneNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbKiraDonemi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGelirTutari;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDaireKapiNo;
        private System.Windows.Forms.ComboBox cmbBinaAdi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}