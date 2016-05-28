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
    public partial class Bereidingscherm : Form
    {
        bool lopendeBestellingenActief;
        protected BestellingDAO bestellingDAO;
        protected ItemDAO itemDAO;

        public Bereidingscherm(BestellingDAO bestellingDAO, ItemDAO itemDAO)
        {
            InitializeComponent();
            this.bestellingDAO = bestellingDAO;
            this.itemDAO = itemDAO;
            lopendeBestellingenActief = true;
            UpdateScherm();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UpdateScherm()
        {
            lstBestellingen.Items.Clear();

            if (lopendeBestellingenActief == true)
            {
                this.lstBestellingen.ListViewItemSorter = new ListViewStatusSort(true);
                ToonLopendeBestellingen();
                btnGereed.Enabled = true;
            }
            else
            {
                this.lstBestellingen.ListViewItemSorter = new ListViewStatusSort(false);
                ToonGereedgemeldeBestellingen();
                btnGereed.Enabled = false;
            }
        }

        protected virtual void ToonLopendeBestellingen()
        {
            List<Bestelling> bestellingen = bestellingDAO.GetAll();

            foreach (Bestelling bestelling in bestellingen)
            {
                if (bestelling.StatusVanBestelling == "in behandeling" || 
                    bestelling.StatusVanBestelling == "wacht")
                {
                    ListViewItem listItem = new ListViewItem(bestelling.Bestelnummer.ToString());
                    listItem.SubItems.Add(bestelling.TafelVanBestelling.tafelNummer.ToString());
                    listItem.SubItems.Add(bestelling.DatumTijdVanBestellen.ToString());
                    listItem.SubItems.Add(bestellingDAO.GetAantalItemsInBestelling(bestelling.Bestelnummer).ToString());
                    listItem.SubItems.Add(bestelling.StatusVanBestelling);
                    lstBestellingen.Items.Add(listItem);
                }
            }
        }

        protected virtual void ToonGereedgemeldeBestellingen()
        {
            List<Bestelling> bestellingen = bestellingDAO.GetAll();

            foreach (Bestelling bestelling in bestellingen)
            {
                if (bestelling.StatusVanBestelling == "gereed" ||
                    bestelling.StatusVanBestelling == "afgerond")
                {
                    ListViewItem listItem = new ListViewItem(bestelling.Bestelnummer.ToString());
                    listItem.SubItems.Add(bestelling.TafelVanBestelling.tafelNummer.ToString());
                    listItem.SubItems.Add(bestelling.DatumTijdVanBestellen.ToString());
                    listItem.SubItems.Add(bestellingDAO.GetAantalItemsInBestelling(bestelling.Bestelnummer).ToString());
                    listItem.SubItems.Add(bestelling.StatusVanBestelling);
                    lstBestellingen.Items.Add(listItem);
                }
            }
        }

        private void Keukenscherm_Load(object sender, EventArgs e)
        {
            btnLopendeBestellingen.BackColor = System.Drawing.Color.DimGray;
        }

        private void btnBestellingen_Click(object sender, EventArgs e)
        {
            if (!lopendeBestellingenActief) LeegItemList();

            lopendeBestellingenActief = true;
            UpdateScherm();
            btnGereedBestellingen.BackColor = DefaultBackColor;
            btnLopendeBestellingen.BackColor = System.Drawing.Color.DimGray;
        }

        private void btnGereedBestellingen_Click(object sender, EventArgs e)
        {
            if (lopendeBestellingenActief) LeegItemList();

            lopendeBestellingenActief = false;
            UpdateScherm();
            btnLopendeBestellingen.BackColor = DefaultBackColor;
            btnGereedBestellingen.BackColor = System.Drawing.Color.DimGray;
        }

        private void btnVoorraad_Click(object sender, EventArgs e)
        {
            Voorraadkeuze voorraadscherm = new Voorraadkeuze(itemDAO);
            this.Hide();
            voorraadscherm.ShowDialog();
            this.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateScherm();
        }

        private void lstBestellingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Geselecteerde bestelling ophalen (in de vorm van een ListViewItem)
            ListView.SelectedListViewItemCollection bestellingen =
                lstBestellingen.SelectedItems;

            // Bestelnummer uit het ListViewItem halen.
            // De foreach loop is nodig omdat het bestelnummer uit een list gehaald moet worden die soms geen items bevat.
            int bestelnummer = 0;

            foreach (ListViewItem bestellingListViewItem in bestellingen)
            {
                bestelnummer = int.Parse(bestellingListViewItem.SubItems[0].Text);
            }

            // Labels met bestelinformatie vullen. 
            // Try catch is noodzakelijk omdat bestelnummer bij deselectie 0 kan worden en 
            // dit mag niet ingevoerd worden.
            try
            {
                Bestelling bestelling = bestellingDAO.GetAllEnkeleBestelling(bestelnummer);

                lblBestellingnummer.Text = bestelling.Bestelnummer.ToString();
                lblTafelnummer.Text = bestelling.TafelVanBestelling.tafelNummer.ToString();
                lblStatus.Text = bestelling.StatusVanBestelling;
                lblTijdVanBestellen.Text = bestelling.DatumTijdVanBestellen.ToString();
            }
            catch 
            {
                // Bij deselectie wordt de ListView van de items geleegd.
                LeegItemList();
            }
            
            
            // De lijst met items vullen
            lstItems.Items.Clear();
            List<Item> items = itemDAO.GetItemsInBestelling(bestelnummer);

            foreach (Item item in items)
            {
                ListViewItem listviewItem = new ListViewItem(item.Naam);
                listviewItem.SubItems.Add(item.Categorienaam);
                listviewItem.SubItems.Add(item.Aantal.ToString());

                lstItems.Items.Add(listviewItem);
            }  
        }

        private void btnInBehandeling_Click(object sender, EventArgs e)
        {
            // Geselecteerde bestelling ophalen (in de vorm van een ListViewItem)
            ListView.SelectedListViewItemCollection bestellingen =
                lstBestellingen.SelectedItems;

            // Bestelnummer uit het ListViewItem halen
            int bestelnummer = 0;

            foreach (ListViewItem bestellingListViewItem in bestellingen)
            {
                bestelnummer = int.Parse(bestellingListViewItem.SubItems[0].Text);
            }

            // Een afgeronde bestelling mag niet terug naar 'in behandeling'
            if (bestellingDAO.GetStatusBestelling(bestelnummer) != "afgerond")
            {
                bestellingDAO.UpdateBestellingInBehandeling(bestelnummer);
            }

            // ListView van de items legen als de bestelling verplaatst wordt naar lopende bestellingen.
            if (!lopendeBestellingenActief) LeegItemList();

            // Als een bestelling van 'wacht' gaat naar 'in behandeling', 
            // moet het label boven de ViewList van items ook naar 'in behandeling'.
            if (lopendeBestellingenActief) lblStatus.Text = "in behandeling"; 

            UpdateScherm();
        }

        private void btnGereed_Click(object sender, EventArgs e)
        {
            // Bestelnummer uit het ListViewItem halen
            int bestelnummer = 0;

            foreach (ListViewItem bestellingListViewItem in lstBestellingen.SelectedItems)
            {
                bestelnummer = int.Parse(bestellingListViewItem.SubItems[0].Text);
            }

            bestellingDAO.UpdateBestellingGereed(bestelnummer);

            // ListView van de items legen als de bestelling verplaatst wordt naar gereed gemelde bestellingen.
            if (lopendeBestellingenActief) LeegItemList();

            UpdateScherm();
        }

        private void btnWacht_Click(object sender, EventArgs e)
        {
            // Bestelnummer uit het ListViewItem halen.
            // De foreach loop is nodig omdat ListView altijd een list teruggeeft.
            int bestelnummer = 0;

            foreach (ListViewItem bestellingListViewItem in lstBestellingen.SelectedItems)
            {
                bestelnummer = int.Parse(bestellingListViewItem.SubItems[0].Text);
            }

            // Een afgeronde bestelling mag niet terug naar 'wacht'
            if (bestellingDAO.GetStatusBestelling(bestelnummer) != "afgerond")
            {
                bestellingDAO.UpdateBestellingWacht(bestelnummer);
            }

            // ListView van de items legen als de bestelling verplaatst wordt naar lopende bestellingen.
            if (!lopendeBestellingenActief) LeegItemList();

            // Als een bestelling van 'in behandeling' terug gaat naar 'wacht', 
            // moet het label boven de ViewList van items ook weer naar 'wacht'.
            if (lopendeBestellingenActief) lblStatus.Text = "wacht"; 
            
            UpdateScherm();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeegItemList()
        {
            lblBestellingnummer.Text = "-";
            lblTafelnummer.Text = "-";
            lblStatus.Text = "-";
            lblTijdVanBestellen.Text = "-";

            lstItems.Items.Clear();
        }
    }
}
