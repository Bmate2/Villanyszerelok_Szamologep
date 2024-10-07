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
        bool tizedesVesszo = false;
        bool elsoLeutes = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void pont_Click(object sender, EventArgs e)
        {

            if (muveletElvegezve)
            {
                EREDMENY.Text = null;
                muveletElvegezve = false;
                elsoszam = "";
                masodikszam = "";
            }
            if (elsoLeutes)
            {
                if (!elsovagymasodikszam)
                {
                    if (!tizedesVesszo)
                    {
                        EREDMENY.Text += "0,";
                        elsoszam += "0,";
                        tizedesVesszo = true;
                    }
                }
                else
                {
                    if (!tizedesVesszo)
                    {
                        EREDMENY.Text += "0,";
                        masodikszam += "0,";
                        tizedesVesszo = true;
                    }
                }
            }
            else
            {
                if (!elsovagymasodikszam)
                {
                    if (!tizedesVesszo)
                    {
                        EREDMENY.Text += ",";
                        elsoszam += ",";
                        tizedesVesszo = true;
                    }
                }
                else
                {
                    if (!tizedesVesszo)
                    {
                        EREDMENY.Text += ",";
                        masodikszam += ",";
                        tizedesVesszo = true;
                    }
                }
            }
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
            elsoLeutes = false;
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
            elsoLeutes = false;
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
            elsoLeutes = false;
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
            elsoLeutes = false;
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
            elsoLeutes = false;
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
            elsoLeutes = false;
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
            elsoLeutes = false;
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
            elsoLeutes = false;
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
            elsoLeutes = false;
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
            elsoLeutes = false;
        }
        #endregion
        private void osszeadas_Click(object sender, EventArgs e)
        {
            MuveletiJel();
            muvelet = '+';

        }
        private void szorzas_Click(object sender, EventArgs e)
        {
            MuveletiJel(); //Létrehoztam egy metódust ami minden szükséges általános tevékenységet elvégez a műveleti jelek lenyomásakor, ezt csak a két operandusos műveleteknél kell alkalmazni
            muvelet = '*';
        }
        private void kivonas_Click(object sender, EventArgs e)
        {
            MuveletiJel();
            muvelet = '-';
        }
        private void hatvanyozas_Click(object sender, EventArgs e)
        {
            MuveletiJel();
            muvelet = '^';
        }
        private void osztas_Click(object sender, EventArgs e)
        {
            MuveletiJel();
            muvelet = '/';
        }
        private void egyenlo_Click(object sender, EventArgs e)
        {

            switch (muvelet)
            {
                case '+':
                    eredmeny = double.Parse(elsoszam) + double.Parse(masodikszam);
                    break;
                case '-':
                    eredmeny = double.Parse(elsoszam) - double.Parse(masodikszam);
                    break;
                case '*':
                    eredmeny = double.Parse(elsoszam) * double.Parse(masodikszam);
                    break;
                case '%':
                    eredmeny = ( double.Parse(elsoszam) / double.Parse(masodikszam) * 100); //Például Az 50 a 200-nak a 25%-a
                    break;
                case '^':
                    eredmeny = Math.Pow(double.Parse(elsoszam), double.Parse(masodikszam));
                    break;
                case '/':
                    if(double.Parse(masodikszam) == 0)
                    {
                        Fullreset_Click(this, EventArgs.Empty);
                        MessageBox.Show("Nem oszthatsz nullával", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    eredmeny = double.Parse(elsoszam) / double.Parse(masodikszam);
                    break;
                default:
                    eredmeny = double.Parse(elsoszam);
                    break;
            }

            EREDMENY.Text = eredmeny.ToString();

            MuveletElvegezve();
        }
        private void negyzet_Click(object sender, EventArgs e)
        {
            eredmeny = Math.Pow(double.Parse(elsoszam), 2);
            EREDMENY.Text = eredmeny.ToString();
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
            eredmeny = eredmeny * 0.0025;
            EREDMENY.Text = $"{eredmeny.ToString("N2")} EUR";
            MuveletElvegezve();
        }
        private void MuveletiJel()
        {
            muveletElvegezve = false;
            EREDMENY.Text = null;
            elsovagymasodikszam = true;
            tizedesVesszo = false;
            elsoLeutes = true;
        }
        private void MuveletElvegezve()
        {
            muvelet = '0';
            elsoszam = eredmeny.ToString(); // A kijött értéket eltároltam az első számban ha esetleg még szeretnénk tovább dolgozni vele
            masodikszam = "0";
            elsovagymasodikszam = false;
            muveletElvegezve = true;
            tizedesVesszo = false;
            elsoLeutes = true;
        }

        private void Fullreset_Click(object sender, EventArgs e)
        {
            EREDMENY.Text = null;
            muvelet = '0';
            elsoszam = "0";
            masodikszam = "0";
            elsovagymasodikszam = false;
            muveletElvegezve = false;
            tizedesVesszo = false;
            eredmeny = 0;
        }

        private void torles_Click(object sender, EventArgs e)
        {
            if (EREDMENY.Text.Length > 0)
            {
                // Az utolsó karakter eltávolítása
                EREDMENY.Text = EREDMENY.Text.Substring(0, EREDMENY.Text.Length - 1);
                if (!elsovagymasodikszam)
                    elsoszam = elsoszam.Substring(0, elsoszam.Length - 1);
                else
                    masodikszam = masodikszam.Substring(0, masodikszam.Length - 1);
            }
        }

        private void Szazalek_Click(object sender, EventArgs e)
        {
            MuveletiJel();
            muvelet = '%';
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double radian = double.Parse(elsoszam) * (Math.PI / 180);
            eredmeny = Math.Cos(radian);
            EREDMENY.Text = eredmeny.ToString();
            MuveletElvegezve();
        }
        private void Sin_Click(object sender, EventArgs e)
        {
            double radian = double.Parse(elsoszam) * (Math.PI / 180);
            eredmeny = Math.Sin(radian);
            EREDMENY.Text = eredmeny.ToString();
            MuveletElvegezve();
        }

    }
}
