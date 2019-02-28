using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financiera.Entidades;

namespace Financiera.Formularios
{
    public partial class Interes_B : UserControl
    {
        public Interes_B()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal capital = txtCapital.Value;
            decimal tasaEfectiva = txtTasaEfectiva.Value;
            decimal totalPeriodos = txtTotalPeriodos.Value;
            txtResultado.Value = InteresCompuesto.CalcularInteres(capital, tasaEfectiva, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
