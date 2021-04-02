using System;
using System.Windows.Forms;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>

namespace Actividad_Integradora_2_Problema_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double ventas = Convert.ToDouble(txtVentas.Text);
            double sueldoBase = Convert.ToDouble(txtSueldoBase.Text);
            double comision = (ventas * 10)/100;

            lblComision.Text = (sueldoBase * (comision)).ToString();
            lblSueldo.Text = (sueldoBase * (1 + comision)).ToString();
        }
    }
}
