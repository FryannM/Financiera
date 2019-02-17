using Financiera.Services;
using System;
using System.Windows.Forms;

namespace Financiera.Formularios
{
    public partial class frmInteresSimple : Form  {

        private readonly Interface.IInteresSimple _interesSimpleServices;
        private Entidades.InteresSimple entidad { get; set; } = new Entidades.InteresSimple();


        public frmInteresSimple()
        {
           
            InitializeComponent();
        }
        private void frmInteresSimple_Load(object sender, EventArgs e)
        {
        }
        private void EnableText(string cb)
        {

           ;
            switch (cbInteresSimple.SelectedItem.ToString().Trim())
            {

                case "Interes Simple":
                    txtInteres.Enabled = false;
                    txtCapital.Enabled = true;
                    txtTasaInteres.Enabled = true;
                    break;

                case "Capital":
                    txtCapital.Enabled = false;
                    txtTasaInteres.Enabled = true;
                    txtInteres.Enabled = true;
                    break;

                case "Tasa de Interes":
                    txtTasaInteres.Enabled = false;
                    txtCapital.Enabled = true;
                    txtInteres.Enabled = true;
                    break;
            }
        }
        private void cbInteresSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Cb = cbInteresSimple.Text;
            EnableText(Cb);
        }

        private void btnInteres_Click(object sender, EventArgs e)
        {
            int capital = Convert.ToInt32(entidad.Capital = Convert.ToInt32(txtCapital.Text));
            int tasaInteres = Convert.ToInt32(entidad.TasaInteres = Convert.ToInt32(txtTasaInteres.Text));
            int tiempo = Convert.ToInt32(entidad.Tiempo = Convert.ToDecimal(txtTiempo.Text));
       
            var result = DatamanagerServices.CalcularInteres(capital, tasaInteres, tiempo);

            txtResultado.Text = result.ToString();

        }

        private void txtInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatamanagerServices.ValidarSoloNumero(e);
        }

        private void txtCapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatamanagerServices.ValidarSoloNumero(e);
        }
        private void txtTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatamanagerServices.ValidarSoloNumero(e);
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            DatamanagerServices.ValidarSoloNumero(e);
        }
    }
}
