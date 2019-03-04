using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmAnticipada.A
{
    public partial class Renta : UserControl
    {
        public Renta()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            decimal monto = txtMonto.Value;
            decimal tasaPeriodica = txtTasaPeriodica.Value;
            decimal totalPeriodos = txtTotalPeriodos.Value;
            txtResultado.Value = Anticipada.CalcularRentaXMonto(monto, tasaPeriodica, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
