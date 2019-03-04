using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadAnticipada
{
    public partial class TasaPeriodica : UserControl
    {
        public TasaPeriodica()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorActual = txtValorActual.Value;
            decimal renta = txtRenta.Value;
            txtResultado.Value = PerpetuidadAnticipada.CalcularTasa(valorActual, renta);
            panelResultado.Visible = true;
        }
    }
}
