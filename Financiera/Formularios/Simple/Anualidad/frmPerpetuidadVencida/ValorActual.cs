using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadVencida
{
    public partial class ValorActual : UserControl
    {
        public ValorActual()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal tasaPeriodica = txtTasaPeriodica.Value;
            decimal renta = txtRenta.Value;
            txtResultado.Value = PerpetuidadVencida.CalcularValorActual(renta, tasaPeriodica);
            panelResultado.Visible = true;
        }
    }
}
