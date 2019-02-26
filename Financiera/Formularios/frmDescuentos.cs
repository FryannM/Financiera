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
        private decimal sumaSolicitada;
        private decimal tasaDescuento;
        private decimal tiempo;
        private decimal descuento;

        public frmDescuentos()
        {
            InitializeComponent();
        }

        private bool hayCamposVacios(NumericUpDown txt)
        {
            return false;
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
            panelResultado.Visible = false;
            switch (cbDescuentoSimple.SelectedItem.ToString().Trim())
            {

                case "Descuento Bancario":
                    txtDescuentoBancario.Enabled = false;
                    txtSumaSolicitada.Enabled = true;
                    txtTasaDescuento.Enabled = true;
                    // cbTipoTasa.Enabled = true;
                    txtTiempo.Enabled = true;

                    btnDescuento.Visible = true;
                    btnSumaSolicitada.Visible = false;
                    btnTasaDescuento.Visible = false;
                    btnTiempo.Visible = false;
                    CleanTexbox();
                    break;

                case "Suma Solicitada":
                    txtSumaSolicitada.Enabled = false;
                    txtDescuentoBancario.Enabled = true;
                    txtTasaDescuento.Enabled = true;
                    // cbTipoTasa.Enabled = true;
                    txtTiempo.Enabled = true;

                    btnDescuento.Visible = false;
                    btnSumaSolicitada.Visible = true;
                    btnTasaDescuento.Visible = false;
                    btnTiempo.Visible = false;
                    CleanTexbox();
                    break;

                case "Tasa de Descuento":
                    txtTasaDescuento.Enabled = false;
                    // cbTipoTasa.Enabled = false;
                    txtSumaSolicitada.Enabled = true;
                    txtDescuentoBancario.Enabled = true;
                    txtTiempo.Enabled = true;

                    btnDescuento.Visible = false;
                    btnSumaSolicitada.Visible = false;
                    btnTasaDescuento.Visible = true;
                    btnTiempo.Visible = false;
                    CleanTexbox();
                    break;


                case "Tiempo":
                    txtTiempo.Enabled = false;
                    txtDescuentoBancario.Enabled = true;
                    txtSumaSolicitada.Enabled = true;
                    txtTasaDescuento.Enabled = true;
                    // cbTipoTasa.Enabled = true;

                    btnDescuento.Visible = false;
                    btnSumaSolicitada.Visible = false;
                    btnTasaDescuento.Visible = false;
                    btnTiempo.Visible = true;
                    CleanTexbox();
                    break;
            }
        }


        private void cbDescuentoSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableText();
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            tasaDescuento = txtTasaDescuento.Value;
            tiempo = txtTiempo.Value;
            sumaSolicitada = txtSumaSolicitada.Value;
            txtResultado.Value = Entidades.DescuentoSimple.CalcularDescuento(sumaSolicitada, tasaDescuento, tiempo);
            panelResultado.Visible = true;
        }

        private void btnTasaDescuento_Click(object sender, EventArgs e)
        {
            descuento = txtDescuentoBancario.Value;
            tiempo = txtTiempo.Value;
            sumaSolicitada = txtSumaSolicitada.Value;
            txtResultado.Value = 100 * Entidades.DescuentoSimple.CalcularTasaDescuento(descuento, sumaSolicitada, tiempo);
            panelResultado.Visible = true;

        }

        private void btnSumaSolicitada_Click(object sender, EventArgs e)
        {
            descuento = txtDescuentoBancario.Value;
            tiempo = txtTiempo.Value;
            tasaDescuento = txtTasaDescuento.Value;
            txtResultado.Value = Entidades.DescuentoSimple.CalcularSumaSolicitada(descuento, tasaDescuento, tiempo);
            panelResultado.Visible = true;
        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {
            descuento = txtDescuentoBancario.Value;
            sumaSolicitada = txtSumaSolicitada.Value;
            tasaDescuento = txtTasaDescuento.Value;
            txtResultado.Value = Entidades.DescuentoSimple.CalcularTiempo(descuento, sumaSolicitada, tasaDescuento);
            panelResultado.Visible = true;

        }
    }
}
