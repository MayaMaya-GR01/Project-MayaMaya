using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace MayaMaya_Concept
{
    class ListViewStatusSort : IComparer
    {
        int kolom;
        bool oplopend;
        //CaseInsensitiveComparer ObjectCompare;

        public ListViewStatusSort(bool oplopend)
        {
            // Initialize the column to '0'
            kolom = 4;

            this.oplopend = oplopend;

            // Initialize the CaseInsensitiveComparer object
            //ObjectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x, object y)
        {
            int vergelijkingsWaarde = String.Compare(((ListViewItem)x).SubItems[kolom].Text,
            ((ListViewItem)y).SubItems[kolom].Text);

            // Geeft sorteer waarde terug
            if (oplopend)
            {
                return vergelijkingsWaarde;
            }
            else
            {
                return -vergelijkingsWaarde;
            }
        }
    }
}
