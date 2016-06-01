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
    public partial class Tafelscherm : Form
    {
        Tafel tafel;
        Personeelslid personeelslid;
        TafelDAO tafelDAO;
        ItemDAO itemDAO;
        BestellingDAO bestellingDAO;

        public Tafelscherm(Tafel tafel, TafelDAO tafelDAO, ItemDAO itemDAO, BestellingDAO bestellingDAO, Personeelslid personeelslid)
        {
            InitializeComponent();
            this.tafel = tafel;
            this.tafelDAO = tafelDAO;
            this.itemDAO = itemDAO;
            this.bestellingDAO = bestellingDAO;
            this.personeelslid = personeelslid;
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {

        }

        private void Tafelklikscherm_Load(object sender, EventArgs e)
        {
            btnTafel.Text = String.Format("Tafel {0}", tafel.tafelNummer);
            GetStatus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTafel_Click(object sender, EventArgs e)
        {
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            tafelDAO.UpdateTafel(tafel);
            GetStatus();
        }

        public void GetStatus()
        {
            if(tafelDAO.GetStatus(tafel))
            {
                btnStatus.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                btnStatus.BackColor = System.Drawing.Color.Green;
            }
        }

        private void btnOpnemen_Click(object sender, EventArgs e)
        {
            Bestelscherm bestellingscherm = new Bestelscherm(itemDAO, bestellingDAO, tafel, personeelslid);
            this.Hide();
            bestellingscherm.ShowDialog();
            this.Show();
        }

        private void btnAfrekenen_Click(object sender, EventArgs e)
        {
            AfrekenBetaalscherm BetaalScherm = new AfrekenBetaalscherm();
            this.Hide();
            BetaalScherm.ShowDialog();
            this.Show();
        }
    }
}
