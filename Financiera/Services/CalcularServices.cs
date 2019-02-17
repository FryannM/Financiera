using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiera.Services
{
   public  static class CalcularServices 
    {
        

        public static  double CalcularInteres(double capital, double tasaInteres, double tiempo)
        {
            var Interes = (capital * tasaInteres/100 * tiempo);
            return Interes;
        }

        public static double CalcularCapital(double interes, double tasainteres, double tiempo)
        {
            //P =  I/it
            var Capital = (interes / tasainteres * tiempo);
            return Capital;
        }

    }
}
