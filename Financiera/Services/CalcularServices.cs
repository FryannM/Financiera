namespace Financiera.Services
{
    public static class CalcularServices
    {

        public static double CalcularInteres(double capital, double tasaInteres, double tiempo)
        {
            var Interes = (capital * tasaInteres / 100 * tiempo);
            return Interes;
        }

        public static double CalcularCapital(double interes, double tasainteres, double tiempo)
        {
            var cap = (tasainteres / 100) * (tiempo);
            var capital = interes / cap;
            return capital;
        }

    }
}
