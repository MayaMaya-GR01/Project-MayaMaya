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
    public partial class Menuvoorraad : Form
    {
        ItemDAO itemDAO;
        List<Item> AlleItems = new List<Item>();
        List<Item> GeslecteerdeItems = new List<Item>();
        public Menuvoorraad(ItemDAO itemdao)
        {
            InitializeComponent();
            this.itemDAO = itemdao;
            ToonLijstDiner();
            btnDiner.BackColor = System.Drawing.Color.DimGray;
        }

        private void Menuvoorraad_Load(object sender, EventArgs e)
        {
        }

        private void btnDiner_Click(object sender, EventArgs e)
        {
            ToonLijstDiner();
            btnDiner.BackColor = System.Drawing.Color.DimGray;
            btnDrank.BackColor = DefaultBackColor;
            btnLunch.BackColor = DefaultBackColor;
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            ToonLijstLunch();
            btnLunch.BackColor = System.Drawing.Color.DimGray;
            btnDiner.BackColor = DefaultBackColor;
            btnDrank.BackColor = DefaultBackColor;
        }

        private void btnDrank_Click(object sender, EventArgs e)
        {
            ToonLijstDrank();
            btnDrank.BackColor = System.Drawing.Color.DimGray;
            btnDiner.BackColor = DefaultBackColor;
            btnLunch.BackColor = DefaultBackColor;
        }

        public void ToonLijstDrank()
        {
            this.AlleItems = itemDAO.GetAll();
            lstItems.Items.Clear();
            GeslecteerdeItems.Clear();
            foreach (Item item in AlleItems)
            {
                if(item.Menukaartnaam == "Drank")
                {
                    lstItems.Items.Add("Naam: " + item.Naam.ToString() + " , Prijs: " + item.Prijs.ToString());
                    GeslecteerdeItems.Add(item);
                }
                else
                {
                    continue;
                }
            }
        }

        public void ToonLijstDiner()
        {
            this.AlleItems = itemDAO.GetAll();
            lstItems.Items.Clear();
            GeslecteerdeItems.Clear();
            foreach (Item item in AlleItems)
            {
                if (item.Menukaartnaam == "Diner")
                {
                    lstItems.Items.Add("Naam: " + item.Naam.ToString() + " , Prijs: " + item.Prijs.ToString());
                    GeslecteerdeItems.Add(item);
                }
                else
                {
                    continue;
                }
            }
        }

        public void ToonLijstLunch()
        {
            this.AlleItems = itemDAO.GetAll();
            lstItems.Items.Clear();
            GeslecteerdeItems.Clear();
            foreach (Item item in AlleItems)
            {
                if (item.Menukaartnaam == "Lunch")
                {
                    lstItems.Items.Add("Naam: " + item.Naam.ToString() + " , Prijs: " + item.Prijs.ToString());
                    GeslecteerdeItems.Add(item);
                }
                else
                {
                    continue;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void lstItems_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Item item = GeslecteerdeItems[lstItems.SelectedIndex];
            txtPrijs.Text = item.Prijs.ToString();
        }

        private void btnVerhoog_Click(object sender, EventArgs e)
        {
            try
            {
                double Prijs = double.Parse(txtPrijs.Text);
                Item item = GeslecteerdeItems[lstItems.SelectedIndex];
                itemDAO.UpdateMenukaart(item, Prijs);

                lstItems.Items.Clear();

                if (btnDiner.BackColor == System.Drawing.Color.DimGray)
                {
                    ToonLijstDiner();
                }
                else if (btnDrank.BackColor == System.Drawing.Color.DimGray)
                {
                    ToonLijstDrank();
                }
                else if (btnLunch.BackColor == System.Drawing.Color.DimGray)
                {
                    ToonLijstLunch();
                }
            }
            catch
            {
                MessageBox.Show("Selecteer een item");
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Item item = GeslecteerdeItems[lstItems.SelectedIndex];
            itemDAO.DeleteItem(item);

            lstItems.Items.Clear();

            if (btnDiner.BackColor == System.Drawing.Color.DimGray)
            {
                ToonLijstDiner();
            }
            else if (btnDrank.BackColor == System.Drawing.Color.DimGray)
            {
                ToonLijstDrank();
            }
            else if (btnLunch.BackColor == System.Drawing.Color.DimGray)
            {
                ToonLijstLunch();
            }
        }
    }
}
