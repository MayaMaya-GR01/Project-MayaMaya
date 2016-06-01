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

        public BestelschermLunch(ItemDAO itemDAO)
        {
            this.itemDAO = itemDAO;
            InitializeComponent();
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
    }
}
