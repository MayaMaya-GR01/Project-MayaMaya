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
        ItemDAO itemDAO;
        Categorie categorie;
        List<Item> alleItems;
        List<Item> selectieItems = new List<Item>();
        List<Item> bestelling;

        public Opneemscherm(ItemDAO itemDAO, Categorie categorie)
        {
            this.itemDAO = itemDAO;
            this.categorie = categorie;
            alleItems = itemDAO.GetAll();
            bestelling = new List<Item>();
            VulSelectieItems();
            InitializeComponent();
        }

        public Opneemscherm(ItemDAO itemDAO, Categorie categorie, List<Item> bestelling)
        {
            this.itemDAO = itemDAO;
            this.categorie = categorie;
            alleItems = itemDAO.GetAll();
            this.bestelling = bestelling;
            VulSelectieItems();
            InitializeComponent();
        }

        private void btnBijvoegen_Click(object sender, EventArgs e)
        {
            lstItems.Select();
            try
            {
                ListView.SelectedIndexCollection selectie = lstItems.SelectedIndices;
                int index = selectie[0];
                bestelling.Add(alleItems[index]);
            }
            catch
            {

            }

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
            }

            return false;
        }

        private void Opneemscherm_Load(object sender, EventArgs e)
        {
            VulListView();
            lstItems.Select();
        }

        private void VulListView()
        {
            lstItems.Columns.Add("Naam", 190);
            lstItems.Columns.Add("aantal", 45);
            string[] entry = new string[2];
            ListViewItem itm;

            foreach (Item i in alleItems)
            {
                entry[0] = i.Naam;
                entry[1] = i.Aantal.ToString();
                itm = new ListViewItem(entry);
                lstItems.Items.Add(itm);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Checkscherm form = new Checkscherm(bestelling);
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
