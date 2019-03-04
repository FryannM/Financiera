namespace Financiera.Entidades.Simple.Anualidad
{
    /// <summary>Provee métodos estáticos para hacer cálculos de anualidad con perpetuidad anticipada simple. </summary>
    public static class PerpetuidadAnticipada
    {
        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularValorActual(decimal renta, decimal tasaXPeriodo)
        {
            tasaXPeriodo = tasaXPeriodo / 100;
            return renta + renta / tasaXPeriodo;
        }

        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularValorActual(decimal renta, decimal tasaXPeriodo, decimal primerPagoPerpetuo)
        {
            tasaXPeriodo = tasaXPeriodo / 100;
            return primerPagoPerpetuo + renta / tasaXPeriodo;
        }

        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularRenta(decimal valorActual, decimal tasaXPeriodo)
        {
            tasaXPeriodo = tasaXPeriodo / 100;
            return valorActual * tasaXPeriodo/(1 + tasaXPeriodo);
        }

        /// <returns>Tasa expresada en %</returns>
        public static decimal CalcularTasa(decimal valorActual, decimal renta)
        {
            return renta / (valorActual - renta) * 100;
        }
    }
}
