using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayaMaya_Concept
{
    public class Personeelslid
    {
        public string Naam { get; set; }
        public string TypePersoneelsLid { get; set; }
        public int Personeelsnummer { get; set; }
        public int Pincode { get; set; }

        public Personeelslid(string naam, string typepersoneel, int personeelsnummer, int pincode)
        {
            this.Naam = naam;
            this.TypePersoneelsLid = typepersoneel;
            this.Personeelsnummer = personeelsnummer;
            this.Pincode = pincode;
        }

        public override string ToString()
        {
            return Naam + " " + TypePersoneelsLid + " " + Personeelsnummer;
        }
    }
}
