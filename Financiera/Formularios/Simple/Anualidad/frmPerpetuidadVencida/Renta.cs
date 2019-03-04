using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadVencida
{
    public partial class Renta : UserControl
    {
        public Renta()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal tasaPeriodica = txtTasaPeriodica.Value;
            decimal valorActual = txtValorActual.Value;
            txtResultado.Value = PerpetuidadVencida.CalcularRenta(valorActual, tasaPeriodica);
            panelResultado.Visible = true;
        }

    }
}
