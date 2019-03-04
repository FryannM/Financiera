using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financiera.Entidades.Simple.Anualidad;

namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadVencidaPagadera
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
            decimal totalPeriodos = txtTotalPeriodos.Value;
            decimal tasaPeriodica = txtTasaEfectiva.Value;
            txtResultado.Value = PerpetuidadVencidaPagadera.CalcularRenta(valorActual, tasaPeriodica, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
