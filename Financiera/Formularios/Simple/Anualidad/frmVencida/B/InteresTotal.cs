using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmVencida.B
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
            decimal valorActual = txtValorActual.Value;
            decimal totalPeriodos = txtTotalPeriodos.Value;
            txtResultado.Value = Vencida.CalcularInteresTotalXValorActual(totalPeriodos, renta, valorActual);
            panelResultado.Visible = true;
        }
    }
}
