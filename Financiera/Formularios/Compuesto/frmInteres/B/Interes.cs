using Financiera.Entidades.Compuesto;
using System;
using System.Windows.Forms;

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
            txtResultado.Value = Interes.CalcularInteres(capital, tasaEfectiva, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
