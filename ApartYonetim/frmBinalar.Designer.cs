namespace ApartYonetim
{
    partial class frmBinalar
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
            System.Windows.Forms.Label bina_idLabel;
            System.Windows.Forms.Label bina_adiLabel;
            System.Windows.Forms.Label bina_adresiLabel;
            System.Windows.Forms.Label bina_daire_sayisiLabel;
            System.Windows.Forms.Label bina_irtibat_tel_noLabel;
            System.Windows.Forms.Label bina_irtibat_tel_no2Label;
            System.Windows.Forms.Label bina_aciklamaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBinalar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbcYoneticiler = new DevExpress.XtraEditors.ListBoxControl();
            this.bina_irtibat_tel_no2MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tbl_BinalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aYSDataSet = new ApartYonetim.AYSDataSet();
            this.bina_irtibat_tel_noMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bina_daire_sayisiMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bina_aciklamaTextBox = new System.Windows.Forms.TextBox();
            this.bina_adresiTextBox = new System.Windows.Forms.TextBox();
            this.bina_adiTextBox = new System.Windows.Forms.TextBox();
            this.bina_idTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.gcBinalar = new DevExpress.XtraGrid.GridControl();
            this.gvBinalar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbl_BinalarTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.tbl_BinalarTableAdapter();
            this.tableAdapterManager = new ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager();
            this.clbYoneticiListesi = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            bina_idLabel = new System.Windows.Forms.Label();
            bina_adiLabel = new System.Windows.Forms.Label();
            bina_adresiLabel = new System.Windows.Forms.Label();
            bina_daire_sayisiLabel = new System.Windows.Forms.Label();
            bina_irtibat_tel_noLabel = new System.Windows.Forms.Label();
            bina_irtibat_tel_no2Label = new System.Windows.Forms.Label();
            bina_aciklamaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcYoneticiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BinalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBinalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBinalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbYoneticiListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // bina_idLabel
            // 
            bina_idLabel.AutoSize = true;
            bina_idLabel.Location = new System.Drawing.Point(86, 32);
            bina_idLabel.Name = "bina_idLabel";
            bina_idLabel.Size = new System.Drawing.Size(52, 17);
            bina_idLabel.TabIndex = 0;
            bina_idLabel.Text = "bina id:";
            // 
            // bina_adiLabel
            // 
            bina_adiLabel.AutoSize = true;
            bina_adiLabel.Location = new System.Drawing.Point(79, 61);
            bina_adiLabel.Name = "bina_adiLabel";
            bina_adiLabel.Size = new System.Drawing.Size(59, 17);
            bina_adiLabel.TabIndex = 2;
            bina_adiLabel.Text = "bina adi:";
            // 
            // bina_adresiLabel
            // 
            bina_adresiLabel.AutoSize = true;
            bina_adresiLabel.Location = new System.Drawing.Point(61, 119);
            bina_adresiLabel.Name = "bina_adresiLabel";
            bina_adresiLabel.Size = new System.Drawing.Size(77, 17);
            bina_adresiLabel.TabIndex = 4;
            bina_adresiLabel.Text = "bina adresi:";
            // 
            // bina_daire_sayisiLabel
            // 
            bina_daire_sayisiLabel.AutoSize = true;
            bina_daire_sayisiLabel.Location = new System.Drawing.Point(57, 90);
            bina_daire_sayisiLabel.Name = "bina_daire_sayisiLabel";
            bina_daire_sayisiLabel.Size = new System.Drawing.Size(81, 17);
            bina_daire_sayisiLabel.TabIndex = 6;
            bina_daire_sayisiLabel.Text = "Daire Sayısı:";
            // 
            // bina_irtibat_tel_noLabel
            // 
            bina_irtibat_tel_noLabel.AutoSize = true;
            bina_irtibat_tel_noLabel.Location = new System.Drawing.Point(379, 35);
            bina_irtibat_tel_noLabel.Name = "bina_irtibat_tel_noLabel";
            bina_irtibat_tel_noLabel.Size = new System.Drawing.Size(114, 17);
            bina_irtibat_tel_noLabel.TabIndex = 8;
            bina_irtibat_tel_noLabel.Text = "bina irtibat tel no:";
            // 
            // bina_irtibat_tel_no2Label
            // 
            bina_irtibat_tel_no2Label.AutoSize = true;
            bina_irtibat_tel_no2Label.Location = new System.Drawing.Point(371, 64);
            bina_irtibat_tel_no2Label.Name = "bina_irtibat_tel_no2Label";
            bina_irtibat_tel_no2Label.Size = new System.Drawing.Size(122, 17);
            bina_irtibat_tel_no2Label.TabIndex = 10;
            bina_irtibat_tel_no2Label.Text = "bina irtibat tel no2:";
            // 
            // bina_aciklamaLabel
            // 
            bina_aciklamaLabel.AutoSize = true;
            bina_aciklamaLabel.Location = new System.Drawing.Point(400, 93);
            bina_aciklamaLabel.Name = "bina_aciklamaLabel";
            bina_aciklamaLabel.Size = new System.Drawing.Size(93, 17);
            bina_aciklamaLabel.TabIndex = 12;
            bina_aciklamaLabel.Text = "bina aciklama:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(label2);
            this.groupControl1.Controls.Add(this.clbYoneticiListesi);
            this.groupControl1.Controls.Add(label1);
            this.groupControl1.Controls.Add(this.lbcYoneticiler);
            this.groupControl1.Controls.Add(this.bina_irtibat_tel_no2MaskedTextBox);
            this.groupControl1.Controls.Add(this.bina_irtibat_tel_noMaskedTextBox);
            this.groupControl1.Controls.Add(this.bina_daire_sayisiMaskedTextBox);
            this.groupControl1.Controls.Add(bina_aciklamaLabel);
            this.groupControl1.Controls.Add(this.bina_aciklamaTextBox);
            this.groupControl1.Controls.Add(bina_irtibat_tel_no2Label);
            this.groupControl1.Controls.Add(bina_irtibat_tel_noLabel);
            this.groupControl1.Controls.Add(bina_daire_sayisiLabel);
            this.groupControl1.Controls.Add(bina_adresiLabel);
            this.groupControl1.Controls.Add(this.bina_adresiTextBox);
            this.groupControl1.Controls.Add(bina_adiLabel);
            this.groupControl1.Controls.Add(this.bina_adiTextBox);
            this.groupControl1.Controls.Add(bina_idLabel);
            this.groupControl1.Controls.Add(this.bina_idTextBox);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1455, 205);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Bina İşlemleri";
            // 
            // lbcYoneticiler
            // 
            this.lbcYoneticiler.Location = new System.Drawing.Point(746, 58);
            this.lbcYoneticiler.Name = "lbcYoneticiler";
            this.lbcYoneticiler.Size = new System.Drawing.Size(113, 127);
            this.lbcYoneticiler.TabIndex = 19;
            // 
            // bina_irtibat_tel_no2MaskedTextBox
            // 
            this.bina_irtibat_tel_no2MaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_BinalarBindingSource, "bina_irtibat_tel_no2", true));
            this.bina_irtibat_tel_no2MaskedTextBox.Location = new System.Drawing.Point(499, 61);
            this.bina_irtibat_tel_no2MaskedTextBox.Mask = "(999) 000-0000";
            this.bina_irtibat_tel_no2MaskedTextBox.Name = "bina_irtibat_tel_no2MaskedTextBox";
            this.bina_irtibat_tel_no2MaskedTextBox.Size = new System.Drawing.Size(200, 23);
            this.bina_irtibat_tel_no2MaskedTextBox.TabIndex = 17;
            // 
            // tbl_BinalarBindingSource
            // 
            this.tbl_BinalarBindingSource.DataMember = "tbl_Binalar";
            this.tbl_BinalarBindingSource.DataSource = this.aYSDataSet;
            // 
            // aYSDataSet
            // 
            this.aYSDataSet.DataSetName = "AYSDataSet";
            this.aYSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bina_irtibat_tel_noMaskedTextBox
            // 
            this.bina_irtibat_tel_noMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_BinalarBindingSource, "bina_irtibat_tel_no", true));
            this.bina_irtibat_tel_noMaskedTextBox.Location = new System.Drawing.Point(499, 32);
            this.bina_irtibat_tel_noMaskedTextBox.Mask = "(999) 000-0000";
            this.bina_irtibat_tel_noMaskedTextBox.Name = "bina_irtibat_tel_noMaskedTextBox";
            this.bina_irtibat_tel_noMaskedTextBox.Size = new System.Drawing.Size(200, 23);
            this.bina_irtibat_tel_noMaskedTextBox.TabIndex = 16;
            // 
            // bina_daire_sayisiMaskedTextBox
            // 
            this.bina_daire_sayisiMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_BinalarBindingSource, "bina_daire_sayisi", true));
            this.bina_daire_sayisiMaskedTextBox.Location = new System.Drawing.Point(144, 87);
            this.bina_daire_sayisiMaskedTextBox.Mask = "0000";
            this.bina_daire_sayisiMaskedTextBox.Name = "bina_daire_sayisiMaskedTextBox";
            this.bina_daire_sayisiMaskedTextBox.Size = new System.Drawing.Size(200, 23);
            this.bina_daire_sayisiMaskedTextBox.TabIndex = 15;
            // 
            // bina_aciklamaTextBox
            // 
            this.bina_aciklamaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_BinalarBindingSource, "bina_aciklama", true));
            this.bina_aciklamaTextBox.Location = new System.Drawing.Point(499, 90);
            this.bina_aciklamaTextBox.Multiline = true;
            this.bina_aciklamaTextBox.Name = "bina_aciklamaTextBox";
            this.bina_aciklamaTextBox.Size = new System.Drawing.Size(200, 95);
            this.bina_aciklamaTextBox.TabIndex = 13;
            // 
            // bina_adresiTextBox
            // 
            this.bina_adresiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_BinalarBindingSource, "bina_adresi", true));
            this.bina_adresiTextBox.Location = new System.Drawing.Point(144, 116);
            this.bina_adresiTextBox.Multiline = true;
            this.bina_adresiTextBox.Name = "bina_adresiTextBox";
            this.bina_adresiTextBox.Size = new System.Drawing.Size(200, 69);
            this.bina_adresiTextBox.TabIndex = 5;
            // 
            // bina_adiTextBox
            // 
            this.bina_adiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_BinalarBindingSource, "bina_adi", true));
            this.bina_adiTextBox.Location = new System.Drawing.Point(144, 58);
            this.bina_adiTextBox.Name = "bina_adiTextBox";
            this.bina_adiTextBox.Size = new System.Drawing.Size(200, 23);
            this.bina_adiTextBox.TabIndex = 3;
            // 
            // bina_idTextBox
            // 
            this.bina_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_BinalarBindingSource, "bina_id", true));
            this.bina_idTextBox.Enabled = false;
            this.bina_idTextBox.Location = new System.Drawing.Point(144, 29);
            this.bina_idTextBox.Name = "bina_idTextBox";
            this.bina_idTextBox.Size = new System.Drawing.Size(200, 23);
            this.bina_idTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnVazgec);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 45);
            this.panel1.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Location = new System.Drawing.Point(510, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 45);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVazgec.Location = new System.Drawing.Point(377, 0);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(133, 45);
            this.btnVazgec.TabIndex = 8;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuncelle.Location = new System.Drawing.Point(244, 0);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(133, 45);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.Location = new System.Drawing.Point(111, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 45);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYeni.Location = new System.Drawing.Point(0, 0);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(111, 45);
            this.btnYeni.TabIndex = 5;
            this.btnYeni.Text = "Yeni ";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // gcBinalar
            // 
            this.gcBinalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBinalar.Location = new System.Drawing.Point(0, 250);
            this.gcBinalar.MainView = this.gvBinalar;
            this.gcBinalar.Name = "gcBinalar";
            this.gcBinalar.Size = new System.Drawing.Size(1455, 403);
            this.gcBinalar.TabIndex = 3;
            this.gcBinalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBinalar});
            // 
            // gvBinalar
            // 
            this.gvBinalar.GridControl = this.gcBinalar;
            this.gvBinalar.Name = "gvBinalar";
            this.gvBinalar.OptionsBehavior.Editable = false;
            this.gvBinalar.OptionsBehavior.ReadOnly = true;
            this.gvBinalar.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvBinalar_FocusedRowChanged);
            // 
            // tbl_BinalarTableAdapter
            // 
            this.tbl_BinalarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_BinalarTableAdapter = this.tbl_BinalarTableAdapter;
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
            this.tableAdapterManager.tbl_MusterilerTableAdapter = null;
            this.tableAdapterManager.tbl_OrtakFaturaTableAdapter = null;
            this.tableAdapterManager.tbl_YoneticiBinaTableAdapter = null;
            this.tableAdapterManager.tbl_YoneticilerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(746, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 17);
            label1.TabIndex = 20;
            label1.Text = "Yetkili Yöneticiler:";
            // 
            // clbYoneticiListesi
            // 
            this.clbYoneticiListesi.Location = new System.Drawing.Point(1021, 58);
            this.clbYoneticiListesi.Name = "clbYoneticiListesi";
            this.clbYoneticiListesi.Size = new System.Drawing.Size(116, 127);
            this.clbYoneticiListesi.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1023, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 17);
            label2.TabIndex = 22;
            label2.Text = "Yönetici Listesi:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(879, 58);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 43);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "Yetki Ver";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(879, 121);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(119, 43);
            this.simpleButton2.TabIndex = 23;
            this.simpleButton2.Text = "Yetki Ver";
            // 
            // frmBinalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 653);
            this.Controls.Add(this.gcBinalar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmBinalar";
            this.Text = "Bina İşlemleri";
            this.Load += new System.EventHandler(this.frmBinalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcYoneticiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BinalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBinalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBinalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbYoneticiListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcBinalar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBinalar;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private AYSDataSet aYSDataSet;
        private System.Windows.Forms.BindingSource tbl_BinalarBindingSource;
        private AYSDataSetTableAdapters.tbl_BinalarTableAdapter tbl_BinalarTableAdapter;
        private AYSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox bina_aciklamaTextBox;
        private System.Windows.Forms.TextBox bina_adresiTextBox;
        private System.Windows.Forms.TextBox bina_adiTextBox;
        private System.Windows.Forms.TextBox bina_idTextBox;
        private System.Windows.Forms.MaskedTextBox bina_daire_sayisiMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox bina_irtibat_tel_no2MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox bina_irtibat_tel_noMaskedTextBox;
        private DevExpress.XtraEditors.ListBoxControl lbcYoneticiler;
        private DevExpress.XtraEditors.CheckedListBoxControl clbYoneticiListesi;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}