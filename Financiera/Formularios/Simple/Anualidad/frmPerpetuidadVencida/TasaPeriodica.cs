using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;


namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadVencida
{
    public partial class TasaPeriodica : UserControl
    {
        public TasaPeriodica()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal renta = txtRenta.Value;
            decimal valorActual = txtValorActual.Value;
            txtResultado.Value = PerpetuidadVencida.CalcularTasa(valorActual, renta);
            panelResultado.Visible = true;
        }
    }
}
