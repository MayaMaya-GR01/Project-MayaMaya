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
    public partial class Itemvoorraadscherm : Form
    {
        ItemDAO itemDAO;
        List<Item> Items = new List<Item>();
        public Itemvoorraadscherm(ItemDAO itemDAO)
        {
            InitializeComponent();
            this.itemDAO = itemDAO;
        }

        private void Voorraadscherm_Load(object sender, EventArgs e)
        {
            ToonLijst();
        }

        public void ToonLijst()
        {
            this.Items = itemDAO.GetAll();
            lstItems.Items.Clear();
            foreach (Item item in Items)
            {
                ListViewItem listItem = new ListViewItem(item.ItemId.ToString());
                listItem.SubItems.Add(item.Naam.ToString());
                listItem.SubItems.Add(item.Aantal.ToString());
                lstItems.Items.Add(listItem);
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lstItems.CheckedItems)
            {
                int index = item.Index;
                itemDAO.DeleteItem(Items[index]);
                lstItems.Items.Remove(item);
            }
            this.Items = itemDAO.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Teller = (int)nmrTeller.Value;
            foreach (ListViewItem item in lstItems.CheckedItems)
            {
                int index = item.Index;
                int nieuwAantal = Items[index].Aantal - Teller;
                itemDAO.UpdateVoorraad(Items[index], nieuwAantal);
            }
            lstItems.Items.Clear();
            ToonLijst();
        }

        private void btnVerhoog_Click(object sender, EventArgs e)
        {
            int Teller = (int)nmrTeller.Value;
            foreach (ListViewItem item in lstItems.CheckedItems)
            {
                int index = item.Index;
                int nieuwAantal = Items[index].Aantal + Teller;
                itemDAO.UpdateVoorraad(Items[index], nieuwAantal);
            }
            lstItems.Items.Clear();
            ToonLijst();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
