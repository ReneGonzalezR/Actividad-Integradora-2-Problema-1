using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
