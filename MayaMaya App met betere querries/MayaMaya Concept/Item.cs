using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayaMaya_Concept
{
    public class Item
    {
        // Properties
        public int ItemId { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public double Btw { get; set; }
        public int Aantal { get; set; }
        public string Categorienaam { get; set; }
        public string Menukaartnaam { get; set; }

        // Constructor
        public Item(int itemId, string naam, double prijs, double btw,
            int aantal, string categorienaam, string menukaartnaam)
        {
            ItemId = itemId;
            Naam = naam;
            Prijs = prijs;
            Btw = btw;
            Aantal = aantal;
            Categorienaam = categorienaam;
            Menukaartnaam = menukaartnaam;
        }

        // Methoden
        public override string ToString()
        {
            string idString = Convert.ToString(ItemId);
            string prijsString = Convert.ToString(Prijs);
            string btwString = Convert.ToString(Btw);
            string aantalString = Convert.ToString(Aantal);

            return idString + " " + Naam + " " + prijsString + " "
                + btwString + " " + aantalString + " " + Categorienaam + " "
                + Menukaartnaam;
        }
    }
}

