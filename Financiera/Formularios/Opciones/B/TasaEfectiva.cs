using System;
using System.Windows.Forms;
using Financiera.Entidades.Compuesto;

namespace Financiera.Formularios
{
    public partial class TasaEfectiva_B : UserControl
    {
        public TasaEfectiva_B()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal monto = txtMonto.Value;
            decimal capital = txtCapital.Value;
            decimal totalPeriodos = txtTotalPeriodos.Value;
            txtResultado.Value = Interes.CalcularTasaEfectiva(monto, capital, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
