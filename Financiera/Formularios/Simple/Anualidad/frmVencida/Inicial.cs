using System;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmVencida
{
    public partial class Inicial : UserControl
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorActual = txtValorActual.Value;
            decimal precioContado = txtPrecioContado.Value;
            txtResultado.Value = Vencida.CalcularInicial(precioContado, valorActual);
            panelResultado.Visible = true;

        }
    }
}
