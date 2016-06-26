
using Luka_app.Enciklopedija_Bolesti;
using Luka_app.EnciklopedijaBolesti;
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

namespace Luka_app
{
    public partial class frmEnciklopedijaBolesti : Form
    {
        public frmEnciklopedijaBolesti()
        {
            InitializeComponent();
        }


        private void frmEnciklopedijaBolesti_Load(object sender, EventArgs e)
        {
            // Početni prikaz svih podataka iz baze
            this.enciklopedija_bolestiTableAdapter.Fill(this._16045_DBDataSet.enciklopedija_bolesti);
        }


        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //spremanje promjena napravljenih na data grid view za bolesti
            this.Validate();
            this.enciklopedijabolestiBindingSource.EndEdit();
            this.enciklopedija_bolestiTableAdapter.Update(this._16045_DBDataSet);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            //prikazivanje svih podataka iz tablice po želji u slučaju da je nešto promijenjeno za vrijeme otvorene tablice na nekoj drugoj strani 
            this.enciklopedija_bolestiTableAdapter.Fill(this._16045_DBDataSet.enciklopedija_bolesti);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //brisanje nekog reda iz data grid view koji prikazuje sve bolesti bolesti te se briše i iz baze
            if (MessageBox.Show("Da li želite izbrisati odabranu bolest?" , "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dgvEnciklopedijaBolesti.Rows.Remove(dgvEnciklopedijaBolesti.CurrentRow);
                this.Validate();
                this.enciklopedijabolestiBindingSource.EndEdit();
                this.enciklopedija_bolestiTableAdapter.Update(this._16045_DBDataSet);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //otvaranje forme za kreiranje nove bolesti te nakon zatvaranja te forme se podaci ponovo prikazu iz baze
            frmNovaBolest novaBolest = new frmNovaBolest();
            novaBolest.ShowDialog();
            this.enciklopedija_bolestiTableAdapter.Fill(this._16045_DBDataSet.enciklopedija_bolesti);
        }

        //help
        private void frmEnciklopedijaBolesti_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //popravljen dio s helpom
            //string helpfile = @"C:\Users\Luka\Documents\Visual Studio 2015\Projects\r16045\Little Paw\Little Paw\helpfile.chm";
            string helpfile = Directory.GetCurrentDirectory() + @"\helpfile.chm";
            //MessageBox.Show(helpfile);
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + @"\helpfile.chm");
        }

    }
}
