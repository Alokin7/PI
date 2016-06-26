namespace Little_Paw.Forme
{
    partial class TajnicaMDIForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TajnicaMDIForma));
            this.tajnicaMDIMeni = new System.Windows.Forms.MenuStrip();
            this.tajnicaMDIMeniKalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.tajnicaMDIMeniStanje_Lijekova = new System.Windows.Forms.ToolStripMenuItem();
            this.tajnicaMDIMeniTrenutnoStanje = new System.Windows.Forms.ToolStripMenuItem();
            this.tajnicaMDIMeniKorisnici = new System.Windows.Forms.ToolStripMenuItem();
            this.tajnicaMDIMeniKorisniciVlasnik = new System.Windows.Forms.ToolStripMenuItem();
            this.tajnicaMDIMeniKorisniciLjubimac = new System.Windows.Forms.ToolStripMenuItem();
            this.tajnicaMDIMeniKalendarTerminiPregleda = new System.Windows.Forms.ToolStripMenuItem();
            this.tajnicaMDIMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // tajnicaMDIMeni
            // 
            this.tajnicaMDIMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tajnicaMDIMeniKalendar,
            this.tajnicaMDIMeniStanje_Lijekova,
            this.tajnicaMDIMeniKorisnici});
            this.tajnicaMDIMeni.Location = new System.Drawing.Point(0, 0);
            this.tajnicaMDIMeni.Name = "tajnicaMDIMeni";
            this.tajnicaMDIMeni.Size = new System.Drawing.Size(484, 24);
            this.tajnicaMDIMeni.TabIndex = 1;
            this.tajnicaMDIMeni.Text = "tajnicaMDIMeni";
            // 
            // tajnicaMDIMeniKalendar
            // 
            this.tajnicaMDIMeniKalendar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tajnicaMDIMeniKalendarTerminiPregleda});
            this.tajnicaMDIMeniKalendar.Name = "tajnicaMDIMeniKalendar";
            this.tajnicaMDIMeniKalendar.Size = new System.Drawing.Size(65, 20);
            this.tajnicaMDIMeniKalendar.Text = "Kalendar";
            // 
            // tajnicaMDIMeniStanje_Lijekova
            // 
            this.tajnicaMDIMeniStanje_Lijekova.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tajnicaMDIMeniTrenutnoStanje});
            this.tajnicaMDIMeniStanje_Lijekova.Name = "tajnicaMDIMeniStanje_Lijekova";
            this.tajnicaMDIMeniStanje_Lijekova.Size = new System.Drawing.Size(97, 20);
            this.tajnicaMDIMeniStanje_Lijekova.Text = "Stanje Lijekova";
            // 
            // tajnicaMDIMeniTrenutnoStanje
            // 
            this.tajnicaMDIMeniTrenutnoStanje.Name = "tajnicaMDIMeniTrenutnoStanje";
            this.tajnicaMDIMeniTrenutnoStanje.Size = new System.Drawing.Size(157, 22);
            this.tajnicaMDIMeniTrenutnoStanje.Text = "Trenutno Stanje";
            this.tajnicaMDIMeniTrenutnoStanje.Click += new System.EventHandler(this.tajnicaMDIMeniTrenutnoStanje_Click);
            // 
            // tajnicaMDIMeniKorisnici
            // 
            this.tajnicaMDIMeniKorisnici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tajnicaMDIMeniKorisniciVlasnik,
            this.tajnicaMDIMeniKorisniciLjubimac});
            this.tajnicaMDIMeniKorisnici.Name = "tajnicaMDIMeniKorisnici";
            this.tajnicaMDIMeniKorisnici.Size = new System.Drawing.Size(64, 20);
            this.tajnicaMDIMeniKorisnici.Text = "Korisnici";
            // 
            // tajnicaMDIMeniKorisniciVlasnik
            // 
            this.tajnicaMDIMeniKorisniciVlasnik.Name = "tajnicaMDIMeniKorisniciVlasnik";
            this.tajnicaMDIMeniKorisniciVlasnik.Size = new System.Drawing.Size(123, 22);
            this.tajnicaMDIMeniKorisniciVlasnik.Text = "Vlasnik";
            // 
            // tajnicaMDIMeniKorisniciLjubimac
            // 
            this.tajnicaMDIMeniKorisniciLjubimac.Name = "tajnicaMDIMeniKorisniciLjubimac";
            this.tajnicaMDIMeniKorisniciLjubimac.Size = new System.Drawing.Size(123, 22);
            this.tajnicaMDIMeniKorisniciLjubimac.Text = "Ljubimac";
            // 
            // tajnicaMDIMeniKalendarTerminiPregleda
            // 
            this.tajnicaMDIMeniKalendarTerminiPregleda.Name = "tajnicaMDIMeniKalendarTerminiPregleda";
            this.tajnicaMDIMeniKalendarTerminiPregleda.Size = new System.Drawing.Size(163, 22);
            this.tajnicaMDIMeniKalendarTerminiPregleda.Text = "Termini Pregleda";
            this.tajnicaMDIMeniKalendarTerminiPregleda.Click += new System.EventHandler(this.tajnicaMDIMeniKalendarTerminiPregleda_Click);
            // 
            // TajnicaMDIForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tajnicaMDIMeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.tajnicaMDIMeni;
            this.Name = "TajnicaMDIForma";
            this.Text = "Tajnica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TajnicaMDIForma_FormClosed);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.TajnicaMDIForma_HelpRequested);
            this.tajnicaMDIMeni.ResumeLayout(false);
            this.tajnicaMDIMeni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tajnicaMDIMeni;
        private System.Windows.Forms.ToolStripMenuItem tajnicaMDIMeniKalendar;
        private System.Windows.Forms.ToolStripMenuItem tajnicaMDIMeniStanje_Lijekova;
        private System.Windows.Forms.ToolStripMenuItem tajnicaMDIMeniKorisnici;
        private System.Windows.Forms.ToolStripMenuItem tajnicaMDIMeniKorisniciVlasnik;
        private System.Windows.Forms.ToolStripMenuItem tajnicaMDIMeniKorisniciLjubimac;
        private System.Windows.Forms.ToolStripMenuItem tajnicaMDIMeniTrenutnoStanje;
        private System.Windows.Forms.ToolStripMenuItem tajnicaMDIMeniKalendarTerminiPregleda;
    }
}