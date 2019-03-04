using System;
using System.Windows.Forms;

namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadVencidaPagadera
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Controles de usuario.
        private static Renta renta;
        private static ValorActual valorActual;

        /// <summary>Método auxiliar para resetear opciones.</summary>
        private static void crearControles()
        {
            renta = new Renta();
            valorActual = new ValorActual();
        }
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

        /// <summary>Selecciona control y opción elegida.</summary>
        private void EnableOption()
        {
            switch (cbAnualidadPerpetuaPagadera.SelectedItem.ToString())
            {
                case "Renta":
                    mostrarOpcion(renta);
                    break;

                case "Valor Actual":
                    mostrarOpcion(valorActual);
                    break;
            }

        }

        private void cbAnualidadPerpetuaPagadera_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelResultante.Controls.Clear();
            crearControles();
            EnableOption();
        }
    }
}
