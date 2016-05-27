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
    public partial class AfrekenBetaalscherm : Form
    {

        public AfrekenBetaalscherm()
        {
            InitializeComponent();
        }

        private void Afrekenscherm_Load(object sender, EventArgs e)
        {

        }

        private void lstBetaalscherm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnContant_Click(object sender, EventArgs e)
        {
            AfrekenBevestigscherm Bevestigscherm = new AfrekenBevestigscherm();
            this.Hide();
            Bevestigscherm.ShowDialog();
            this.Show();
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            AfrekenBevestigscherm Bevestigscherm = new AfrekenBevestigscherm();
            this.Hide();
            Bevestigscherm.ShowDialog();
            this.Show();
        }

        private void btnCreditcard_Click(object sender, EventArgs e)
        {
            AfrekenBevestigscherm Bevestigscherm = new AfrekenBevestigscherm();
            this.Hide();
            Bevestigscherm.ShowDialog();
            this.Show();
        }



        private void lblRekeningBedrag_Click(object sender, EventArgs e) 
        {

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }


    }
}
