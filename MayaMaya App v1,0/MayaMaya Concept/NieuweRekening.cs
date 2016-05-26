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
    public partial class NieuweRekening : Form
    {
        RekeningDAO rekeningDAO;

        public NieuweRekening(RekeningDAO rekeningDAO)
        {
            this.rekeningDAO = rekeningDAO;
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaakRekening_Click(object sender, EventArgs e)
        {
            try {
                Rekening nieuweRekening = new Rekening(rekeningDAO);
                nieuweRekening.TotaalPrijs = Convert.ToDouble(txtTotaalPrijs.Text);
                nieuweRekening.BedragBtw = Convert.ToDouble(txtBedrag_btw.Text);
                nieuweRekening.BedragFooi = Convert.ToDouble(txtBedrag_fooi.Text);
                nieuweRekening.Commentaar = txtCommentaar.Text;
            }
            catch
            {
                lblException.Text = "Mislukt.";
            }

        }
    }
}
