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
        private ItemDAO ItemDao { get; set; }
        List<Item> bedsteld = new List<Item>();

        public Bestelscherm(ItemDAO itemDAO)
        {
            ItemDao = itemDAO;
            InitializeComponent();
        }

        private void Bestelscherm_Load(object sender, EventArgs e)
        {
            List<Item> producten = new List<Item>();
            producten = ItemDao.GetAll();
            foreach (Item i in producten)
            {
                lstItems.Items.Add(i);
            }

            lstItems.SelectedIndex = 0;
        }

        private void btnBijvoegen_Click(object sender, EventArgs e)
        {
            Item product = (Item)lstItems.SelectedItem;
            bedsteld.Add(product);
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Checkscherm form = new Checkscherm(bedsteld);
            form.ShowDialog();
        }
    }
}
