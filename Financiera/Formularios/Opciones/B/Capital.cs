using Financiera.Entidades.Compuesto;
using System;
using System.Windows.Forms;

namespace Financiera.Formularios
{
    public partial class Capital_B : UserControl
    {

        public Capital_B()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal monto = txtMonto.Value;
            decimal tasaEfectiva = txtTasaEfectiva.Value;
            decimal totalPeriodos = txtTotalPeriodos.Value;
            txtResultado.Value = Interes.CalcularCapitalPorMonto(monto, tasaEfectiva, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
