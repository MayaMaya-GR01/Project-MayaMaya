using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace MayaMaya_Concept
{
    public class ItemDAO
    {
        SqlConnection dbConnection;
        
        public ItemDAO(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public List<Item> GetAll()
        {
            dbConnection.Close();
            List<Item> items = new List<Item>();

            // Open database connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"SELECT Item.item_id, Item.naam AS 
                item_naam, Item.prijs, Item.btw, Item.voorraad, Menucategorie.naam 
                AS categorie_naam, Menukaart.naam AS menu_naam FROM (Item INNER JOIN 
                Menucategorie ON Item.categorie_id = Menucategorie.categorie_id) 
                INNER JOIN Menukaart ON Menucategorie.menu_id = Menukaart.menu_id"
                , dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Database uitlezen
            while (reader.Read())
            {
                int itemId = (int)reader["item_id"];
                string itemNaam = (string)reader["item_naam"];
                double prijs = (double)reader["prijs"];
                double btw = (double)reader["btw"];
                int aantal = (int)reader["voorraad"];
                string categorieNaam = (string)reader["categorie_naam"];
                string menukaartNaam = (string)reader["menu_naam"];

                Item item = new Item(itemId, itemNaam, prijs, btw, aantal,
                    categorieNaam, menukaartNaam);
                items.Add(item);
            }

            dbConnection.Close();

            return items;
        }

        public void DeleteItem(Item item)
        {
            dbConnection.Close();

            dbConnection.Open();

            string sql = String.Format("DELETE FROM Item WHERE item_id={0}",item.ItemId);
            SqlCommand command = new SqlCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            dbConnection.Close();
        }

        public void UpdateVoorraad(Item item, int index)
        {
            dbConnection.Open();

            string sql = String.Format("UPDATE Item SET voorraad={0} WHERE item_id={1}", index, item.ItemId);
            SqlCommand command = new SqlCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            dbConnection.Close();
        }

        public void UpdateMenukaart(Item item, double prijs)
        {
            dbConnection.Open();

            string sql = String.Format("UPDATE Item SET prijs={0} WHERE item_id={1}", prijs, item.ItemId);
            SqlCommand command = new SqlCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            dbConnection.Close();
        }

        public List<Item> GetItemsInBestelling(int bestelnummer)
        {
            List<Item> items = new List<Item>();

            // Open database connectie
            dbConnection.Open();

            // Commando
            SqlCommand command = new SqlCommand(@"SELECT Item.item_id, Item.naam AS 
                item_naam, Item.prijs, Item.btw, Bestaat_uit.aantal, Menucategorie.naam AS 
                categorie_naam, Menukaart.naam AS menu_naam 
                FROM ((Item INNER JOIN Menucategorie ON Item.categorie_id = 
                Menucategorie.categorie_id) INNER JOIN Menukaart ON 
                Menucategorie.menu_id = Menukaart.menu_id) INNER JOIN Bestaat_uit 
                ON Item.item_id = Bestaat_uit.item_id 
                WHERE Bestaat_uit.bestelnummer = @bestelnummer"
                , dbConnection);
            command.Parameters.AddWithValue("@bestelnummer", bestelnummer);
            SqlDataReader reader = command.ExecuteReader();

            // Database uitlezen
            while (reader.Read())
            {
                int itemId = (int)reader["item_id"];
                string itemNaam = (string)reader["item_naam"];
                double prijs = (double)reader["prijs"];
                double btw = (double)reader["btw"];
                int aantal = (int)reader["aantal"];
                string categorieNaam = (string)reader["categorie_naam"];
                string menukaartNaam = (string)reader["menu_naam"];

                Item item = new Item(itemId, itemNaam, prijs, btw, aantal,
                    categorieNaam, menukaartNaam);
                items.Add(item);
            }

            dbConnection.Close();

            return items;
        }
    }
}

