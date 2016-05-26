using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace MayaMaya_Concept
{
    public class TafelDAO
    {
        SqlConnection dbConnection;

        public TafelDAO(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public List<Tafel> GetAll()
        {
            dbConnection.Close();
            List<Tafel> tafelLijst = new List<Tafel>();
            Tafel tafel = null;

            dbConnection.Open();

            string sql = "SELECT * FROM Tafel";
            SqlCommand command = new SqlCommand(sql, dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int tafelnummer = (int)reader["tafelnummer"];
                int aantalzitplaatsen = (int)reader["aantal_zitplaatsen"];
                bool isbezet = (bool)reader["isBezet"];

                tafel = new Tafel(tafelnummer, aantalzitplaatsen, isbezet);
                tafelLijst.Add(tafel);
            }
            dbConnection.Close();
            return tafelLijst;
        }

        public void UpdateTafel(Tafel tafel)
        {
            int verandering;
            if (GetStatus(tafel))
            {
                verandering = 0;
            }
            else
            {
                verandering = 1;
            }

            dbConnection.Open();

            string sql = String.Format("UPDATE Tafel SET isBezet={0} WHERE tafelnummer={1}", verandering, tafel.tafelNummer);
            SqlCommand command = new SqlCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            dbConnection.Close();
        }

        public bool GetStatus(Tafel tafel)
        {
            bool Bezetting = false;
            dbConnection.Close();

            dbConnection.Open();

            string sql = String.Format("SELECT * FROM Tafel WHERE tafelnummer={0}", tafel.tafelNummer);
            SqlCommand command = new SqlCommand(sql, dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                bool isbezet = (bool)reader["isBezet"];
                if (isbezet)
                {
                    Bezetting = true;
                }
            }

            dbConnection.Close();

            return Bezetting;
        }

        public void ClearAll()
        {
            dbConnection.Open();

            string sql = "UPDATE Tafel SET isBezet=0";
            SqlCommand command = new SqlCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            dbConnection.Close();
        }

    }
}
