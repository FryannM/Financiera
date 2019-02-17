using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Formularios.frmInteresSimple InteresSimple = new Formularios.frmInteresSimple();
            InteresSimple.Show();
        }

        private void BtnDescuentos_Click(object sender, EventArgs e)
        {
            Formularios.frmDescuentos Descuento = new Formularios.frmDescuentos();
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
            Formularios.frmMontoSimple montosimple = new Formularios.frmMontoSimple();
            montosimple.Show();
        }
    }
}
