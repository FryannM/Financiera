using System;
using System.Windows.Forms;

namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadAnticipada
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Controles de usuario.
        private static A.ValorActual valorActual_A;
        private static B.ValorActual valorActual_B;
        private static Renta renta;
        private static TasaPeriodica tasaPeriodica;

        /// <summary>Método auxiliar para resetear opciones</summary>
        private static void crearControles()
        {
            renta = new Renta();
            tasaPeriodica = new TasaPeriodica();
            valorActual_A = new A.ValorActual();
            valorActual_B = new B.ValorActual();
        }

        private void resetearOpciones()
        {
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            crearControles();
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

        /// <summary>Solo habilita la opción de renta o tasa periódica.</summary>
        private void EnableOption()
        {
            switch (cbPerpetuidadAnticipada.SelectedItem.ToString())
            {
                case "Renta":
                    mostrarOpcion(renta);
                    break;

                case "Tasa Periódica":
                    mostrarOpcion(tasaPeriodica);
                    break;
            }

        }

        private void cbPerpetuidadAnticipada_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelResultante.Controls.Clear();
            groupBoxOpciones.Visible = "Valor Actual".Equals(cbPerpetuidadAnticipada.SelectedItem.ToString());
            resetearOpciones();
            if(!groupBoxOpciones.Visible)
                EnableOption();
        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
            {
                mostrarOpcion(valorActual_A);
            }
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonB.Checked)
            {
                mostrarOpcion(valorActual_B);
            }
        }
    }
}
