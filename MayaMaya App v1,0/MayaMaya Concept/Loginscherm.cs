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
    public partial class InlogForm : Form
    {
        PersoneelslidDAO personeelslidDAO;
        ItemDAO itemDAO;
        TafelDAO tafelDAO;
        BestellingDAO bestellingDAO;
        Personeelslid personeelslid;

        public InlogForm(PersoneelslidDAO personeelslidDAO, ItemDAO itemDAO, TafelDAO tafelDAO, BestellingDAO bestellingDAO)
        {
            InitializeComponent();
            this.personeelslidDAO = personeelslidDAO;
            this.itemDAO = itemDAO;
            this.tafelDAO = tafelDAO;
            this.bestellingDAO = bestellingDAO;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool CorrectePin = personeelslidDAO.CheckPinCode(txtPincode.Text);
            if(CorrectePin)
            {
                personeelslid = personeelslidDAO.GetUser(txtPincode.Text);
                MessageBox.Show("Welkom op het bestelsysteem van restaurant MayaMaya!");
                if(personeelslid.TypePersoneelsLid == "keuken")
                {
                    Keukenscherm keukenscherm = new Keukenscherm(bestellingDAO, itemDAO);
                    this.Hide();
                    keukenscherm.ShowDialog();
                    this.Show();
                }
                else if (personeelslid.TypePersoneelsLid == "bar")
                {
                    Barscherm barscherm = new Barscherm(bestellingDAO, itemDAO);
                    this.Hide();
                    barscherm.ShowDialog();
                    this.Show();
                }
                else
                {
                    Menuscherm mainmenu = new Menuscherm(txtPincode.Text, personeelslidDAO, itemDAO, tafelDAO, bestellingDAO);
                    this.Hide();
                    mainmenu.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Incorrecte pin!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPincode_TextChanged(object sender, EventArgs e)
        {
            txtPincode.MaxLength = 4;
            txtPincode.PasswordChar = '*';
        }
    }
}
