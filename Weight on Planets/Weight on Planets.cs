using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weight_on_Planets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lab_calculated_weight.Text = "Your weight on " + cbx_planets.Text + ":";

            MassOnMercury();
            MassOnVenus();
            MassOnMoon();
            MassOnMars();
            MassOnFobos();
            MassOnDeimos();
            MassOnJupiter();
            MassOnIo();
            MassOnEuropa();
            MassOnGanimede();
            MassOnCallisto();
            MassOnSaturn();
            MassOnTitan();
            MassOnRea();
            MassOnGiapeto();
            MassOnMimas();
            MassOnUranus();
            MassOnTitania();
            MassOnNeptune();
            MassOnTriton();
            MassOnPluto();
        }

        private void ComboboxError()
        {
            if (cbx_planets.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select a planet");
                return;
            }
                
        }

        private void MassOnMercury()
        {
            if (cbx_planets.SelectedIndex==0)
            {
                decimal mercury = 0;

                try
                { 
                    mercury = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnMercury = (mercury * 3.7m) / 9.807m;
                txt_calculated_weight.Text = MassOnMercury.ToString("0.000");
            }
        }

        private void MassOnVenus()
        {
            if (cbx_planets.SelectedIndex == 1)
            {
                decimal venus = 0;

                try
                {
                    venus = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnVenus = (venus * 8.87m) / 9.807m;
                txt_calculated_weight.Text = MassOnVenus.ToString("0.000");
            }
        }

        private void MassOnMoon()
        {
            if (cbx_planets.SelectedIndex == 2)
            {
                decimal moon = 0;

                try
                {
                    moon = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnMoon = (moon * 1.62m) / 9.807m;
                txt_calculated_weight.Text = MassOnMoon.ToString("0.000");
            }
        }

        private void MassOnMars()
        {
            if (cbx_planets.SelectedIndex == 3)
            {
                decimal mars = 0;

                try
                {
                    mars = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnMars = (mars * 3.721m) / 9.807m;
                txt_calculated_weight.Text = MassOnMars.ToString("0.000");
            }
        }

        private void MassOnFobos()
        {
            if (cbx_planets.SelectedIndex == 4)
            {
                decimal fobos = 0;

                try
                {
                    fobos = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnFobos = (fobos * 0.0057m) / 9.807m;
                txt_calculated_weight.Text = MassOnFobos.ToString("0.0000");
            }
        }

        private void MassOnDeimos()
        {
            if (cbx_planets.SelectedIndex == 5)
            {
                decimal deimos = 0;

                try
                {
                    deimos = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnDeimos= (deimos * 0.003m) / 9.807m;
                txt_calculated_weight.Text = MassOnDeimos.ToString("0.0000");
            }
        }

        private void MassOnJupiter()
        {
            if (cbx_planets.SelectedIndex == 6)
            {
                decimal jupiter = 0;

                try
                {
                    jupiter = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnJupiter = (jupiter * 24.79m) / 9.807m;
                txt_calculated_weight.Text = MassOnJupiter.ToString("0.000");
            }
        }

        private void MassOnIo()
        {
            if (cbx_planets.SelectedIndex == 7)
            {
                decimal io = 0;

                try
                {
                    io = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnIo = (io * 1.769m) / 9.807m;
                txt_calculated_weight.Text = MassOnIo.ToString("0.000");
            }
        }

        private void MassOnEuropa()
        {
            if (cbx_planets.SelectedIndex == 8)
            {
                decimal europa = 0;

                try
                {
                    europa = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnEuropa = (europa * 1.315m) / 9.807m;
                txt_calculated_weight.Text = MassOnEuropa.ToString("0.000");
            }
        }

        private void MassOnGanimede()
        {
            if (cbx_planets.SelectedIndex == 9)
            {
                decimal ganimede = 0;

                try
                {
                    ganimede = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnGanimede = (ganimede * 1.428m) / 9.807m;
                txt_calculated_weight.Text = MassOnGanimede.ToString("0.000");
            }
        }

        private void MassOnCallisto()
        {
            if (cbx_planets.SelectedIndex == 10)
            {
                decimal callisto = 0;

                try
                {
                    callisto = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnCallisto = (callisto * 1.236m) / 9.807m;
                txt_calculated_weight.Text = MassOnCallisto.ToString("0.000");
            }
        }

        private void MassOnSaturn()
        {
            if (cbx_planets.SelectedIndex == 11)
            {
                decimal saturn = 0;

                try
                {
                    saturn = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnSaturn = (saturn * 10.44m) / 9.807m;
                txt_calculated_weight.Text = MassOnSaturn.ToString("0.000");
            }
        }

        private void MassOnTitan()
        {
            if (cbx_planets.SelectedIndex == 12)
            {
                decimal titan = 0;

                try
                {
                    titan = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnTitan = (titan * 1.352m) / 9.807m;
                txt_calculated_weight.Text = MassOnTitan.ToString("0.000");
            }
        }

        private void MassOnRea()
        {
            if (cbx_planets.SelectedIndex == 13)
            {
                decimal rea = 0;

                try
                {
                    rea = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnRea = (rea * 0.264m) / 9.807m;
                txt_calculated_weight.Text = MassOnRea.ToString("0.0000");
            }
        }

        private void MassOnGiapeto()
        {
            if (cbx_planets.SelectedIndex == 14)
            {
                decimal giapeto = 0;

                try
                {
                    giapeto = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnGiapeto = (giapeto * 0.223m) / 9.807m;
                txt_calculated_weight.Text = MassOnGiapeto.ToString("0.0000");
            }
        }

        private void MassOnMimas()
        {
            if (cbx_planets.SelectedIndex == 15)
            {
                decimal mimas = 0;

                try
                {
                    mimas = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnMimas = (mimas * 0.064m) / 9.807m;
                txt_calculated_weight.Text = MassOnMimas.ToString("0.0000");
            }
        }

        private void MassOnUranus()
        {
            if (cbx_planets.SelectedIndex == 16)
            {
                decimal uranus = 0;

                try
                {
                    uranus = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnUranus = (uranus * 8.87m) / 9.807m;
                txt_calculated_weight.Text = MassOnUranus.ToString("0.000");
            }
        }

        private void MassOnTitania()
        {
            if (cbx_planets.SelectedIndex == 17)
            {
                decimal titania = 0;

                try
                {
                    titania = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnTitania = (titania * 0.367m) / 9.807m;
                txt_calculated_weight.Text = MassOnTitania.ToString("0.0000");
            }
        }

        private void MassOnNeptune()
        {
            if (cbx_planets.SelectedIndex == 18)
            {
                decimal neptune = 0;

                try
                {
                    neptune = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnNeptune = (neptune * 11.15m) / 9.807m;
                txt_calculated_weight.Text = MassOnNeptune.ToString("0.000");
            }
        }

        private void MassOnTriton()
        {
            if (cbx_planets.SelectedIndex == 19)
            {
                decimal triton = 0;

                try
                {
                    triton = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnTriton = (triton * 0.779m) / 9.807m;
                txt_calculated_weight.Text = MassOnTriton.ToString("0.000");
            }
        }

        private void MassOnPluto()
        {
            if (cbx_planets.SelectedIndex == 20)
            {
                decimal pluto = 0;

                try
                {
                    pluto = decimal.Parse(txt_earth_weight.Text);
                }
                catch
                {
                    if (txt_earth_weight.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid");
                    }
                }

                decimal MassOnPluto = (pluto * 0.62m) / 9.807m;
                txt_calculated_weight.Text = MassOnPluto.ToString("0.0000");
            }
        }

        private void KgToPounds()
        {
            decimal kg1 = 0;

            try
            {
                kg1 = decimal.Parse(txt_kg.Text);
            }
            catch
            {
                if (txt_kg.Text.Length == 0)
                {
                    //nothing
                }
                else
                {
                    MessageBox.Show("Only numbers are valid");
                }
            }

            decimal pounds1 = kg1 * 2.205m;

            lab_pounds.Text = pounds1.ToString("0.00") + " pounds";
        }

        private void PoundsToKg()
        {
            decimal pounds2 = 0;

            try
            {
                pounds2 = decimal.Parse(txt_pounds.Text);
            }
            catch
            {
                if (txt_pounds.Text.Length == 0)
                {
                    //nothing
                }
                else
                {
                    MessageBox.Show("Only numbers are valid");
                }
            }

            decimal kg2 = pounds2 / 2.205m;

            lab_kg.Text = kg2.ToString("0.00") + " kg";
        }

        private void onTextChange(object sender, EventArgs e)
        {
            ComboboxError();
            MassOnMercury();
            MassOnVenus();
            MassOnMoon();
            MassOnMars();
            MassOnFobos();
            MassOnDeimos();
            MassOnJupiter();
            MassOnIo();
            MassOnEuropa();
            MassOnGanimede();
            MassOnCallisto();
            MassOnSaturn();
            MassOnTitan();
            MassOnRea();
            MassOnGiapeto();
            MassOnMimas();
            MassOnUranus();
            MassOnTitania();
            MassOnNeptune();
            MassOnTriton();
            MassOnPluto();
        }

        private void Conversion(object sender, EventArgs e)
        {
            KgToPounds();
            PoundsToKg();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/riccio333/Weight-on-Planets");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nit_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lab_pounds_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lab_calculated_weight_Click(object sender, EventArgs e)
        {

        }

        private void lab_kg_Click(object sender, EventArgs e)
        {

        }
    }
}
