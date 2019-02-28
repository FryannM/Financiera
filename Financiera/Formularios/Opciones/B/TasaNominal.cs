using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Financiera.Entidades;

namespace Financiera.Formularios
{
    public partial class TasaNominal_B : UserControl
    {
        private static IReadOnlyDictionary<string, InteresCompuesto.Frecuencia> Periodos { get; } = 
            new Dictionary<string, InteresCompuesto.Frecuencia>{
            {"Año(s)", InteresCompuesto.Frecuencia.Anual}, {"Semestre(s)", InteresCompuesto.Frecuencia.Semestral},
            { "Cuatrimestre(s)", InteresCompuesto.Frecuencia.Cuatrimestral},
            { "Trimestre(s)", InteresCompuesto.Frecuencia.Trimestral}, {"Bimestre(s)", InteresCompuesto.Frecuencia.Bimestral},
            { "Mes(es)", InteresCompuesto.Frecuencia.Mensual}, {"Quincena(s)", InteresCompuesto.Frecuencia.Quincenal},
            { "Semana(s)", InteresCompuesto.Frecuencia.Semanal}, {"Día(s)", InteresCompuesto.Frecuencia.Diaria}
        };

        public TasaNominal_B()
        {
            InitializeComponent();
            foreach (var periodo in Periodos.Keys)
            {
                cbPeriodos.Items.Add(periodo);
            }

            cbPeriodos.SelectedIndex = cbPeriodos.Items.IndexOf("Año(s)");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal monto = txtMonto.Value;
            decimal capital = txtCapital.Value;
            decimal totalPeriodos = txtTotalPeriodos.Value;
            var value = Periodos[cbPeriodos.SelectedItem.ToString()].ToString();
            var periodo = (InteresCompuesto.Frecuencia)Enum.Parse(typeof(InteresCompuesto.Frecuencia), value);
            txtResultado.Value = InteresCompuesto.CalcularTasaNominal(periodo, monto, capital, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
