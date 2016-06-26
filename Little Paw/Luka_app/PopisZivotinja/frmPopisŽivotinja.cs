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

namespace Luka_app.PopisZivotinja
{
    public partial class frmPopisŽivotinja : Form
    {
        public frmPopisŽivotinja()
        {
            InitializeComponent();
        }

        private void frmPopisŽivotinja_Load(object sender, EventArgs e)
        {
            //Popunjavanje data grid view sa podacima iz baze
            this.enciklopedija_zivotinjaTableAdapter.Fill(this._16045_DBDataSet.enciklopedija_zivotinja);

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //instanciranje nove forme za dodavanje nove zivotinje
            frmNovaŽivotinja forma = new frmNovaŽivotinja();
            forma.ShowDialog();
            this.enciklopedija_zivotinjaTableAdapter.Fill(this._16045_DBDataSet.enciklopedija_zivotinja);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //brisanje životinje iz data grid view te brisanje zivotinje i iz baze
            if (MessageBox.Show("Da li želite izbrisati odabranu životinju?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dgvPopisZivotinja.Rows.Remove(dgvPopisZivotinja.CurrentRow);
                this.Validate();
                this.enciklopedijazivotinjaBindingSource.EndEdit();
                this.enciklopedija_zivotinjaTableAdapter.Update(this._16045_DBDataSet);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //spremanje promjena na data grid view u bazu
            this.Validate();
            this.enciklopedijazivotinjaBindingSource.EndEdit();
            this.enciklopedija_zivotinjaTableAdapter.Update(this._16045_DBDataSet);

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            //prikazivanje svih podataka iz tablice po želji u slučaju da je nešto promijenjeno za vrijeme otvorene tablice na nekoj drugoj strani 
            this.enciklopedija_zivotinjaTableAdapter.Fill(this._16045_DBDataSet.enciklopedija_zivotinja);
        }

        //event da u slučaju da napišemo slovo umjesto broja na za to predviđeno mjesto
        private void dgvPopisZivotinja_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Unijeli ste nedozvoljenu vrijednost u polje koje za to nije predviđeno", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //help
        private void frmPopisŽivotinja_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //popravljen dio s helpom
            //string helpfile = @"C:\Users\Luka\Documents\Visual Studio 2015\Projects\r16045\Little Paw\Little Paw\helpfile.chm";
            string helpfile = Directory.GetCurrentDirectory() + @"\helpfile.chm";
            //MessageBox.Show(helpfile);
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + @"\helpfile.chm");
        }
    }
}
