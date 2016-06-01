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
    public partial class BestelschermDiner : Form
    {
        ItemDAO itemDAO;

        public BestelschermDiner(ItemDAO itemDAO)
        {
            this.itemDAO = itemDAO;
            InitializeComponent();
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
            MaakOpneemscherm(Categorie.VoorD);
        }

        private void btnTussen_Click(object sender, EventArgs e)
        {
            MaakOpneemscherm(Categorie.TussenD);
        }

        private void btnHoofd_Click(object sender, EventArgs e)
        {
            MaakOpneemscherm(Categorie.HoofdD);
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            MaakOpneemscherm(Categorie.NaD);
        }
    }
}
