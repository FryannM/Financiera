using Financiera.Services;
using System;
using System.Windows.Forms;


namespace Financiera.Formularios
{
    public partial class frmInteresSimple : Form
    {
        public double result = 0;
        public  double capital;
        public double tasaInteres;
        public double tiempo;
        public  double interes;

        private Entidades.InteresSimple entidad { get; set; } = new Entidades.InteresSimple();


        public frmInteresSimple()
        {

            InitializeComponent();
        }
        private void frmInteresSimple_Load(object sender, EventArgs e)
        {
        }
        private void   SelectTasa()
        {
          
            switch (cbTipoTasa.SelectedItem.ToString().Trim())

            {
                case "Mensual":

                    txtTiempo.Text = (double.Parse(txtTiempo.Text) / 1).ToString();
                    break;
                case "Bimestral":
                    txtTiempo.Text = (double.Parse(txtTiempo.Text) / 2).ToString();
                    break;


                case "Trimestral":
                    txtTiempo.Text =  (double.Parse(txtTiempo.Text)/ 3).ToString();
              

                    break;

                case "Cuatrimestral":
                    txtTiempo.Text = (double.Parse(txtTiempo.Text) / 4).ToString();
                    break;

                case "Anual":
                    txtTiempo.Text = (double.Parse(txtTiempo.Text) / 12).ToString();
                    break;
                default:
                    break;
            }

        }

        private void cbTipoTasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTasa();
        }
        private void EnableText(string cb)
        {

          
            switch (cbInteresSimple.SelectedItem.ToString().Trim())
            {

                case "Interes Simple":
                    txtInteres.Enabled = false;
                    txtCapital.Enabled = true;
                    txtTasaInteres.Enabled = true;

                  

                    btnInteres.Visible = true;
                    btnCapital.Visible = false;
                    btnTasaInteres.Visible = false;
                    btnTiempo.Visible = false;
                    CleanTexbox();
                    break;

                case "Capital":
                    txtCapital.Enabled = false;
                    txtInteres.Enabled = true;
                    txtTasaInteres.Enabled = true;


                    txtInteres.Visible = true;
                    btnInteres.Visible = false;
                    btnCapital.Visible = true;
                    btnTasaInteres.Visible = false;
                    btnTiempo.Visible = false;
                    CleanTexbox();
                    break;

                case "Tasa de Interes":
                    txtTasaInteres.Enabled = false;
                    txtCapital.Enabled = true;
                    txtInteres.Enabled = true;

                    btnInteres.Visible = false;
                    btnCapital.Visible = false;
                    btnTasaInteres.Visible = true;
                    btnTiempo.Visible = false;
                    CleanTexbox();
                    break;
            }
        }
        private void cbInteresSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Cb = cbInteresSimple.Text;
            EnableText(Cb);
        }

        private void CleanTexbox()
        {
            txtCapital.Text = string.Empty;
            txtInteres.Text = string.Empty;
            txtResultado.Text = string.Empty;
            txtTiempo.Text = string.Empty;
            txtTasaInteres.Text = string.Empty;
        }

        private void btnInteres_Click(object sender, EventArgs e)
        {
         
            capital = entidad.Capital = Convert.ToDouble(txtCapital.Text);
            tasaInteres = entidad.TasaInteres = Convert.ToDouble(txtTasaInteres.Text);

            tiempo = entidad.Tiempo = Convert.ToDouble(txtTiempo.Text);
            
                result = CalcularServices.CalcularInteres(capital,tasaInteres,tiempo);

            Math.Pow(result, 0);

            txtResultado.Text = result.ToString();

        }

        private void txtInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.util.ValidarSoloNumero(e);
        }

        private void txtCapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.util.ValidarSoloNumero(e);
        }
        private void txtTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.util.ValidarSoloNumero(e);
        }
        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  util.util.ValidarSoloNumero(e);
        }

        private void btnCapital_Click(object sender, EventArgs e)
        {
            interes = entidad.Interes = Convert.ToDouble(txtInteres.Text);
            tasaInteres = entidad.TasaInteres = Convert.ToDouble(txtTasaInteres.Text);
            tiempo = entidad.Tiempo = Convert.ToDouble(txtTiempo.Text);
            result = CalcularServices.CalcularCapital(interes, tasaInteres, tiempo);

            Math.Pow(result, 0);

            txtResultado.Text = result.ToString();
        }
    }
}
