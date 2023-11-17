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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            
            cboUnidadMasa.DataSource = new string[] { "Libra", "Kilogramo" };
        }

        private void ButtonConvertir_Click(object sender, EventArgs e)
        {
            
            if (!double.TryParse(txtmasa.Text, out double masa))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico.");
                return;
            }

            if (cboUnidadMasa.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una unidad de masa a convertir.");
                return;
            }

            string unidadMasaSeleccionada = cboUnidadMasa.SelectedItem.ToString();

            double resultado;
            if (unidadMasaSeleccionada == "Libra")
            {
                resultado = masa / 2.205;
            }
            else 
            {
                resultado = masa * 2.205;
            }

            lblResultado.Text = $"El resultado de la conversión es: {resultado}";
        }
    }
}
