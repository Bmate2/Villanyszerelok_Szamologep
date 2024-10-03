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
        string elsoszam = "0";
        string masodikszam = "0";
        char muvelet = '0';
        bool elsovagymasodikszam = false; //Ha true akkor a második szám beírása van már folyamatban
        double eredmeny = 0.0;
        bool muveletElvegezve = false; //Létrehoztam egy bool változót ami ellenőrzi hogy végrehajtottunk e már műveletet,
                                       //ha igen akkor új szám beírásakor ezt hamisra állítja, és mindent visszaállít alaphelyzetbe
       
        public Form1()
        {
            InitializeComponent();
        }

        #region 1-9szamok
        private void szam0_Click(object sender, EventArgs e)
        {
            if (muveletElvegezve)
            {
                EREDMENY.Text = null;
                muveletElvegezve = false;
                elsoszam = "";
                masodikszam = "0";
            }
            EREDMENY.Text += "0";
            if (!elsovagymasodikszam) elsoszam += "0";
            else masodikszam += "0";
        }

        private void szam1_Click(object sender, EventArgs e)
        {
            if (muveletElvegezve)
            {
                EREDMENY.Text = null;
                muveletElvegezve = false;
                elsoszam = "";
                masodikszam = "0";
            }
            EREDMENY.Text += "1";
            if (!elsovagymasodikszam) elsoszam += "1";
            else masodikszam += "1";
        }

        private void szam2_Click(object sender, EventArgs e)
        {
            if (muveletElvegezve)
            {
                EREDMENY.Text = null;
                muveletElvegezve = false;
                elsoszam = "";
                masodikszam = "0";
            }
            EREDMENY.Text += "2";
            if (!elsovagymasodikszam) elsoszam += "2";
            else masodikszam += "2";
        }

        private void szam3_Click(object sender, EventArgs e)
        {
            if (muveletElvegezve)
            {
                EREDMENY.Text = null;
                muveletElvegezve = false;
                elsoszam = "";
                masodikszam = "0";
            }
            EREDMENY.Text += "3";
            if (!elsovagymasodikszam) elsoszam += "3";
            else masodikszam += "3";
        }

        private void szam4_Click(object sender, EventArgs e)
        {
            if (muveletElvegezve)
            {
                EREDMENY.Text = null;
                muveletElvegezve = false;
                elsoszam = "";
                masodikszam = "0";
            }
            EREDMENY.Text += "4";
            if (!elsovagymasodikszam) elsoszam += "4";
            else masodikszam += "4";
        }

        private void szam5_Click(object sender, EventArgs e)
        {
            if (muveletElvegezve)
            {
                EREDMENY.Text = null;
                muveletElvegezve = false;
                elsoszam = "";
                masodikszam = "0";
            }
            EREDMENY.Text += "5";
            if (!elsovagymasodikszam) elsoszam += "5";
            else masodikszam += "5";
        }

        private void szam6_Click(object sender, EventArgs e)
        {
            if (muveletElvegezve)
            {
                EREDMENY.Text = null;
                muveletElvegezve = false;
                elsoszam = "";
                masodikszam = "0";
            }
            EREDMENY.Text += "6";
            if (!elsovagymasodikszam) elsoszam += "6";
            else masodikszam += "6";
        }

        private void szam7_Click(object sender, EventArgs e)
        {
            if (muveletElvegezve)
            {
                EREDMENY.Text = null;
                muveletElvegezve = false;
                elsoszam = "";
                masodikszam = "0";
            }
            EREDMENY.Text += "7";
            if (!elsovagymasodikszam) elsoszam += "7";
            else masodikszam += "7";
        }

        private void szam8_Click(object sender, EventArgs e)
        {
            if (muveletElvegezve)
            {
                EREDMENY.Text = null;
                muveletElvegezve = false;
                elsoszam = "";
                masodikszam = "0";
            }
            EREDMENY.Text += "8";
            if (!elsovagymasodikszam) elsoszam += "8";
            else masodikszam += "8";
        }

        private void szam9_Click(object sender, EventArgs e)
        {
            if (muveletElvegezve)
            {
                EREDMENY.Text = null;
                muveletElvegezve = false;
                elsoszam = "";
                masodikszam = "0";
            }
            EREDMENY.Text += "9";
            if (!elsovagymasodikszam) elsoszam += "9";
            else masodikszam += "9";
        }
        #endregion
        private void osszeadas_Click(object sender, EventArgs e)
        {
            muveletElvegezve = false; //Átállítottam a változó értékét hamisra hogy tudjunk tovább dolgozni a kijött eredményünkel,
                                      //ezt minden művelet metódusnál érdemes megtenni
            EREDMENY.Text = null;
            muvelet = '+';
            elsovagymasodikszam = true;
            
        }
        private void szorzas_Click(object sender, EventArgs e)
        {
            muveletElvegezve = false;
            EREDMENY.Text = null;
            muvelet = '*';
            elsovagymasodikszam = true;
        }

        private void egyenlo_Click(object sender, EventArgs e)
        {
            
            if (muvelet == '0')
                EREDMENY.Text = elsoszam.ToString();
            if (muvelet=='+')
            {
                eredmeny = double.Parse(elsoszam) + double.Parse(masodikszam);
                EREDMENY.Text = eredmeny.ToString();
            }
            else if (muvelet == '*')
            {
                eredmeny = double.Parse(elsoszam) * double.Parse(masodikszam);
                EREDMENY.Text = eredmeny.ToString();
            }

            MuveletElvegezve();
        }

        private void dollar_Click(object sender, EventArgs e)
        {
            eredmeny = double.Parse(elsoszam);
            eredmeny = eredmeny * 0.0028;
            EREDMENY.Text = $"{eredmeny.ToString("N2")} USD";
            MuveletElvegezve();
        }

        private void euro_Click(object sender, EventArgs e)
        {
            eredmeny = double.Parse(elsoszam);
            eredmeny = eredmeny * 0.0028;
            EREDMENY.Text = $"{eredmeny.ToString("N2")} EUR";
            MuveletElvegezve();
        }

        private void MuveletElvegezve()
        {
            muvelet = '0';
            elsoszam = eredmeny.ToString(); // A kijött értéket eltároltam az első számban ha esetleg még szeretnénk tovább dolgozni vele
            masodikszam = "0";
            elsovagymasodikszam = false;
            muveletElvegezve = true;
        }
    }
}
