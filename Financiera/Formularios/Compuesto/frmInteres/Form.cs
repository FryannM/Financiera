using System;
using System.Windows.Forms;

namespace Financiera.Formularios.Compuesto.Interes
{
    public partial class View : Form
    {
        // Controles de usuario.
        private static Capital_A capital_A;
        private static Capital_B capital_B;
        private static Capital_C capital_C;
        private static Monto_A monto_A;
        private static Monto_B monto_B;
        private static Interes_A interes_A;
        private static Interes_B interes_B;
        private static TasaEfectiva_A tasaEfectiva_A;
        private static TasaEfectiva_B tasaEfectiva_B;
        private static TasaNominal_A tasaNominal_A;
        private static TasaNominal_B tasaNominal_B;
        private static TotalPeriodos_A totalPeriodos_A;
        private static TotalPeriodos_B totalPeriodos_B;
        private static Tiempo tiempo;

        // Método auxiliar para resetear opciones
        private static void crearControles()
        {
            capital_A = new Capital_A();
            capital_B = new Capital_B();
            capital_C = new Capital_C();
            monto_A = new Monto_A();
            monto_B = new Monto_B();
            interes_A = new Interes_A();
            interes_B = new Interes_B();
            tasaEfectiva_A = new TasaEfectiva_A();
            tasaEfectiva_B = new TasaEfectiva_B();
            tasaNominal_A = new TasaNominal_A();
            tasaNominal_B = new TasaNominal_B();
            totalPeriodos_A = new TotalPeriodos_A();
            totalPeriodos_B = new TotalPeriodos_B();
            tiempo = new Tiempo();
        }

        public void resetearOpciones()
        {
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonB.Enabled = !cbInteresCompuesto.SelectedIndex.Equals(cbInteresCompuesto.Items.IndexOf("Tiempo"));
            radioButtonC.Checked = false;
            radioButtonC.Enabled = cbInteresCompuesto.SelectedIndex.Equals(cbInteresCompuesto.Items.IndexOf("Capital"));
            crearControles();
        }

        public View()
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
            switch (cbInteresCompuesto.SelectedItem.ToString())
            {
                case "Capital":
                    mostrarOpcion(capital_A);
                    break;

                case "Interés":
                    mostrarOpcion(interes_A);
                    break;

                case "Monto":
                    mostrarOpcion(monto_A);
                    break;

                case "Tasa de interés por período":
                    mostrarOpcion(tasaEfectiva_A);
                    break;

                case "Tasa nominal":
                    mostrarOpcion(tasaNominal_A);
                    break;

                case "Número total de períodos":
                    mostrarOpcion(totalPeriodos_A);
                    break;

                case "Tiempo":
                    mostrarOpcion(tiempo);
                    break;

            }

        }

        private void EnableOptionB()
        {
            switch (cbInteresCompuesto.SelectedItem.ToString())
            {

                case "Capital":
                    mostrarOpcion(capital_B);
                    break;

                case "Interés":
                    mostrarOpcion(interes_B);
                    break;

                case "Monto":
                    mostrarOpcion(monto_B);
                    break;

                case "Tasa de interés por período":
                    mostrarOpcion(tasaEfectiva_B);
                    break;

                case "Tasa nominal":
                    mostrarOpcion(tasaNominal_B);
                    break;

                case "Número total de períodos":
                    mostrarOpcion(totalPeriodos_B);
                    break;

            }

        }

        private void EnableOptionC()
        {
            mostrarOpcion(capital_C);
        }

        private void cbInteresCompuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelResultante.Controls.Clear();
            resetearOpciones();
            groupBoxOpciones.Visible = true;
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

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonC.Checked)
            {
                EnableOptionC();

            }
        }
    }
}
