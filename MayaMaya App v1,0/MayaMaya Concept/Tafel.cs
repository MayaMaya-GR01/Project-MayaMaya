using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayaMaya_Concept
{
    public class Tafel
    {
        public int tafelNummer { get; set; }
        public int aantalZitplaatsen { get; set; }
        public bool isBezet { get; set; }

        public Tafel(int tafelNummer, int aantalZitplaatsen, bool isBezet)
        {
            this.tafelNummer = tafelNummer;
            this.aantalZitplaatsen = aantalZitplaatsen;
            this.isBezet = isBezet;
        }

        public override string ToString()
        {
            return tafelNummer + " " + aantalZitplaatsen + " " + isBezet;
        }
    }
}
