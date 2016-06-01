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
    public partial class Checkscherm : Form
    {
        Personeelslid personeelslid;
        Bestelling bestelling;
        BestellingDAO bestellingDAO;
        public List<Item> itemsVanBestelling;

        public Checkscherm(List<Item> itemsVanBestelling, Bestelling bestelling, Personeelslid personeelslid, BestellingDAO bestellingDAO)
        {
            this.bestellingDAO = bestellingDAO;
            this.bestelling = bestelling;
            this.personeelslid = personeelslid;
            this.itemsVanBestelling = itemsVanBestelling;
            InitializeComponent();
        }

        private void Checkscherm_Load(object sender, EventArgs e)
        {
            //Gebeurt als het scherm geladen wordt.

            //Geeft de naam van het personeelslid weer dat is ingelogt.
            lblPersoneel.Text = personeelslid.Naam;

            try
            {
                //Vult de lijst met de items die besteld zijn.
                VulListView();

                //Zorgt ervoor dat de lijst geselecteerd is zodat ermee gewerkt kan worden.
                lstvwCheckBestelling.Select();
            }
            catch { }
        }

        private void VulListView()
        {
            //Maakt de lijst leeg.
            lstvwCheckBestelling.Clear();

            //Voegt de kolommen toe.
            lstvwCheckBestelling.Columns.Add("Product", 190);
            lstvwCheckBestelling.Columns.Add("Aantal", 45);
            string[] entry = new string[2];
            ListViewItem itm;

            //Gaat alle items langs in de weergave lijst.
            foreach (Item i in itemsVanBestelling)
            {
                //Voegt de naam van het item toe aan de product-kolom.
                entry[0] = i.Naam;

                //Voegt de hoeveelheid van het item toe aan de aantal-kolom.
                entry[1] = i.Aantal.ToString();

                itm = new ListViewItem(entry);

                lstvwCheckBestelling.Items.Add(itm);
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                //haalt de index op van het geselecteerde item
                ListView.SelectedIndexCollection selectie = lstvwCheckBestelling.SelectedIndices;
                index = selectie[0];

                //Als het aantal groter is dan 0 wordt er 1 van afgehaald.
                if (itemsVanBestelling[index].Aantal > 0)
                    itemsVanBestelling[index].Aantal--;

                //Vult opnieuw de lijst met de nieuwe gegevens.
                VulListView();
            }
            catch { }

            //Zorgt ervoor dat de lijst geselecteerd word en dat het item geselecteerd blijft.
            lstvwCheckBestelling.Select();
            lstvwCheckBestelling.SelectedIndices.Clear();
            lstvwCheckBestelling.SelectedIndices.Add(index);
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStuur_Click(object sender, EventArgs e)
        {
            bestelling.DatumTijdVanBestellen = DateTime.Now;
            bestellingDAO.VoegToe(bestelling, itemsVanBestelling);
        }

    }
}
