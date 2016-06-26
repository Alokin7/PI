using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Paw.Entitetne_Klase
{
    class Korisnik
    {
        int ID { get; set; }
        string ime { get; set; }
        string prezime { get; set; }
        string adresa { get; set; }
        string telefon { get; set; }
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }
        string vrstaKorisnika { get; set; }
    }
}
