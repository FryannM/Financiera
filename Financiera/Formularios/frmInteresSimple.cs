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
    public partial class frmInteresSimple : Form

    {
        private readonly Interface.IInteresSimple _interesSimple;
        public frmInteresSimple( Interface.IInteresSimple  interesSimple)
        {

             
            InitializeComponent();
            this._interesSimple = interesSimple;
        }
        private void frmInteresSimple_Load(object sender, EventArgs e)
        {
        }
        private void EnableText(string cb)
        {
         
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
    }
}
