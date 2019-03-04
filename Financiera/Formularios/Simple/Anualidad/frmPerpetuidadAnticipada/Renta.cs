using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadAnticipada
{
    public partial class Renta : UserControl
    {
        public Renta()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorActual = txtValorActual.Value;
            decimal tasaPeriodica = txtTasaPeriodica.Value;
            txtResultado.Value = PerpetuidadAnticipada.CalcularRenta(valorActual, tasaPeriodica);
            panelResultado.Visible = true;
        }
    }
}
