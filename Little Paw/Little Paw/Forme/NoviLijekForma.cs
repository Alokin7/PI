using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Little_Paw.Entitetne_Klase;

namespace Little_Paw.Forme
{
    public partial class NoviLijekForma : Form
    {
        Lijek lijek;
        private int id;
        private bool newLijek;
        private string vrstaKorisnika;

        public NoviLijekForma()
        {
            InitializeComponent();
            this.newLijek = true;
            this.Text = "NoviLijekForma";
        }

        public NoviLijekForma(int id, string vrstaKorisnika)
        {
            InitializeComponent();
            this.id = id;
            this.newLijek = false;
            this.Text = "IzmjenaLijekForma";
            this.vrstaKorisnika = vrstaKorisnika;

            disableInput(vrstaKorisnika);
        }

        private void disableInput(string vrstaKorisnika)
        {
            if (vrstaKorisnika != "veterinar")
            {
                this.NoviLijekNazivTextBox.Enabled = false;
                this.NoviLijekOpisTextBox.Enabled = false;
                this.NoviLijekProizvodacTextBox.Enabled = false;
                this.NoviLijekNuspojaveTextBox.Enabled = false;
                this.NoviLijekDateTimePicker.Enabled = false;
            }
        }

        private void NoviLijekForma_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            if (!this.newLijek)
            {
                lijek = new Lijek();
                DataTable table = popis_lijekovaTableAdapter1.GetLijekByID(this.id);
                DataRow row = table.Rows[0];
                NoviLijekNazivTextBox.Text = row["naziv"].ToString();
                NoviLijekOpisTextBox.Text = row["opis"].ToString();
                NoviLijekProizvodacTextBox.Text = row["proizvodac"].ToString();
                NoviLijekNuspojaveTextBox.Text = row["nuspojave"].ToString();
                NoviLijekDateTimePicker.Value = Convert.ToDateTime(row["valjanost"].ToString());
                NoviLijekKolicinaTextBox.Text = row["kolicina"].ToString();
            }

        }

        private void NoviLijekUnesiButton_Click(object sender, EventArgs e)
        {
            lijek = new Lijek();
            lijek.naziv = NoviLijekNazivTextBox.Text.ToString();
            lijek.opis = NoviLijekOpisTextBox.Text.ToString();
            lijek.proizvodac = NoviLijekProizvodacTextBox.Text.ToString();
            lijek.nuspojave = NoviLijekNuspojaveTextBox.Text.ToString();
            lijek.valjanost = NoviLijekDateTimePicker.Value;
            int kolicina = 0;
            
            if (lijek.naziv == "" || lijek.opis == "" || lijek.proizvodac == "" || lijek.nuspojave == "" || lijek.valjanost == null)
            {
                MessageBox.Show("Nije unesena vrijednost u sva polja!");
            }
            else if (int.TryParse(NoviLijekKolicinaTextBox.Text, out kolicina) == false)
            {
                MessageBox.Show("Niste unjeli kolicinu lijeka!");
            }
            else if (lijek.valjanost < DateTime.Today)
            {
                MessageBox.Show("Lijeku kojeg unosite istekao je rok trajanja!");
            }else
            {
                lijek.kolicina = kolicina;
                if (this.newLijek)
                {
                    if (lijek.kolicina < 0)
                    {
                        MessageBox.Show("Kličina ne može biti manja od 0!");
                    }
                    else
                    {
                        popis_lijekovaTableAdapter1.Insert(lijek.naziv, lijek.opis, lijek.proizvodac, lijek.valjanost, lijek.nuspojave, lijek.kolicina);
                        clearTextBox();
                    }
                }
                else
                {
                    if (lijek.kolicina < 0)
                    {
                        MessageBox.Show("Količina ne može biti manja od 0!");
                    }
                    else
                    {
                        lijek.ID = this.id;
                        popis_lijekovaTableAdapter1.UpdateLijek(lijek.naziv, lijek.opis, lijek.proizvodac, lijek.valjanost.ToString(), lijek.nuspojave, lijek.kolicina, lijek.ID);
                        this.Close();
                    }
                }
            }
        }

        void clearTextBox()
        {
            this.NoviLijekNazivTextBox.Clear();
            this.NoviLijekOpisTextBox.Clear();
            this.NoviLijekProizvodacTextBox.Clear();
            this.NoviLijekNuspojaveTextBox.Clear();
            this.NoviLijekKolicinaTextBox.Clear();
            this.NoviLijekDateTimePicker.ResetText();
        }
    }
}
