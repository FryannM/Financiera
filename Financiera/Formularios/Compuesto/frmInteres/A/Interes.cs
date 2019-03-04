using Financiera.Entidades.Compuesto;
using System;
using System.Windows.Forms;

namespace Financiera.Formularios
{
    public partial class Interes_A : UserControl
    {
        public Interes_A()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal monto = txtMonto.Value;
            decimal capital = txtCapital.Value;
            txtResultado.Value = Interes.CalcularInteres(monto, capital);
            panelResultado.Visible = true;

        }
    }
}
