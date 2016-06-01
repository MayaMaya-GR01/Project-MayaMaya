using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayaMaya_Concept
{
    public partial class BestelschermDiner : Form
    {
        ItemDAO itemDAO;
        BestellingDAO bestellingDAO;
        Personeelslid personeelslid;
        Bestelling bestelling;
        List<Item> itemsVanBestelling;

        public BestelschermDiner(ItemDAO itemDAO, List<Item> itemsVanBestelling, Bestelling bestelling, 
            Personeelslid personeelslid, BestellingDAO bestellingDAO)
        {
            this.bestellingDAO = bestellingDAO;
            this.bestelling = bestelling;
            this.personeelslid = personeelslid;
            this.itemsVanBestelling = itemsVanBestelling;
            this.itemDAO = itemDAO;
            InitializeComponent();
        }

        private void MaakOpneemscherm(Categorie categorie)
        {
            //Methode voor het maken van een opneemscherm.
            //Categorie bepaalt welke items in de lijst zichtbaar zullen zijn.

            Opneemscherm form = new Opneemscherm(itemDAO, categorie, itemsVanBestelling, bestelling, personeelslid, bestellingDAO);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void btnVoor_Click(object sender, EventArgs e)
        {
            //Geeft de categorie van Diner voorgerechten door.

            MaakOpneemscherm(Categorie.VoorD);
        }

        private void btnTussen_Click(object sender, EventArgs e)
        {
            //Geeft de categorie van Diner tussengerechten door.

            MaakOpneemscherm(Categorie.TussenD);
        }

        private void btnHoofd_Click(object sender, EventArgs e)
        {
            //Geeft de categorie van Diner hoofdgerechten door.

            MaakOpneemscherm(Categorie.HoofdD);
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            //Geeft de categorie van Diner nagerechten door.

            MaakOpneemscherm(Categorie.NaD);
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            //Gebeurt als de terug knop geklikt wordt.

            //Sluit het huidige scherm.
            Close();
        }

        private void BestelschermDiner_Load(object sender, EventArgs e)
        {
            //Gebeurt als het scherm geladen wordt

            //Laat de naam van de persoon zien die is ingelogd.
            lblPersoneel.Text = personeelslid.Naam;
        }
    }
}
