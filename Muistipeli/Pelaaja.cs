using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muistipeli
{
    public class Pelaaja
    {
        public string Nimi { get; set; }
        public int Voitot { get; set; }
        public int Tappiot { get; set; }

        public Pelaaja()
        {
        }

        public Pelaaja(string nimi)
        {
            this.Nimi = nimi;
        }

        public Pelaaja(string nimi, int voitot, int tappiot)
        {
            this.Nimi = nimi;
            this.Voitot = voitot;
            this.Tappiot = tappiot;
        }

     
    }
}
