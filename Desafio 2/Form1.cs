using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_2
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

        private void btncalc_Click(object sender, EventArgs e)
        {
             // Obtener los valores ingresados por el usuario
            if (!double.TryParse(txtmont.Text, out double montoPrestamo) ||
                !double.TryParse(txtint.Text, out double tasaInteres) ||
                !int.TryParse(txtcuo.Text, out int numeroCuotas))
            {
                return;
            }

            // Convertir la tasa de interés a periódica
            tasaInteres /= 100;
            double tasaPeriodica = tasaInteres / 12; // Suponiendo que la tasa de interés es anual

            // Calcular el monto de la cuota
            double cuota = (montoPrestamo * tasaPeriodica * Math.Pow(1 + tasaPeriodica, numeroCuotas)) / (Math.Pow(1 + tasaPeriodica, numeroCuotas) - 1);

            // Mostrar el resultado
            MessageBox.Show($"La cuota mensual es: {cuota:C}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
