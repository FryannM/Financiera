using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmVencida
{
    public partial class Monto : UserControl
    {
        public Monto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal renta = txtRenta.Value;
            decimal tasaPeriodica = txtTasaPeriodica.Value;
            decimal totalPeriodos = txtTotalPeriodos.Value;
            txtResultado.Value = Vencida.CalcularMonto(renta, tasaPeriodica, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
