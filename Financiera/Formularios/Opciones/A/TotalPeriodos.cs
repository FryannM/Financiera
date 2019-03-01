using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Financiera.Entidades;

namespace Financiera.Formularios
{
    public partial class TotalPeriodos_A : UserControl
    {
        public TotalPeriodos_A()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal tiempo = txtTiempo.Value;
            decimal periodo = txtPeriodo.Value;
            txtResultado.Value = InteresCompuesto.CalcularTotalPeriodos(periodo, tiempo);
            panelResultado.Visible = true;
        }
    }
}
