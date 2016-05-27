using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace MayaMaya_Concept
{
    public class BestellingDAO
    {
        SqlConnection dbConnection;

        public BestellingDAO(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public List<Bestelling> GetAll()
        {
            

            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"SELECT *
                FROM (Bestelling INNER JOIN Tafel ON Bestelling.tafelnummer = Tafel.tafelnummer)
                INNER JOIN Personeelslid ON Bestelling.personeelsnummer = Personeelslid.personeelsnummer
                ", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Lezen
            List<Bestelling> bestellingen = GetAllBestellingenList(reader);

            // Sluit connectie
            dbConnection.Close();

            return bestellingen;
        }

        private List<Bestelling> GetAllBestellingenList(SqlDataReader reader)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();

            while (reader.Read())
            {
                int bestelnummer = (int)reader["bestelnummer"];
                DateTime datumTijd = (DateTime)reader["datum_en_tijd_van_bestellen"];
                string status = (string)reader["status"];

                // Personeelslid object

                string naam = (string)reader["naam"];
                string typePersoneelsLid = (string)reader["type_personeelslid"];
                int personeelsnummer = (int)reader["personeelsnummer"]; ;
                int pincode = (int)reader["pincode"];

                Personeelslid personeelslid = new Personeelslid(naam, typePersoneelsLid,
                    personeelsnummer, pincode);

                // Rekening object (alleen nog nummer)
                //int rekeningnummer = (int)reader["rekening"];

                // Tafel object
                int tafelnummer = (int)reader["tafelnummer"];
                int aantalZitplaatsen = (int)reader["aantal_zitplaatsen"];
                bool isBezet = (bool)reader["isBezet"];

                Tafel tafel = new Tafel(tafelnummer, aantalZitplaatsen, isBezet);

                // Bestelling object en toevoegen aan list

                Bestelling bestelling = new Bestelling(bestelnummer, datumTijd,
                    tafel, personeelslid, status);

                bestellingen.Add(bestelling);
            }

            return bestellingen;
        }

        public int GetAantalItemsInBestelling(int bestelnummer)
        {
            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"SELECT SUM(Bestaat_uit.aantal) AS 
                [aantal_items] FROM Bestelling INNER JOIN 
                Bestaat_uit ON Bestelling.bestelnummer = Bestaat_uit.bestelnummer 
                WHERE Bestelling.bestelnummer = @bestelnummer GROUP BY Bestelling.bestelnummer
                ", dbConnection);
            command.Parameters.AddWithValue("@bestelnummer", bestelnummer);

            // Lezen
            int aantalItems = (int)command.ExecuteScalar();

            // Sluit connectie
            dbConnection.Close();

            return aantalItems;
        }

        public List<Bestelling> GetAllKeuken()
        {
            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"SELECT DISTINCT Bestelling.*, Tafel.*, Personeelslid.*
                FROM (((((Bestelling INNER JOIN Tafel ON Bestelling.tafelnummer = Tafel.tafelnummer)
                INNER JOIN Personeelslid ON Bestelling.personeelsnummer = Personeelslid.personeelsnummer) 
                INNER JOIN Bestaat_uit ON Bestelling.bestelnummer = Bestaat_uit.bestelnummer) 
                INNER JOIN Item ON Bestaat_uit.item_id = Item.item_id)
                INNER JOIN Menucategorie ON Item.categorie_id = Menucategorie.categorie_id)
                INNER JOIN Menukaart ON Menucategorie.menu_id = Menukaart.menu_id
                WHERE Menukaart.naam = 'Diner' OR Menukaart.naam = 'Lunch'
                ", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Lezen
            List<Bestelling> bestellingen = GetAllBestellingenList(reader);

            // Sluit connectie
            dbConnection.Close();

            return bestellingen;
        }

        public List<Bestelling> GetAllKeukenLopend()
        {
            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"SELECT DISTINCT Bestelling.*, Tafel.*, Personeelslid.*
                FROM (((((Bestelling INNER JOIN Tafel ON Bestelling.tafelnummer = Tafel.tafelnummer)
                INNER JOIN Personeelslid ON Bestelling.personeelsnummer = Personeelslid.personeelsnummer) 
                INNER JOIN Bestaat_uit ON Bestelling.bestelnummer = Bestaat_uit.bestelnummer) 
                INNER JOIN Item ON Bestaat_uit.item_id = Item.item_id)
                INNER JOIN Menucategorie ON Item.categorie_id = Menucategorie.categorie_id)
                INNER JOIN Menukaart ON Menucategorie.menu_id = Menukaart.menu_id
                WHERE (Menukaart.naam = 'Diner' OR Menukaart.naam = 'Lunch') AND 
                (Bestelling.status = 'wacht' OR Bestelling.status = 'in behandeling') 
                ", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Lezen
            List<Bestelling> bestellingen = GetAllBestellingenList(reader);

            // Sluit connectie
            dbConnection.Close();

            return bestellingen;
        }

        public List<Bestelling> GetAllKeukenGereed()
        {
            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"SELECT DISTINCT Bestelling.*, Tafel.*, Personeelslid.*
                FROM (((((Bestelling INNER JOIN Tafel ON Bestelling.tafelnummer = Tafel.tafelnummer)
                INNER JOIN Personeelslid ON Bestelling.personeelsnummer = Personeelslid.personeelsnummer) 
                INNER JOIN Bestaat_uit ON Bestelling.bestelnummer = Bestaat_uit.bestelnummer) 
                INNER JOIN Item ON Bestaat_uit.item_id = Item.item_id)
                INNER JOIN Menucategorie ON Item.categorie_id = Menucategorie.categorie_id)
                INNER JOIN Menukaart ON Menucategorie.menu_id = Menukaart.menu_id
                WHERE (Menukaart.naam = 'Diner' OR Menukaart.naam = 'Lunch') AND 
                (Bestelling.status = 'gereed') 
                ", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Lezen
            List<Bestelling> bestellingen = GetAllBestellingenList(reader);

            // Sluit connectie
            dbConnection.Close();

            return bestellingen;
        }

        public List<Bestelling> GetAllBar()
        {
            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"SELECT DISTINCT Bestelling.*, Tafel.*, Personeelslid.*
                FROM (((((Bestelling INNER JOIN Tafel ON Bestelling.tafelnummer = Tafel.tafelnummer)
                INNER JOIN Personeelslid ON Bestelling.personeelsnummer = Personeelslid.personeelsnummer) 
                INNER JOIN Bestaat_uit ON Bestelling.bestelnummer = Bestaat_uit.bestelnummer) 
                INNER JOIN Item ON Bestaat_uit.item_id = Item.item_id)
                INNER JOIN Menucategorie ON Item.categorie_id = Menucategorie.categorie_id)
                INNER JOIN Menukaart ON Menucategorie.menu_id = Menukaart.menu_id
                WHERE Menukaart.naam = 'Drank'
                ", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Lezen
            List<Bestelling> bestellingen = GetAllBestellingenList(reader);

            // Sluit connectie
            dbConnection.Close();

            return bestellingen;
        }

        public List<Bestelling> GetAllBarLopend()
        {
            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"SELECT DISTINCT Bestelling.*, Tafel.*, Personeelslid.*
                FROM (((((Bestelling INNER JOIN Tafel ON Bestelling.tafelnummer = Tafel.tafelnummer)
                INNER JOIN Personeelslid ON Bestelling.personeelsnummer = Personeelslid.personeelsnummer) 
                INNER JOIN Bestaat_uit ON Bestelling.bestelnummer = Bestaat_uit.bestelnummer) 
                INNER JOIN Item ON Bestaat_uit.item_id = Item.item_id)
                INNER JOIN Menucategorie ON Item.categorie_id = Menucategorie.categorie_id)
                INNER JOIN Menukaart ON Menucategorie.menu_id = Menukaart.menu_id
                WHERE (Menukaart.naam = 'Drank') AND 
                (Bestelling.status = 'wacht' OR Bestelling.status = 'in behandeling') 
                ", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Lezen
            List<Bestelling> bestellingen = GetAllBestellingenList(reader);

            // Sluit connectie
            dbConnection.Close();

            return bestellingen;
        }

        public List<Bestelling> GetAllBarGereed()
        {
            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"SELECT DISTINCT Bestelling.*, Tafel.*, Personeelslid.*
                FROM (((((Bestelling INNER JOIN Tafel ON Bestelling.tafelnummer = Tafel.tafelnummer)
                INNER JOIN Personeelslid ON Bestelling.personeelsnummer = Personeelslid.personeelsnummer) 
                INNER JOIN Bestaat_uit ON Bestelling.bestelnummer = Bestaat_uit.bestelnummer) 
                INNER JOIN Item ON Bestaat_uit.item_id = Item.item_id)
                INNER JOIN Menucategorie ON Item.categorie_id = Menucategorie.categorie_id)
                INNER JOIN Menukaart ON Menucategorie.menu_id = Menukaart.menu_id
                WHERE (Menukaart.naam = 'Drank') AND 
                (Bestelling.status = 'gereed') 
                ", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Lezen
            List<Bestelling> bestellingen = GetAllBestellingenList(reader);

            // Sluit connectie
            dbConnection.Close();

            return bestellingen;
        }

        public List<String> CheckTafel(Tafel tafel)
        {
            List<string> status = new List<String>();
            string Status;

            // Open connectie
            dbConnection.Open();

            // Commando
            string query = String.Format("SELECT status FROM Tafel INNER JOIN Bestelling on Tafel.tafelnummer = Bestelling.tafelnummer WHERE Tafel.tafelnummer={0}", tafel.tafelNummer);
            SqlCommand command = new SqlCommand(query, dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Lezen
            while(reader.Read())
            {
                Status = (string)reader["status"];
                status.Add(Status);
            }

            // Sluit connectie
            dbConnection.Close();

            return status;
        }

        public void UpdateBestellingGereed(int bestelnummer)
        {
            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"UPDATE Bestelling
                SET status = 'gereed'
                WHERE bestelnummer = @bestelnummer
                ", dbConnection);
            command.Parameters.AddWithValue("@bestelnummer", bestelnummer);

            // Schrijven
            command.ExecuteNonQuery();

            // Sluit connectie
            dbConnection.Close();
        }

        public void UpdateBestellingWacht(int bestelnummer)
        {
            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"UPDATE Bestelling
                SET status = 'wacht'
                WHERE bestelnummer = @bestelnummer
                ", dbConnection);
            command.Parameters.AddWithValue("@bestelnummer", bestelnummer);

            // Schrijven
            command.ExecuteNonQuery();

            // Sluit connectie
            dbConnection.Close();
        }

        public string GetStatusBestelling(int bestelnummer)
        {
            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"SELECT status
                FROM Bestelling
                WHERE bestelnummer = @bestelnummer
                ", dbConnection);
            command.Parameters.AddWithValue("@bestelnummer", bestelnummer);

            // Lezen
            string status = (string)command.ExecuteScalar();

            // Sluit connectie
            dbConnection.Close();

            return status;
        }

        public Bestelling GetAllEnkeleBestelling(int bestelnummer)
        {
            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"SELECT DISTINCT Bestelling.bestelnummer,
                Bestelling.datum_en_tijd_van_bestellen, 
                Bestelling.status, Tafel.*, Personeelslid.* 
                FROM (Bestelling INNER JOIN Tafel ON Bestelling.tafelnummer = 
                Tafel.tafelnummer) INNER JOIN Personeelslid ON 
                Bestelling.personeelsnummer = Personeelslid.personeelsnummer
                WHERE Bestelling.bestelnummer = @bestelnummer
                ", dbConnection);
            command.Parameters.AddWithValue("@bestelnummer", bestelnummer);
            SqlDataReader reader = command.ExecuteReader();

            // Lezen
            List<Bestelling> bestellingen = GetAllBestellingenList(reader);

            // Sluit connectie
            dbConnection.Close();

            Bestelling bestelling = bestellingen[0];

            return bestelling;
        }

        public void UpdateBestellingInBehandeling(int bestelnummer)
        {
            // Open connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"UPDATE Bestelling
                SET status = 'in behandeling'
                WHERE bestelnummer = @bestelnummer
                ", dbConnection);
            command.Parameters.AddWithValue("@bestelnummer", bestelnummer);

            // Schrijven
            command.ExecuteNonQuery();

            // Sluit connectie
            dbConnection.Close();
        }
    }
}
