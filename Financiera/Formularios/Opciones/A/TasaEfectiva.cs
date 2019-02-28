using System;
using System.Windows.Forms;
using Financiera.Entidades;

namespace Financiera.Formularios
{
    public partial class TasaEfectiva_A : UserControl
    {
        public TasaEfectiva_A()
        {
            InitializeComponent();
            foreach(var periodo in Enum.GetNames(typeof(InteresCompuesto.Frecuencia)))
            {
                cbPeriodos.Items.Add(periodo);
            }

            cbPeriodos.SelectedIndex = cbPeriodos.Items.IndexOf(InteresCompuesto.Frecuencia.Anual);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal tasaNominal = txtTasaNominal.Value;
            var periodo = (InteresCompuesto.Frecuencia)Enum.Parse(typeof(InteresCompuesto.Frecuencia), cbPeriodos.SelectedItem.ToString());
            txtResultado.Value = InteresCompuesto.CalcularTasaEfectiva(periodo, tasaNominal);
            labelPeriodo.Text = periodo.ToString();
            panelResultado.Visible = true;
        }
    }
}
