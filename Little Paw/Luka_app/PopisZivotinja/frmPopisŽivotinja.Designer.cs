namespace Luka_app.PopisZivotinja
{
    partial class frmPopisŽivotinja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopisŽivotinja));
            this.dgvPopisZivotinja = new System.Windows.Forms.DataGridView();
            this.enciklopedijazivotinjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16045_DBDataSet = new Luka_app._16045_DBDataSet();
            this.enciklopedija_zivotinjaTableAdapter = new Luka_app._16045_DBDataSetTableAdapters.enciklopedija_zivotinjaTableAdapter();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lblRefresh = new System.Windows.Forms.ToolStripLabel();
            this.idzivotinjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karakterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisizgledaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilazaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilazamaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duzinaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duzinamaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZivotinja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enciklopedijazivotinjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16045_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPopisZivotinja
            // 
            this.dgvPopisZivotinja.AllowUserToAddRows = false;
            this.dgvPopisZivotinja.AllowUserToDeleteRows = false;
            this.dgvPopisZivotinja.AutoGenerateColumns = false;
            this.dgvPopisZivotinja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisZivotinja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzivotinjaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.karakterDataGridViewTextBoxColumn,
            this.opisizgledaDataGridViewTextBoxColumn,
            this.kilazaminDataGridViewTextBoxColumn,
            this.kilazamaxDataGridViewTextBoxColumn,
            this.duzinaminDataGridViewTextBoxColumn,
            this.duzinamaxDataGridViewTextBoxColumn});
            this.dgvPopisZivotinja.DataSource = this.enciklopedijazivotinjaBindingSource;
            this.dgvPopisZivotinja.Location = new System.Drawing.Point(12, 28);
            this.dgvPopisZivotinja.Name = "dgvPopisZivotinja";
            this.dgvPopisZivotinja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisZivotinja.Size = new System.Drawing.Size(1233, 423);
            this.dgvPopisZivotinja.TabIndex = 0;
            this.dgvPopisZivotinja.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPopisZivotinja_DataError);
            // 
            // enciklopedijazivotinjaBindingSource
            // 
            this.enciklopedijazivotinjaBindingSource.DataMember = "enciklopedija_zivotinja";
            this.enciklopedijazivotinjaBindingSource.DataSource = this._16045_DBDataSet;
            // 
            // _16045_DBDataSet
            // 
            this._16045_DBDataSet.DataSetName = "_16045_DBDataSet";
            this._16045_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enciklopedija_zivotinjaTableAdapter
            // 
            this.enciklopedija_zivotinjaTableAdapter.ClearBeforeFill = true;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(1149, 469);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(96, 36);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton,
            this.lblRefresh});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1257, 25);
            this.bindingNavigator1.TabIndex = 8;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // lblRefresh
            // 
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(46, 22);
            this.lblRefresh.Text = "Refresh";
            this.lblRefresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // idzivotinjaDataGridViewTextBoxColumn
            // 
            this.idzivotinjaDataGridViewTextBoxColumn.DataPropertyName = "id_zivotinja";
            this.idzivotinjaDataGridViewTextBoxColumn.HeaderText = "id_zivotinja";
            this.idzivotinjaDataGridViewTextBoxColumn.Name = "idzivotinjaDataGridViewTextBoxColumn";
            this.idzivotinjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idzivotinjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv životinje";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 200;
            // 
            // karakterDataGridViewTextBoxColumn
            // 
            this.karakterDataGridViewTextBoxColumn.DataPropertyName = "karakter";
            this.karakterDataGridViewTextBoxColumn.HeaderText = "Karakter";
            this.karakterDataGridViewTextBoxColumn.Name = "karakterDataGridViewTextBoxColumn";
            this.karakterDataGridViewTextBoxColumn.Width = 140;
            // 
            // opisizgledaDataGridViewTextBoxColumn
            // 
            this.opisizgledaDataGridViewTextBoxColumn.DataPropertyName = "opis_izgleda";
            this.opisizgledaDataGridViewTextBoxColumn.HeaderText = "Opis izgleda";
            this.opisizgledaDataGridViewTextBoxColumn.Name = "opisizgledaDataGridViewTextBoxColumn";
            this.opisizgledaDataGridViewTextBoxColumn.Width = 380;
            // 
            // kilazaminDataGridViewTextBoxColumn
            // 
            this.kilazaminDataGridViewTextBoxColumn.DataPropertyName = "kilaza_min";
            this.kilazaminDataGridViewTextBoxColumn.HeaderText = "Min. kilaža (kg)";
            this.kilazaminDataGridViewTextBoxColumn.Name = "kilazaminDataGridViewTextBoxColumn";
            this.kilazaminDataGridViewTextBoxColumn.Width = 110;
            // 
            // kilazamaxDataGridViewTextBoxColumn
            // 
            this.kilazamaxDataGridViewTextBoxColumn.DataPropertyName = "kilaza_max";
            this.kilazamaxDataGridViewTextBoxColumn.HeaderText = "Max. kilaža (kg)";
            this.kilazamaxDataGridViewTextBoxColumn.Name = "kilazamaxDataGridViewTextBoxColumn";
            this.kilazamaxDataGridViewTextBoxColumn.Width = 110;
            // 
            // duzinaminDataGridViewTextBoxColumn
            // 
            this.duzinaminDataGridViewTextBoxColumn.DataPropertyName = "duzina_min";
            this.duzinaminDataGridViewTextBoxColumn.HeaderText = "Min. dužina (cm)";
            this.duzinaminDataGridViewTextBoxColumn.Name = "duzinaminDataGridViewTextBoxColumn";
            this.duzinaminDataGridViewTextBoxColumn.Width = 110;
            // 
            // duzinamaxDataGridViewTextBoxColumn
            // 
            this.duzinamaxDataGridViewTextBoxColumn.DataPropertyName = "duzina_max";
            this.duzinamaxDataGridViewTextBoxColumn.HeaderText = "Max. dužina (cm)";
            this.duzinamaxDataGridViewTextBoxColumn.Name = "duzinamaxDataGridViewTextBoxColumn";
            this.duzinamaxDataGridViewTextBoxColumn.Width = 110;
            // 
            // frmPopisŽivotinja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 517);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dgvPopisZivotinja);
            this.Name = "frmPopisŽivotinja";
            this.Text = "Popis Životinja";
            this.Load += new System.EventHandler(this.frmPopisŽivotinja_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmPopisŽivotinja_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZivotinja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enciklopedijazivotinjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16045_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisZivotinja;
        private _16045_DBDataSet _16045_DBDataSet;
        private System.Windows.Forms.BindingSource enciklopedijazivotinjaBindingSource;
        private _16045_DBDataSetTableAdapters.enciklopedija_zivotinjaTableAdapter enciklopedija_zivotinjaTableAdapter;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripLabel lblRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzivotinjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karakterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisizgledaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilazaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilazamaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duzinaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duzinamaxDataGridViewTextBoxColumn;
    }
}