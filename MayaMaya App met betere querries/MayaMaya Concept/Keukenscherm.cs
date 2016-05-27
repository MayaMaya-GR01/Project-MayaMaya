﻿using System;
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
    public class Keukenscherm : Bereidingscherm
    {
        

        public Keukenscherm(BestellingDAO bestellingDAO, ItemDAO itemDAO)
            : base(bestellingDAO, itemDAO)
        {
            lblBereidingTitelTekst.Text = "Keukenscherm";
            base.Text = "Keukenscherm";
        }

        protected override void ToonLopendeBestellingen()
        {
            List<Bestelling> bestellingen = bestellingDAO.GetAllKeukenLopend();

            foreach (Bestelling bestelling in bestellingen)
            {
                    ListViewItem listItem = new ListViewItem(bestelling.Bestelnummer.ToString());
                    listItem.SubItems.Add(bestelling.TafelVanBestelling.tafelNummer.ToString());
                    listItem.SubItems.Add(bestelling.DatumTijdVanBestellen.ToString());
                    listItem.SubItems.Add(bestellingDAO.GetAantalItemsInBestelling(bestelling.Bestelnummer).ToString());
                    listItem.SubItems.Add(bestelling.StatusVanBestelling);
                    lstBestellingen.Items.Add(listItem);
                
            }
        }

        protected override void ToonGereedgemeldeBestellingen()
        {
            List<Bestelling> bestellingen = bestellingDAO.GetAllKeukenGereed();

            foreach (Bestelling bestelling in bestellingen)
            {
                    ListViewItem listItem = new ListViewItem(bestelling.Bestelnummer.ToString());
                    listItem.SubItems.Add(bestelling.TafelVanBestelling.tafelNummer.ToString());
                    listItem.SubItems.Add(bestelling.DatumTijdVanBestellen.ToString());
                    listItem.SubItems.Add(bestellingDAO.GetAantalItemsInBestelling(bestelling.Bestelnummer).ToString());
                    listItem.SubItems.Add(bestelling.StatusVanBestelling);
                    lstBestellingen.Items.Add(listItem);
                
            }
        }
    }
}
