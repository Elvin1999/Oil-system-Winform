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

            textBCafePrice.Text = cafe.GetPrice().ToString();
            if (checkBxHotdog.Checked)
            {
                maskedtbHotDog.Enabled = true;
            }
            else
            {
                maskedtbHotDog.Enabled = false;
            }
            checkBxHotdog.Checked = false;
        }

        private void maskedtbQamburger_Leave(object sender, EventArgs e)
        {

            if (maskedtbQamburger.Text != String.Empty)
            {
                cafe.foods[1].Count = int.Parse(maskedtbQamburger.Text);

            }
            textBCafePrice.Text = cafe.GetPrice().ToString();
            if (checkBxQamb.Checked)
            {
                maskedtbQamburger.Enabled = true;
            }
            else
            {
                maskedtbQamburger.Enabled = false;
            }
            checkBxQamb.Checked = false;
        }

        private void maskedtbFries_Leave(object sender, EventArgs e)
        {

            if (maskedtbFries.Text != String.Empty)
            {
                cafe.foods[2].Count = int.Parse(maskedtbFries.Text);
            }

            textBCafePrice.Text = cafe.GetPrice().ToString();
            if (checkBxFries.Checked)
            {
                maskedtbFries.Enabled = true;
            }
            else
            {
                maskedtbFries.Enabled = false;
            }
            checkBxFries.Checked = false;
        }
        private void maskedtbCola_Leave(object sender, EventArgs e)
        {
            if (maskedtbCola.Text != String.Empty)
            {
                cafe.foods[3].Count = int.Parse(maskedtbCola.Text);
            }
            textBCafePrice.Text = cafe.GetPrice().ToString();
            if (checkBxCola.Checked)
            {
                maskedtbCola.Enabled = true;
            }
            else
            {
                maskedtbCola.Enabled = false;
            }
            checkBxCola.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBCafePrice.Text = cafe.GetPrice().ToString();
            labelResult.Text = oilSystem.GetAllPrice().ToString();
        }
        private void buttonDelAll_click(object sender, EventArgs e)
        {
            //after write file I have to write oilsystem to json file
            for (int i = 0; i < cafe.foods.Count; i++)
            {
                cafe.foods[i].Count = 0;
            }
            maskedtbCola.Text = "0";
            maskedtbFries.Text = "0";
            maskedtbHotDog.Text = "0";
            maskedtbQamburger.Text = "0";
            textBCafePrice.Text = "0";
            labelResult.Text = "0";
        }
    }
}
