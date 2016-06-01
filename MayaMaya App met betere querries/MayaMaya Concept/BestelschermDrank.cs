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

        public BestelschermDrank(ItemDAO itemDAO)
        {
            this.itemDAO = itemDAO;
            InitializeComponent();
        }

        private void BestelschermDrank_Load(object sender, EventArgs e)
        {

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaakOpneemscherm(Categorie categorie)
        {
            Opneemscherm form = new Opneemscherm(itemDAO, categorie);
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
    }
}
