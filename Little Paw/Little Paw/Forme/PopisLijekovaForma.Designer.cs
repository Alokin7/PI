namespace Little_Paw.Forme
{
    partial class PopisLijekovaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopisLijekovaForma));
            this._16045_DBDataSet = new Little_Paw._16045_DBDataSet();
            this.popis_lijekovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popis_lijekovaTableAdapter = new Little_Paw._16045_DBDataSetTableAdapters.popis_lijekovaTableAdapter();
            this.tableAdapterManager = new Little_Paw._16045_DBDataSetTableAdapters.TableAdapterManager();
            this.popis_lijekovaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.popis_lijekovaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Uredi = new System.Windows.Forms.ToolStripButton();
            this.Azuriraj = new System.Windows.Forms.ToolStripButton();
            this.popis_lijekovaDataGridView = new System.Windows.Forms.DataGridView();
            this.id_lijek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this._16045_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popis_lijekovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popis_lijekovaBindingNavigator)).BeginInit();
            this.popis_lijekovaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popis_lijekovaDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _16045_DBDataSet
            // 
            this._16045_DBDataSet.DataSetName = "_16045_DBDataSet";
            this._16045_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // popis_lijekovaBindingSource
            // 
            this.popis_lijekovaBindingSource.DataMember = "popis_lijekova";
            this.popis_lijekovaBindingSource.DataSource = this._16045_DBDataSet;
            // 
            // popis_lijekovaTableAdapter
            // 
            this.popis_lijekovaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bolesti_lijekoviTableAdapter = null;
            this.tableAdapterManager.enciklopedija_bolestiTableAdapter = null;
            this.tableAdapterManager.enciklopedija_zivotinjaTableAdapter = null;
            this.tableAdapterManager.korisnikTableAdapter = null;
            this.tableAdapterManager.ljubimacTableAdapter = null;
            this.tableAdapterManager.popis_lijekovaTableAdapter = this.popis_lijekovaTableAdapter;
            this.tableAdapterManager.terminTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Little_Paw._16045_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vlasnik_ljubimacTableAdapter = null;
            this.tableAdapterManager.vlasnikTableAdapter = null;
            this.tableAdapterManager.vrsta_zahvataTableAdapter = null;
            // 
            // popis_lijekovaBindingNavigator
            // 
            this.popis_lijekovaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.popis_lijekovaBindingNavigator.BindingSource = this.popis_lijekovaBindingSource;
            this.popis_lijekovaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.popis_lijekovaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.popis_lijekovaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.popis_lijekovaBindingNavigatorSaveItem,
            this.Uredi,
            this.Azuriraj});
            this.popis_lijekovaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.popis_lijekovaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.popis_lijekovaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.popis_lijekovaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.popis_lijekovaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.popis_lijekovaBindingNavigator.Name = "popis_lijekovaBindingNavigator";
            this.popis_lijekovaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.popis_lijekovaBindingNavigator.Size = new System.Drawing.Size(1051, 25);
            this.popis_lijekovaBindingNavigator.TabIndex = 0;
            this.popis_lijekovaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // popis_lijekovaBindingNavigatorSaveItem
            // 
            this.popis_lijekovaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.popis_lijekovaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("popis_lijekovaBindingNavigatorSaveItem.Image")));
            this.popis_lijekovaBindingNavigatorSaveItem.Name = "popis_lijekovaBindingNavigatorSaveItem";
            this.popis_lijekovaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.popis_lijekovaBindingNavigatorSaveItem.Text = "Save Data";
            this.popis_lijekovaBindingNavigatorSaveItem.Visible = false;
            this.popis_lijekovaBindingNavigatorSaveItem.Click += new System.EventHandler(this.popis_lijekovaBindingNavigatorSaveItem_Click);
            // 
            // Uredi
            // 
            this.Uredi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Uredi.Image = ((System.Drawing.Image)(resources.GetObject("Uredi.Image")));
            this.Uredi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Uredi.Name = "Uredi";
            this.Uredi.Size = new System.Drawing.Size(23, 22);
            this.Uredi.Text = "Uredi";
            this.Uredi.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Azuriraj
            // 
            this.Azuriraj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Azuriraj.Image = ((System.Drawing.Image)(resources.GetObject("Azuriraj.Image")));
            this.Azuriraj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Azuriraj.Name = "Azuriraj";
            this.Azuriraj.Size = new System.Drawing.Size(23, 22);
            this.Azuriraj.Text = "Ažuriraj";
            this.Azuriraj.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // popis_lijekovaDataGridView
            // 
            this.popis_lijekovaDataGridView.AllowUserToAddRows = false;
            this.popis_lijekovaDataGridView.AllowUserToDeleteRows = false;
            this.popis_lijekovaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popis_lijekovaDataGridView.AutoGenerateColumns = false;
            this.popis_lijekovaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.popis_lijekovaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.popis_lijekovaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popis_lijekovaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_lijek,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.popis_lijekovaDataGridView.DataSource = this.popis_lijekovaBindingSource;
            this.popis_lijekovaDataGridView.Location = new System.Drawing.Point(13, 26);
            this.popis_lijekovaDataGridView.Name = "popis_lijekovaDataGridView";
            this.popis_lijekovaDataGridView.ReadOnly = true;
            this.popis_lijekovaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.popis_lijekovaDataGridView.Size = new System.Drawing.Size(1023, 423);
            this.popis_lijekovaDataGridView.TabIndex = 1;
            this.popis_lijekovaDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.popis_lijekovaDataGridView_RowPrePaint);
            this.popis_lijekovaDataGridView.SelectionChanged += new System.EventHandler(this.popis_lijekovaDataGridView_SelectionChanged);
            // 
            // id_lijek
            // 
            this.id_lijek.DataPropertyName = "id_lijek";
            this.id_lijek.HeaderText = "šifra";
            this.id_lijek.Name = "id_lijek";
            this.id_lijek.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "opis";
            this.dataGridViewTextBoxColumn3.HeaderText = "opis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "proizvodac";
            this.dataGridViewTextBoxColumn4.HeaderText = "proizvodac";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valjanost";
            this.dataGridViewTextBoxColumn5.HeaderText = "valjanost";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nuspojave";
            this.dataGridViewTextBoxColumn6.HeaderText = "nuspojave";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn7.HeaderText = "kolicina";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.Controls.Add(this.popis_lijekovaDataGridView, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 477);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PopisLijekovaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.popis_lijekovaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopisLijekovaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PopisLijekovaForma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PopisLijekovaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this._16045_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popis_lijekovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popis_lijekovaBindingNavigator)).EndInit();
            this.popis_lijekovaBindingNavigator.ResumeLayout(false);
            this.popis_lijekovaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popis_lijekovaDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _16045_DBDataSet _16045_DBDataSet;
        private System.Windows.Forms.BindingSource popis_lijekovaBindingSource;
        private _16045_DBDataSetTableAdapters.popis_lijekovaTableAdapter popis_lijekovaTableAdapter;
        private _16045_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator popis_lijekovaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton popis_lijekovaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView popis_lijekovaDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lijek;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStripButton Uredi;
        private System.Windows.Forms.ToolStripButton Azuriraj;
    }
}