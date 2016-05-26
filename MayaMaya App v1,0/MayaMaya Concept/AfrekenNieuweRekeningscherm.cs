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
    public partial class AfrekenNieuweRekeningscherm : Form
    {
        public AfrekenNieuweRekeningscherm()
        {
            InitializeComponent();
        }

        private void AfrekenNieuweRekeningscherm_Load(object sender, EventArgs e)
        {

        }

        private void btnOpnemen_Click(object sender, EventArgs e)
        {
            AfrekenLopendeRekeningenscherm LopendeRekeningen = new AfrekenLopendeRekeningenscherm();
            this.Hide();
            LopendeRekeningen.ShowDialog();
            this.Show();
        }

        private void btnMaakRekening_Click(object sender, EventArgs e)
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
