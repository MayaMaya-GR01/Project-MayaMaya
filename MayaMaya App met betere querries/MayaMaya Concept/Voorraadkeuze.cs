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
    public partial class Voorraadkeuze : Form
    {
        ItemDAO itemDAO;
        public Voorraadkeuze(ItemDAO itemdao)
        {
            InitializeComponent();
            this.itemDAO = itemdao;
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Itemvoorraadscherm voorraadscherm = new Itemvoorraadscherm(itemDAO);
            this.Hide();
            voorraadscherm.ShowDialog();
            this.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menuvoorraad menuvoorraadscherm = new Menuvoorraad(itemDAO);
            this.Hide();
            menuvoorraadscherm.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
