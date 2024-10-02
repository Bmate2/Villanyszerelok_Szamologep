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
        }
        
        private void dollar_Click(object sender, EventArgs e)
        {
            double ertek = int.Parse(EREDMENY.Text);
            ertek = ertek * 0.0028;
            EREDMENY.Text = $"{ertek.ToString()} USD";
        }

        private void euro_Click(object sender, EventArgs e)
        {
            double ertek = int.Parse(EREDMENY.Text);
            ertek = ertek * 0.0025;
            EREDMENY.Text = $"{ertek.ToString()} EUR";
        }
    }
}
