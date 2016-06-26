using Little_Paw.Entitetne_Klase;
using Little_Paw.Forme;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Little_Paw
{
    public partial class PrijavaForma : Form
    {
        Korisnik noviKorisnik = new Korisnik();
        string vrstaKorisnika;
        private VeterinarMDIForma veterinarParent;
        private TehnicarMDIForma tehnicarParent;
        private TajnicaMDIForma tajnicaParent;

        public PrijavaForma()
        {
            InitializeComponent();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            noviKorisnik.korisnickoIme = korisnickoImeTextBox.Text.ToString();
            noviKorisnik.lozinka = lozinkaTextBox.Text.ToString();

            int count = (int)korisnikTableAdapter1.getCountByKorisnickoImeAndLozinka(noviKorisnik.korisnickoIme, noviKorisnik.lozinka);
            if(count > 0)
            {
                DataTable table = korisnikTableAdapter1.GetKorisnikByKorisnickoImeAndLozinka(noviKorisnik.korisnickoIme, noviKorisnik.lozinka);
                DataRow row = table.Rows[0];
                vrstaKorisnika = row["vrsta_korisnika"].ToString();
                MessageBox.Show(row["vrsta_korisnika"].ToString());

                switch (vrstaKorisnika)
                {
                    case "veterinar":
                        {
                            veterinarParent = new VeterinarMDIForma(vrstaKorisnika);
                            this.Hide();
                            veterinarParent.Show();
                            break;
                        }
                    case "tehnicar":
                        {
                            tehnicarParent = new TehnicarMDIForma(vrstaKorisnika);
                            this.Hide();
                            tehnicarParent.Show();
                            break;
                        }
                    case "tajnica":
                        {
                            tajnicaParent = new TajnicaMDIForma(vrstaKorisnika);
                            this.Hide();
                            tajnicaParent.Show();
                            break;
                        }

                }
            }else MessageBox.Show("Krivo Korisnicko ime ili Lozinka!");
        }
    }
}
