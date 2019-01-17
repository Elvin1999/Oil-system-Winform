using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oil_system1
{
    public partial class Form1 : Form
    {
        OilSystem oilSystem = new OilSystem();
        MiniCafe cafe = new MiniCafe();
        Petrol petrol = new Petrol();
        public Form1()
        {
            InitializeComponent();
            maskedtbFries.Enabled = false;
            maskedtbCola.Enabled = false;
            maskedtbQamburger.Enabled = false;
            maskedtbHotDog.Enabled = false;
            oilSystem._Cafe = cafe;
            oilSystem._Petrol = petrol;
        }

        private void checkBxHotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (!maskedtbHotDog.Enabled)
            {
                maskedtbHotDog.Enabled = true;
            }
            else
            {
                maskedtbHotDog.Enabled = false;
            }

            if (maskedtbHotDog.Text != String.Empty)
            {
                cafe.foods[0].Count = int.Parse(maskedtbHotDog.Text);

            }
        }

        private void checkBxQamb_CheckedChanged(object sender, EventArgs e)
        {

            if (!maskedtbQamburger.Enabled)
            {
                maskedtbQamburger.Enabled = true;
            }
            else
            {
                maskedtbQamburger.Enabled = false;
            }

            if (maskedtbQamburger.Text != String.Empty)
            {
                cafe.foods[1].Count = int.Parse(maskedtbQamburger.Text);
            }
        }

        private void checkBxFries_CheckedChanged(object sender, EventArgs e)
        {

            if (!maskedtbFries.Enabled)
            {
                maskedtbFries.Enabled = true;
            }
            else
            {
                maskedtbFries.Enabled = false;
            }

            if (maskedtbFries.Text != String.Empty)
            {
                cafe.foods[2].Count = int.Parse(maskedtbFries.Text);
            }
        }

        private void checkBxCola_CheckedChanged(object sender, EventArgs e)
        {

            if (!maskedtbCola.Enabled)
            {
                maskedtbCola.Enabled = true;
            }
            else
            {
                maskedtbCola.Enabled = false;
            }
            if (maskedtbCola.Text != String.Empty)
            {
                cafe.foods[3].Count = int.Parse(maskedtbCola.Text);
            }
        }
        private void maskedtbHotDog_Leave(object sender, EventArgs e)
        {
            if (maskedtbHotDog.Text != String.Empty)
            {
                cafe.foods[0].Count = int.Parse(maskedtbHotDog.Text);
            }
            cafe.Price += cafe.foods[0].Count * cafe.foods[0].Price;
            textBCafePrice.Text = cafe.GetPrice().ToString();
            maskedtbHotDog.Enabled = false;
        }

        private void maskedtbQamburger_Leave(object sender, EventArgs e)
        {
            if (maskedtbQamburger.Text != String.Empty)
            {
                cafe.foods[1].Count = int.Parse(maskedtbQamburger.Text);
            }
            cafe.Price += cafe.foods[1].Count* cafe.foods[1].Price;
            textBCafePrice.Text = cafe.GetPrice().ToString();
            
            maskedtbQamburger.Enabled = false;
        }

        private void maskedtbFries_Leave(object sender, EventArgs e)
        {
            if (maskedtbFries.Text != String.Empty)
            {
                cafe.foods[2].Count = int.Parse(maskedtbFries.Text);
            }
            cafe.Price += cafe.foods[2].Count * cafe.foods[2].Price;
            textBCafePrice.Text = cafe.GetPrice().ToString();
            maskedtbFries.Enabled = false;
        }
        private void maskedtbCola_Leave(object sender, EventArgs e)
        {
            if (maskedtbCola.Text != String.Empty)
            {
                cafe.foods[3].Count = int.Parse(maskedtbCola.Text);
            }
            cafe.Price += cafe.foods[3].Count * cafe.foods[3].Price;
            textBCafePrice.Text = cafe.GetPrice().ToString();
            maskedtbCola.Enabled = false;
        }
    }
}
