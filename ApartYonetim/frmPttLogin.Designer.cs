namespace ApartYonetim
{
    partial class frmPttLogin
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
            this.chkBeniHatirla = new System.Windows.Forms.CheckBox();
            this.lblBekle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSms = new System.Windows.Forms.Label();
            this.btnSms = new System.Windows.Forms.Button();
            this.txtSms = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chkBeniHatirla
            // 
            this.chkBeniHatirla.AutoSize = true;
            this.chkBeniHatirla.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBeniHatirla.Location = new System.Drawing.Point(178, 131);
            this.chkBeniHatirla.Name = "chkBeniHatirla";
            this.chkBeniHatirla.Size = new System.Drawing.Size(80, 17);
            this.chkBeniHatirla.TabIndex = 23;
            this.chkBeniHatirla.Text = "Beni Hatırla";
            this.chkBeniHatirla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBeniHatirla.UseVisualStyleBackColor = true;
            this.chkBeniHatirla.CheckedChanged += new System.EventHandler(this.chkBeniHatirla_CheckedChanged);
            // 
            // lblBekle
            // 
            this.lblBekle.AutoSize = true;
            this.lblBekle.Location = new System.Drawing.Point(20, 110);
            this.lblBekle.Name = "lblBekle";
            this.lblBekle.Size = new System.Drawing.Size(0, 13);
            this.lblBekle.TabIndex = 22;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(104, 45);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 21;
            this.lblTime.Visible = false;
            // 
            // lblSms
            // 
            this.lblSms.AutoSize = true;
            this.lblSms.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSms.Location = new System.Drawing.Point(23, 17);
            this.lblSms.Name = "lblSms";
            this.lblSms.Size = new System.Drawing.Size(75, 15);
            this.lblSms.TabIndex = 20;
            this.lblSms.Text = "Sms şifresi :";
            this.lblSms.Visible = false;
            // 
            // btnSms
            // 
            this.btnSms.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSms.FlatAppearance.BorderSize = 0;
            this.btnSms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSms.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSms.Location = new System.Drawing.Point(183, 47);
            this.btnSms.Name = "btnSms";
            this.btnSms.Size = new System.Drawing.Size(75, 35);
            this.btnSms.TabIndex = 19;
            this.btnSms.Text = "Gönder";
            this.btnSms.UseVisualStyleBackColor = false;
            this.btnSms.Visible = false;
            this.btnSms.Click += new System.EventHandler(this.btnSms_Click);
            // 
            // txtSms
            // 
            this.txtSms.Location = new System.Drawing.Point(104, 15);
            this.txtSms.Name = "txtSms";
            this.txtSms.Size = new System.Drawing.Size(154, 21);
            this.txtSms.TabIndex = 18;
            this.txtSms.Visible = false;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(54, 43);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(41, 15);
            this.lblSifre.TabIndex = 17;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteri.Location = new System.Drawing.Point(20, 17);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(78, 15);
            this.lblMusteri.TabIndex = 16;
            this.lblMusteri.Text = "Müşteri No :";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(104, 42);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(154, 21);
            this.txtSifre.TabIndex = 15;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(104, 15);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(154, 21);
            this.txtMusteriNo.TabIndex = 14;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(183, 88);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 35);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            // 
            // frmPttLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 162);
            this.Controls.Add(this.chkBeniHatirla);
            this.Controls.Add(this.lblBekle);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSms);
            this.Controls.Add(this.btnSms);
            this.Controls.Add(this.txtSms);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.btnLogin);
            this.MaximizeBox = false;
            this.Name = "frmPttLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPttLogin";
            this.Load += new System.EventHandler(this.frmPttLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBeniHatirla;
        private System.Windows.Forms.Label lblBekle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSms;
        private System.Windows.Forms.Button btnSms;
        private System.Windows.Forms.TextBox txtSms;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Timer tmr;
    }
}