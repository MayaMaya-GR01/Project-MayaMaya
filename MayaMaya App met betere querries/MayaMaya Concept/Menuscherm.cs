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
    public partial class Menuscherm : Form
    {
        string Pincode;
        List<Personeelslid> ledenLijst = new List<Personeelslid>();
        List<Tafel> tafelLijst = new List<Tafel>();
        Personeelslid personeelslid;
        PersoneelslidDAO personeelslidDAO;
        ItemDAO itemDAO;
        TafelDAO tafelDAO;
        BestellingDAO bestellingDAO;

        public Menuscherm(string pincode, PersoneelslidDAO personeelslidDAO, ItemDAO itemdao, TafelDAO tafelDAO, BestellingDAO bestellingDAO)
        {
            InitializeComponent();
            this.personeelslidDAO = personeelslidDAO;
            this.itemDAO = itemdao;
            this.tafelDAO = tafelDAO;
            this.Pincode = pincode;
            this.bestellingDAO = bestellingDAO;
        }

        public Menuscherm()
        {
            // TODO: Complete member initialization
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.personeelslid = personeelslidDAO.GetUser(Pincode);
            ToonTafels();
            ToonStatus();
        }



        public void ToonStatus()
        {
            int gereedBestellingen = 0;
            int lopendeBestellingen = 0;
            int totaalLopendeBestellingen = 0;
            int totaalGereedBestellingen = 0;
            this.tafelLijst = tafelDAO.GetAll();
            foreach (Tafel tafel in tafelLijst)
            {
                switch (tafel.tafelNummer)
                {
                    case 1:
                        gereedBestellingen = 0;
                        lopendeBestellingen = 0;
                        foreach(string status in bestellingDAO.CheckTafel(tafel))
                        {
                            if (status == "in behandeling" || status == "wacht")
                            {
                                lopendeBestellingen++;
                                totaalLopendeBestellingen++;
                            }
                            if (status == "gereed")
                            {
                                gereedBestellingen++;
                                totaalGereedBestellingen++;
                                btnTafel1.BackColor = System.Drawing.Color.Purple;
                            }
                        }
                        lblGereed1.Text = String.Format("G: {0}", gereedBestellingen);
                        lblLopende1.Text = String.Format("L:  {0}", lopendeBestellingen);
                        break;
                    case 2:
                        gereedBestellingen = 0;
                        lopendeBestellingen = 0;
                        foreach(string status in bestellingDAO.CheckTafel(tafel))
                        {
                            if (status == "in behandeling" || status == "wacht")
                            {
                                lopendeBestellingen++;
                                totaalLopendeBestellingen++;
                            }
                            if (status == "gereed")
                            {
                                gereedBestellingen++;
                                totaalGereedBestellingen++;
                                btnTafel2.BackColor = System.Drawing.Color.Purple;
                            }
                        }
                        lblGereed2.Text = String.Format("G: {0}", gereedBestellingen);
                        lblLopende2.Text = String.Format("L:  {0}", lopendeBestellingen);
                        break;
                    case 3:
                        gereedBestellingen = 0;
                        lopendeBestellingen = 0;
                        foreach(string status in bestellingDAO.CheckTafel(tafel))
                        {
                            if (status == "in behandeling" || status == "wacht")
                            {
                                lopendeBestellingen++;
                                totaalLopendeBestellingen++;
                            }
                            if (status == "gereed")
                            {
                                gereedBestellingen++;
                                totaalGereedBestellingen++;
                                btnTafel3.BackColor = System.Drawing.Color.Purple;
                            }
                        }
                        lblGereed3.Text = String.Format("G: {0}", gereedBestellingen);
                        lblLopende3.Text = String.Format("L:  {0}", lopendeBestellingen);
                        break;
                    case 4:
                        gereedBestellingen = 0;
                        lopendeBestellingen = 0;
                        foreach(string status in bestellingDAO.CheckTafel(tafel))
                        {
                            if (status == "in behandeling" || status == "wacht")
                            {
                                lopendeBestellingen++;
                                totaalLopendeBestellingen++;
                            }
                            if (status == "gereed")
                            {
                                gereedBestellingen++;
                                totaalGereedBestellingen++;
                                btnTafel4.BackColor = System.Drawing.Color.Purple;
                            }
                        }
                        lblGereed4.Text = String.Format("G: {0}", gereedBestellingen);
                        lblLopende4.Text = String.Format("L:  {0}", lopendeBestellingen);
                        break;
                    case 5:
                        gereedBestellingen = 0;
                        lopendeBestellingen = 0;
                        foreach(string status in bestellingDAO.CheckTafel(tafel))
                        {
                            if (status == "in behandeling" || status == "wacht")
                            {
                                lopendeBestellingen++;
                                totaalLopendeBestellingen++;
                            }
                            if (status == "gereed")
                            {
                                gereedBestellingen++;
                                totaalGereedBestellingen++;
                                btnTafel5.BackColor = System.Drawing.Color.Purple;
                            }
                        }
                        lblGereed5.Text = String.Format("G: {0}", gereedBestellingen);
                        lblLopende5.Text = String.Format("L:  {0}", lopendeBestellingen);
                        break; 
                    case 6:
                        gereedBestellingen = 0;
                        lopendeBestellingen = 0;
                        foreach(string status in bestellingDAO.CheckTafel(tafel))
                        {
                            if (status == "in behandeling" || status == "wacht")
                            {
                                lopendeBestellingen++;
                                totaalLopendeBestellingen++;
                            }
                            if (status == "gereed")
                            {
                                gereedBestellingen++;
                                totaalGereedBestellingen++;
                                btnTafel6.BackColor = System.Drawing.Color.Purple;
                            }
                        }
                        lblGereed6.Text = String.Format("G: {0}", gereedBestellingen);
                        lblLopende66.Text = String.Format("L:  {0}", lopendeBestellingen);
                        break;
                    case 7:
                        gereedBestellingen = 0;
                        lopendeBestellingen = 0;
                        foreach(string status in bestellingDAO.CheckTafel(tafel))
                        {
                            if (status == "in behandeling" || status == "wacht")
                            {
                                lopendeBestellingen++;
                                totaalLopendeBestellingen++;
                            }
                            if (status == "gereed")
                            {
                                gereedBestellingen++;
                                totaalGereedBestellingen++;
                                btnTafel7.BackColor = System.Drawing.Color.Purple;
                            }
                        }
                        lblGereed7.Text = String.Format("G: {0}", gereedBestellingen);
                        lblLopende7.Text = String.Format("L:  {0}", lopendeBestellingen);
                        break;
                    case 8:
                        gereedBestellingen = 0;
                        lopendeBestellingen = 0;
                        foreach(string status in bestellingDAO.CheckTafel(tafel))
                        {
                            if (status == "in behandeling" || status == "wacht")
                            {
                                lopendeBestellingen++;
                                totaalLopendeBestellingen++;
                            }
                            if (status == "gereed")
                            {
                                gereedBestellingen++;
                                totaalGereedBestellingen++;
                                btnTafel8.BackColor = System.Drawing.Color.Purple;
                            }
                        }
                        lblGereed8.Text = String.Format("G: {0}", gereedBestellingen);
                        lblLopende8.Text = String.Format("L:  {0}", lopendeBestellingen);
                        break;
                    case 9:
                        gereedBestellingen = 0;
                        lopendeBestellingen = 0;
                        foreach(string status in bestellingDAO.CheckTafel(tafel))
                        {
                            if (status == "in behandeling" || status == "wacht")
                            {
                                lopendeBestellingen++;
                                totaalLopendeBestellingen++;
                            }
                            if (status == "gereed")
                            {
                                gereedBestellingen++;
                                totaalGereedBestellingen++;
                                btnTafel9.BackColor = System.Drawing.Color.Purple;
                            }
                        }
                        lblGereed9.Text = String.Format("G: {0}", gereedBestellingen);
                        lblLopende9.Text = String.Format("L:  {0}", lopendeBestellingen);
                        break;
                    case 10:
                        gereedBestellingen = 0;
                        lopendeBestellingen = 0;
                        foreach(string status in bestellingDAO.CheckTafel(tafel))
                        {
                            if (status == "in behandeling" || status == "wacht")
                            {
                                lopendeBestellingen++;
                                totaalLopendeBestellingen++;
                            }
                            if (status == "gereed")
                            {
                                gereedBestellingen++;
                                totaalGereedBestellingen++;
                                btnTafel10.BackColor = System.Drawing.Color.Purple;
                            }
                        }
                        lblGereed10.Text = String.Format("G: {0}", gereedBestellingen);
                        lblLopende10.Text = String.Format("L:  {0}", lopendeBestellingen);
                        break;
                    default:
                        break;
                }
                lblTotaalLopend.Text = String.Format("Totaal lopende bestellingen: {0}", totaalLopendeBestellingen);
                lblTotaalGereed.Text = String.Format("Totaal gereed bestellingen: {0}", totaalGereedBestellingen);
            }
        }

        public void ToonTafels()
        {
            this.tafelLijst = tafelDAO.GetAll();
            foreach (Tafel tafel in tafelLijst)
            {
                switch (tafel.tafelNummer)
                {
                    case 1: if (tafel.isBezet)
                        {
                            btnTafel1.BackColor = System.Drawing.Color.Red;
                        }
                    else
                        {
                            btnTafel1.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    case 2: if (tafel.isBezet)
                        {
                            btnTafel2.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            btnTafel2.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    case 3: if (tafel.isBezet)
                        {
                            btnTafel3.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            btnTafel3.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    case 4: if (tafel.isBezet)
                        {
                            btnTafel4.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            btnTafel4.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    case 5: if (tafel.isBezet)
                        {
                            btnTafel5.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            btnTafel5.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    case 6: if (tafel.isBezet)
                        {
                            btnTafel6.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            btnTafel6.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    case 7: if (tafel.isBezet)
                        {
                            btnTafel7.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            btnTafel7.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    case 8: if (tafel.isBezet)
                        {
                            btnTafel8.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            btnTafel8.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    case 9: if (tafel.isBezet)
                        {
                            btnTafel9.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            btnTafel9.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    case 10: if (tafel.isBezet)
                        {
                            btnTafel10.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            btnTafel10.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTafel1_Click(object sender, EventArgs e)
        {
            Tafelscherm tafelscherm = new Tafelscherm(tafelLijst[0], tafelDAO, itemDAO);
            this.Hide();
            tafelscherm.ShowDialog();
            btnTafel1.Refresh();
            this.Show();
        }
        private void btnTafel2_Click(object sender, EventArgs e)
        {
            Tafelscherm tafelscherm = new Tafelscherm(tafelLijst[1], tafelDAO, itemDAO);
            this.Hide();
            tafelscherm.ShowDialog();
            btnTafel2.Refresh();
            this.Show();
        }
        private void btnTafel3_Click(object sender, EventArgs e)
        {
            Tafelscherm tafelscherm = new Tafelscherm(tafelLijst[2], tafelDAO, itemDAO);
            this.Hide();
            tafelscherm.ShowDialog();
            btnTafel3.Refresh();
            this.Show();
        }
        private void btnTafel4_Click(object sender, EventArgs e)
        {
            Tafelscherm tafelscherm = new Tafelscherm(tafelLijst[3], tafelDAO, itemDAO);
            this.Hide();
            tafelscherm.ShowDialog();
            btnTafel4.Refresh();
            this.Show();
        }
        private void btnTafel5_Click(object sender, EventArgs e)
        {
            Tafelscherm tafelscherm = new Tafelscherm(tafelLijst[4], tafelDAO, itemDAO);
            this.Hide();
            tafelscherm.ShowDialog();
            btnTafel5.Refresh();
            this.Show();
        }
        private void btnTafel6_Click(object sender, EventArgs e)
        {
            Tafelscherm tafelscherm = new Tafelscherm(tafelLijst[5], tafelDAO, itemDAO);
            this.Hide();
            tafelscherm.ShowDialog();
            btnTafel6.Refresh();
            this.Show();
        }
        private void btnTafel7_Click(object sender, EventArgs e)
        {
            Tafelscherm tafelscherm = new Tafelscherm(tafelLijst[6], tafelDAO, itemDAO);
            this.Hide();
            tafelscherm.ShowDialog();
            btnTafel7.Refresh();
            this.Show();
        }
        private void btnTafel8_Click(object sender, EventArgs e)
        {
            Tafelscherm tafelscherm = new Tafelscherm(tafelLijst[7], tafelDAO, itemDAO);
            this.Hide();
            tafelscherm.ShowDialog();
            btnTafel8.Refresh();
            this.Show();
        }
        private void btnTafel9_Click(object sender, EventArgs e)
        {
            Tafelscherm tafelscherm = new Tafelscherm(tafelLijst[8], tafelDAO, itemDAO);
            this.Hide();
            tafelscherm.ShowDialog();
            btnTafel9.Refresh();
            this.Show();
        }
        private void btnTafel10_Click(object sender, EventArgs e)
        {
            Tafelscherm tafelscherm = new Tafelscherm(tafelLijst[9], tafelDAO, itemDAO);
            this.Hide();
            tafelscherm.ShowDialog();
            btnTafel10.Refresh();
            this.Show();
        }

        private void Menuscherm_Paint(object sender, PaintEventArgs e)
        {
            ToonTafels();
            ToonStatus();
        }

        private void btnVrijmaken_Click(object sender, EventArgs e)
        {
            tafelDAO.ClearAll();
            ToonTafels();
            ToonStatus();
        }

        private void lblLopende10_Click(object sender, EventArgs e)
        {

        }

        private void btnRekening_Click(object sender, EventArgs e)
        {
            AfrekenBetaalscherm BetaalScherm = new AfrekenBetaalscherm();
            this.Hide();
            BetaalScherm.ShowDialog();
            this.Show();
        }

        private void btnBestellingen_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblLopende1_Click(object sender, EventArgs e)
        {

        }
    }
}
