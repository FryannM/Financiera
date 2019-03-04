using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Financiera.Entidades.Compuesto;

namespace Financiera.Formularios
{
    public partial class TasaNominal_B : UserControl
    {
        private static IReadOnlyDictionary<string, Interes.Frecuencia> Periodos { get; } = 
            new Dictionary<string, Interes.Frecuencia>{
            {"Año(s)", Interes.Frecuencia.Anual}, {"Semestre(s)", Interes.Frecuencia.Semestral},
            { "Cuatrimestre(s)", Interes.Frecuencia.Cuatrimestral},
            { "Trimestre(s)", Interes.Frecuencia.Trimestral}, {"Bimestre(s)", Interes.Frecuencia.Bimestral},
            { "Mes(es)", Interes.Frecuencia.Mensual}, {"Quincena(s)", Interes.Frecuencia.Quincenal},
            { "Semana(s)", Interes.Frecuencia.Semanal}, {"Día(s)", Interes.Frecuencia.Diaria}
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
            var periodo = (Interes.Frecuencia)Enum.Parse(typeof(Interes.Frecuencia), value);
            txtResultado.Value = Interes.CalcularTasaNominal(periodo, monto, capital, totalPeriodos);
            panelResultado.Visible = true;
        }
    }
}
