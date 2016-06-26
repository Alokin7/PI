using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Paw.Entitetne_Klase
{
    class Termin
    {
        public int ID { get; set; }
        public string simptomi { get; set; }
        public string lijecenje { get; set; }
        //   public DateTime vrijeme { get; set; }
        public string biljeske { get; set; }
        public int ID_ljubimac { get; set; }
        public int ID_vrsta { get; set; }
        public int ID_korisnik { get; set; }
    }
}
