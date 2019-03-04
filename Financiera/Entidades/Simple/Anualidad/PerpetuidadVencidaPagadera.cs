using System;
namespace Financiera.Entidades.Simple.Anualidad
{
    /// <summary>
    /// Provee métodos estáticos para calcular la anualidad con una perpetuidad vencida simple pagadera 
    /// cada "n" períodos de capitalización.
    /// </summary>
    public static class PerpetuidadVencidaPagadera
    {
        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularRenta(decimal valorActual, decimal tasaXPeriodo, decimal totalPeriodos)
        {
            var i = Convert.ToDouble(tasaXPeriodo / 100);
            var a = valorActual;
            var n = Convert.ToDouble(totalPeriodos);
            return a * Convert.ToDecimal(Math.Pow(1 + i, n) - 1);
        }

        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularValorActual(decimal renta, decimal tasaXPeriodo, decimal totalPeriodos)
        {
            var i = Convert.ToDouble(tasaXPeriodo / 100);
            var r = renta;
            var n = Convert.ToDouble(totalPeriodos);
            return r / Convert.ToDecimal(Math.Pow(1 + i, n) - 1);
        }
    }
}
