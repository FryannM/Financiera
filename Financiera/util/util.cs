using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiera.util
{
   public static  class util
    {
        public static void ValidarSoloNumero(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


        }

         public   static string  ValidarCampoVacio(string Name)
        { 
             if (string.IsNullOrEmpty(Name))
            {
                  MessageBox.Show("No Pueden Haber Campo Vacio");
            }

            return "No Pueden Haber Campo Vacio";
        }
    }
}
