using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace MayaMaya_Concept
{
    public partial class Bestelscherm : Form
    {
        ItemDAO itemDAO;

        public Bestelscherm(ItemDAO itemDAO)
        {
            this.itemDAO = itemDAO;
            InitializeComponent();
        }

        private void Bestelscherm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBijvoegen_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDrank_Click(object sender, EventArgs e)
        {
            BestelschermDrank form = new BestelschermDrank(itemDAO);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            BestelschermLunch form = new BestelschermLunch(itemDAO);
            Hide();
            form.ShowDialog();
            Show();
        }

        private void btnDiner_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
