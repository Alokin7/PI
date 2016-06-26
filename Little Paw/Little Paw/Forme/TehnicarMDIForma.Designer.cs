namespace Little_Paw.Forme
{
    partial class TehnicarMDIForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TehnicarMDIForma));
            this.tehnicarMDIMeni = new System.Windows.Forms.MenuStrip();
            this.tehnicarMDIMeniKalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.tehnicarMDIMeniStanje_Lijekova = new System.Windows.Forms.ToolStripMenuItem();
            this.tehnicarMDIMeniTrenutnoStanje = new System.Windows.Forms.ToolStripMenuItem();
            this.tehnicarMDIMeniKarton_Zivotinja = new System.Windows.Forms.ToolStripMenuItem();
            this.tehnicarMDIMeniPopis_Zivotinja = new System.Windows.Forms.ToolStripMenuItem();
            this.tehnicarMDIMeniKalendarTerminiPregleda = new System.Windows.Forms.ToolStripMenuItem();
            this.tehnicarMDIMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // tehnicarMDIMeni
            // 
            this.tehnicarMDIMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tehnicarMDIMeniKalendar,
            this.tehnicarMDIMeniStanje_Lijekova,
            this.tehnicarMDIMeniKarton_Zivotinja,
            this.tehnicarMDIMeniPopis_Zivotinja});
            this.tehnicarMDIMeni.Location = new System.Drawing.Point(0, 0);
            this.tehnicarMDIMeni.Name = "tehnicarMDIMeni";
            this.tehnicarMDIMeni.Size = new System.Drawing.Size(484, 24);
            this.tehnicarMDIMeni.TabIndex = 1;
            this.tehnicarMDIMeni.Text = "tehnicarMDIMeni";
            // 
            // tehnicarMDIMeniKalendar
            // 
            this.tehnicarMDIMeniKalendar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tehnicarMDIMeniKalendarTerminiPregleda});
            this.tehnicarMDIMeniKalendar.Name = "tehnicarMDIMeniKalendar";
            this.tehnicarMDIMeniKalendar.Size = new System.Drawing.Size(65, 20);
            this.tehnicarMDIMeniKalendar.Text = "Kalendar";
            // 
            // tehnicarMDIMeniStanje_Lijekova
            // 
            this.tehnicarMDIMeniStanje_Lijekova.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tehnicarMDIMeniTrenutnoStanje});
            this.tehnicarMDIMeniStanje_Lijekova.Name = "tehnicarMDIMeniStanje_Lijekova";
            this.tehnicarMDIMeniStanje_Lijekova.Size = new System.Drawing.Size(97, 20);
            this.tehnicarMDIMeniStanje_Lijekova.Text = "Stanje Lijekova";
            // 
            // tehnicarMDIMeniTrenutnoStanje
            // 
            this.tehnicarMDIMeniTrenutnoStanje.Name = "tehnicarMDIMeniTrenutnoStanje";
            this.tehnicarMDIMeniTrenutnoStanje.Size = new System.Drawing.Size(157, 22);
            this.tehnicarMDIMeniTrenutnoStanje.Text = "Trenutno Stanje";
            this.tehnicarMDIMeniTrenutnoStanje.Click += new System.EventHandler(this.tehnicarMDIMeniTrenutnoStanje_Click);
            // 
            // tehnicarMDIMeniKarton_Zivotinja
            // 
            this.tehnicarMDIMeniKarton_Zivotinja.Name = "tehnicarMDIMeniKarton_Zivotinja";
            this.tehnicarMDIMeniKarton_Zivotinja.Size = new System.Drawing.Size(103, 20);
            this.tehnicarMDIMeniKarton_Zivotinja.Text = "Karton Životinja";
            // 
            // tehnicarMDIMeniPopis_Zivotinja
            // 
            this.tehnicarMDIMeniPopis_Zivotinja.Name = "tehnicarMDIMeniPopis_Zivotinja";
            this.tehnicarMDIMeniPopis_Zivotinja.Size = new System.Drawing.Size(97, 20);
            this.tehnicarMDIMeniPopis_Zivotinja.Text = "Popis Životinja";
            this.tehnicarMDIMeniPopis_Zivotinja.Click += new System.EventHandler(this.tehnicarMDIMeniPopis_Zivotinja_Click);
            // 
            // tehnicarMDIMeniKalendarTerminiPregleda
            // 
            this.tehnicarMDIMeniKalendarTerminiPregleda.Name = "tehnicarMDIMeniKalendarTerminiPregleda";
            this.tehnicarMDIMeniKalendarTerminiPregleda.Size = new System.Drawing.Size(163, 22);
            this.tehnicarMDIMeniKalendarTerminiPregleda.Text = "Termini Pregleda";
            this.tehnicarMDIMeniKalendarTerminiPregleda.Click += new System.EventHandler(this.terminiPregledaToolStripMenuItem_Click);
            // 
            // TehnicarMDIForma
            // 
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tehnicarMDIMeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.tehnicarMDIMeni;
            this.Name = "TehnicarMDIForma";
            this.Text = "Tehničar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TehnicarMDIForma_FormClosed);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.TehnicarMDIForma_HelpRequested);
            this.tehnicarMDIMeni.ResumeLayout(false);
            this.tehnicarMDIMeni.PerformLayout();
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
        private System.Windows.Forms.MenuStrip tehnicarMDIMeni;
        private System.Windows.Forms.ToolStripMenuItem tehnicarMDIMeniKalendar;
        private System.Windows.Forms.ToolStripMenuItem tehnicarMDIMeniStanje_Lijekova;
        private System.Windows.Forms.ToolStripMenuItem tehnicarMDIMeniKarton_Zivotinja;
        private System.Windows.Forms.ToolStripMenuItem tehnicarMDIMeniPopis_Zivotinja;
        private System.Windows.Forms.ToolStripMenuItem tehnicarMDIMeniTrenutnoStanje;
        private System.Windows.Forms.ToolStripMenuItem tehnicarMDIMeniKalendarTerminiPregleda;
    }
}