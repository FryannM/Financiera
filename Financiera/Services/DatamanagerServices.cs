using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiera.Services
{
   public  static class DatamanagerServices 
    {
        

        public static  int CalcularInteres(int capital, int tasaInteres, int tiempo)
        {
            var Interes = (capital * tasaInteres * tiempo);
            return Interes;
        }

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


        

    }
}
