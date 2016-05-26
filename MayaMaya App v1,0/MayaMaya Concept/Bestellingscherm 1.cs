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
    public partial class Bestelling1 : Form
    {
        Tafel tafel;
        public Bestelling1(Tafel tafel)
        {
            InitializeComponent();
            this.tafel = tafel;
        }

        private void Keukenscherm_Load(object sender, EventArgs e)
        {
            btnTafel.Text = String.Format("Tafel: {0}", tafel.tafelNummer);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
