using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Services
{
    class CalcularServices : Interface.IInteresSimple
    {
        public void CalcularCapital()
        {
            throw new NotImplementedException();
        }

        public int CalcularInteres(int capital, int tasaInteres, int tiempo)
        {
            var Interes = (capital * tasaInteres * tiempo);
            return Interes;
        }

        public void CalcularTiempo()
        {
            throw new NotImplementedException();
        }
    }
}
