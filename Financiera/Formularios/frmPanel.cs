using System;
using System.Windows.Forms;

namespace Financiera
{
    public partial class frmPanel : Form
    {
        public frmPanel()
        {
            InitializeComponent();
        }
       
        private void BtnInteresSimple_Click(object sender, EventArgs e)
        {
            var InteresSimple = new Formularios.Simple.frmInteres.Form();
            InteresSimple.Show();
        }

        private void BtnDescuentos_Click(object sender, EventArgs e)
        {
            var Descuento = new Formularios.Simple.frmDescuentoBancario.Form();
            Descuento.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta Seguro que desea salir ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnMontoSimple_Click(object sender, EventArgs e)
        {
            var montosimple = new Formularios.Simple.frmMontoSimple.Form();
            montosimple.Show();
        }

        private void btnInteresCompuesto_Click(object sender, EventArgs e)
        {
            var interesCompuesto = new Formularios.Simple.frmInteres.Form();
            interesCompuesto.Show();
        }


        private void btnPerpetuidadVencida_Click(object sender, EventArgs e)
        {
            var perpetuidadVencida = new Formularios.Simple.Anualidad.frmPerpetuidadVencida.Form();
            perpetuidadVencida.Show();
        }

        private void btnPerpetuidadVencidaPagadera_Click(object sender, EventArgs e)
        {
            var perpetuidadVencidaPagadera = new Formularios.Simple.Anualidad.frmPerpetuidadVencidaPagadera.Form();
            perpetuidadVencidaPagadera.Show();
        }

        private void btnPerpetualidadAnticipada_Click(object sender, EventArgs e)
        {
            var perpetuidadAnticipada = new Formularios.Simple.Anualidad.frmPerpetuidadAnticipada.Form();
            perpetuidadAnticipada.Show();
        }

        private void btnAnticipada_Click(object sender, EventArgs e)
        {
            var anticipada = new Formularios.Simple.Anualidad.frmAnticipada.Form();
            anticipada.Show();
        }
        
        private void btnVencida_Click(object sender, EventArgs e)
        {
            var vencida = new Formularios.Simple.Anualidad.frmVencida.Form();
            vencida.Show();
        }
    }
}
