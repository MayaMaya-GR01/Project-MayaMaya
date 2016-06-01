using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace MayaMaya_Concept
{
    public partial class Bestelscherm : Form
    {
        Tafel tafel;
        Personeelslid personeelslid;
        ItemDAO itemDAO;
        BestellingDAO bestellingDAO;
        public int Bestelling_id { get; set; }
        List<Item> itemsVanBestelling = new List<Item>();
        Bestelling bestelling;

        public Bestelscherm(ItemDAO itemDAO, BestellingDAO bestellingDAO, Tafel tafel, Personeelslid personeelslid)
        {
            this.bestellingDAO = bestellingDAO;
            this.itemDAO = itemDAO;
            Bestelling_id = 0;
            this.tafel = tafel;
            this.personeelslid = personeelslid;
            bestelling = new Bestelling(Bestelling_id, DateTime.Now, tafel, personeelslid, "wacht");
            InitializeComponent();
        }

        private void btnDrank_Click(object sender, EventArgs e)
        {
            //Gebeurt als op de knop Drank geklikt wordt.

            BestelschermDrank form = new BestelschermDrank(itemDAO, itemsVanBestelling, bestelling, personeelslid, bestellingDAO);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            //Gebeurt als op de knop Lunch geklikt wordt.

            BestelschermLunch form = new BestelschermLunch(itemDAO, itemsVanBestelling, bestelling, personeelslid, bestellingDAO);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void btnDiner_Click(object sender, EventArgs e)
        {
            //Gebeurt als op de knop Diner geklikt wordt.

            BestelschermDiner form = new BestelschermDiner(itemDAO, itemsVanBestelling, bestelling, personeelslid, bestellingDAO);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            //Gebeurt als op de knop terug geklikt wordt.

            Close();
        }

        private void Bestelscherm_Load(object sender, EventArgs e)
        {
            //Gebeurt als het Bestelscherm geladen wordt.

            lblPersoneel.Text = personeelslid.Naam;
        }
    }
}
