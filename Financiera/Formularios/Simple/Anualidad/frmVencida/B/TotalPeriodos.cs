using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmVencida.B
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
            txtResultado.Value = Vencida.CalcularPeriodosXValorActual(valorActual, renta, tasaPeriodica);
            panelResultado.Visible = true;
        }
    }
}
