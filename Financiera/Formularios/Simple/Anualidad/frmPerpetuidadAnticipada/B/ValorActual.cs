using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadAnticipada.B
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
            decimal primerPago = txtPrimerPago.Value;
            txtResultado.Value = PerpetuidadAnticipada.CalcularValorActual(renta, tasaPeriodica, primerPago);
            panelResultado.Visible = true;
        }
    }
}
