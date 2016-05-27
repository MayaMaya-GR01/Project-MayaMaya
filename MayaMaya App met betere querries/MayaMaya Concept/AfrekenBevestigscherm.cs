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
    public partial class AfrekenBevestigscherm : Form
    {
        public AfrekenBevestigscherm()
        {
            InitializeComponent();
        }


        private void btnBevestig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Betaling is gelukt.");
        }

        private void AfrekenBevestigscherm2_Load(object sender, EventArgs e)
        {

        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            AfrekenBetaalscherm BetaalScherm = new AfrekenBetaalscherm();
            this.Hide();
            BetaalScherm.ShowDialog();
            this.Show();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
