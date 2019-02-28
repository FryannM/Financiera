using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financiera.Entidades;

namespace Financiera.Formularios
{
    public partial class Interes_A : UserControl
    {
        public Interes_A()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal monto = txtMonto.Value;
            decimal capital = txtCapital.Value;
            txtResultado.Value = InteresCompuesto.CalcularInteres(monto, capital);
            panelResultado.Visible = true;

        }
    }
}
