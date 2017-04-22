namespace ApartYonetim
{
    partial class frmYoneticiGirisi
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
            this.btnYoneticiGirisi = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtYoneticiAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtYoneticiParola = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYoneticiAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYoneticiParola.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYoneticiGirisi
            // 
            this.btnYoneticiGirisi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnYoneticiGirisi.Appearance.Options.UseFont = true;
            this.btnYoneticiGirisi.Location = new System.Drawing.Point(239, 162);
            this.btnYoneticiGirisi.Name = "btnYoneticiGirisi";
            this.btnYoneticiGirisi.Size = new System.Drawing.Size(113, 33);
            this.btnYoneticiGirisi.TabIndex = 0;
            this.btnYoneticiGirisi.Text = "Giriş";
            this.btnYoneticiGirisi.Click += new System.EventHandler(this.btnYoneticiGirisi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 54);
            this.panel1.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Location = new System.Drawing.Point(342, 10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(10, 20);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "X";
            this.labelControl4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelControl4_MouseClick);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Location = new System.Drawing.Point(85, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(222, 33);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "AYS Yönetici Girisi";
            // 
            // txtYoneticiAdi
            // 
            this.txtYoneticiAdi.Location = new System.Drawing.Point(150, 90);
            this.txtYoneticiAdi.Name = "txtYoneticiAdi";
            this.txtYoneticiAdi.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtYoneticiAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiAdi.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtYoneticiAdi.Properties.Appearance.Options.UseBackColor = true;
            this.txtYoneticiAdi.Properties.Appearance.Options.UseFont = true;
            this.txtYoneticiAdi.Properties.Appearance.Options.UseForeColor = true;
            this.txtYoneticiAdi.Properties.Mask.EditMask = "dgdgd";
            this.txtYoneticiAdi.Size = new System.Drawing.Size(202, 28);
            this.txtYoneticiAdi.TabIndex = 1;
            // 
            // txtYoneticiParola
            // 
            this.txtYoneticiParola.Location = new System.Drawing.Point(150, 128);
            this.txtYoneticiParola.Name = "txtYoneticiParola";
            this.txtYoneticiParola.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtYoneticiParola.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiParola.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtYoneticiParola.Properties.Appearance.Options.UseBackColor = true;
            this.txtYoneticiParola.Properties.Appearance.Options.UseFont = true;
            this.txtYoneticiParola.Properties.Appearance.Options.UseForeColor = true;
            this.txtYoneticiParola.Size = new System.Drawing.Size(202, 28);
            this.txtYoneticiParola.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(38, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yönetici Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yönetici Parola:";
            // 
            // frmYoneticiGirisi
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(376, 218);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYoneticiParola);
            this.Controls.Add(this.txtYoneticiAdi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnYoneticiGirisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYoneticiGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AYS Yönetici Girişi";
            this.Load += new System.EventHandler(this.frmYoneticiGirisi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYoneticiAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYoneticiParola.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnYoneticiGirisi;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtYoneticiAdi;
        private DevExpress.XtraEditors.TextEdit txtYoneticiParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}