using System;
using System.Windows.Forms;
using Financiera.Entidades;

namespace Financiera.Formularios
{
    public partial class Capital_C : UserControl
    {
        public Capital_C()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal interes = txtInteres.Value;
            decimal tasaEfectiva = txtTasaEfectiva.Value;
            decimal totalPeriodos = txtTotalPeriodos.Value;
            txtResultado.Value = InteresCompuesto.CalcularCapitalPorInteres(interes, tasaEfectiva, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
