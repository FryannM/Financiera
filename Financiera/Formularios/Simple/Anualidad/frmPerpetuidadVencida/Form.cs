using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadVencida
{
    public partial class Form : System.Windows.Forms.Form
    {
         public Form()
        {
            InitializeComponent();
        }

        private void mostrarOpcion(UserControl userControl)
        {
            if (!panelResultante.Controls.Contains(userControl))
            {
                panelResultante.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
            }
            userControl.BringToFront();

        }

        /// <summary>Selecciona control elegida.</summary>
        private void EnableOption()
        {
            switch (cbPerpetuidadVencida.SelectedItem.ToString())
            {
                case "Valor Actual":
                    mostrarOpcion(new ValorActual());
                    break;

                case "Renta":
                    mostrarOpcion(new Renta());
                    break;

                case "Tasa Periódica":
                    mostrarOpcion(new TasaPeriodica());
                    break;
            }

        }

        private void cbPerpetuidadVencida_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelResultante.Controls.Clear();
            EnableOption();
        }
    }
}
