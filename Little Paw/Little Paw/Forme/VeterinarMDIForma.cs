﻿
using Luka_app;
using Luka_app.PopisZivotinja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Little_Paw.Forme
{
    public partial class VeterinarMDIForma : Form
    {
        string vrstaKorisnika;
        PopisLijekovaForma popis;
        NoviLijekForma noviLijek;
        DnevniTerminForma termini;

        public VeterinarMDIForma(string vrstaKorisnika)
        {
            InitializeComponent();
            this.vrstaKorisnika = vrstaKorisnika;
        }

        private void VeterinarMDIForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void veterinarMDIMeniEnciklopedija_Click(object sender, EventArgs e)
        {
            frmEnciklopedijaBolesti formaBolesti = new frmEnciklopedijaBolesti();
            formaBolesti.Show();
        }

        private void veterinarMDIMeniPopis_Zivotinja_Click(object sender, EventArgs e)
        {
            frmPopisŽivotinja formaZivotinje = new frmPopisŽivotinja();
            formaZivotinje.Show();
        }

        private void VeterinarMDIForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //popravljen dio s helpom
            //string helpfile = @"C:\Users\Luka\Documents\Visual Studio 2015\Projects\r16045\Little Paw\Little Paw\helpfile.chm";
            string helpfile = Directory.GetCurrentDirectory() + @"\helpfile.chm";
            //MessageBox.Show(helpfile);
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + @"\helpfile.chm");
        }

        private void veterinarMDIMeniUnosNovogLijeka_Click(object sender, EventArgs e)
        {
            FormCollection formCollection = Application.OpenForms;
            bool findForm = false;
            foreach (Form form in formCollection)
            {
                if (form.Name == "NoviLijekForma")
                {
                    form.Refresh();
                    findForm = true;
                    form.Activate();
                }
            }

            if (findForm == false)
            {
                noviLijek = new NoviLijekForma();
                noviLijek.MdiParent = this;
                noviLijek.Show();
            }

        }

        private void trenutnoStanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection formCollection = Application.OpenForms;
            bool findForm = false;
            foreach (Form form in formCollection)
            {
                if (form.Name == "PopisLijekovaForma")
                {
                    form.Refresh();
                    findForm = true;
                    form.Activate();
                }
            }

            if (findForm == false)
            {
                popis = new PopisLijekovaForma(this, this.vrstaKorisnika);
                popis.MdiParent = this;
                popis.Show();
            }
        }

        private void veterinarMDIMeniKalendarTerminiPregleda_Click(object sender, EventArgs e)
        {
            FormCollection formCollection = Application.OpenForms;
            bool findForm = false;
            foreach (Form form in formCollection)
            {
                if (form.Name == "DnevniTerminForma")
                {
                    form.Refresh();
                    findForm = true;
                    form.Activate();
                }
            }

            if (findForm == false)
            {
                termini = new DnevniTerminForma(this, this.vrstaKorisnika);
                termini.MdiParent = this;
                termini.Show();
            }
        }
    }
}