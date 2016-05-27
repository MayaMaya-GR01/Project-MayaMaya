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
    }
}
