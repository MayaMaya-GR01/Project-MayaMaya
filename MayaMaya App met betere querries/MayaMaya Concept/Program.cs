using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MayaMaya_Concept
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connString = ConfigurationManager.ConnectionStrings["ReserveringenConnectionStringSQL"].ConnectionString;
            SqlConnection dbConnection = new SqlConnection(connString);
            PersoneelslidDAO personeelslidDAO = new PersoneelslidDAO(dbConnection);
            ItemDAO itemDAO = new ItemDAO(dbConnection);
            TafelDAO tafelDAO = new TafelDAO(dbConnection);
            BestellingDAO bestellingDAO = new BestellingDAO(dbConnection);
            //Application.Run(new InlogForm(personeelslidDAO, itemDAO, tafelDAO, bestellingDAO));
            Application.Run(new Opneemscherm(itemDAO, Categorie.Bier));
        }
    }
}
