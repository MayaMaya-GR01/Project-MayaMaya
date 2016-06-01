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
    public partial class Opneemscherm : Form
    {
        Bestelling bestelling;
        Personeelslid personeelslid;
        ItemDAO itemDAO;
        BestellingDAO bestellingDAO;
        Categorie categorie;
        List<Item> alleItems;
        List<Item> selectieItems = new List<Item>();
        public List<Item> itemsVanBestelling;
        Checkscherm form;

        public Opneemscherm(ItemDAO itemDAO, Categorie categorie, List<Item> itemsVanBestelling,
            Bestelling bestelling, Personeelslid personeelslid, BestellingDAO bestellingDAO)
        {
            this.bestellingDAO = bestellingDAO;
            this.bestelling = bestelling;
            this.personeelslid = personeelslid;
            this.itemDAO = itemDAO;
            this.categorie = categorie;
            alleItems = itemDAO.GetAll();
            this.itemsVanBestelling = itemsVanBestelling;
            VulSelectieItems();
            InitializeComponent();
        }

        private void btnBijvoegen_Click(object sender, EventArgs e)
        {
            lstItems.Select();
            int x = 0;
            bool b = false;
            Item itm;
            try
            {
                ListView.SelectedIndexCollection selectie = lstItems.SelectedIndices;
                int index = selectie[0];
                if (selectieItems[index].Aantal > 0)
                {
                    selectieItems[index].Aantal = selectieItems[index].Aantal - 1;

                    foreach(Item i in itemsVanBestelling)
                    {
                        if (i.Naam == selectieItems[index].Naam)
                            b = true;
                    }

                    if (!b)
                    {
                        itm = new Item(selectieItems[index].ItemId, selectieItems[index].Naam, selectieItems[index].Prijs,
                            selectieItems[index].Btw, 1, selectieItems[index].Categorienaam, selectieItems[index].Menukaartnaam);

                        itemsVanBestelling.Add(itm);
                    }
                    else
                    {
                        foreach(Item i in itemsVanBestelling)
                        {
                            if (i.Naam == selectieItems[index].Naam)
                                i.Aantal++;
                        }
                    }
                }
            }
            catch { }

        }

        private void VulSelectieItems()
        {
            selectieItems.Clear();

            foreach (Item i in alleItems)
            {
                if (GoedeCategorie(i))
                    selectieItems.Add(i);
            }
        }

        private bool GoedeCategorie(Item i)
        {
            switch (categorie)
            {
                case Categorie.Frisdrank:
                    if (i.Categorienaam == "Frisdranken")
                        return true;
                    break;
                case Categorie.Bier:
                    if (i.Categorienaam == "Bieren")
                        return true;
                    break;
                case Categorie.Wijn:
                    if (i.Categorienaam == "Wijnen")
                        return true;
                    break;
                case Categorie.Gedest:
                    if (i.Categorienaam == "Gedestilleerde dranken")
                        return true;
                    break;
                case Categorie.Koffiethee:
                    if (i.Categorienaam == "Koffie / Thee")
                        return true;
                    break;
                case Categorie.VoorL:
                    if (i.Categorienaam == "Voorgerechten" && i.Menukaartnaam == "Lunch")
                        return true;
                    break;
                case Categorie.HoofdL:
                    if (i.Categorienaam == "Hoofdgerechten" && i.Menukaartnaam == "Lunch")
                        return true;
                    break;
                case Categorie.NaL:
                    if (i.Categorienaam == "Nagerechten" && i.Menukaartnaam == "Lunch")
                        return true;
                    break;
                case Categorie.VoorD:
                    if (i.Categorienaam == "Voorgerechten" && i.Menukaartnaam == "Diner")
                        return true;
                    break;
                case Categorie.TussenD:
                    if (i.Categorienaam == "Tussengerechten")
                        return true;
                    break;
                case Categorie.HoofdD:
                    if (i.Categorienaam == "Hoofdgerechten" && i.Menukaartnaam == "Diner")
                        return true;
                    break;
                case Categorie.NaD:
                    if (i.Categorienaam == "Nagerechten" && i.Menukaartnaam == "Diner")
                        return true;
                    break;
                default:
                    return false;
            }
            return false;
        }

        private void Opneemscherm_Load(object sender, EventArgs e)
        {
            lblPersoneel.Text = personeelslid.Naam;
            VulListView();
            lstItems.Select();
            label4.Text = selectieItems[0].Menukaartnaam + " " + selectieItems[0].Categorienaam;
        }

        private void VulListView()
        {
            lstItems.Columns.Add("Naam", 190);
            lstItems.Columns.Add("Voorraad", 45);
            string[] entry = new string[2];
            VulSelectieItems();
            ListViewItem itm;

            foreach (Item i in selectieItems)
            {
                entry[0] = i.Naam;
                entry[1] = i.Aantal.ToString();
                itm = new ListViewItem(entry);
                lstItems.Items.Add(itm);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            form = new Checkscherm(itemsVanBestelling, bestelling, personeelslid, bestellingDAO);
            Hide();
            form.ShowDialog();
            itemsVanBestelling = form.itemsVanBestelling;
            Show();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
