using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmAnticipada.B
{
    public partial class TotalPeriodos : UserControl
    {
        public TotalPeriodos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorActual = txtValorActual.Value;
            decimal renta = txtRenta.Value;
            decimal tasaPeriodica = txtTasaPeriodica.Value;
            txtResultado.Value = Anticipada.CalcularPeriodosXValorActual(valorActual, renta, tasaPeriodica);
            panelResultado.Visible = true;
        }
    }
}
