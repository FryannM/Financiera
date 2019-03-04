using System;
using System.Windows.Forms;
using Financiera.Entidades.Compuesto;

namespace Financiera.Formularios
{
    public partial class Monto_B : UserControl
    {
        public Monto_B()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal capital = txtCapital.Value;
            decimal tasaEfectiva = txtTasaEfectiva.Value;
            decimal totalPeriodos = txtTotalPeriodos.Value;
            txtResultado.Value = Interes.CalcularMonto(capital, tasaEfectiva, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
