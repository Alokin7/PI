namespace Luka_app.Enciklopedija_Bolesti
{
    partial class frmNovaBolest
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
            this.txtbIDBolest = new System.Windows.Forms.TextBox();
            this.lblIDBolest = new System.Windows.Forms.Label();
            this.txtbNazivBolest = new System.Windows.Forms.TextBox();
            this.lblNazivBolest = new System.Windows.Forms.Label();
            this.lblOpisBolesti = new System.Windows.Forms.Label();
            this.txtbOpisBolesti = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.enciklopedijabolestiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enciklopedija_bolestiTableAdapter = new Luka_app._16045_DBDataSetTableAdapters.enciklopedija_bolestiTableAdapter();
            this._16045_DBDataSet = new Luka_app._16045_DBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.enciklopedijabolestiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16045_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbIDBolest
            // 
            this.txtbIDBolest.Location = new System.Drawing.Point(78, 43);
            this.txtbIDBolest.Name = "txtbIDBolest";
            this.txtbIDBolest.ReadOnly = true;
            this.txtbIDBolest.Size = new System.Drawing.Size(100, 20);
            this.txtbIDBolest.TabIndex = 0;
            // 
            // lblIDBolest
            // 
            this.lblIDBolest.AutoSize = true;
            this.lblIDBolest.Location = new System.Drawing.Point(48, 46);
            this.lblIDBolest.Name = "lblIDBolest";
            this.lblIDBolest.Size = new System.Drawing.Size(24, 13);
            this.lblIDBolest.TabIndex = 1;
            this.lblIDBolest.Text = "ID: ";
            // 
            // txtbNazivBolest
            // 
            this.txtbNazivBolest.Location = new System.Drawing.Point(78, 82);
            this.txtbNazivBolest.Name = "txtbNazivBolest";
            this.txtbNazivBolest.Size = new System.Drawing.Size(362, 20);
            this.txtbNazivBolest.TabIndex = 2;
            // 
            // lblNazivBolest
            // 
            this.lblNazivBolest.AutoSize = true;
            this.lblNazivBolest.Location = new System.Drawing.Point(32, 85);
            this.lblNazivBolest.Name = "lblNazivBolest";
            this.lblNazivBolest.Size = new System.Drawing.Size(40, 13);
            this.lblNazivBolest.TabIndex = 3;
            this.lblNazivBolest.Text = "Naziv: ";
            // 
            // lblOpisBolesti
            // 
            this.lblOpisBolesti.AutoSize = true;
            this.lblOpisBolesti.Location = new System.Drawing.Point(32, 138);
            this.lblOpisBolesti.Name = "lblOpisBolesti";
            this.lblOpisBolesti.Size = new System.Drawing.Size(34, 13);
            this.lblOpisBolesti.TabIndex = 4;
            this.lblOpisBolesti.Text = "Opis: ";
            // 
            // txtbOpisBolesti
            // 
            this.txtbOpisBolesti.Location = new System.Drawing.Point(78, 138);
            this.txtbOpisBolesti.Multiline = true;
            this.txtbOpisBolesti.Name = "txtbOpisBolesti";
            this.txtbOpisBolesti.Size = new System.Drawing.Size(362, 279);
            this.txtbOpisBolesti.TabIndex = 5;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(251, 457);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(86, 35);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(354, 457);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(86, 35);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // enciklopedijabolestiBindingSource
            // 
            this.enciklopedijabolestiBindingSource.DataMember = "enciklopedija_bolesti";
            // 
            // enciklopedija_bolestiTableAdapter
            // 
            this.enciklopedija_bolestiTableAdapter.ClearBeforeFill = true;
            // 
            // _16045_DBDataSet
            // 
            this._16045_DBDataSet.DataSetName = "_16045_DBDataSet";
            this._16045_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmNovaBolest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 526);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtbOpisBolesti);
            this.Controls.Add(this.lblOpisBolesti);
            this.Controls.Add(this.lblNazivBolest);
            this.Controls.Add(this.txtbNazivBolest);
            this.Controls.Add(this.lblIDBolest);
            this.Controls.Add(this.txtbIDBolest);
            this.Name = "frmNovaBolest";
            this.Text = "Dodaj/Izmijeni Bolest";
            ((System.ComponentModel.ISupportInitialize)(this.enciklopedijabolestiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16045_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbIDBolest;
        private System.Windows.Forms.Label lblIDBolest;
        private System.Windows.Forms.TextBox txtbNazivBolest;
        private System.Windows.Forms.Label lblNazivBolest;
        private System.Windows.Forms.Label lblOpisBolesti;
        private System.Windows.Forms.TextBox txtbOpisBolesti;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.BindingSource enciklopedijabolestiBindingSource;
        private _16045_DBDataSetTableAdapters.enciklopedija_bolestiTableAdapter enciklopedija_bolestiTableAdapter;
        private _16045_DBDataSet _16045_DBDataSet;
    }
}