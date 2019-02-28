using System;
using System.Windows.Forms;
using Financiera.Entidades;

namespace Financiera.Formularios
{
    public partial class TasaNominal_A : UserControl
    {
        public TasaNominal_A()
        {
            InitializeComponent();
            foreach (var periodo in Enum.GetNames(typeof(InteresCompuesto.Frecuencia)))
            {
                cbPeriodos.Items.Add(periodo);
            }

            cbPeriodos.SelectedIndex = cbPeriodos.Items.IndexOf(Enum.GetName(
                typeof(InteresCompuesto.Frecuencia), InteresCompuesto.Frecuencia.Anual
                ));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal tasaEfectiva = txtTasaEfectiva.Value;
            var periodo = (InteresCompuesto.Frecuencia)Enum.Parse(typeof(InteresCompuesto.Frecuencia), cbPeriodos.SelectedItem.ToString());
            txtResultado.Value = InteresCompuesto.CalcularTasaNominal(periodo, tasaEfectiva);
            panelResultado.Visible = true;
        }
    }
}
