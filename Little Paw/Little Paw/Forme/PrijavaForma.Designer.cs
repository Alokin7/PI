namespace Little_Paw
{
    partial class PrijavaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaForma));
            this.korisnickoImeLabela = new System.Windows.Forms.Label();
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaLabela = new System.Windows.Forms.Label();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.korisnikTableAdapter1 = new Little_Paw._16045_DBDataSetTableAdapters.korisnikTableAdapter();
            this.SuspendLayout();
            // 
            // korisnickoImeLabela
            // 
            this.korisnickoImeLabela.AutoSize = true;
            this.korisnickoImeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.korisnickoImeLabela.Location = new System.Drawing.Point(50, 70);
            this.korisnickoImeLabela.Name = "korisnickoImeLabela";
            this.korisnickoImeLabela.Size = new System.Drawing.Size(103, 17);
            this.korisnickoImeLabela.TabIndex = 0;
            this.korisnickoImeLabela.Text = "Korisnicko Ime:";
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(159, 70);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(163, 20);
            this.korisnickoImeTextBox.TabIndex = 1;
            // 
            // lozinkaLabela
            // 
            this.lozinkaLabela.AutoSize = true;
            this.lozinkaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lozinkaLabela.Location = new System.Drawing.Point(50, 140);
            this.lozinkaLabela.Name = "lozinkaLabela";
            this.lozinkaLabela.Size = new System.Drawing.Size(61, 17);
            this.lozinkaLabela.TabIndex = 2;
            this.lozinkaLabela.Text = "Lozinka:";
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(117, 140);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(205, 20);
            this.lozinkaTextBox.TabIndex = 3;
            this.lozinkaTextBox.UseSystemPasswordChar = true;
            // 
            // prijavaButton
            // 
            this.prijavaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.prijavaButton.Location = new System.Drawing.Point(150, 210);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(80, 30);
            this.prijavaButton.TabIndex = 4;
            this.prijavaButton.Text = "Prijava";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // korisnikTableAdapter1
            // 
            this.korisnikTableAdapter1.ClearBeforeFill = true;
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 286);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(this.lozinkaLabela);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.Controls.Add(this.korisnickoImeLabela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrijavaForma";
            this.Text = "Little Paw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label korisnickoImeLabela;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.Label lozinkaLabela;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.Button prijavaButton;
        private _16045_DBDataSetTableAdapters.korisnikTableAdapter korisnikTableAdapter1;
    }
}

