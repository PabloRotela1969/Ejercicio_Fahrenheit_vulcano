using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Formulario
{
    public partial class frmVulcano : Form
    {

        public frmVulcano()
        {
            InitializeComponent();
        }

        private void btnDeFah_Click(object sender, EventArgs e)
        {
            double temperatura;
            double.TryParse(this.txtFahren.Text, out temperatura);
            Fahrenheit f = new Fahrenheit(temperatura);
            Celsius c = (Celsius)f;
            this.txtFAh_Cel.Text = c.Temperatura.ToString();
            Kelvin k = (Kelvin)f;
            this.txtFah_Kel.Text = k.Temperatura.ToString();
            this.txtFah_Fah.Text = f.Temperatura.ToString();
        }

        private void txtDeCel_Click(object sender, EventArgs e)
        {
            double temperatura;
            double.TryParse(this.txtCelsius.Text, out temperatura);
            Celsius c = new Celsius(temperatura);
            this.txtCel_Cel.Text = c.Temperatura.ToString();
            Fahrenheit f = c;
            this.txtCel_Fah.Text = f.Temperatura.ToString();
            Kelvin k = c;
            this.txtCel_Kel.Text = k.Temperatura.ToString();
        }

        private void txtDeKel_Click(object sender, EventArgs e)
        {
            double temperatura;
            double.TryParse(this.txtCelsius.Text, out temperatura);
            Kelvin kelvin = new Kelvin(temperatura);
            this.txtKel_Kel.Text = kelvin.Temperatura.ToString();
            Celsius c = kelvin;
            this.txtKel_Cel.Text = c.Temperatura.ToString();
            Fahrenheit f = kelvin;
            this.txtKel_Fah.Text = f.Temperatura.ToString();

        }
    }
}
