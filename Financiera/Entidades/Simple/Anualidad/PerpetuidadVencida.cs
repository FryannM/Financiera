namespace Financiera.Entidades.Simple.Anualidad
{
    /// <summary>Provee métodos estáticos para calcular la anualidad con una perpetuidad vencida simple.</summary>
    public static class PerpetuidadVencida
    {
        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularRenta(decimal valorActual, decimal tasaXPeriodo)
        {
            tasaXPeriodo = tasaXPeriodo / 100;
            return valorActual * tasaXPeriodo;
        }

        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularValorActual(decimal renta, decimal tasaXPeriodo)
        {
            tasaXPeriodo = tasaXPeriodo / 100;
            return renta / tasaXPeriodo;
        }

        /// <returns>Tasa expresada en %</returns>
        public static decimal CalcularTasa(decimal valorActual, decimal renta) 
            => renta / valorActual * 100;
    }
}
