using System;
using System.Windows.Forms;
using Financiera.Entidades.Compuesto;

namespace Financiera.Formularios
{
    public partial class TasaEfectiva_A : UserControl
    {
        public TasaEfectiva_A()
        {
            InitializeComponent();
            foreach(var periodo in Enum.GetNames(typeof(Interes.Frecuencia)))
            {
                cbPeriodos.Items.Add(periodo);
            }

            cbPeriodos.SelectedIndex = cbPeriodos.Items.IndexOf(Enum.GetName(
                typeof(Interes.Frecuencia), Interes.Frecuencia.Anual
                ));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal tasaNominal = txtTasaNominal.Value;
            var periodo = (Interes.Frecuencia)Enum.Parse(typeof(Interes.Frecuencia), cbPeriodos.SelectedItem.ToString());
            txtResultado.Value = Interes.CalcularTasaEfectiva(periodo, tasaNominal);
            panelResultado.Visible = true;
        }
    }
}
