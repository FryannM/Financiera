using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Financiera.Entidades;

namespace Financiera.Formularios
{
    public partial class TotalPeriodos_A : UserControl
    {
        private static IReadOnlyDictionary<string, string> Periodos { get; } = new Dictionary<string, string>{
            {"Año(s)", "ANUAL"}, {"Semestre(s)", "SEMESTRAL"}, {"Cuatrimestre(s)", "CUATRIMESTRAL"},
            { "Trimestre(s)", "TRIMESTRAL"}, {"Bimestre(s)", "BIMESTRAL"},
            { "Mes(es)", "MENSUAL"}, {"Quincena(s)", "QUINCENAL"}, {"Semana(s)", "SEMANAL"}, {"Día(s)", "DIARIA"}
        };

        public TotalPeriodos_A()
        {
            InitializeComponent();
            foreach(var periodo in Periodos.Keys)
            {
                cbPeriodos.Items.Add(periodo);
            }
            cbPeriodos.SelectedIndex = cbPeriodos.Items.IndexOf("Año(s)");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal tiempo = txtTiempo.Value;
            decimal periodo = txtPeriodo.Value;
            txtResultado.Value = InteresCompuesto.CalcularTotalPeriodos(periodo, tiempo);
            panelResultado.Visible = true;
        }

        private void cbPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPeriodo.Text = cbPeriodos.SelectedItem.ToString();
        }
    }
}
