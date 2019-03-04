using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmVencida.A
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
            txtResultado.Value = Vencida.CalcularRentaXMonto(monto, tasaPeriodica, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
