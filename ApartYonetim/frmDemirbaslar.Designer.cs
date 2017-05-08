namespace ApartYonetim
{
    partial class frmDemirbaslar
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
            System.Windows.Forms.Label demirbas_idLabel;
            System.Windows.Forms.Label demirbas_tur_idLabel;
            System.Windows.Forms.Label demirbas_alis_tarihiLabel;
            System.Windows.Forms.Label demirbas_aciklamaLabel;
            System.Windows.Forms.Label demirbas_adetLabel;
            System.Windows.Forms.Label demirbas_fiyatiLabel;
            System.Windows.Forms.Label daire_noLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemirbaslar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.daire_noComboBox = new System.Windows.Forms.ComboBox();
            this.tbl_DemirbaslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aYSDataSet = new ApartYonetim.AYSDataSet();
            this.demirbas_fiyatiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.demirbas_adetSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.demirbas_aciklamaMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.demirbas_alis_tarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.demirbas_tur_idLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tblDemirbasTurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aYSDataSet3 = new ApartYonetim.AYSDataSet3();
            this.demirbas_idTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.gcDemirbaslar = new DevExpress.XtraGrid.GridControl();
            this.gvDemirbaslar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbl_DemirbaslarTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.tbl_DemirbaslarTableAdapter();
            this.tableAdapterManager = new ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager();
            this.tbl_DemirbaslarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_DemirbaslarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_DemirbasTurTableAdapter = new ApartYonetim.AYSDataSet3TableAdapters.tbl_DemirbasTurTableAdapter();
            demirbas_idLabel = new System.Windows.Forms.Label();
            demirbas_tur_idLabel = new System.Windows.Forms.Label();
            demirbas_alis_tarihiLabel = new System.Windows.Forms.Label();
            demirbas_aciklamaLabel = new System.Windows.Forms.Label();
            demirbas_adetLabel = new System.Windows.Forms.Label();
            demirbas_fiyatiLabel = new System.Windows.Forms.Label();
            daire_noLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DemirbaslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbas_fiyatiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbas_adetSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbas_aciklamaMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbas_tur_idLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDemirbasTurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDemirbaslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDemirbaslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DemirbaslarBindingNavigator)).BeginInit();
            this.tbl_DemirbaslarBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // demirbas_idLabel
            // 
            demirbas_idLabel.AutoSize = true;
            demirbas_idLabel.Location = new System.Drawing.Point(56, 57);
            demirbas_idLabel.Name = "demirbas_idLabel";
            demirbas_idLabel.Size = new System.Drawing.Size(82, 17);
            demirbas_idLabel.TabIndex = 0;
            demirbas_idLabel.Text = "demirbas id:";
            // 
            // demirbas_tur_idLabel
            // 
            demirbas_tur_idLabel.AutoSize = true;
            demirbas_tur_idLabel.Location = new System.Drawing.Point(34, 115);
            demirbas_tur_idLabel.Name = "demirbas_tur_idLabel";
            demirbas_tur_idLabel.Size = new System.Drawing.Size(104, 17);
            demirbas_tur_idLabel.TabIndex = 4;
            demirbas_tur_idLabel.Text = "demirbas tur id:";
            // 
            // demirbas_alis_tarihiLabel
            // 
            demirbas_alis_tarihiLabel.AutoSize = true;
            demirbas_alis_tarihiLabel.Location = new System.Drawing.Point(410, 61);
            demirbas_alis_tarihiLabel.Name = "demirbas_alis_tarihiLabel";
            demirbas_alis_tarihiLabel.Size = new System.Drawing.Size(122, 17);
            demirbas_alis_tarihiLabel.TabIndex = 10;
            demirbas_alis_tarihiLabel.Text = "demirbas alis tarihi:";
            // 
            // demirbas_aciklamaLabel
            // 
            demirbas_aciklamaLabel.AutoSize = true;
            demirbas_aciklamaLabel.Location = new System.Drawing.Point(409, 89);
            demirbas_aciklamaLabel.Name = "demirbas_aciklamaLabel";
            demirbas_aciklamaLabel.Size = new System.Drawing.Size(123, 17);
            demirbas_aciklamaLabel.TabIndex = 12;
            demirbas_aciklamaLabel.Text = "demirbas aciklama:";
            // 
            // demirbas_adetLabel
            // 
            demirbas_adetLabel.AutoSize = true;
            demirbas_adetLabel.Location = new System.Drawing.Point(39, 143);
            demirbas_adetLabel.Name = "demirbas_adetLabel";
            demirbas_adetLabel.Size = new System.Drawing.Size(99, 17);
            demirbas_adetLabel.TabIndex = 13;
            demirbas_adetLabel.Text = "demirbas adet:";
            // 
            // demirbas_fiyatiLabel
            // 
            demirbas_fiyatiLabel.AutoSize = true;
            demirbas_fiyatiLabel.Location = new System.Drawing.Point(38, 171);
            demirbas_fiyatiLabel.Name = "demirbas_fiyatiLabel";
            demirbas_fiyatiLabel.Size = new System.Drawing.Size(100, 17);
            demirbas_fiyatiLabel.TabIndex = 14;
            demirbas_fiyatiLabel.Text = "demirbas fiyati:";
            // 
            // daire_noLabel
            // 
            daire_noLabel.AutoSize = true;
            daire_noLabel.Location = new System.Drawing.Point(76, 86);
            daire_noLabel.Name = "daire_noLabel";
            daire_noLabel.Size = new System.Drawing.Size(62, 17);
            daire_noLabel.TabIndex = 15;
            daire_noLabel.Text = "daire no:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(daire_noLabel);
            this.groupControl1.Controls.Add(this.daire_noComboBox);
            this.groupControl1.Controls.Add(demirbas_fiyatiLabel);
            this.groupControl1.Controls.Add(this.demirbas_fiyatiTextEdit);
            this.groupControl1.Controls.Add(demirbas_adetLabel);
            this.groupControl1.Controls.Add(this.demirbas_adetSpinEdit);
            this.groupControl1.Controls.Add(demirbas_aciklamaLabel);
            this.groupControl1.Controls.Add(this.demirbas_aciklamaMemoEdit);
            this.groupControl1.Controls.Add(demirbas_alis_tarihiLabel);
            this.groupControl1.Controls.Add(this.demirbas_alis_tarihiDateTimePicker);
            this.groupControl1.Controls.Add(demirbas_tur_idLabel);
            this.groupControl1.Controls.Add(this.demirbas_tur_idLookUpEdit);
            this.groupControl1.Controls.Add(demirbas_idLabel);
            this.groupControl1.Controls.Add(this.demirbas_idTextBox);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1193, 252);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Demirbaş İşlemleri";
            // 
            // daire_noComboBox
            // 
            this.daire_noComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_DemirbaslarBindingSource, "daire_no", true));
            this.daire_noComboBox.FormattingEnabled = true;
            this.daire_noComboBox.Location = new System.Drawing.Point(144, 83);
            this.daire_noComboBox.Name = "daire_noComboBox";
            this.daire_noComboBox.Size = new System.Drawing.Size(200, 24);
            this.daire_noComboBox.TabIndex = 16;
            // 
            // tbl_DemirbaslarBindingSource
            // 
            this.tbl_DemirbaslarBindingSource.DataMember = "tbl_Demirbaslar";
            this.tbl_DemirbaslarBindingSource.DataSource = this.aYSDataSet;
            // 
            // aYSDataSet
            // 
            this.aYSDataSet.DataSetName = "AYSDataSet";
            this.aYSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // demirbas_fiyatiTextEdit
            // 
            this.demirbas_fiyatiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbl_DemirbaslarBindingSource, "demirbas_fiyati", true));
            this.demirbas_fiyatiTextEdit.Location = new System.Drawing.Point(144, 168);
            this.demirbas_fiyatiTextEdit.Name = "demirbas_fiyatiTextEdit";
            this.demirbas_fiyatiTextEdit.Properties.Mask.EditMask = "c";
            this.demirbas_fiyatiTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.demirbas_fiyatiTextEdit.Size = new System.Drawing.Size(200, 22);
            this.demirbas_fiyatiTextEdit.TabIndex = 15;
            // 
            // demirbas_adetSpinEdit
            // 
            this.demirbas_adetSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbl_DemirbaslarBindingSource, "demirbas_adet", true));
            this.demirbas_adetSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.demirbas_adetSpinEdit.Location = new System.Drawing.Point(144, 140);
            this.demirbas_adetSpinEdit.Name = "demirbas_adetSpinEdit";
            this.demirbas_adetSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.demirbas_adetSpinEdit.Size = new System.Drawing.Size(200, 22);
            this.demirbas_adetSpinEdit.TabIndex = 14;
            // 
            // demirbas_aciklamaMemoEdit
            // 
            this.demirbas_aciklamaMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbl_DemirbaslarBindingSource, "demirbas_aciklama", true));
            this.demirbas_aciklamaMemoEdit.Location = new System.Drawing.Point(538, 86);
            this.demirbas_aciklamaMemoEdit.Name = "demirbas_aciklamaMemoEdit";
            this.demirbas_aciklamaMemoEdit.Size = new System.Drawing.Size(200, 106);
            this.demirbas_aciklamaMemoEdit.TabIndex = 13;
            // 
            // demirbas_alis_tarihiDateTimePicker
            // 
            this.demirbas_alis_tarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_DemirbaslarBindingSource, "demirbas_alis_tarihi", true));
            this.demirbas_alis_tarihiDateTimePicker.Location = new System.Drawing.Point(538, 57);
            this.demirbas_alis_tarihiDateTimePicker.Name = "demirbas_alis_tarihiDateTimePicker";
            this.demirbas_alis_tarihiDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.demirbas_alis_tarihiDateTimePicker.TabIndex = 11;
            this.demirbas_alis_tarihiDateTimePicker.Value = new System.DateTime(2017, 5, 8, 0, 0, 0, 0);
            // 
            // demirbas_tur_idLookUpEdit
            // 
            this.demirbas_tur_idLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbl_DemirbaslarBindingSource, "demirbas_tur_id", true));
            this.demirbas_tur_idLookUpEdit.Location = new System.Drawing.Point(144, 112);
            this.demirbas_tur_idLookUpEdit.Name = "demirbas_tur_idLookUpEdit";
            this.demirbas_tur_idLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.demirbas_tur_idLookUpEdit.Properties.DataSource = this.tblDemirbasTurBindingSource;
            this.demirbas_tur_idLookUpEdit.Properties.DisplayMember = "demirbas_adi";
            this.demirbas_tur_idLookUpEdit.Properties.ValueMember = "id";
            this.demirbas_tur_idLookUpEdit.Size = new System.Drawing.Size(200, 22);
            this.demirbas_tur_idLookUpEdit.TabIndex = 5;
            // 
            // tblDemirbasTurBindingSource
            // 
            this.tblDemirbasTurBindingSource.DataMember = "tbl_DemirbasTur";
            this.tblDemirbasTurBindingSource.DataSource = this.aYSDataSet3;
            // 
            // aYSDataSet3
            // 
            this.aYSDataSet3.DataSetName = "AYSDataSet3";
            this.aYSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // demirbas_idTextBox
            // 
            this.demirbas_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_DemirbaslarBindingSource, "demirbas_id", true));
            this.demirbas_idTextBox.Location = new System.Drawing.Point(144, 54);
            this.demirbas_idTextBox.Name = "demirbas_idTextBox";
            this.demirbas_idTextBox.Size = new System.Drawing.Size(200, 23);
            this.demirbas_idTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnVazgec);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 45);
            this.panel1.TabIndex = 3;
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
            // gcDemirbaslar
            // 
            this.gcDemirbaslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDemirbaslar.Location = new System.Drawing.Point(0, 297);
            this.gcDemirbaslar.MainView = this.gvDemirbaslar;
            this.gcDemirbaslar.Name = "gcDemirbaslar";
            this.gcDemirbaslar.Size = new System.Drawing.Size(1193, 414);
            this.gcDemirbaslar.TabIndex = 4;
            this.gcDemirbaslar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDemirbaslar});
            // 
            // gvDemirbaslar
            // 
            this.gvDemirbaslar.GridControl = this.gcDemirbaslar;
            this.gvDemirbaslar.Name = "gvDemirbaslar";
            this.gvDemirbaslar.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDemirbaslar_FocusedRowChanged);
            // 
            // tbl_DemirbaslarTableAdapter
            // 
            this.tbl_DemirbaslarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_BinalarTableAdapter = null;
            this.tableAdapterManager.tbl_DairelerTableAdapter = null;
            this.tableAdapterManager.tbl_DemirbaslarTableAdapter = this.tbl_DemirbaslarTableAdapter;
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
            // tbl_DemirbaslarBindingNavigator
            // 
            this.tbl_DemirbaslarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_DemirbaslarBindingNavigator.BindingSource = this.tbl_DemirbaslarBindingSource;
            this.tbl_DemirbaslarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_DemirbaslarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_DemirbaslarBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_DemirbaslarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_DemirbaslarBindingNavigatorSaveItem});
            this.tbl_DemirbaslarBindingNavigator.Location = new System.Drawing.Point(0, 297);
            this.tbl_DemirbaslarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_DemirbaslarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_DemirbaslarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_DemirbaslarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_DemirbaslarBindingNavigator.Name = "tbl_DemirbaslarBindingNavigator";
            this.tbl_DemirbaslarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_DemirbaslarBindingNavigator.Size = new System.Drawing.Size(1193, 27);
            this.tbl_DemirbaslarBindingNavigator.TabIndex = 5;
            this.tbl_DemirbaslarBindingNavigator.Text = "bindingNavigator1";
            this.tbl_DemirbaslarBindingNavigator.Visible = false;
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
            // tbl_DemirbaslarBindingNavigatorSaveItem
            // 
            this.tbl_DemirbaslarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_DemirbaslarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_DemirbaslarBindingNavigatorSaveItem.Image")));
            this.tbl_DemirbaslarBindingNavigatorSaveItem.Name = "tbl_DemirbaslarBindingNavigatorSaveItem";
            this.tbl_DemirbaslarBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tbl_DemirbaslarBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_DemirbaslarBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_DemirbaslarBindingNavigatorSaveItem_Click);
            // 
            // tbl_DemirbasTurTableAdapter
            // 
            this.tbl_DemirbasTurTableAdapter.ClearBeforeFill = true;
            // 
            // frmDemirbaslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 711);
            this.Controls.Add(this.tbl_DemirbaslarBindingNavigator);
            this.Controls.Add(this.gcDemirbaslar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDemirbaslar";
            this.Text = "Demirbaş İşlemleri";
            this.Load += new System.EventHandler(this.frmDemirbaslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DemirbaslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbas_fiyatiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbas_adetSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbas_aciklamaMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbas_tur_idLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDemirbasTurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDemirbaslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDemirbaslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DemirbaslarBindingNavigator)).EndInit();
            this.tbl_DemirbaslarBindingNavigator.ResumeLayout(false);
            this.tbl_DemirbaslarBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraGrid.GridControl gcDemirbaslar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDemirbaslar;
        private AYSDataSet aYSDataSet;
        private System.Windows.Forms.BindingSource tbl_DemirbaslarBindingSource;
        private AYSDataSetTableAdapters.tbl_DemirbaslarTableAdapter tbl_DemirbaslarTableAdapter;
        private AYSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_DemirbaslarBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_DemirbaslarBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox demirbas_idTextBox;
        private System.Windows.Forms.DateTimePicker demirbas_alis_tarihiDateTimePicker;
        private DevExpress.XtraEditors.LookUpEdit demirbas_tur_idLookUpEdit;
        private DevExpress.XtraEditors.TextEdit demirbas_fiyatiTextEdit;
        private DevExpress.XtraEditors.SpinEdit demirbas_adetSpinEdit;
        private DevExpress.XtraEditors.MemoEdit demirbas_aciklamaMemoEdit;
        private AYSDataSet3 aYSDataSet3;
        private System.Windows.Forms.BindingSource tblDemirbasTurBindingSource;
        private AYSDataSet3TableAdapters.tbl_DemirbasTurTableAdapter tbl_DemirbasTurTableAdapter;
        private System.Windows.Forms.ComboBox daire_noComboBox;
    }
}