using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btmcalc_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            if (!double.TryParse(txtcap.Text, out double montoInicial) ||
                !double.TryParse(txtinte.Text, out double tasaInteres) ||
                !int.TryParse(txtperi.Text, out int periodo))

            {
                return;
            }

            // Convertir la tasa de interés a decimal
            tasaInteres /= 100;

            // Calcular el capital final
            double capitalFinal = montoInicial * Math.Pow(1 + tasaInteres, periodo);

            // Mostrar el resultado
            MessageBox.Show($"El capital final es: {capitalFinal:C}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
