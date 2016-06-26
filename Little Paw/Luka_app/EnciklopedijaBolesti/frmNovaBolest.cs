using Luka_app.EnciklopedijaBolesti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luka_app.Enciklopedija_Bolesti
{
    public partial class frmNovaBolest : Form
    {
        public frmNovaBolest()
        {
            InitializeComponent();
            
        }

        //instanciranje klase Bolest
        Bolest bolest = new Bolest();

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            //popunjavanje objekta bolest s podacima iz forme i šalje taj objekta metodi za dodavanje 
            bolest.Naziv = txtbNazivBolest.Text;
            bolest.Opis = txtbOpisBolesti.Text;
            dodajNovuBolest(bolest);
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //metoda za dodavanje nove životinje kojoj smo proslijedili objekt bolest
        private void dodajNovuBolest(Bolest novaBolest)
        {
            this.Validate();
            this.enciklopedijabolestiBindingSource.EndEdit();
            //dodavanje bolesti u bazu podataka
            this.enciklopedija_bolestiTableAdapter.Insert(novaBolest.Naziv, novaBolest.Opis);
        }
    }
}
