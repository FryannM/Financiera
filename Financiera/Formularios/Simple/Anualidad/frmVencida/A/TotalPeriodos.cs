using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmVencida.A
{
    public partial class TotalPeriodos : UserControl
    {
        public TotalPeriodos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal monto = txtMonto.Value;
            decimal renta = txtRenta.Value;
            decimal tasaPeriodica = txtTasaPeriodica.Value;
            txtResultado.Value = Vencida.CalcularPeriodosXMonto(monto, renta, tasaPeriodica);
            panelResultado.Visible = true;
        }
    }
}
