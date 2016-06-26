using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Paw.Entitetne_Klase
{
    class Lijek
    {
        public int ID { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public string proizvodac { get; set; }
        public DateTime valjanost { get; set; }
        public string nuspojave { get; set; }
        public int kolicina { get; set; }
    }
}
