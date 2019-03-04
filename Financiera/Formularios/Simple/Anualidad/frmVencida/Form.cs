using System;
using System.Windows.Forms;

namespace Financiera.Formularios.Simple.Anualidad.frmVencida
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Controles de usuario.
        private static Monto monto;
        private static ValorActual valorActual;
        private static Inicial inicial;
        private static PrecioContado precioContado;
        private static A.Renta renta_A;
        private static A.TotalPeriodos totalPeriodos_A;
        private static A.InteresTotal interesTotal_A;
        private static B.Renta renta_B;
        private static B.TotalPeriodos totalPeriodos_B;
        private static B.InteresTotal interesTotal_B;


        /// <summary>Método auxiliar para resetear opciones.</summary>
        private static void crearControles()
        {
            monto = new Monto();
            valorActual = new ValorActual();
            inicial = new Inicial();
            precioContado = new PrecioContado();
            renta_A = new A.Renta();
            renta_B = new B.Renta();
            totalPeriodos_A = new A.TotalPeriodos();
            totalPeriodos_B = new B.TotalPeriodos();
            interesTotal_A = new A.InteresTotal();
            interesTotal_B = new B.InteresTotal();
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
            switch (cbVencida.SelectedItem.ToString())
            {
                case "Renta":
                    mostrarOpcion(renta_A);
                    break;

                case "Total Períodos":
                    mostrarOpcion(totalPeriodos_A);
                    break;

                case "Interés Total":
                    mostrarOpcion(interesTotal_A);
                    break;
            }

        }

        private void EnableOptionB()
        {
            switch (cbVencida.SelectedItem.ToString())
            {
                case "Renta":
                    mostrarOpcion(renta_B);
                    break;

                case "Total Períodos":
                    mostrarOpcion(totalPeriodos_B);
                    break;

                case "Interés Total":
                    mostrarOpcion(interesTotal_B);
                    break;

            }
        }

        private void cbVencida_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelResultante.Controls.Clear();
            resetearOpciones();
            string opcion = cbVencida.SelectedItem.ToString();
            groupBoxOpciones.Visible = "Total Períodos".Equals(opcion)
                                        || "Interés Total".Equals(opcion)
                                        || "Renta".Equals(opcion);

            if (!groupBoxOpciones.Visible)
            {
                switch (opcion)
                {
                    case "Inicial":
                        mostrarOpcion(inicial);
                        break;
                    case "Monto":
                        mostrarOpcion(monto);
                        break;
                    case "Precio Contado":
                        mostrarOpcion(precioContado);
                        break;
                    case "Valor Actual":
                        mostrarOpcion(valorActual);
                        break;
                }
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
