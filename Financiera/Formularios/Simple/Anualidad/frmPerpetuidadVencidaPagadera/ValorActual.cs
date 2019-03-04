using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadVencidaPagadera
{
    public partial class ValorActual : UserControl
    {
        public ValorActual()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal renta = txtRenta.Value;
            decimal totalPeriodos = txtTotalPeriodos.Value;
            decimal tasaPeriodica = txtTasaEfectiva.Value;
            txtResultado.Value = PerpetuidadVencidaPagadera.CalcularValorActual(renta, tasaPeriodica, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
