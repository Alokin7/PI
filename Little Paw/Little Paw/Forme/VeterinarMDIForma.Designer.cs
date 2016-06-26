namespace Little_Paw.Forme
{
    partial class VeterinarMDIForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeterinarMDIForma));
            this.veterinarMDIMeni = new System.Windows.Forms.MenuStrip();
            this.veterinarMDIMeniKalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarMDIMeniStanje_Lijekova = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarMDIMeniUnosNovogLijeka = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarMDIMeniTrenutnoStanje = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarMDIMeniKarton_Zivotinja = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarMDIMeniPopis_Zivotinja = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarMDIMeniEnciklopedija = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarMDIMeniKalendarTerminiPregleda = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarMDIMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // veterinarMDIMeni
            // 
            this.veterinarMDIMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veterinarMDIMeniKalendar,
            this.veterinarMDIMeniStanje_Lijekova,
            this.veterinarMDIMeniKarton_Zivotinja,
            this.veterinarMDIMeniPopis_Zivotinja,
            this.veterinarMDIMeniEnciklopedija});
            this.veterinarMDIMeni.Location = new System.Drawing.Point(0, 0);
            this.veterinarMDIMeni.Name = "veterinarMDIMeni";
            this.veterinarMDIMeni.Size = new System.Drawing.Size(1350, 24);
            this.veterinarMDIMeni.TabIndex = 1;
            this.veterinarMDIMeni.Text = "veterinarMDIMeni";
            // 
            // veterinarMDIMeniKalendar
            // 
            this.veterinarMDIMeniKalendar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veterinarMDIMeniKalendarTerminiPregleda});
            this.veterinarMDIMeniKalendar.Name = "veterinarMDIMeniKalendar";
            this.veterinarMDIMeniKalendar.Size = new System.Drawing.Size(65, 20);
            this.veterinarMDIMeniKalendar.Text = "Kalendar";
            // 
            // veterinarMDIMeniStanje_Lijekova
            // 
            this.veterinarMDIMeniStanje_Lijekova.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veterinarMDIMeniUnosNovogLijeka,
            this.veterinarMDIMeniTrenutnoStanje});
            this.veterinarMDIMeniStanje_Lijekova.Name = "veterinarMDIMeniStanje_Lijekova";
            this.veterinarMDIMeniStanje_Lijekova.Size = new System.Drawing.Size(97, 20);
            this.veterinarMDIMeniStanje_Lijekova.Text = "Stanje Lijekova";
            // 
            // veterinarMDIMeniUnosNovogLijeka
            // 
            this.veterinarMDIMeniUnosNovogLijeka.Name = "veterinarMDIMeniUnosNovogLijeka";
            this.veterinarMDIMeniUnosNovogLijeka.Size = new System.Drawing.Size(173, 22);
            this.veterinarMDIMeniUnosNovogLijeka.Text = "Unos Novog Lijeka";
            this.veterinarMDIMeniUnosNovogLijeka.Click += new System.EventHandler(this.veterinarMDIMeniUnosNovogLijeka_Click);
            // 
            // veterinarMDIMeniTrenutnoStanje
            // 
            this.veterinarMDIMeniTrenutnoStanje.Name = "veterinarMDIMeniTrenutnoStanje";
            this.veterinarMDIMeniTrenutnoStanje.Size = new System.Drawing.Size(173, 22);
            this.veterinarMDIMeniTrenutnoStanje.Text = "Trenutno Stanje";
            this.veterinarMDIMeniTrenutnoStanje.Click += new System.EventHandler(this.trenutnoStanjeToolStripMenuItem_Click);
            // 
            // veterinarMDIMeniKarton_Zivotinja
            // 
            this.veterinarMDIMeniKarton_Zivotinja.Name = "veterinarMDIMeniKarton_Zivotinja";
            this.veterinarMDIMeniKarton_Zivotinja.Size = new System.Drawing.Size(103, 20);
            this.veterinarMDIMeniKarton_Zivotinja.Text = "Karton Životinja";
            // 
            // veterinarMDIMeniPopis_Zivotinja
            // 
            this.veterinarMDIMeniPopis_Zivotinja.Name = "veterinarMDIMeniPopis_Zivotinja";
            this.veterinarMDIMeniPopis_Zivotinja.Size = new System.Drawing.Size(97, 20);
            this.veterinarMDIMeniPopis_Zivotinja.Text = "Popis Životinja";
            this.veterinarMDIMeniPopis_Zivotinja.Click += new System.EventHandler(this.veterinarMDIMeniPopis_Zivotinja_Click);
            // 
            // veterinarMDIMeniEnciklopedija
            // 
            this.veterinarMDIMeniEnciklopedija.Name = "veterinarMDIMeniEnciklopedija";
            this.veterinarMDIMeniEnciklopedija.Size = new System.Drawing.Size(127, 20);
            this.veterinarMDIMeniEnciklopedija.Text = "Enciklopedija Bolesti";
            this.veterinarMDIMeniEnciklopedija.Click += new System.EventHandler(this.veterinarMDIMeniEnciklopedija_Click);
            // 
            // veterinarMDIMeniKalendarTerminiPregleda
            // 
            this.veterinarMDIMeniKalendarTerminiPregleda.Name = "veterinarMDIMeniKalendarTerminiPregleda";
            this.veterinarMDIMeniKalendarTerminiPregleda.Size = new System.Drawing.Size(163, 22);
            this.veterinarMDIMeniKalendarTerminiPregleda.Text = "Termini Pregleda";
            this.veterinarMDIMeniKalendarTerminiPregleda.Click += new System.EventHandler(this.veterinarMDIMeniKalendarTerminiPregleda_Click);
            // 
            // VeterinarMDIForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.veterinarMDIMeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.veterinarMDIMeni;
            this.Name = "VeterinarMDIForma";
            this.Text = "Veterinar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VeterinarMDIForma_FormClosed);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.VeterinarMDIForma_HelpRequested);
            this.veterinarMDIMeni.ResumeLayout(false);
            this.veterinarMDIMeni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip veterinarMDIMeni;
        private System.Windows.Forms.ToolStripMenuItem veterinarMDIMeniKalendar;
        private System.Windows.Forms.ToolStripMenuItem veterinarMDIMeniStanje_Lijekova;
        private System.Windows.Forms.ToolStripMenuItem veterinarMDIMeniKarton_Zivotinja;
        private System.Windows.Forms.ToolStripMenuItem veterinarMDIMeniPopis_Zivotinja;
        private System.Windows.Forms.ToolStripMenuItem veterinarMDIMeniEnciklopedija;
        private System.Windows.Forms.ToolStripMenuItem veterinarMDIMeniUnosNovogLijeka;
        private System.Windows.Forms.ToolStripMenuItem veterinarMDIMeniTrenutnoStanje;
        private System.Windows.Forms.ToolStripMenuItem veterinarMDIMeniKalendarTerminiPregleda;
    }
}