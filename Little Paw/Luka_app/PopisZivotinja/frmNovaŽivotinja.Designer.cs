namespace Luka_app.PopisZivotinja
{
    partial class frmNovaŽivotinja
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblNazivZivotinje = new System.Windows.Forms.Label();
            this.txtbNazivZivotinje = new System.Windows.Forms.TextBox();
            this.lblIDZivotinje = new System.Windows.Forms.Label();
            this.txtbIDZivotinje = new System.Windows.Forms.TextBox();
            this.lblOpisIzgledaZivotinje = new System.Windows.Forms.Label();
            this.txtbOpisIzgledaZivotinje = new System.Windows.Forms.TextBox();
            this.lblMinTezina = new System.Windows.Forms.Label();
            this.txtbMinTezina = new System.Windows.Forms.TextBox();
            this.lblMinkg = new System.Windows.Forms.Label();
            this.gboxTezinaZivotinje = new System.Windows.Forms.GroupBox();
            this.lblMaxTezina = new System.Windows.Forms.Label();
            this.lblMaxkg = new System.Windows.Forms.Label();
            this.txtbMaxTezina = new System.Windows.Forms.TextBox();
            this.gboxDuljineZivotinje = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMaxcm = new System.Windows.Forms.Label();
            this.txtbMaxDuljina = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMincm = new System.Windows.Forms.Label();
            this.txtbMinDuljina = new System.Windows.Forms.TextBox();
            this.lblOpisKarakteraZivotinje = new System.Windows.Forms.Label();
            this.txtbOpisKarakteraZivotinje = new System.Windows.Forms.TextBox();
            this._16045_DBDataSet = new Luka_app._16045_DBDataSet();
            this.enciklopedijazivotinjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enciklopedija_zivotinjaTableAdapter = new Luka_app._16045_DBDataSetTableAdapters.enciklopedija_zivotinjaTableAdapter();
            this.gboxTezinaZivotinje.SuspendLayout();
            this.gboxDuljineZivotinje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._16045_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enciklopedijazivotinjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(468, 511);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(86, 35);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(365, 511);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(86, 35);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblNazivZivotinje
            // 
            this.lblNazivZivotinje.AutoSize = true;
            this.lblNazivZivotinje.Location = new System.Drawing.Point(53, 67);
            this.lblNazivZivotinje.Name = "lblNazivZivotinje";
            this.lblNazivZivotinje.Size = new System.Drawing.Size(40, 13);
            this.lblNazivZivotinje.TabIndex = 13;
            this.lblNazivZivotinje.Text = "Naziv: ";
            // 
            // txtbNazivZivotinje
            // 
            this.txtbNazivZivotinje.Location = new System.Drawing.Point(99, 64);
            this.txtbNazivZivotinje.Name = "txtbNazivZivotinje";
            this.txtbNazivZivotinje.Size = new System.Drawing.Size(290, 20);
            this.txtbNazivZivotinje.TabIndex = 12;
            // 
            // lblIDZivotinje
            // 
            this.lblIDZivotinje.AutoSize = true;
            this.lblIDZivotinje.Location = new System.Drawing.Point(69, 28);
            this.lblIDZivotinje.Name = "lblIDZivotinje";
            this.lblIDZivotinje.Size = new System.Drawing.Size(24, 13);
            this.lblIDZivotinje.TabIndex = 11;
            this.lblIDZivotinje.Text = "ID: ";
            // 
            // txtbIDZivotinje
            // 
            this.txtbIDZivotinje.Location = new System.Drawing.Point(99, 25);
            this.txtbIDZivotinje.Name = "txtbIDZivotinje";
            this.txtbIDZivotinje.ReadOnly = true;
            this.txtbIDZivotinje.Size = new System.Drawing.Size(100, 20);
            this.txtbIDZivotinje.TabIndex = 10;
            // 
            // lblOpisIzgledaZivotinje
            // 
            this.lblOpisIzgledaZivotinje.AutoSize = true;
            this.lblOpisIzgledaZivotinje.Location = new System.Drawing.Point(23, 106);
            this.lblOpisIzgledaZivotinje.Name = "lblOpisIzgledaZivotinje";
            this.lblOpisIzgledaZivotinje.Size = new System.Drawing.Size(70, 13);
            this.lblOpisIzgledaZivotinje.TabIndex = 15;
            this.lblOpisIzgledaZivotinje.Text = "Opis izgleda: ";
            // 
            // txtbOpisIzgledaZivotinje
            // 
            this.txtbOpisIzgledaZivotinje.Location = new System.Drawing.Point(99, 103);
            this.txtbOpisIzgledaZivotinje.Multiline = true;
            this.txtbOpisIzgledaZivotinje.Name = "txtbOpisIzgledaZivotinje";
            this.txtbOpisIzgledaZivotinje.Size = new System.Drawing.Size(455, 134);
            this.txtbOpisIzgledaZivotinje.TabIndex = 14;
            // 
            // lblMinTezina
            // 
            this.lblMinTezina.AutoSize = true;
            this.lblMinTezina.Location = new System.Drawing.Point(28, 29);
            this.lblMinTezina.Name = "lblMinTezina";
            this.lblMinTezina.Size = new System.Drawing.Size(60, 13);
            this.lblMinTezina.TabIndex = 17;
            this.lblMinTezina.Text = "Minimalna: ";
            // 
            // txtbMinTezina
            // 
            this.txtbMinTezina.Location = new System.Drawing.Point(104, 26);
            this.txtbMinTezina.Name = "txtbMinTezina";
            this.txtbMinTezina.Size = new System.Drawing.Size(72, 20);
            this.txtbMinTezina.TabIndex = 18;
            // 
            // lblMinkg
            // 
            this.lblMinkg.AutoSize = true;
            this.lblMinkg.Location = new System.Drawing.Point(182, 29);
            this.lblMinkg.Name = "lblMinkg";
            this.lblMinkg.Size = new System.Drawing.Size(19, 13);
            this.lblMinkg.TabIndex = 19;
            this.lblMinkg.Text = "kg";
            // 
            // gboxTezinaZivotinje
            // 
            this.gboxTezinaZivotinje.Controls.Add(this.lblMaxTezina);
            this.gboxTezinaZivotinje.Controls.Add(this.lblMaxkg);
            this.gboxTezinaZivotinje.Controls.Add(this.txtbMaxTezina);
            this.gboxTezinaZivotinje.Controls.Add(this.lblMinTezina);
            this.gboxTezinaZivotinje.Controls.Add(this.lblMinkg);
            this.gboxTezinaZivotinje.Controls.Add(this.txtbMinTezina);
            this.gboxTezinaZivotinje.Location = new System.Drawing.Point(26, 266);
            this.gboxTezinaZivotinje.Name = "gboxTezinaZivotinje";
            this.gboxTezinaZivotinje.Size = new System.Drawing.Size(244, 100);
            this.gboxTezinaZivotinje.TabIndex = 20;
            this.gboxTezinaZivotinje.TabStop = false;
            this.gboxTezinaZivotinje.Text = "Težina";
            // 
            // lblMaxTezina
            // 
            this.lblMaxTezina.AutoSize = true;
            this.lblMaxTezina.Location = new System.Drawing.Point(28, 55);
            this.lblMaxTezina.Name = "lblMaxTezina";
            this.lblMaxTezina.Size = new System.Drawing.Size(67, 13);
            this.lblMaxTezina.TabIndex = 20;
            this.lblMaxTezina.Text = "Makrimalna: ";
            // 
            // lblMaxkg
            // 
            this.lblMaxkg.AutoSize = true;
            this.lblMaxkg.Location = new System.Drawing.Point(182, 55);
            this.lblMaxkg.Name = "lblMaxkg";
            this.lblMaxkg.Size = new System.Drawing.Size(19, 13);
            this.lblMaxkg.TabIndex = 22;
            this.lblMaxkg.Text = "kg";
            // 
            // txtbMaxTezina
            // 
            this.txtbMaxTezina.Location = new System.Drawing.Point(104, 52);
            this.txtbMaxTezina.Name = "txtbMaxTezina";
            this.txtbMaxTezina.Size = new System.Drawing.Size(72, 20);
            this.txtbMaxTezina.TabIndex = 21;
            // 
            // gboxDuljineZivotinje
            // 
            this.gboxDuljineZivotinje.Controls.Add(this.label11);
            this.gboxDuljineZivotinje.Controls.Add(this.lblMaxcm);
            this.gboxDuljineZivotinje.Controls.Add(this.txtbMaxDuljina);
            this.gboxDuljineZivotinje.Controls.Add(this.label12);
            this.gboxDuljineZivotinje.Controls.Add(this.lblMincm);
            this.gboxDuljineZivotinje.Controls.Add(this.txtbMinDuljina);
            this.gboxDuljineZivotinje.Location = new System.Drawing.Point(26, 372);
            this.gboxDuljineZivotinje.Name = "gboxDuljineZivotinje";
            this.gboxDuljineZivotinje.Size = new System.Drawing.Size(244, 100);
            this.gboxDuljineZivotinje.TabIndex = 21;
            this.gboxDuljineZivotinje.TabStop = false;
            this.gboxDuljineZivotinje.Text = "Duljina";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Makrimalna: ";
            // 
            // lblMaxcm
            // 
            this.lblMaxcm.AutoSize = true;
            this.lblMaxcm.Location = new System.Drawing.Point(182, 55);
            this.lblMaxcm.Name = "lblMaxcm";
            this.lblMaxcm.Size = new System.Drawing.Size(21, 13);
            this.lblMaxcm.TabIndex = 22;
            this.lblMaxcm.Text = "cm";
            // 
            // txtbMaxDuljina
            // 
            this.txtbMaxDuljina.Location = new System.Drawing.Point(104, 52);
            this.txtbMaxDuljina.Name = "txtbMaxDuljina";
            this.txtbMaxDuljina.Size = new System.Drawing.Size(72, 20);
            this.txtbMaxDuljina.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Minimalna: ";
            // 
            // lblMincm
            // 
            this.lblMincm.AutoSize = true;
            this.lblMincm.Location = new System.Drawing.Point(182, 29);
            this.lblMincm.Name = "lblMincm";
            this.lblMincm.Size = new System.Drawing.Size(21, 13);
            this.lblMincm.TabIndex = 19;
            this.lblMincm.Text = "cm";
            // 
            // txtbMinDuljina
            // 
            this.txtbMinDuljina.Location = new System.Drawing.Point(104, 26);
            this.txtbMinDuljina.Name = "txtbMinDuljina";
            this.txtbMinDuljina.Size = new System.Drawing.Size(72, 20);
            this.txtbMinDuljina.TabIndex = 18;
            // 
            // lblOpisKarakteraZivotinje
            // 
            this.lblOpisKarakteraZivotinje.AutoSize = true;
            this.lblOpisKarakteraZivotinje.Location = new System.Drawing.Point(296, 266);
            this.lblOpisKarakteraZivotinje.Name = "lblOpisKarakteraZivotinje";
            this.lblOpisKarakteraZivotinje.Size = new System.Drawing.Size(82, 13);
            this.lblOpisKarakteraZivotinje.TabIndex = 23;
            this.lblOpisKarakteraZivotinje.Text = "Opis karaktera: ";
            // 
            // txtbOpisKarakteraZivotinje
            // 
            this.txtbOpisKarakteraZivotinje.Location = new System.Drawing.Point(299, 292);
            this.txtbOpisKarakteraZivotinje.Multiline = true;
            this.txtbOpisKarakteraZivotinje.Name = "txtbOpisKarakteraZivotinje";
            this.txtbOpisKarakteraZivotinje.Size = new System.Drawing.Size(255, 180);
            this.txtbOpisKarakteraZivotinje.TabIndex = 22;
            // 
            // _16045_DBDataSet
            // 
            this._16045_DBDataSet.DataSetName = "_16045_DBDataSet";
            this._16045_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enciklopedijazivotinjaBindingSource
            // 
            this.enciklopedijazivotinjaBindingSource.DataMember = "enciklopedija_zivotinja";
            this.enciklopedijazivotinjaBindingSource.DataSource = this._16045_DBDataSet;
            // 
            // enciklopedija_zivotinjaTableAdapter
            // 
            this.enciklopedija_zivotinjaTableAdapter.ClearBeforeFill = true;
            // 
            // frmNovaŽivotinja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 568);
            this.Controls.Add(this.lblOpisKarakteraZivotinje);
            this.Controls.Add(this.txtbOpisKarakteraZivotinje);
            this.Controls.Add(this.gboxDuljineZivotinje);
            this.Controls.Add(this.gboxTezinaZivotinje);
            this.Controls.Add(this.lblOpisIzgledaZivotinje);
            this.Controls.Add(this.txtbOpisIzgledaZivotinje);
            this.Controls.Add(this.lblNazivZivotinje);
            this.Controls.Add(this.txtbNazivZivotinje);
            this.Controls.Add(this.lblIDZivotinje);
            this.Controls.Add(this.txtbIDZivotinje);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Name = "frmNovaŽivotinja";
            this.Text = "Dodaj/izmijeni Životinju";
            this.gboxTezinaZivotinje.ResumeLayout(false);
            this.gboxTezinaZivotinje.PerformLayout();
            this.gboxDuljineZivotinje.ResumeLayout(false);
            this.gboxDuljineZivotinje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._16045_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enciklopedijazivotinjaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblNazivZivotinje;
        private System.Windows.Forms.TextBox txtbNazivZivotinje;
        private System.Windows.Forms.Label lblIDZivotinje;
        private System.Windows.Forms.TextBox txtbIDZivotinje;
        private System.Windows.Forms.Label lblOpisIzgledaZivotinje;
        private System.Windows.Forms.TextBox txtbOpisIzgledaZivotinje;
        private System.Windows.Forms.Label lblMinTezina;
        private System.Windows.Forms.TextBox txtbMinTezina;
        private System.Windows.Forms.Label lblMinkg;
        private System.Windows.Forms.GroupBox gboxTezinaZivotinje;
        private System.Windows.Forms.Label lblMaxTezina;
        private System.Windows.Forms.Label lblMaxkg;
        private System.Windows.Forms.TextBox txtbMaxTezina;
        private System.Windows.Forms.GroupBox gboxDuljineZivotinje;
        private System.Windows.Forms.Label lblMaxcm;
        private System.Windows.Forms.TextBox txtbMaxDuljina;
        private System.Windows.Forms.Label lblMincm;
        private System.Windows.Forms.TextBox txtbMinDuljina;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblOpisKarakteraZivotinje;
        private System.Windows.Forms.TextBox txtbOpisKarakteraZivotinje;
        private _16045_DBDataSet _16045_DBDataSet;
        private System.Windows.Forms.BindingSource enciklopedijazivotinjaBindingSource;
        private _16045_DBDataSetTableAdapters.enciklopedija_zivotinjaTableAdapter enciklopedija_zivotinjaTableAdapter;
    }
}