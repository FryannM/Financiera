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
        public static double CalcularTasaInteres(double interes, double capital, double tiempo)
        {
            var CapitalxTiempo = capital * tiempo;
            var Tinteres = (interes /CapitalxTiempo);
            return Tinteres;
        }

        public static double CalcularTiempo(double interes, double capital, double tasainteres)
        {
            var CapitalxTasaInteres = capital * tasainteres;
            var Tinteres = (interes / CapitalxTasaInteres);
            return Tinteres;
        }
    }
}
