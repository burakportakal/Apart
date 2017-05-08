namespace ApartYonetim
{
    partial class frmFaturaSorgula
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
            System.Windows.Forms.Label bina_AdıLabel;
            System.Windows.Forms.Label fatura_AdıLabel;
            this.groupFatura = new DevExpress.XtraEditors.GroupControl();
            this.prgSorgulama = new System.Windows.Forms.ProgressBar();
            this.bina_AdıComboBox = new System.Windows.Forms.ComboBox();
            this.fatura_AdıComboBox = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSorgula = new DevExpress.XtraEditors.SimpleButton();
            this.gcFatura = new DevExpress.XtraGrid.GridControl();
            this.gvFatura = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblSorgulama = new System.Windows.Forms.Label();
            bina_AdıLabel = new System.Windows.Forms.Label();
            fatura_AdıLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupFatura)).BeginInit();
            this.groupFatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFatura)).BeginInit();
            this.SuspendLayout();
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
            // fatura_AdıLabel
            // 
            fatura_AdıLabel.AutoSize = true;
            fatura_AdıLabel.Location = new System.Drawing.Point(30, 36);
            fatura_AdıLabel.Name = "fatura_AdıLabel";
            fatura_AdıLabel.Size = new System.Drawing.Size(61, 13);
            fatura_AdıLabel.TabIndex = 0;
            fatura_AdıLabel.Text = "Fatura Adı:";
            // 
            // groupFatura
            // 
            this.groupFatura.Controls.Add(this.lblSorgulama);
            this.groupFatura.Controls.Add(this.prgSorgulama);
            this.groupFatura.Controls.Add(bina_AdıLabel);
            this.groupFatura.Controls.Add(this.bina_AdıComboBox);
            this.groupFatura.Controls.Add(fatura_AdıLabel);
            this.groupFatura.Controls.Add(this.fatura_AdıComboBox);
            this.groupFatura.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFatura.Location = new System.Drawing.Point(0, 0);
            this.groupFatura.Name = "groupFatura";
            this.groupFatura.Size = new System.Drawing.Size(908, 221);
            this.groupFatura.TabIndex = 1;
            this.groupFatura.Text = "Fatura";
            // 
            // prgSorgulama
            // 
            this.prgSorgulama.Location = new System.Drawing.Point(12, 193);
            this.prgSorgulama.Name = "prgSorgulama";
            this.prgSorgulama.Size = new System.Drawing.Size(884, 23);
            this.prgSorgulama.TabIndex = 6;
            // 
            // bina_AdıComboBox
            // 
            this.bina_AdıComboBox.FormattingEnabled = true;
            this.bina_AdıComboBox.Location = new System.Drawing.Point(97, 60);
            this.bina_AdıComboBox.Name = "bina_AdıComboBox";
            this.bina_AdıComboBox.Size = new System.Drawing.Size(121, 21);
            this.bina_AdıComboBox.TabIndex = 5;
            // 
            // fatura_AdıComboBox
            // 
            this.fatura_AdıComboBox.FormattingEnabled = true;
            this.fatura_AdıComboBox.Location = new System.Drawing.Point(97, 33);
            this.fatura_AdıComboBox.Name = "fatura_AdıComboBox";
            this.fatura_AdıComboBox.Size = new System.Drawing.Size(121, 21);
            this.fatura_AdıComboBox.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSorgula);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 221);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(908, 37);
            this.panelControl1.TabIndex = 4;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSorgula.Location = new System.Drawing.Point(2, 2);
            this.btnSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(114, 33);
            this.btnSorgula.TabIndex = 4;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
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
            this.gcFatura.TabIndex = 5;
            this.gcFatura.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFatura});
            // 
            // gvFatura
            // 
            this.gvFatura.GridControl = this.gcFatura;
            this.gvFatura.Name = "gvFatura";
            // 
            // lblSorgulama
            // 
            this.lblSorgulama.AutoSize = true;
            this.lblSorgulama.Location = new System.Drawing.Point(33, 174);
            this.lblSorgulama.Name = "lblSorgulama";
            this.lblSorgulama.Size = new System.Drawing.Size(0, 13);
            this.lblSorgulama.TabIndex = 7;
            // 
            // frmFaturaSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 555);
            this.Controls.Add(this.gcFatura);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupFatura);
            this.Name = "frmFaturaSorgula";
            this.Text = "frmFaturaSorgula";
            this.Load += new System.EventHandler(this.frmFaturaSorgula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupFatura)).EndInit();
            this.groupFatura.ResumeLayout(false);
            this.groupFatura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupFatura;
        private System.Windows.Forms.ComboBox bina_AdıComboBox;
        private System.Windows.Forms.ComboBox fatura_AdıComboBox;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSorgula;
        private DevExpress.XtraGrid.GridControl gcFatura;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFatura;
        private System.Windows.Forms.ProgressBar prgSorgulama;
        private System.Windows.Forms.Label lblSorgulama;
    }
}