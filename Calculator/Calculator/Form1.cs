using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void szam0_Click(object sender, EventArgs e)
        {
            EREDMENY.Text += "0";
        }

        private void szam1_Click(object sender, EventArgs e)
        {
            EREDMENY.Text += "1";
        }

        private void szam2_Click(object sender, EventArgs e)
        {
            EREDMENY.Text += "2";
        }

        private void szam3_Click(object sender, EventArgs e)
        {
            EREDMENY.Text += "3";
        }

        private void szam4_Click(object sender, EventArgs e)
        {
            EREDMENY.Text += "4";
        }

        private void szam5_Click(object sender, EventArgs e)
        {
            EREDMENY.Text += "5";
        }

        private void szam6_Click(object sender, EventArgs e)
        {
            EREDMENY.Text += "6";
        }

        private void szam7_Click(object sender, EventArgs e)
        {
            EREDMENY.Text += "7";
        }

        private void szam8_Click(object sender, EventArgs e)
        {
            EREDMENY.Text += "8";
        }

        private void szam9_Click(object sender, EventArgs e)
        {
            EREDMENY.Text += "9";
<<<<<<< Updated upstream
=======
            if (!elsovagymasodikszam) elsoszam += "9";
            else masodikszam += "9";
        }
        #endregion
        private void osszeadas_Click(object sender, EventArgs e)
        {
            
            EREDMENY.Text = null;
            muvelet = '+';
            elsovagymasodikszam = true;
            elsoszamesmuvelet.Text = elsoszam + muvelet;
        }
        
        private void egyenlo_Click(object sender, EventArgs e)
        {
            EREDMENY.Text = null;
            if (muvelet=='+')
            {
                eredmeny = double.Parse(elsoszam) + double.Parse(masodikszam);
                EREDMENY.Text += eredmeny;
            }
>>>>>>> Stashed changes
        }
    }
}
