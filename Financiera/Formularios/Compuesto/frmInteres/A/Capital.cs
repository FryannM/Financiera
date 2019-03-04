using System;
using System.Windows.Forms;
using Financiera.Entidades.Compuesto;

namespace Financiera.Formularios
{
    public partial class Capital_A : UserControl
    {
        public Capital_A()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal monto = txtMonto.Value;
            decimal interes = txtInteres.Value;
            txtResultado.Value = Interes.CalcularCapital(monto, interes);
            panelResultado.Visible = true;

        }
    }
}
