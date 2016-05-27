using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MayaMaya_Concept
{
    public class Rekening
    {
        public int Rekeningnummer { get; set; }
        public double TotaalPrijs { get; set; }
        public double BedragBtw { get; set; }
        public double BedragFooi { get; set; }
        public string Commentaar { get; set; }
        public DateTime Datum { get; set; }
        RekeningDAO rekeningDAO;
        

        public Rekening(RekeningDAO rekeningDAO)
        {
            this.rekeningDAO = rekeningDAO;

            TotaalPrijs = 0;
            BedragBtw = 0;
            BedragFooi = 0;
            Commentaar = "-";
            Datum = DateTime.Now;

            Rekeningnummer = 0;



            //TotaalPrijs = totaalPrijs;
            //BedragBtw = bedragBtw;
            //BedragFooi = bedragFooi;
            //Commentaar = commentaar;
            //Datum = datum;
        }

        public void SchrijfNaarDb()
        {
            Rekeningnummer = rekeningDAO.NieuweRekening(TotaalPrijs, BedragBtw, BedragFooi, Commentaar, Datum);

        }

        public override string ToString()
        {
            string rekeningnummerString = Convert.ToString(Rekeningnummer);
            string totaalPrijsString = Convert.ToString(TotaalPrijs);
            string bedragBtwString = Convert.ToString(BedragBtw);
            string bedragFooiString = Convert.ToString(BedragFooi);
            string datumString = Convert.ToString(Datum);

            return rekeningnummerString + " " + totaalPrijsString + " " +
                bedragBtwString + " " + bedragFooiString + " " + datumString;
        }
    }
}
