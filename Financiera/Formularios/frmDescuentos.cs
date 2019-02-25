using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiera.Formularios
{
    public partial class frmDescuentos : Form
    {
        public frmDescuentos()
        {
            InitializeComponent();
        }

        private void CleanTexbox()
        {
            txtSumaSolicitada.Text = string.Empty;
            txtDescuentoBancario.Text = string.Empty;
            txtTiempo.Text = string.Empty;
            txtTasaDescuento.Text = string.Empty;

        }


        private void EnableText()
        {
            panelCampos.Visible = true;

            switch (cbDescuentoSimple.SelectedItem.ToString().Trim())
            {

                case "Descuento Bancario":
                    txtDescuentoBancario.Enabled = false;
                    txtSumaSolicitada.Enabled = true;
                    txtTasaDescuento.Enabled = true;
                    // cbTipoTasa.Enabled = true;
                    txtTiempo.Enabled = true;

                    /*btnDescuentoBancario.Visible = true;
                    btnCapital.Visible = false;
                    btnTasaInteres.Visible = false;
                    btnTiempo.Visible = false;*/
                    CleanTexbox();
                    break;

                case "Suma Solicitada":
                    txtSumaSolicitada.Enabled = false;
                    txtDescuentoBancario.Enabled = true;
                    txtTasaDescuento.Enabled = true;
                    // cbTipoTasa.Enabled = true;
                    txtTiempo.Enabled = true;

                    /*txtInteres.Visible = true;
                    btnInteres.Visible = false;
                    btnCapital.Visible = true;
                    btnTasaInteres.Visible = false;
                    btnTiempo.Visible = false;*/
                    CleanTexbox();
                    break;

                case "Tasa de Descuento":
                    txtTasaDescuento.Enabled = false;
                    // cbTipoTasa.Enabled = false;
                    txtSumaSolicitada.Enabled = true;
                    txtDescuentoBancario.Enabled = true;
                    txtTiempo.Enabled = true;

                    /*btnInteres.Visible = false;
                    btnCapital.Visible = false;
                    btnTasaInteres.Visible = true;
                    btnTiempo.Visible = false;*/
                    CleanTexbox();
                    break;


                case "Tiempo":
                    txtTiempo.Enabled = false;
                    txtDescuentoBancario.Enabled = true;
                    txtSumaSolicitada.Enabled = true;
                    txtTasaDescuento.Enabled = true;
                    // cbTipoTasa.Enabled = true;

                    /*btnInteres.Visible = false;
                    btnCapital.Visible = false;
                    btnTasaInteres.Visible = false;
                    btnTiempo.Visible = true;*/
                    CleanTexbox();
                    break;
            }
        }


        private void cbDescuentoSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableText();
        }
    }
}
