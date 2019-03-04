using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmVencida
{
    public partial class PrecioContado : UserControl
    {
        public PrecioContado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorActual = txtValorActual.Value;
            decimal inicial = txtInicial.Value;
            txtResultado.Value = Vencida.CalcularPrecioContado(inicial, valorActual);
            panelResultado.Visible = true;

        }
    }
}
