using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadAnticipada.A
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
            txtResultado.Value = PerpetuidadAnticipada.CalcularValorActual(renta, tasaPeriodica);
            panelResultado.Visible = true;
        }
    }
}
