namespace ApartYonetim
{
    partial class frmMusteriEkleme
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
            System.Windows.Forms.Label musteri_idLabel;
            System.Windows.Forms.Label musteri_tc_kimlik_noLabel;
            System.Windows.Forms.Label musteri_adiLabel;
            System.Windows.Forms.Label musteri_soyadiLabel;
            System.Windows.Forms.Label musteri_telefon_noLabel;
            System.Windows.Forms.Label musteri_telefon_no2Label;
            System.Windows.Forms.Label musteri_emailLabel;
            System.Windows.Forms.Label musteri_sehirLabel;
            System.Windows.Forms.Label musteri_adresLabel;
            System.Windows.Forms.Label musteri_aciklamaLabel;
            System.Windows.Forms.Label musteri_kira_tutariLabel;
            System.Windows.Forms.Label musteri_yetkiLabel;
            System.Windows.Forms.Label musteri_durumuLabel;
            System.Windows.Forms.Label musteri_kontrat_baslangic_tarihiLabel;
            System.Windows.Forms.Label musteri_kontrat_bitis_tarihiLabel;
            System.Windows.Forms.Label bina_adiLabel;
            System.Windows.Forms.Label daire_noLabel;
            this.aYSDataSet = new ApartYonetim.AYSDataSet();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.groupMusteri = new DevExpress.XtraEditors.GroupControl();
            this.daire_noComboBox = new System.Windows.Forms.ComboBox();
            this.bina_adiComboBox = new System.Windows.Forms.ComboBox();
            this.musteri_kontrat_bitis_tarihiDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.spMusteriDaireBinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteri_kontrat_baslangic_tarihiDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.musteri_durumuCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.musteri_yetkiCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.musteri_kira_tutariSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.musteri_aciklamaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.musteri_adresTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.musteri_sehirTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.musteri_emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.musteri_telefon_no2TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.musteri_telefon_noTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.musteri_soyadiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.musteri_adiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.musteri_tc_kimlik_noTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.musteri_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.spMusteriDaireBinaTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.spMusteriDaireBinaTableAdapter();
            this.tableAdapterManager = new ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager();
            this.tbl_MusterilerTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.tbl_MusterilerTableAdapter();
            this.gcMusteriler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTCKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colŞehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaireKapıNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApartAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAçıklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKontratBaşlangıç = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKontratBitiş = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKiraMiktarı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbl_MusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daire_NoTextEdit = new DevExpress.XtraEditors.TextEdit();
            musteri_idLabel = new System.Windows.Forms.Label();
            musteri_tc_kimlik_noLabel = new System.Windows.Forms.Label();
            musteri_adiLabel = new System.Windows.Forms.Label();
            musteri_soyadiLabel = new System.Windows.Forms.Label();
            musteri_telefon_noLabel = new System.Windows.Forms.Label();
            musteri_telefon_no2Label = new System.Windows.Forms.Label();
            musteri_emailLabel = new System.Windows.Forms.Label();
            musteri_sehirLabel = new System.Windows.Forms.Label();
            musteri_adresLabel = new System.Windows.Forms.Label();
            musteri_aciklamaLabel = new System.Windows.Forms.Label();
            musteri_kira_tutariLabel = new System.Windows.Forms.Label();
            musteri_yetkiLabel = new System.Windows.Forms.Label();
            musteri_durumuLabel = new System.Windows.Forms.Label();
            musteri_kontrat_baslangic_tarihiLabel = new System.Windows.Forms.Label();
            musteri_kontrat_bitis_tarihiLabel = new System.Windows.Forms.Label();
            bina_adiLabel = new System.Windows.Forms.Label();
            daire_noLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupMusteri)).BeginInit();
            this.groupMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_kontrat_bitis_tarihiDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_kontrat_bitis_tarihiDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMusteriDaireBinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_kontrat_baslangic_tarihiDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_kontrat_baslangic_tarihiDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_durumuCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_yetkiCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_kira_tutariSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_aciklamaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_adresTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_sehirTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_telefon_no2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_telefon_noTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_soyadiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_adiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_tc_kimlik_noTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MusterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daire_NoTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // musteri_idLabel
            // 
            musteri_idLabel.AutoSize = true;
            musteri_idLabel.Location = new System.Drawing.Point(55, 26);
            musteri_idLabel.Name = "musteri_idLabel";
            musteri_idLabel.Size = new System.Drawing.Size(57, 13);
            musteri_idLabel.TabIndex = 0;
            musteri_idLabel.Text = "Musteri id:";
            // 
            // musteri_tc_kimlik_noLabel
            // 
            musteri_tc_kimlik_noLabel.AutoSize = true;
            musteri_tc_kimlik_noLabel.Location = new System.Drawing.Point(6, 52);
            musteri_tc_kimlik_noLabel.Name = "musteri_tc_kimlik_noLabel";
            musteri_tc_kimlik_noLabel.Size = new System.Drawing.Size(106, 13);
            musteri_tc_kimlik_noLabel.TabIndex = 2;
            musteri_tc_kimlik_noLabel.Text = "Musteri TC Kimlik No:";
            // 
            // musteri_adiLabel
            // 
            musteri_adiLabel.AutoSize = true;
            musteri_adiLabel.Location = new System.Drawing.Point(48, 79);
            musteri_adiLabel.Name = "musteri_adiLabel";
            musteri_adiLabel.Size = new System.Drawing.Size(64, 13);
            musteri_adiLabel.TabIndex = 4;
            musteri_adiLabel.Text = "Müşteri Adı:";
            // 
            // musteri_soyadiLabel
            // 
            musteri_soyadiLabel.AutoSize = true;
            musteri_soyadiLabel.Location = new System.Drawing.Point(31, 104);
            musteri_soyadiLabel.Name = "musteri_soyadiLabel";
            musteri_soyadiLabel.Size = new System.Drawing.Size(81, 13);
            musteri_soyadiLabel.TabIndex = 6;
            musteri_soyadiLabel.Text = "Müşteri Soyadı:";
            // 
            // musteri_telefon_noLabel
            // 
            musteri_telefon_noLabel.AutoSize = true;
            musteri_telefon_noLabel.Location = new System.Drawing.Point(49, 130);
            musteri_telefon_noLabel.Name = "musteri_telefon_noLabel";
            musteri_telefon_noLabel.Size = new System.Drawing.Size(63, 13);
            musteri_telefon_noLabel.TabIndex = 8;
            musteri_telefon_noLabel.Text = "Telefon No:";
            // 
            // musteri_telefon_no2Label
            // 
            musteri_telefon_no2Label.AutoSize = true;
            musteri_telefon_no2Label.Location = new System.Drawing.Point(40, 156);
            musteri_telefon_no2Label.Name = "musteri_telefon_no2Label";
            musteri_telefon_no2Label.Size = new System.Drawing.Size(72, 13);
            musteri_telefon_no2Label.TabIndex = 10;
            musteri_telefon_no2Label.Text = "Telefon No 2:";
            // 
            // musteri_emailLabel
            // 
            musteri_emailLabel.AutoSize = true;
            musteri_emailLabel.Location = new System.Drawing.Point(284, 26);
            musteri_emailLabel.Name = "musteri_emailLabel";
            musteri_emailLabel.Size = new System.Drawing.Size(35, 13);
            musteri_emailLabel.TabIndex = 12;
            musteri_emailLabel.Text = "Email:";
            // 
            // musteri_sehirLabel
            // 
            musteri_sehirLabel.AutoSize = true;
            musteri_sehirLabel.Location = new System.Drawing.Point(242, 52);
            musteri_sehirLabel.Name = "musteri_sehirLabel";
            musteri_sehirLabel.Size = new System.Drawing.Size(77, 13);
            musteri_sehirLabel.TabIndex = 14;
            musteri_sehirLabel.Text = "Yaşadığı Şehir:";
            // 
            // musteri_adresLabel
            // 
            musteri_adresLabel.AutoSize = true;
            musteri_adresLabel.Location = new System.Drawing.Point(278, 78);
            musteri_adresLabel.Name = "musteri_adresLabel";
            musteri_adresLabel.Size = new System.Drawing.Size(41, 13);
            musteri_adresLabel.TabIndex = 16;
            musteri_adresLabel.Text = "Adresi:";
            // 
            // musteri_aciklamaLabel
            // 
            musteri_aciklamaLabel.AutoSize = true;
            musteri_aciklamaLabel.Location = new System.Drawing.Point(511, 22);
            musteri_aciklamaLabel.Name = "musteri_aciklamaLabel";
            musteri_aciklamaLabel.Size = new System.Drawing.Size(52, 13);
            musteri_aciklamaLabel.TabIndex = 20;
            musteri_aciklamaLabel.Text = "Açıklama:";
            // 
            // musteri_kira_tutariLabel
            // 
            musteri_kira_tutariLabel.AutoSize = true;
            musteri_kira_tutariLabel.Location = new System.Drawing.Point(256, 158);
            musteri_kira_tutariLabel.Name = "musteri_kira_tutariLabel";
            musteri_kira_tutariLabel.Size = new System.Drawing.Size(63, 13);
            musteri_kira_tutariLabel.TabIndex = 22;
            musteri_kira_tutariLabel.Text = "Kira Miktarı:";
            // 
            // musteri_yetkiLabel
            // 
            musteri_yetkiLabel.AutoSize = true;
            musteri_yetkiLabel.Location = new System.Drawing.Point(529, 100);
            musteri_yetkiLabel.Name = "musteri_yetkiLabel";
            musteri_yetkiLabel.Size = new System.Drawing.Size(34, 13);
            musteri_yetkiLabel.TabIndex = 24;
            musteri_yetkiLabel.Text = "Yetki:";
            // 
            // musteri_durumuLabel
            // 
            musteri_durumuLabel.AutoSize = true;
            musteri_durumuLabel.Location = new System.Drawing.Point(515, 126);
            musteri_durumuLabel.Name = "musteri_durumuLabel";
            musteri_durumuLabel.Size = new System.Drawing.Size(48, 13);
            musteri_durumuLabel.TabIndex = 26;
            musteri_durumuLabel.Text = "Durumu:";
            // 
            // musteri_kontrat_baslangic_tarihiLabel
            // 
            musteri_kontrat_baslangic_tarihiLabel.AutoSize = true;
            musteri_kontrat_baslangic_tarihiLabel.Location = new System.Drawing.Point(440, 48);
            musteri_kontrat_baslangic_tarihiLabel.Name = "musteri_kontrat_baslangic_tarihiLabel";
            musteri_kontrat_baslangic_tarihiLabel.Size = new System.Drawing.Size(123, 13);
            musteri_kontrat_baslangic_tarihiLabel.TabIndex = 28;
            musteri_kontrat_baslangic_tarihiLabel.Text = "Kontrat Başlangıç Tarihi:";
            // 
            // musteri_kontrat_bitis_tarihiLabel
            // 
            musteri_kontrat_bitis_tarihiLabel.AutoSize = true;
            musteri_kontrat_bitis_tarihiLabel.Location = new System.Drawing.Point(465, 74);
            musteri_kontrat_bitis_tarihiLabel.Name = "musteri_kontrat_bitis_tarihiLabel";
            musteri_kontrat_bitis_tarihiLabel.Size = new System.Drawing.Size(98, 13);
            musteri_kontrat_bitis_tarihiLabel.TabIndex = 30;
            musteri_kontrat_bitis_tarihiLabel.Text = "Kontrat Bitiş Tarihi:";
            // 
            // bina_adiLabel
            // 
            bina_adiLabel.AutoSize = true;
            bina_adiLabel.Location = new System.Drawing.Point(271, 104);
            bina_adiLabel.Name = "bina_adiLabel";
            bina_adiLabel.Size = new System.Drawing.Size(48, 13);
            bina_adiLabel.TabIndex = 31;
            bina_adiLabel.Text = "bina adi:";
            // 
            // daire_noLabel
            // 
            daire_noLabel.AutoSize = true;
            daire_noLabel.Location = new System.Drawing.Point(269, 130);
            daire_noLabel.Name = "daire_noLabel";
            daire_noLabel.Size = new System.Drawing.Size(50, 13);
            daire_noLabel.TabIndex = 32;
            daire_noLabel.Text = "daire no:";
            // 
            // aYSDataSet
            // 
            this.aYSDataSet.DataSetName = "AYSDataSet";
            this.aYSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
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
            this.panelControl1.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Location = new System.Drawing.Point(439, 2);
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
            this.btnVazgec.Location = new System.Drawing.Point(325, 2);
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
            this.btnGuncelle.Location = new System.Drawing.Point(211, 2);
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
            this.btnSil.Location = new System.Drawing.Point(97, 2);
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
            this.btnYeni.Size = new System.Drawing.Size(95, 33);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni ";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // groupMusteri
            // 
            this.groupMusteri.Controls.Add(this.bina_adiComboBox);
            this.groupMusteri.Controls.Add(daire_noLabel);
            this.groupMusteri.Controls.Add(this.daire_noComboBox);
            this.groupMusteri.Controls.Add(bina_adiLabel);
            this.groupMusteri.Controls.Add(musteri_kontrat_bitis_tarihiLabel);
            this.groupMusteri.Controls.Add(this.musteri_kontrat_bitis_tarihiDateEdit);
            this.groupMusteri.Controls.Add(musteri_kontrat_baslangic_tarihiLabel);
            this.groupMusteri.Controls.Add(this.musteri_kontrat_baslangic_tarihiDateEdit);
            this.groupMusteri.Controls.Add(musteri_durumuLabel);
            this.groupMusteri.Controls.Add(this.musteri_durumuCheckEdit);
            this.groupMusteri.Controls.Add(musteri_yetkiLabel);
            this.groupMusteri.Controls.Add(this.musteri_yetkiCheckEdit);
            this.groupMusteri.Controls.Add(musteri_kira_tutariLabel);
            this.groupMusteri.Controls.Add(this.musteri_kira_tutariSpinEdit);
            this.groupMusteri.Controls.Add(musteri_aciklamaLabel);
            this.groupMusteri.Controls.Add(this.musteri_aciklamaTextEdit);
            this.groupMusteri.Controls.Add(musteri_adresLabel);
            this.groupMusteri.Controls.Add(this.musteri_adresTextEdit);
            this.groupMusteri.Controls.Add(musteri_sehirLabel);
            this.groupMusteri.Controls.Add(this.musteri_sehirTextEdit);
            this.groupMusteri.Controls.Add(musteri_emailLabel);
            this.groupMusteri.Controls.Add(this.musteri_emailTextEdit);
            this.groupMusteri.Controls.Add(musteri_telefon_no2Label);
            this.groupMusteri.Controls.Add(this.musteri_telefon_no2TextEdit);
            this.groupMusteri.Controls.Add(musteri_telefon_noLabel);
            this.groupMusteri.Controls.Add(this.musteri_telefon_noTextEdit);
            this.groupMusteri.Controls.Add(musteri_soyadiLabel);
            this.groupMusteri.Controls.Add(this.musteri_soyadiTextEdit);
            this.groupMusteri.Controls.Add(musteri_adiLabel);
            this.groupMusteri.Controls.Add(this.musteri_adiTextEdit);
            this.groupMusteri.Controls.Add(musteri_tc_kimlik_noLabel);
            this.groupMusteri.Controls.Add(this.musteri_tc_kimlik_noTextEdit);
            this.groupMusteri.Controls.Add(musteri_idLabel);
            this.groupMusteri.Controls.Add(this.musteri_idSpinEdit);
            this.groupMusteri.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupMusteri.Location = new System.Drawing.Point(0, 0);
            this.groupMusteri.Name = "groupMusteri";
            this.groupMusteri.Size = new System.Drawing.Size(908, 221);
            this.groupMusteri.TabIndex = 3;
            this.groupMusteri.Text = "Müsteri Bilgileri";
            // 
            // daire_noComboBox
            // 
            this.daire_noComboBox.FormattingEnabled = true;
            this.daire_noComboBox.Location = new System.Drawing.Point(325, 128);
            this.daire_noComboBox.Name = "daire_noComboBox";
            this.daire_noComboBox.Size = new System.Drawing.Size(100, 21);
            this.daire_noComboBox.TabIndex = 33;
            this.daire_noComboBox.SelectedIndexChanged += new System.EventHandler(this.daire_noComboBox_SelectedIndexChanged);
            // 
            // bina_adiComboBox
            // 
            this.bina_adiComboBox.FormattingEnabled = true;
            this.bina_adiComboBox.Location = new System.Drawing.Point(325, 101);
            this.bina_adiComboBox.Name = "bina_adiComboBox";
            this.bina_adiComboBox.Size = new System.Drawing.Size(100, 21);
            this.bina_adiComboBox.TabIndex = 32;
            this.bina_adiComboBox.SelectedIndexChanged += new System.EventHandler(this.bina_adiComboBox_SelectedIndexChanged);
            // 
            // musteri_kontrat_bitis_tarihiDateEdit
            // 
            this.musteri_kontrat_bitis_tarihiDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Kontrat Bitiş", true));
            this.musteri_kontrat_bitis_tarihiDateEdit.EditValue = null;
            this.musteri_kontrat_bitis_tarihiDateEdit.Location = new System.Drawing.Point(569, 71);
            this.musteri_kontrat_bitis_tarihiDateEdit.Name = "musteri_kontrat_bitis_tarihiDateEdit";
            this.musteri_kontrat_bitis_tarihiDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.musteri_kontrat_bitis_tarihiDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.musteri_kontrat_bitis_tarihiDateEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_kontrat_bitis_tarihiDateEdit.TabIndex = 31;
            // 
            // spMusteriDaireBinaBindingSource
            // 
            this.spMusteriDaireBinaBindingSource.DataMember = "spMusteriDaireBina";
            this.spMusteriDaireBinaBindingSource.DataSource = this.aYSDataSet;
            // 
            // musteri_kontrat_baslangic_tarihiDateEdit
            // 
            this.musteri_kontrat_baslangic_tarihiDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Kontrat Başlangıç", true));
            this.musteri_kontrat_baslangic_tarihiDateEdit.EditValue = null;
            this.musteri_kontrat_baslangic_tarihiDateEdit.Location = new System.Drawing.Point(569, 45);
            this.musteri_kontrat_baslangic_tarihiDateEdit.Name = "musteri_kontrat_baslangic_tarihiDateEdit";
            this.musteri_kontrat_baslangic_tarihiDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.musteri_kontrat_baslangic_tarihiDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.musteri_kontrat_baslangic_tarihiDateEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_kontrat_baslangic_tarihiDateEdit.TabIndex = 29;
            // 
            // musteri_durumuCheckEdit
            // 
            this.musteri_durumuCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Durumu", true));
            this.musteri_durumuCheckEdit.Location = new System.Drawing.Point(569, 124);
            this.musteri_durumuCheckEdit.Name = "musteri_durumuCheckEdit";
            this.musteri_durumuCheckEdit.Properties.Caption = "Apartta Kayıtlı";
            this.musteri_durumuCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.musteri_durumuCheckEdit.TabIndex = 27;
            // 
            // musteri_yetkiCheckEdit
            // 
            this.musteri_yetkiCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Yetkili", true));
            this.musteri_yetkiCheckEdit.Location = new System.Drawing.Point(569, 98);
            this.musteri_yetkiCheckEdit.Name = "musteri_yetkiCheckEdit";
            this.musteri_yetkiCheckEdit.Properties.Caption = "Yetkili Kişi";
            this.musteri_yetkiCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.musteri_yetkiCheckEdit.TabIndex = 25;
            // 
            // musteri_kira_tutariSpinEdit
            // 
            this.musteri_kira_tutariSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Kira Miktarı", true));
            this.musteri_kira_tutariSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.musteri_kira_tutariSpinEdit.Location = new System.Drawing.Point(325, 155);
            this.musteri_kira_tutariSpinEdit.Name = "musteri_kira_tutariSpinEdit";
            this.musteri_kira_tutariSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.musteri_kira_tutariSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_kira_tutariSpinEdit.TabIndex = 23;
            // 
            // musteri_aciklamaTextEdit
            // 
            this.musteri_aciklamaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Açıklama", true));
            this.musteri_aciklamaTextEdit.Location = new System.Drawing.Point(569, 19);
            this.musteri_aciklamaTextEdit.Name = "musteri_aciklamaTextEdit";
            this.musteri_aciklamaTextEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_aciklamaTextEdit.TabIndex = 21;
            // 
            // musteri_adresTextEdit
            // 
            this.musteri_adresTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Adres", true));
            this.musteri_adresTextEdit.Location = new System.Drawing.Point(325, 75);
            this.musteri_adresTextEdit.Name = "musteri_adresTextEdit";
            this.musteri_adresTextEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_adresTextEdit.TabIndex = 17;
            // 
            // musteri_sehirTextEdit
            // 
            this.musteri_sehirTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Şehir", true));
            this.musteri_sehirTextEdit.Location = new System.Drawing.Point(325, 49);
            this.musteri_sehirTextEdit.Name = "musteri_sehirTextEdit";
            this.musteri_sehirTextEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_sehirTextEdit.TabIndex = 15;
            // 
            // musteri_emailTextEdit
            // 
            this.musteri_emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Email", true));
            this.musteri_emailTextEdit.Location = new System.Drawing.Point(325, 23);
            this.musteri_emailTextEdit.Name = "musteri_emailTextEdit";
            this.musteri_emailTextEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_emailTextEdit.TabIndex = 13;
            // 
            // musteri_telefon_no2TextEdit
            // 
            this.musteri_telefon_no2TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Telefon 2", true));
            this.musteri_telefon_no2TextEdit.Location = new System.Drawing.Point(118, 153);
            this.musteri_telefon_no2TextEdit.Name = "musteri_telefon_no2TextEdit";
            this.musteri_telefon_no2TextEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_telefon_no2TextEdit.TabIndex = 11;
            // 
            // musteri_telefon_noTextEdit
            // 
            this.musteri_telefon_noTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Telefon", true));
            this.musteri_telefon_noTextEdit.Location = new System.Drawing.Point(118, 127);
            this.musteri_telefon_noTextEdit.Name = "musteri_telefon_noTextEdit";
            this.musteri_telefon_noTextEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_telefon_noTextEdit.TabIndex = 9;
            // 
            // musteri_soyadiTextEdit
            // 
            this.musteri_soyadiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Soyadı", true));
            this.musteri_soyadiTextEdit.Location = new System.Drawing.Point(118, 101);
            this.musteri_soyadiTextEdit.Name = "musteri_soyadiTextEdit";
            this.musteri_soyadiTextEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_soyadiTextEdit.TabIndex = 7;
            // 
            // musteri_adiTextEdit
            // 
            this.musteri_adiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Adı", true));
            this.musteri_adiTextEdit.Location = new System.Drawing.Point(118, 75);
            this.musteri_adiTextEdit.Name = "musteri_adiTextEdit";
            this.musteri_adiTextEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_adiTextEdit.TabIndex = 5;
            // 
            // musteri_tc_kimlik_noTextEdit
            // 
            this.musteri_tc_kimlik_noTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "TC Kimlik No", true));
            this.musteri_tc_kimlik_noTextEdit.Location = new System.Drawing.Point(118, 49);
            this.musteri_tc_kimlik_noTextEdit.Name = "musteri_tc_kimlik_noTextEdit";
            this.musteri_tc_kimlik_noTextEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_tc_kimlik_noTextEdit.TabIndex = 3;
            // 
            // musteri_idSpinEdit
            // 
            this.musteri_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.musteri_idSpinEdit.Enabled = false;
            this.musteri_idSpinEdit.Location = new System.Drawing.Point(118, 23);
            this.musteri_idSpinEdit.Name = "musteri_idSpinEdit";
            this.musteri_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.musteri_idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.musteri_idSpinEdit.TabIndex = 1;
            // 
            // spMusteriDaireBinaTableAdapter
            // 
            this.spMusteriDaireBinaTableAdapter.ClearBeforeFill = true;
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
            // tbl_MusterilerTableAdapter
            // 
            this.tbl_MusterilerTableAdapter.ClearBeforeFill = true;
            // 
            // gcMusteriler
            // 
            this.gcMusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMusteriler.Location = new System.Drawing.Point(0, 263);
            this.gcMusteriler.MainView = this.gridView1;
            this.gcMusteriler.Name = "gcMusteriler";
            this.gcMusteriler.Size = new System.Drawing.Size(908, 278);
            this.gcMusteriler.TabIndex = 3;
            this.gcMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTCKimlikNo,
            this.colAdı,
            this.colSoyadı,
            this.colTelefon,
            this.colTelefon2,
            this.colEmail,
            this.colŞehir,
            this.colAdres,
            this.colDaireKapıNo,
            this.colApartAdı,
            this.colAçıklama,
            this.colKontratBaşlangıç,
            this.colKontratBitiş,
            this.colKiraMiktarı,
            this.colYetkili,
            this.colDurumu});
            this.gridView1.GridControl = this.gcMusteriler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colTCKimlikNo
            // 
            this.colTCKimlikNo.FieldName = "TC Kimlik No";
            this.colTCKimlikNo.Name = "colTCKimlikNo";
            this.colTCKimlikNo.Visible = true;
            this.colTCKimlikNo.VisibleIndex = 0;
            this.colTCKimlikNo.Width = 53;
            // 
            // colAdı
            // 
            this.colAdı.FieldName = "Adı";
            this.colAdı.Name = "colAdı";
            this.colAdı.Visible = true;
            this.colAdı.VisibleIndex = 1;
            this.colAdı.Width = 53;
            // 
            // colSoyadı
            // 
            this.colSoyadı.FieldName = "Soyadı";
            this.colSoyadı.Name = "colSoyadı";
            this.colSoyadı.Visible = true;
            this.colSoyadı.VisibleIndex = 2;
            this.colSoyadı.Width = 53;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 3;
            this.colTelefon.Width = 53;
            // 
            // colTelefon2
            // 
            this.colTelefon2.FieldName = "Telefon 2";
            this.colTelefon2.Name = "colTelefon2";
            this.colTelefon2.Visible = true;
            this.colTelefon2.VisibleIndex = 4;
            this.colTelefon2.Width = 53;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 53;
            // 
            // colŞehir
            // 
            this.colŞehir.FieldName = "Şehir";
            this.colŞehir.Name = "colŞehir";
            this.colŞehir.Visible = true;
            this.colŞehir.VisibleIndex = 6;
            this.colŞehir.Width = 53;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 7;
            this.colAdres.Width = 53;
            // 
            // colDaireKapıNo
            // 
            this.colDaireKapıNo.FieldName = "Daire Kapı No";
            this.colDaireKapıNo.Name = "colDaireKapıNo";
            this.colDaireKapıNo.Visible = true;
            this.colDaireKapıNo.VisibleIndex = 8;
            this.colDaireKapıNo.Width = 93;
            // 
            // colApartAdı
            // 
            this.colApartAdı.FieldName = "Apart Adı";
            this.colApartAdı.Name = "colApartAdı";
            this.colApartAdı.Visible = true;
            this.colApartAdı.VisibleIndex = 9;
            this.colApartAdı.Width = 101;
            // 
            // colAçıklama
            // 
            this.colAçıklama.FieldName = "Açıklama";
            this.colAçıklama.Name = "colAçıklama";
            this.colAçıklama.Visible = true;
            this.colAçıklama.VisibleIndex = 10;
            this.colAçıklama.Width = 38;
            // 
            // colKontratBaşlangıç
            // 
            this.colKontratBaşlangıç.FieldName = "Kontrat Başlangıç";
            this.colKontratBaşlangıç.Name = "colKontratBaşlangıç";
            this.colKontratBaşlangıç.Visible = true;
            this.colKontratBaşlangıç.VisibleIndex = 11;
            this.colKontratBaşlangıç.Width = 38;
            // 
            // colKontratBitiş
            // 
            this.colKontratBitiş.FieldName = "Kontrat Bitiş";
            this.colKontratBitiş.Name = "colKontratBitiş";
            this.colKontratBitiş.Visible = true;
            this.colKontratBitiş.VisibleIndex = 12;
            this.colKontratBitiş.Width = 38;
            // 
            // colKiraMiktarı
            // 
            this.colKiraMiktarı.FieldName = "Kira Miktarı";
            this.colKiraMiktarı.Name = "colKiraMiktarı";
            this.colKiraMiktarı.Visible = true;
            this.colKiraMiktarı.VisibleIndex = 13;
            this.colKiraMiktarı.Width = 38;
            // 
            // colYetkili
            // 
            this.colYetkili.FieldName = "Yetkili";
            this.colYetkili.Name = "colYetkili";
            this.colYetkili.Visible = true;
            this.colYetkili.VisibleIndex = 14;
            this.colYetkili.Width = 38;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 15;
            this.colDurumu.Width = 53;
            // 
            // tbl_MusterilerBindingSource
            // 
            this.tbl_MusterilerBindingSource.DataMember = "tbl_Musteriler";
            this.tbl_MusterilerBindingSource.DataSource = this.aYSDataSet;
            // 
            // daire_NoTextEdit
            // 
            this.daire_NoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spMusteriDaireBinaBindingSource, "Daire No", true));
            this.daire_NoTextEdit.Location = new System.Drawing.Point(2, 272);
            this.daire_NoTextEdit.Name = "daire_NoTextEdit";
            this.daire_NoTextEdit.Size = new System.Drawing.Size(100, 20);
            this.daire_NoTextEdit.TabIndex = 35;
            // 
            // frmMusteriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 543);
            this.Controls.Add(this.gcMusteriler);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupMusteri);
            this.Controls.Add(this.daire_NoTextEdit);
            this.Name = "frmMusteriEkleme";
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.frmMusteriEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupMusteri)).EndInit();
            this.groupMusteri.ResumeLayout(false);
            this.groupMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_kontrat_bitis_tarihiDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_kontrat_bitis_tarihiDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMusteriDaireBinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_kontrat_baslangic_tarihiDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_kontrat_baslangic_tarihiDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_durumuCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_yetkiCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_kira_tutariSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_aciklamaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_adresTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_sehirTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_telefon_no2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_telefon_noTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_soyadiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_adiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_tc_kimlik_noTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MusterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daire_NoTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AYSDataSet aYSDataSet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.GroupControl groupMusteri;
        private DevExpress.XtraEditors.CheckEdit musteri_durumuCheckEdit;
        private DevExpress.XtraEditors.CheckEdit musteri_yetkiCheckEdit;
        private DevExpress.XtraEditors.SpinEdit musteri_kira_tutariSpinEdit;
        private DevExpress.XtraEditors.TextEdit musteri_aciklamaTextEdit;
        private DevExpress.XtraEditors.TextEdit musteri_adresTextEdit;
        private DevExpress.XtraEditors.TextEdit musteri_sehirTextEdit;
        private DevExpress.XtraEditors.TextEdit musteri_emailTextEdit;
        private DevExpress.XtraEditors.TextEdit musteri_telefon_no2TextEdit;
        private DevExpress.XtraEditors.TextEdit musteri_telefon_noTextEdit;
        private DevExpress.XtraEditors.TextEdit musteri_soyadiTextEdit;
        private DevExpress.XtraEditors.TextEdit musteri_adiTextEdit;
        private DevExpress.XtraEditors.TextEdit musteri_tc_kimlik_noTextEdit;
        private DevExpress.XtraEditors.SpinEdit musteri_idSpinEdit;
        private DevExpress.XtraEditors.DateEdit musteri_kontrat_bitis_tarihiDateEdit;
        private DevExpress.XtraEditors.DateEdit musteri_kontrat_baslangic_tarihiDateEdit;
        private System.Windows.Forms.ComboBox bina_adiComboBox;
        private System.Windows.Forms.ComboBox daire_noComboBox;
        private System.Windows.Forms.BindingSource spMusteriDaireBinaBindingSource;
        private AYSDataSetTableAdapters.spMusteriDaireBinaTableAdapter spMusteriDaireBinaTableAdapter;
        private AYSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcMusteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private AYSDataSetTableAdapters.tbl_MusterilerTableAdapter tbl_MusterilerTableAdapter;
        private System.Windows.Forms.BindingSource tbl_MusterilerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTCKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadı;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon2;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colŞehir;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colDaireKapıNo;
        private DevExpress.XtraGrid.Columns.GridColumn colApartAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colAçıklama;
        private DevExpress.XtraGrid.Columns.GridColumn colKontratBaşlangıç;
        private DevExpress.XtraGrid.Columns.GridColumn colKontratBitiş;
        private DevExpress.XtraGrid.Columns.GridColumn colKiraMiktarı;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkili;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraEditors.TextEdit daire_NoTextEdit;
    }
}