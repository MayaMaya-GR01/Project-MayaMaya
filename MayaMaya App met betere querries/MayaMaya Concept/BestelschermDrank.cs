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
    public partial class BestelschermDrank : Form
    {
        ItemDAO itemDAO;
        BestellingDAO bestellingDAO;
        Bestelling bestelling;
        Personeelslid personeelslid;
        List<Item> itemsVanBestelling;

        public BestelschermDrank(ItemDAO itemDAO, List<Item> itemsVanBestelling, Bestelling bestelling, 
            Personeelslid personeelslid, BestellingDAO bestellingDAO)
        {
            this.bestellingDAO = bestellingDAO;
            this.personeelslid = personeelslid;
            this.bestelling = bestelling;
            this.itemsVanBestelling = itemsVanBestelling;
            this.itemDAO = itemDAO;
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            //Gebeurt als de terug knop geklikt wordt.

            //Sluit het huidige scherm.
            Close();
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

        private void btnFrisdrank_Click(object sender, EventArgs e)
        {
            MaakOpneemscherm(Categorie.Frisdrank);
        }

        private void btnBier_Click(object sender, EventArgs e)
        {
            MaakOpneemscherm(Categorie.Bier);
        }

        private void btnWijn_Click(object sender, EventArgs e)
        {
            MaakOpneemscherm(Categorie.Wijn);
        }

        private void btnGedest_Click(object sender, EventArgs e)
        {
            MaakOpneemscherm(Categorie.Gedest);
        }

        private void btnKot_Click(object sender, EventArgs e)
        {
            MaakOpneemscherm(Categorie.Koffiethee);
        }

        private void BestelschermDrank_Load(object sender, EventArgs e)
        {
            lblPersoneel.Text = personeelslid.Naam;
        }
    }
}
