using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Interface
{
  public   interface IInteresSimple
    {



        int CalcularInteres(int capital,int tasaInteres,int tiempo);
        void CalcularCapital();
        void CalcularTiempo();
    }
}
