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
    public partial class Monto_A : UserControl
    {
        public Monto_A()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal capital = txtCapital.Value;
            decimal interes = txtInteres.Value;
            txtResultado.Value = InteresCompuesto.CalcularMonto(capital, interes);
            panelResultado.Visible = true;
        }
    }
}
