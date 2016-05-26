using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayaMaya_Concept
{
    public class Bestelling
    {
        public int Bestelnummer { get; set; }
        public DateTime DatumTijdVanBestellen { get; set; }
        public Tafel TafelVanBestelling { get; set; }
        public Personeelslid PersoneelslidVanBestelling { get; set; }
        //public Rekening RekeningVanBestelling { get; set;}
        //public int Rekeningnummer { get; set; }
        //public Status StatusVanBestelling { get; set; }
        public string StatusVanBestelling { get; set; }
        public List<Item> ItemsVanBestelling { get; set; }

        public Bestelling(int bestelnummer, DateTime datumTijdVanbestellen,
            Tafel tafelVanBestelling, Personeelslid personeelslidVanBestelling, 
            string statusVanBestelling)
        {
            Bestelnummer = bestelnummer;
            DatumTijdVanBestellen = datumTijdVanbestellen;
            TafelVanBestelling = tafelVanBestelling;
            PersoneelslidVanBestelling = personeelslidVanBestelling;
            //RekeningVanBestelling = rekeningVanBestelling;
            //Rekeningnummer = rekeningnummer;
            StatusVanBestelling = statusVanBestelling;
        }

        public override string ToString()
        {
            string bestelnummerString = Convert.ToString(Bestelnummer);
            string datumTijdVanBestellingString = Convert.ToString(DatumTijdVanBestellen);
            string tafelString = Convert.ToString(TafelVanBestelling.tafelNummer);
            string personeelslidString = Convert.ToString(PersoneelslidVanBestelling.Personeelsnummer);
            //string rekeningString = Convert.ToString(RekeningVanBestelling.Rekeningnummer);
            //string rekeningnummerString = Convert.ToString(Rekeningnummer);
            string statusString = Convert.ToString(StatusVanBestelling);

            return bestelnummerString + " " + datumTijdVanBestellingString + " " +
                tafelString + " " + personeelslidString + " " + statusString;
        }
    }
}

