using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Temperaturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void rbFahrenheit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);

            if (rbCelsius1.Checked == true)
            {
                if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = (valor + 273) + "K";
                }

                else
                    if (rbFahrenheit2.Checked == true)
                {
                    txtResultado.Text = (valor * 1.8 + 32) + "°F";
                }

                else
                {
                    txtResultado.Text = valor + "°C";
                }
            }

            else
                if (rbKelvin2.Checked == true)
              {
                if (rbCelsius2.Checked == true)
                {
                    txtResultado.Text = (valor - 273) + "°C";
                }

                else
                    if (rbFahrenheit2.Checked == true)
                {
                    txtResultado.Text = (valor * 1.8 - 459.67) + "°F";
                }

                else
                {
                    txtResultado.Text = valor + "K";
                }

                    if (rbFahrenheit1.Checked == true) // verifica se a opção Fahrenheit do GroupBox Saída e realiza a conversão.
                {
                    // verifica qual opção está selecionada no GroupBox Saída e realiza a conversão.
                    // ..e atribui o resultado ao txtResultado.

                    if (rbCelsius2.Checked == true)
                    {
                        txtResultado.Text = ((valor - 32) / 1.8) + "ºC";
                    }

                    else
                        if (rbKelvin2.Checked == true)
                    {
                        txtResultado.Text = ((valor + 459.67) / 1.8) + "K";
                    }

                    else
                    {
                        txtResultado.Text = valor + "°F";
                    }    
                }
                
                else // no aso de todas as verificações retornarem falso...
                {
                    txtResultado.Text = valor.ToString(); // ...o programa somente irá atribuir o valor ao txtResultado. 
                }
            }
            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtResultado.Clear();

            foreach(Control Componente in gbEntrada.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }

            foreach (Control Componente in gbSaida.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }
        }
    }
}
