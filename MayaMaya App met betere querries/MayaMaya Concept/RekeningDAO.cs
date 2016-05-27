using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace MayaMaya_Concept
{
    public class RekeningDAO
    {
        SqlConnection dbConnection;

        public RekeningDAO(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public List<Rekening> GetAll()
        {
            List<Rekening> rekeningen = new List<Rekening>();
            Rekening rekening = new Rekening(this);

            dbConnection.Open();
            SqlCommand command = new SqlCommand("select * from rekening", dbConnection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int Rekeningnummer = (int)reader["rekening_id"];

                rekening.TotaalPrijs = (double)reader["totaalprijs"]; 
                rekening.BedragBtw = (double)reader["bedrag_btw"]; 
                rekening.BedragFooi = (double)reader["bedrag_fooi"]; 
                rekening.Commentaar = (string)reader["commentaar"]; 
                rekening.Datum = (DateTime)reader["datum"]; 

                rekeningen.Add(rekening);
                rekening = null;
            }
            dbConnection.Close();

            return rekeningen;
        }

        public int NieuweRekening(double totaalprijs, double bedrag_btw, double bedrag_fooi, string commentaar, DateTime datum)
        {
            dbConnection.Open();

            //string getDate = "current_timestamp";

            string sql = "insert into rekening(totaalprijs, bedrag_btw, bedrag_fooi, commentaar, datum) " +
                "values(@totaalprijs, @bedrag_btw, bedrag_fooi, @commentaar, @datum)";
            SqlCommand command = new SqlCommand(sql, dbConnection);
            command.Parameters.AddWithValue("@totaalprijs", totaalprijs);
            command.Parameters.AddWithValue("@bedrag_btw", bedrag_btw);
            command.Parameters.AddWithValue("@bedrag_fooi", bedrag_fooi);
            command.Parameters.AddWithValue("@commentaar", commentaar);
            command.Parameters.AddWithValue("@datum", datum);
            int rowsaffected = command.ExecuteNonQuery();

            dbConnection.Close();

            if (rowsaffected != 1)
            {
                return 0;
            }

            return geefLaatsteIndex();
        }

        private int geefLaatsteIndex()
        {
            int laatsteIndex = 0;

            dbConnection.Open();

            SqlCommand command = new SqlCommand("select * from rekening", dbConnection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                laatsteIndex = (int)reader["rekening_id"];
            }

            dbConnection.Close();

            return laatsteIndex;
        }
    }
}
