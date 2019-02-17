using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Interface
{
    public  interface IInteresSimple
    {
        int CalcularInteres(int capital,int tasaInteres,int tiempo);
        int CalcularCapital(int interes,int tasaInteres,int tiempo);
        int CalcularTiempo(int  interes,int capital, int tasaInteres);
    }
}
