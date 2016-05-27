using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace MayaMaya_Concept
{
    public class PersoneelslidDAO
    {
        SqlConnection dbConnection;

        public PersoneelslidDAO(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public bool CheckPinCode(string pincode)
        {
            dbConnection.Close();
            try
            {
                dbConnection.Open();

                string sql = String.Format("SELECT * FROM Personeelslid WHERE pincode={0}", pincode);
                SqlCommand command = new SqlCommand(sql, dbConnection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    dbConnection.Close();
                    return true;
                }
                dbConnection.Close();
                return false;
            }
            catch
            {
                dbConnection.Close();
                return false;
            }
        }

        public Personeelslid GetUser(string pincode)
        {
            dbConnection.Close();
            Personeelslid personeelslid = null;

            dbConnection.Open();

            string sql = String.Format("SELECT * FROM Personeelslid WHERE pincode={0}", pincode);
            SqlCommand command = new SqlCommand(sql, dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            if(reader.Read())
            {
                int personeelsnummer = (int)reader["personeelsnummer"];
                string naam = (string)reader["naam"];
                string typelid = (string)reader["type_personeelslid"];
                int pin = (int)reader["pincode"];

                personeelslid = new Personeelslid(naam, typelid, personeelsnummer, pin);
            }
            dbConnection.Close();
            return personeelslid;
        }

        public List<Personeelslid> GetAll()
        {
            dbConnection.Close();
            List<Personeelslid> ledenLijst = new List<Personeelslid>();
            Personeelslid personeelslid = null;

            this.dbConnection.Open();

            string sql = String.Format("SELECT * FROM Personeelslid");
            SqlCommand command = new SqlCommand(sql, dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                int personeelsnummer = (int)reader["personeelsnummer"];
                string naam = (string)reader["naam"];
                string typelid = (string)reader["type_personeelslid"];
                int pin = (int)reader["pincode"];

                personeelslid = new Personeelslid(naam, typelid, personeelsnummer, pin);
                ledenLijst.Add(personeelslid);
            }
            this.dbConnection.Close();
            return ledenLijst;
        }
    }
}
