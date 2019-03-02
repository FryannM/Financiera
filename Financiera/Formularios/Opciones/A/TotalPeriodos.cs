using System;
using System.Windows.Forms;
using Financiera.Entidades.Compuesto;

namespace Financiera.Formularios
{
    public partial class TotalPeriodos_A : UserControl
    {
        public TotalPeriodos_A()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal tiempo = txtTiempo.Value;
            decimal periodo = txtPeriodo.Value;
            txtResultado.Value = Interes.CalcularTotalPeriodos(periodo, tiempo);
            panelResultado.Visible = true;
        }
    }
}
