using System;
using System.Windows.Forms;
using Financiera.Entidades.Compuesto;

namespace Financiera.Formularios
{
    public partial class Tiempo : UserControl
    {
        public Tiempo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal totalPeriodos = txtTotalPeriodos.Value;
            decimal frecuencia = txtPeriodo.Value;
            txtResultado.Value = Interes.CalcularTiempo(frecuencia, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
