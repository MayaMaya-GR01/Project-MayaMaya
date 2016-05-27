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
    public partial class Rekeningenscherm : Form
    {
        RekeningDAO rekeningDAO;

        public Rekeningenscherm(RekeningDAO rekeningDAO)
        {
            this.rekeningDAO = rekeningDAO;
            InitializeComponent();
        }

        private void Rekeningenscherm_Load(object sender, EventArgs e)
        {
            List<Rekening> rekeningen = rekeningDAO.GetAll();

            foreach (Rekening r in rekeningen)
            {
                lstRekeningen.Items.Add(r);
            }

        }

        private void btnNieuweRekening_Click(object sender, EventArgs e)
        {
            NieuweRekening form = new NieuweRekening(rekeningDAO);
            form.ShowDialog();
        }
    }
}
