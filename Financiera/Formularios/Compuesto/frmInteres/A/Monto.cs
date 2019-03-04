using Financiera.Entidades.Compuesto;
using System;
using System.Windows.Forms;

namespace Financiera.Formularios
{
    public partial class Monto_A : UserControl
    {
        public Monto_A()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal capital = txtCapital.Value;
            decimal interes = txtInteres.Value;
            txtResultado.Value = Interes.CalcularMonto(capital, interes);
            panelResultado.Visible = true;
        }
    }
}
