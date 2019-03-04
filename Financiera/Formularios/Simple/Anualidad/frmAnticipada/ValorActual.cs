using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmAnticipada
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
            decimal tasaPeriodica = txtTasaPeriodica.Value;
            decimal totalPeriodos = txtTotalPeriodos.Value;
            txtResultado.Value = Anticipada.CalcularValorActual(renta, tasaPeriodica, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
