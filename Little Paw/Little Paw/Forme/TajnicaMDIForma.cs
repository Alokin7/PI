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
    public partial class TajnicaMDIForma : Form
    {
        PopisLijekovaForma popis;
        string vrstaKorisnika;
        DnevniTerminForma termini;

        public TajnicaMDIForma(string vrstaKorisnika)
        {
            InitializeComponent();
            this.vrstaKorisnika = vrstaKorisnika;
        }

        private void TajnicaMDIForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TajnicaMDIForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //popravljen dio s helpom
            //string helpfile = @"C:\Users\Luka\Documents\Visual Studio 2015\Projects\r16045\Little Paw\Little Paw\helpfile.chm";
            string helpfile = Directory.GetCurrentDirectory() + @"\helpfile.chm";
            //MessageBox.Show(helpfile);
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + @"\helpfile.chm");
        }

        private void tajnicaMDIMeniTrenutnoStanje_Click(object sender, EventArgs e)
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

        private void tajnicaMDIMeniKalendarTerminiPregleda_Click(object sender, EventArgs e)
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
