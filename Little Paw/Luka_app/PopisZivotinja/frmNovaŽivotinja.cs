using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luka_app.PopisZivotinja
{
    public partial class frmNovaŽivotinja : Form
    {
        public frmNovaŽivotinja()
        {
            InitializeComponent();
        }
        //instanciranje klase Zivotinja
        Zivotinja zivotinja = new Zivotinja();

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            //upisivanje podataka iz forme u objekt te pozivanje metoda za dodavanje zivotinje u bazu i zatvaranje forme
            zivotinja.Naziv = txtbNazivZivotinje.Text;
            zivotinja.OpisIzgleda = txtbOpisIzgledaZivotinje.Text;
            int broj = 0;
            if (int.TryParse(txtbMinTezina.Text, out broj) == true)
            {
                zivotinja.KilazaMin = int.Parse(txtbMinTezina.Text);
            }
            else
            {
                zivotinja.KilazaMin = 0;
            }
            if (int.TryParse(txtbMaxTezina.Text, out broj) == true)
            {
                zivotinja.KilazaMax = int.Parse(txtbMaxTezina.Text);
            }
            else
            {
                zivotinja.KilazaMax = 0;
            }
            if (int.TryParse(txtbMinDuljina.Text, out broj) == true)
            {
                zivotinja.DuljinaMin = int.Parse(txtbMinDuljina.Text);
            }
            else
            {
                zivotinja.DuljinaMin = 0;
            }
            if (int.TryParse(txtbMaxDuljina.Text, out broj) == true)
            {
                zivotinja.DuljinaMax = int.Parse(txtbMaxDuljina.Text);
            }
            else
            {
                zivotinja.DuljinaMax = 0;
            }
            zivotinja.Karakter = txtbOpisKarakteraZivotinje.Text;

            dodajNovuZivotinju(zivotinja);
            Close();
        }

        private void dodajNovuZivotinju(Zivotinja novaZivotinja)
        {
            //spremanje podataka u tablicu u bazi
            this.Validate();
            this.enciklopedijazivotinjaBindingSource.EndEdit();
            this.enciklopedija_zivotinjaTableAdapter.Insert(novaZivotinja.Naziv, novaZivotinja.OpisIzgleda, novaZivotinja.KilazaMin, novaZivotinja.KilazaMax, novaZivotinja.DuljinaMin, novaZivotinja.DuljinaMax, novaZivotinja.Karakter);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
