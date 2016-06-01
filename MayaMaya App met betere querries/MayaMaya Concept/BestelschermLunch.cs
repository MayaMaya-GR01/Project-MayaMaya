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
    public partial class BestelschermLunch : Form
    {
        ItemDAO itemDAO;
        BestellingDAO bestellingDAO;
        Bestelling bestelling;
        Personeelslid personeelslid;
        List<Item> itemsVanBestelling;

        public BestelschermLunch(ItemDAO itemDAO, List<Item> itemsVanBestelling, Bestelling bestelling, 
            Personeelslid personeelslid, BestellingDAO bestellingDAO)
        {
            this.bestellingDAO = bestellingDAO;
            this.bestelling = bestelling;
            this.personeelslid = personeelslid;
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

        private void btnVoor_Click(object sender, EventArgs e)
        {
            MaakOpneemscherm(Categorie.VoorL);
        }

        private void btnHoofd_Click(object sender, EventArgs e)
        {
            MaakOpneemscherm(Categorie.HoofdL);
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            MaakOpneemscherm(Categorie.NaL);
        }

        private void BestelschermLunch_Load(object sender, EventArgs e)
        {
            lblPersoneel.Text = personeelslid.Naam;
        }
    }
}
