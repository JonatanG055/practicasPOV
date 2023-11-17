using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
           
            if (float.TryParse(textBoxTemperaturaCelsius.Text, out float temperaturaCelsius))
            {
               
                float temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

                labelTemperaturaFahrenheit.Text = $"{temperaturaFahrenheit} °F";
            }
            else
            {
              
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
    }
}
