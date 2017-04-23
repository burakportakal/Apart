namespace ApartYonetim
{
    partial class frmMusteriler
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
            this.grSorgula = new DevExpress.XtraGrid.GridControl();
            this.gridSorgulama = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.aYSDataSet = new ApartYonetim.AYSDataSet();
            this.tbl_MusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MusterilerTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.tbl_MusterilerTableAdapter();
            this.tableAdapterManager = new ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager();
            this.tbl_GelirTuruTableAdapter = new ApartYonetim.AYSDataSetTableAdapters.tbl_GelirTuruTableAdapter();
            this.tbl_GelirTuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bina_adiComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grSorgula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSorgulama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MusterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GelirTuruBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grSorgula
            // 
            this.grSorgula.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grSorgula.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grSorgula.Location = new System.Drawing.Point(0, 203);
            this.grSorgula.MainView = this.gridSorgulama;
            this.grSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grSorgula.Name = "grSorgula";
            this.grSorgula.Size = new System.Drawing.Size(1065, 260);
            this.grSorgula.TabIndex = 0;
            this.grSorgula.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSorgulama});
            // 
            // gridSorgulama
            // 
            this.gridSorgulama.GridControl = this.grSorgula;
            this.gridSorgulama.Name = "gridSorgulama";
            this.gridSorgulama.OptionsBehavior.Editable = false;
            this.gridSorgulama.OptionsBehavior.ReadOnly = true;
            this.gridSorgulama.OptionsView.ShowFooter = true;
            this.gridSorgulama.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // aYSDataSet
            // 
            this.aYSDataSet.DataSetName = "AYSDataSet";
            this.aYSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_MusterilerBindingSource
            // 
            this.tbl_MusterilerBindingSource.DataMember = "tbl_Musteriler";
            this.tbl_MusterilerBindingSource.DataSource = this.aYSDataSet;
            // 
            // tbl_MusterilerTableAdapter
            // 
            this.tbl_MusterilerTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tbl_GelirTuruTableAdapter = this.tbl_GelirTuruTableAdapter;
            this.tableAdapterManager.tbl_GiderTableAdapter = null;
            this.tableAdapterManager.tbl_GiderTuruTableAdapter = null;
            this.tableAdapterManager.tbl_KiralarTableAdapter = null;
            this.tableAdapterManager.tbl_MusterilerTableAdapter = this.tbl_MusterilerTableAdapter;
            this.tableAdapterManager.tbl_OrtakFaturaTableAdapter = null;
            this.tableAdapterManager.tbl_YoneticiBinaTableAdapter = null;
            this.tableAdapterManager.tbl_YoneticilerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ApartYonetim.AYSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_GelirTuruTableAdapter
            // 
            this.tbl_GelirTuruTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_GelirTuruBindingSource
            // 
            this.tbl_GelirTuruBindingSource.DataMember = "tbl_GelirTuru";
            this.tbl_GelirTuruBindingSource.DataSource = this.aYSDataSet;
            // 
            // bina_adiComboBox
            // 
            this.bina_adiComboBox.FormattingEnabled = true;
            this.bina_adiComboBox.Location = new System.Drawing.Point(50, 51);
            this.bina_adiComboBox.Name = "bina_adiComboBox";
            this.bina_adiComboBox.Size = new System.Drawing.Size(121, 21);
            this.bina_adiComboBox.TabIndex = 1;
            this.bina_adiComboBox.SelectedIndexChanged += new System.EventHandler(this.bina_adiComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bina_adiComboBox);
            this.Controls.Add(this.grSorgula);
            this.Name = "frmMusteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grSorgula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSorgulama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MusterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GelirTuruBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grSorgula;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSorgulama;
        private AYSDataSet aYSDataSet;
        private System.Windows.Forms.BindingSource tbl_MusterilerBindingSource;
        private AYSDataSetTableAdapters.tbl_MusterilerTableAdapter tbl_MusterilerTableAdapter;
        private AYSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AYSDataSetTableAdapters.tbl_GelirTuruTableAdapter tbl_GelirTuruTableAdapter;
        private System.Windows.Forms.BindingSource tbl_GelirTuruBindingSource;
        private System.Windows.Forms.ComboBox bina_adiComboBox;
        private System.Windows.Forms.Label label1;
    }
}