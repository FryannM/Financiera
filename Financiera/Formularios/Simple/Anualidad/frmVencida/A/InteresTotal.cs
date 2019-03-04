using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmVencida.A
{
    public partial class InteresTotal : UserControl
    {
        public InteresTotal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal renta = txtRenta.Value;
            decimal monto = txtMonto.Value;
            decimal totalPeriodos = txtTotalPeriodos.Value;
            txtResultado.Value = Vencida.CalcularInteresTotalXMonto(monto, totalPeriodos, renta);
            panelResultado.Visible = true;
        }
    }
}
