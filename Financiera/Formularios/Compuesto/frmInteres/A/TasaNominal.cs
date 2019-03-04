using System;
using System.Windows.Forms;
using Financiera.Entidades.Compuesto;

namespace Financiera.Formularios
{
    public partial class TasaNominal_A : UserControl
    {
        public TasaNominal_A()
        {
            InitializeComponent();
            foreach (var periodo in Enum.GetNames(typeof(Interes.Frecuencia)))
            {
                cbPeriodos.Items.Add(periodo);
            }

            cbPeriodos.SelectedIndex = cbPeriodos.Items.IndexOf(Enum.GetName(
                typeof(Interes.Frecuencia), Interes.Frecuencia.Anual
                ));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal tasaEfectiva = txtTasaEfectiva.Value;
            var periodo = (Interes.Frecuencia)Enum.Parse(typeof(Interes.Frecuencia), cbPeriodos.SelectedItem.ToString());
            txtResultado.Value = Interes.CalcularTasaNominal(periodo, tasaEfectiva);
            panelResultado.Visible = true;
        }
    }
}
