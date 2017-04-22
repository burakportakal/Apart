namespace ApartYonetim
{
    partial class frmYoneticiler
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
            System.Windows.Forms.Label yonetici_adiLabel;
            System.Windows.Forms.Label yonetici_soyadiLabel;
            System.Windows.Forms.Label yonetici_telefonLabel;
            System.Windows.Forms.Label yonetici_telefon2Label;
            System.Windows.Forms.Label yonetici_emailLabel;
            System.Windows.Forms.Label yonetici_aciklamaLabel;
            System.Windows.Forms.Label yonetici_sifresiLabel;
            System.Windows.Forms.Label yonetici_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoneticiler));
            this.gcYoneticiler = new DevExpress.XtraGrid.GridControl();
            this.gvYoneticiler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbl_YoneticilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aYSDataSet = new ApartYonetim.AYSDataSet();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.clbSorumluOlduguBinalar = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.yonetici_idTextBox = new System.Windows.Forms.TextBox();
            this.yonetici_sifresiTextBox = new System.Windows.Forms.TextBox();
            this.yonetici_aciklamaTextBox = new System.Windows.Forms.TextBox();
            this.yonetici_emailTextBox = new System.Windows.Forms.TextBox();
            this.yonetici_telefon2TextBox = new System.Windows.Forms.TextBox();
            this.yonetici_telefonTextBox = new System.Windows.Forms.TextBox();
            this.yonetici_soyadiTextBox = new System.Windows.Forms.TextBox();
            this.yonetici_adiTextBox = new System.Windows.Forms.TextBox();
            this.tbl_BinalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_YoneticilerTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.tbl_YoneticilerTableAdapter();
            this.tableAdapterManager = new ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager();
            this.tbl_YoneticilerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbl_YoneticilerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_YoneticiBinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_YoneticiBinaTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.tbl_YoneticiBinaTableAdapter();
            this.tbl_BinalarTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.tbl_BinalarTableAdapter();
            this.colyonetici_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyonetici_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyonetici_soyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyonetici_telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyonetici_telefon2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyonetici_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyonetici_aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyonetici_sifresi = new DevExpress.XtraGrid.Columns.GridColumn();
            yonetici_adiLabel = new System.Windows.Forms.Label();
            yonetici_soyadiLabel = new System.Windows.Forms.Label();
            yonetici_telefonLabel = new System.Windows.Forms.Label();
            yonetici_telefon2Label = new System.Windows.Forms.Label();
            yonetici_emailLabel = new System.Windows.Forms.Label();
            yonetici_aciklamaLabel = new System.Windows.Forms.Label();
            yonetici_sifresiLabel = new System.Windows.Forms.Label();
            yonetici_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcYoneticiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvYoneticiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_YoneticilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbSorumluOlduguBinalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BinalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_YoneticilerBindingNavigator)).BeginInit();
            this.tbl_YoneticilerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_YoneticiBinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // yonetici_adiLabel
            // 
            yonetici_adiLabel.AutoSize = true;
            yonetici_adiLabel.Location = new System.Drawing.Point(42, 106);
            yonetici_adiLabel.Name = "yonetici_adiLabel";
            yonetici_adiLabel.Size = new System.Drawing.Size(82, 17);
            yonetici_adiLabel.TabIndex = 0;
            yonetici_adiLabel.Text = "Yönetici Adı:";
            // 
            // yonetici_soyadiLabel
            // 
            yonetici_soyadiLabel.AutoSize = true;
            yonetici_soyadiLabel.Location = new System.Drawing.Point(19, 135);
            yonetici_soyadiLabel.Name = "yonetici_soyadiLabel";
            yonetici_soyadiLabel.Size = new System.Drawing.Size(105, 17);
            yonetici_soyadiLabel.TabIndex = 2;
            yonetici_soyadiLabel.Text = "Yonetici Soyadi:";
            // 
            // yonetici_telefonLabel
            // 
            yonetici_telefonLabel.AutoSize = true;
            yonetici_telefonLabel.Location = new System.Drawing.Point(15, 164);
            yonetici_telefonLabel.Name = "yonetici_telefonLabel";
            yonetici_telefonLabel.Size = new System.Drawing.Size(108, 17);
            yonetici_telefonLabel.TabIndex = 4;
            yonetici_telefonLabel.Text = "Yonetici Telefon:";
            // 
            // yonetici_telefon2Label
            // 
            yonetici_telefon2Label.AutoSize = true;
            yonetici_telefon2Label.Location = new System.Drawing.Point(3, 193);
            yonetici_telefon2Label.Name = "yonetici_telefon2Label";
            yonetici_telefon2Label.Size = new System.Drawing.Size(120, 17);
            yonetici_telefon2Label.TabIndex = 6;
            yonetici_telefon2Label.Text = "Yonetici Telefon 2:";
            // 
            // yonetici_emailLabel
            // 
            yonetici_emailLabel.AutoSize = true;
            yonetici_emailLabel.Location = new System.Drawing.Point(439, 68);
            yonetici_emailLabel.Name = "yonetici_emailLabel";
            yonetici_emailLabel.Size = new System.Drawing.Size(95, 17);
            yonetici_emailLabel.TabIndex = 8;
            yonetici_emailLabel.Text = "Yönetici Email:";
            // 
            // yonetici_aciklamaLabel
            // 
            yonetici_aciklamaLabel.AutoSize = true;
            yonetici_aciklamaLabel.Location = new System.Drawing.Point(418, 126);
            yonetici_aciklamaLabel.Name = "yonetici_aciklamaLabel";
            yonetici_aciklamaLabel.Size = new System.Drawing.Size(116, 17);
            yonetici_aciklamaLabel.TabIndex = 10;
            yonetici_aciklamaLabel.Text = "Yönetici Aciklama:";
            // 
            // yonetici_sifresiLabel
            // 
            yonetici_sifresiLabel.AutoSize = true;
            yonetici_sifresiLabel.Location = new System.Drawing.Point(437, 97);
            yonetici_sifresiLabel.Name = "yonetici_sifresiLabel";
            yonetici_sifresiLabel.Size = new System.Drawing.Size(98, 17);
            yonetici_sifresiLabel.TabIndex = 12;
            yonetici_sifresiLabel.Text = "Yönetici Şifresi:";
            // 
            // yonetici_idLabel
            // 
            yonetici_idLabel.AutoSize = true;
            yonetici_idLabel.Location = new System.Drawing.Point(99, 74);
            yonetici_idLabel.Name = "yonetici_idLabel";
            yonetici_idLabel.Size = new System.Drawing.Size(25, 17);
            yonetici_idLabel.TabIndex = 14;
            yonetici_idLabel.Text = "Id:";
            // 
            // gcYoneticiler
            // 
            this.gcYoneticiler.DataSource = this.tbl_YoneticilerBindingSource;
            this.gcYoneticiler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcYoneticiler.Location = new System.Drawing.Point(0, 316);
            this.gcYoneticiler.MainView = this.gvYoneticiler;
            this.gcYoneticiler.Name = "gcYoneticiler";
            this.gcYoneticiler.Size = new System.Drawing.Size(1313, 301);
            this.gcYoneticiler.TabIndex = 0;
            this.gcYoneticiler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvYoneticiler});
            this.gcYoneticiler.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gcYoneticiler_FocusedViewChanged);
            // 
            // gvYoneticiler
            // 
            this.gvYoneticiler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colyonetici_id,
            this.colyonetici_adi,
            this.colyonetici_soyadi,
            this.colyonetici_telefon,
            this.colyonetici_telefon2,
            this.colyonetici_email,
            this.colyonetici_aciklama,
            this.colyonetici_sifresi});
            this.gvYoneticiler.GridControl = this.gcYoneticiler;
            this.gvYoneticiler.Name = "gvYoneticiler";
            this.gvYoneticiler.OptionsBehavior.Editable = false;
            this.gvYoneticiler.OptionsBehavior.ReadOnly = true;
            // 
            // tbl_YoneticilerBindingSource
            // 
            this.tbl_YoneticilerBindingSource.DataMember = "tbl_Yoneticiler";
            this.tbl_YoneticilerBindingSource.DataSource = this.aYSDataSet;
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
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 270);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1313, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Location = new System.Drawing.Point(512, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 42);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVazgec.Location = new System.Drawing.Point(379, 2);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(133, 42);
            this.btnVazgec.TabIndex = 3;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuncelle.Location = new System.Drawing.Point(246, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(133, 42);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Guncelle";
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.Location = new System.Drawing.Point(113, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 42);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            // 
            // btnYeni
            // 
            this.btnYeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYeni.Location = new System.Drawing.Point(2, 2);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(111, 42);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni ";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.clbSorumluOlduguBinalar);
            this.groupControl1.Controls.Add(yonetici_idLabel);
            this.groupControl1.Controls.Add(this.yonetici_idTextBox);
            this.groupControl1.Controls.Add(yonetici_sifresiLabel);
            this.groupControl1.Controls.Add(this.yonetici_sifresiTextBox);
            this.groupControl1.Controls.Add(yonetici_aciklamaLabel);
            this.groupControl1.Controls.Add(this.yonetici_aciklamaTextBox);
            this.groupControl1.Controls.Add(yonetici_emailLabel);
            this.groupControl1.Controls.Add(this.yonetici_emailTextBox);
            this.groupControl1.Controls.Add(yonetici_telefon2Label);
            this.groupControl1.Controls.Add(this.yonetici_telefon2TextBox);
            this.groupControl1.Controls.Add(yonetici_telefonLabel);
            this.groupControl1.Controls.Add(this.yonetici_telefonTextBox);
            this.groupControl1.Controls.Add(yonetici_soyadiLabel);
            this.groupControl1.Controls.Add(this.yonetici_soyadiTextBox);
            this.groupControl1.Controls.Add(yonetici_adiLabel);
            this.groupControl1.Controls.Add(this.yonetici_adiTextBox);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Enabled = false;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1313, 270);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Yonetici Listesi";
            // 
            // clbSorumluOlduguBinalar
            // 
            this.clbSorumluOlduguBinalar.Location = new System.Drawing.Point(833, 59);
            this.clbSorumluOlduguBinalar.Name = "clbSorumluOlduguBinalar";
            this.clbSorumluOlduguBinalar.Size = new System.Drawing.Size(156, 151);
            this.clbSorumluOlduguBinalar.TabIndex = 19;
            // 
            // yonetici_idTextBox
            // 
            this.yonetici_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_YoneticilerBindingSource, "yonetici_id", true));
            this.yonetici_idTextBox.Enabled = false;
            this.yonetici_idTextBox.Location = new System.Drawing.Point(129, 68);
            this.yonetici_idTextBox.Name = "yonetici_idTextBox";
            this.yonetici_idTextBox.Size = new System.Drawing.Size(100, 23);
            this.yonetici_idTextBox.TabIndex = 15;
            this.yonetici_idTextBox.TextChanged += new System.EventHandler(this.yonetici_idTextBox_TextChanged);
            // 
            // yonetici_sifresiTextBox
            // 
            this.yonetici_sifresiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_YoneticilerBindingSource, "yonetici_sifresi", true));
            this.yonetici_sifresiTextBox.Location = new System.Drawing.Point(539, 94);
            this.yonetici_sifresiTextBox.Name = "yonetici_sifresiTextBox";
            this.yonetici_sifresiTextBox.Size = new System.Drawing.Size(210, 23);
            this.yonetici_sifresiTextBox.TabIndex = 13;
            // 
            // yonetici_aciklamaTextBox
            // 
            this.yonetici_aciklamaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_YoneticilerBindingSource, "yonetici_aciklama", true));
            this.yonetici_aciklamaTextBox.Location = new System.Drawing.Point(539, 123);
            this.yonetici_aciklamaTextBox.Multiline = true;
            this.yonetici_aciklamaTextBox.Name = "yonetici_aciklamaTextBox";
            this.yonetici_aciklamaTextBox.Size = new System.Drawing.Size(210, 93);
            this.yonetici_aciklamaTextBox.TabIndex = 11;
            // 
            // yonetici_emailTextBox
            // 
            this.yonetici_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_YoneticilerBindingSource, "yonetici_email", true));
            this.yonetici_emailTextBox.Location = new System.Drawing.Point(539, 65);
            this.yonetici_emailTextBox.Name = "yonetici_emailTextBox";
            this.yonetici_emailTextBox.Size = new System.Drawing.Size(210, 23);
            this.yonetici_emailTextBox.TabIndex = 9;
            // 
            // yonetici_telefon2TextBox
            // 
            this.yonetici_telefon2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_YoneticilerBindingSource, "yonetici_telefon2", true));
            this.yonetici_telefon2TextBox.Location = new System.Drawing.Point(129, 187);
            this.yonetici_telefon2TextBox.Name = "yonetici_telefon2TextBox";
            this.yonetici_telefon2TextBox.Size = new System.Drawing.Size(210, 23);
            this.yonetici_telefon2TextBox.TabIndex = 7;
            // 
            // yonetici_telefonTextBox
            // 
            this.yonetici_telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_YoneticilerBindingSource, "yonetici_telefon", true));
            this.yonetici_telefonTextBox.Location = new System.Drawing.Point(129, 158);
            this.yonetici_telefonTextBox.Name = "yonetici_telefonTextBox";
            this.yonetici_telefonTextBox.Size = new System.Drawing.Size(210, 23);
            this.yonetici_telefonTextBox.TabIndex = 5;
            // 
            // yonetici_soyadiTextBox
            // 
            this.yonetici_soyadiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_YoneticilerBindingSource, "yonetici_soyadi", true));
            this.yonetici_soyadiTextBox.Location = new System.Drawing.Point(129, 129);
            this.yonetici_soyadiTextBox.Name = "yonetici_soyadiTextBox";
            this.yonetici_soyadiTextBox.Size = new System.Drawing.Size(210, 23);
            this.yonetici_soyadiTextBox.TabIndex = 3;
            // 
            // yonetici_adiTextBox
            // 
            this.yonetici_adiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_YoneticilerBindingSource, "yonetici_adi", true));
            this.yonetici_adiTextBox.Location = new System.Drawing.Point(129, 100);
            this.yonetici_adiTextBox.Name = "yonetici_adiTextBox";
            this.yonetici_adiTextBox.Size = new System.Drawing.Size(210, 23);
            this.yonetici_adiTextBox.TabIndex = 1;
            // 
            // tbl_BinalarBindingSource
            // 
            this.tbl_BinalarBindingSource.DataMember = "tbl_Binalar";
            this.tbl_BinalarBindingSource.DataSource = this.aYSDataSet;
            // 
            // tbl_YoneticilerTableAdapter
            // 
            this.tbl_YoneticilerTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tbl_MusterilerTableAdapter = null;
            this.tableAdapterManager.tbl_OrtakFaturaTableAdapter = null;
            this.tableAdapterManager.tbl_YoneticiBinaTableAdapter = null;
            this.tableAdapterManager.tbl_YoneticilerTableAdapter = this.tbl_YoneticilerTableAdapter;
            this.tableAdapterManager.UpdateOrder = ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_YoneticilerBindingNavigator
            // 
            this.tbl_YoneticilerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_YoneticilerBindingNavigator.BindingSource = this.tbl_YoneticilerBindingSource;
            this.tbl_YoneticilerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_YoneticilerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_YoneticilerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_YoneticilerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_YoneticilerBindingNavigatorSaveItem});
            this.tbl_YoneticilerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_YoneticilerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_YoneticilerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_YoneticilerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_YoneticilerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_YoneticilerBindingNavigator.Name = "tbl_YoneticilerBindingNavigator";
            this.tbl_YoneticilerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_YoneticilerBindingNavigator.Size = new System.Drawing.Size(1313, 27);
            this.tbl_YoneticilerBindingNavigator.TabIndex = 3;
            this.tbl_YoneticilerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbl_YoneticilerBindingNavigatorSaveItem
            // 
            this.tbl_YoneticilerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_YoneticilerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_YoneticilerBindingNavigatorSaveItem.Image")));
            this.tbl_YoneticilerBindingNavigatorSaveItem.Name = "tbl_YoneticilerBindingNavigatorSaveItem";
            this.tbl_YoneticilerBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tbl_YoneticilerBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_YoneticilerBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_YoneticilerBindingNavigatorSaveItem_Click);
            // 
            // tbl_YoneticiBinaBindingSource
            // 
            this.tbl_YoneticiBinaBindingSource.DataMember = "FK_tbl_Kullanicilar_tbl_Kullanici";
            this.tbl_YoneticiBinaBindingSource.DataSource = this.tbl_YoneticilerBindingSource;
            // 
            // tbl_YoneticiBinaTableAdapter
            // 
            this.tbl_YoneticiBinaTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_BinalarTableAdapter
            // 
            this.tbl_BinalarTableAdapter.ClearBeforeFill = true;
            // 
            // colyonetici_id
            // 
            this.colyonetici_id.FieldName = "yonetici_id";
            this.colyonetici_id.Name = "colyonetici_id";
            this.colyonetici_id.Visible = true;
            this.colyonetici_id.VisibleIndex = 0;
            // 
            // colyonetici_adi
            // 
            this.colyonetici_adi.FieldName = "yonetici_adi";
            this.colyonetici_adi.Name = "colyonetici_adi";
            this.colyonetici_adi.Visible = true;
            this.colyonetici_adi.VisibleIndex = 1;
            // 
            // colyonetici_soyadi
            // 
            this.colyonetici_soyadi.FieldName = "yonetici_soyadi";
            this.colyonetici_soyadi.Name = "colyonetici_soyadi";
            this.colyonetici_soyadi.Visible = true;
            this.colyonetici_soyadi.VisibleIndex = 2;
            // 
            // colyonetici_telefon
            // 
            this.colyonetici_telefon.FieldName = "yonetici_telefon";
            this.colyonetici_telefon.Name = "colyonetici_telefon";
            this.colyonetici_telefon.Visible = true;
            this.colyonetici_telefon.VisibleIndex = 3;
            // 
            // colyonetici_telefon2
            // 
            this.colyonetici_telefon2.FieldName = "yonetici_telefon2";
            this.colyonetici_telefon2.Name = "colyonetici_telefon2";
            this.colyonetici_telefon2.Visible = true;
            this.colyonetici_telefon2.VisibleIndex = 4;
            // 
            // colyonetici_email
            // 
            this.colyonetici_email.FieldName = "yonetici_email";
            this.colyonetici_email.Name = "colyonetici_email";
            this.colyonetici_email.Visible = true;
            this.colyonetici_email.VisibleIndex = 5;
            // 
            // colyonetici_aciklama
            // 
            this.colyonetici_aciklama.FieldName = "yonetici_aciklama";
            this.colyonetici_aciklama.Name = "colyonetici_aciklama";
            this.colyonetici_aciklama.Visible = true;
            this.colyonetici_aciklama.VisibleIndex = 6;
            // 
            // colyonetici_sifresi
            // 
            this.colyonetici_sifresi.FieldName = "yonetici_sifresi";
            this.colyonetici_sifresi.Name = "colyonetici_sifresi";
            this.colyonetici_sifresi.Visible = true;
            this.colyonetici_sifresi.VisibleIndex = 7;
            // 
            // frmYoneticiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 617);
            this.Controls.Add(this.tbl_YoneticilerBindingNavigator);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcYoneticiler);
            this.Name = "frmYoneticiler";
            this.Text = "Yöneticiler";
            this.Load += new System.EventHandler(this.frmYoneticiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcYoneticiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvYoneticiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_YoneticilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbSorumluOlduguBinalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BinalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_YoneticilerBindingNavigator)).EndInit();
            this.tbl_YoneticilerBindingNavigator.ResumeLayout(false);
            this.tbl_YoneticilerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_YoneticiBinaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcYoneticiler;
        private DevExpress.XtraGrid.Views.Grid.GridView gvYoneticiler;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private AYSDataSet aYSDataSet;
        private System.Windows.Forms.BindingSource tbl_YoneticilerBindingSource;
        private AYSDataSetTableAdapters.tbl_YoneticilerTableAdapter tbl_YoneticilerTableAdapter;
        private AYSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_YoneticilerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_YoneticilerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox yonetici_telefonTextBox;
        private System.Windows.Forms.TextBox yonetici_soyadiTextBox;
        private System.Windows.Forms.TextBox yonetici_adiTextBox;
        private System.Windows.Forms.TextBox yonetici_sifresiTextBox;
        private System.Windows.Forms.TextBox yonetici_aciklamaTextBox;
        private System.Windows.Forms.TextBox yonetici_emailTextBox;
        private System.Windows.Forms.TextBox yonetici_telefon2TextBox;
        private System.Windows.Forms.TextBox yonetici_idTextBox;
        private System.Windows.Forms.BindingSource tbl_YoneticiBinaBindingSource;
        private AYSDataSetTableAdapters.tbl_YoneticiBinaTableAdapter tbl_YoneticiBinaTableAdapter;
        private System.Windows.Forms.BindingSource tbl_BinalarBindingSource;
        private AYSDataSetTableAdapters.tbl_BinalarTableAdapter tbl_BinalarTableAdapter;
        private DevExpress.XtraEditors.CheckedListBoxControl clbSorumluOlduguBinalar;
        private DevExpress.XtraGrid.Columns.GridColumn colyonetici_id;
        private DevExpress.XtraGrid.Columns.GridColumn colyonetici_adi;
        private DevExpress.XtraGrid.Columns.GridColumn colyonetici_soyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colyonetici_telefon;
        private DevExpress.XtraGrid.Columns.GridColumn colyonetici_telefon2;
        private DevExpress.XtraGrid.Columns.GridColumn colyonetici_email;
        private DevExpress.XtraGrid.Columns.GridColumn colyonetici_aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colyonetici_sifresi;
    }
}