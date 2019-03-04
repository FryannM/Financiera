using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiera.Formularios.Simple.Anualidad.frmAnticipada
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Controles de usuario.
        private static Monto monto;
        private static ValorActual valorActual;
        private static A.Renta renta_A;
        private static A.TotalPeriodos totalPeriodos_A;
        private static B.Renta renta_B;
        private static B.TotalPeriodos totalPeriodos_B;

        /// <summary>Método auxiliar para resetear opciones.</summary>
        private static void crearControles()
        {
            valorActual = new ValorActual();
            monto = new Monto();
            renta_A = new A.Renta();
            renta_B = new B.Renta();
            totalPeriodos_A = new A.TotalPeriodos();
            totalPeriodos_B = new B.TotalPeriodos();
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

        // Selecciona control y opcion elegida
        private void EnableOptionA()
        {
            switch (cbAnticipada.SelectedItem.ToString())
            {
                case "Renta":
                    mostrarOpcion(renta_A);
                    break;

                case "Total Períodos":
                    mostrarOpcion(totalPeriodos_A);
                    break;

            }

        }

        private void EnableOptionB()
        {
            switch (cbAnticipada.SelectedItem.ToString())
            {
                case "Renta":
                    mostrarOpcion(renta_B);
                    break;

                case "Total Períodos":
                    mostrarOpcion(totalPeriodos_B);
                    break;

            }
        }

        private void cbAnticipada_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelResultante.Controls.Clear();
            resetearOpciones();
            groupBoxOpciones.Visible = !"Valor Actual".Equals(cbAnticipada.SelectedItem.ToString())
                                        && !"Monto".Equals(cbAnticipada.SelectedItem.ToString());
            if (!groupBoxOpciones.Visible)
            {
                if ("Monto".Equals(cbAnticipada.SelectedItem.ToString()))
                    mostrarOpcion(monto);
                else
                    mostrarOpcion(valorActual);
            }
        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
            {
                EnableOptionA();
            }
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonB.Checked)
            {
                EnableOptionB();
            }
        }
    }
}
