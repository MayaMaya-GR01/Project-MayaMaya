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
    public partial class Checkscherm : Form
    {
        List<Item> producten;

        public Checkscherm(List<Item> producten)
        {
            this.producten = producten;
            InitializeComponent();
        }

        private void btnCheckscherm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Checkscherm_Load(object sender, EventArgs e)
        {
            if(producten != null)
            {
                foreach(Item i in producten)
                {
                    lstbxCheckbestelling.Items.Add(i);
                }
                lstbxCheckbestelling.SelectedIndex = 0;
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            lstbxCheckbestelling.Items.Remove(lstbxCheckbestelling.SelectedItem);
            
        }
    }
}
