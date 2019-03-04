using System;

namespace Financiera.Formularios.Simple.frmMontoSimple
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void CleanTexbox()
        {
            txtCapital.Text = string.Empty;
            txtInteres.Text = string.Empty;
            txtMonto.Text = string.Empty;
        }

        private void EnableText()
        {
            panelCampos.Visible = true;

            switch (cbMontoSimple.SelectedItem.ToString().Trim())
            {

                case "Monto":
                    txtMonto.Enabled = false;
                    txtInteres.Enabled = true;
                    txtCapital.Enabled = true;

                    /*btnDescuentoBancario.Visible = true;
                    btnCapital.Visible = false;
                    btnTasaInteres.Visible = false;
                    btnTiempo.Visible = false;*/
                    CleanTexbox();
                    break;

                case "Interes":
                    txtMonto.Enabled = true;
                    txtInteres.Enabled = false;
                    txtCapital.Enabled = true;

                    /*btnInteres.Visible = false;
                    btnCapital.Visible = true;
                    btnTasaInteres.Visible = false;
                    btnTiempo.Visible = false;*/
                    CleanTexbox();
                    break;

                case "Capital":
                    txtMonto.Enabled = true;
                    txtInteres.Enabled = true;
                    txtCapital.Enabled = false;

                    CleanTexbox();
                    break;

            }
        }

        private void cbMontoSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableText();
        }
    }
}
