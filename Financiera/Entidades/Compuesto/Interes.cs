using System;

namespace Financiera.Entidades.Compuesto
{
    /// <summary>
    /// Provee métodos estáticos para hacer cálculos de interés compuesto en el formulario.
    /// </summary>

    public static class Interes
    {
        public enum Frecuencia : ushort
        {
            Anual = 1, Semestral = 2, Cuatrimestral = 3, Trimestral = 4, Bimestral = 6,
            Mensual = 12, Quincenal = 24, Semanal = 52, Diaria = 360
        }

        /// <returns>Tiempo expresado en años.</returns>
        public static decimal CalcularTiempo(decimal frecuencia, decimal totalPeriodos) 
            => totalPeriodos / frecuencia;
        
        public static decimal CalcularTotalPeriodos(decimal tiempo, decimal periodo)
            => tiempo * periodo;

        public static decimal CalcularTotalPeriodos(decimal monto, decimal capital, decimal tasaEfectiva)
            => Convert.ToDecimal(Math.Log10(Convert.ToDouble(monto / capital)) / Math.Log10(Convert.ToDouble(1 + tasaEfectiva/100)));

        /// <returns>Tasa nominal expresada en porcentaje.</returns>
        public static decimal CalcularTasaNominal(Frecuencia periodo, decimal tasaEfectiva)
            => Convert.ToDecimal(periodo) * tasaEfectiva;

        /// <returns>Tasa nominal expresada en porcentaje.</returns>
        public static decimal CalcularTasaNominal(Frecuencia periodo, decimal monto, decimal capital, decimal totalPeriodos)
            => Convert.ToDecimal(periodo) * CalcularTasaEfectiva(monto, capital, totalPeriodos);

        /// <returns>Tasa efectiva expresada en porcentaje.</returns>
        public static decimal CalcularTasaEfectiva(decimal monto, decimal capital, decimal totalPeriodos) 
            => Convert.ToDecimal(Math.Pow(Convert.ToDouble(monto / capital), Convert.ToDouble(1 / totalPeriodos)) - 1) * 100;

        /// <returns>Tasa efectiva expresada en porcentaje.</returns>
        public static decimal CalcularTasaEfectiva(Frecuencia periodo, decimal tasaNominal)
            => tasaNominal / Convert.ToDecimal(periodo);

        public static decimal CalcularInteres(decimal monto, decimal capital) 
            => monto - capital;

        public static decimal CalcularInteres(decimal capital, decimal tasaEfectiva, decimal totalPeriodos)
            => capital * (
            Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + tasaEfectiva/100), Convert.ToDouble(totalPeriodos))) - 1
            );

        public static decimal CalcularMonto(decimal capital, decimal interes)
            => capital + interes;

        public static decimal CalcularMonto(decimal capital, decimal tasaEfectiva, decimal totalPeriodos)
            => capital *
            Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + tasaEfectiva / 100), Convert.ToDouble(totalPeriodos)));

        public static decimal CalcularCapital(decimal monto, decimal interes)
            => monto - interes;

        public static decimal CalcularCapitalPorInteres(decimal interes, decimal tasaEfectiva, decimal totalPeriodos)
            => interes / (
            Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + tasaEfectiva / 100), Convert.ToDouble(totalPeriodos))) - 1
            );

        public static decimal CalcularCapitalPorMonto(decimal monto, decimal tasaEfectiva, decimal totalPeriodos)
            => monto /
            Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + tasaEfectiva / 100), Convert.ToDouble(totalPeriodos)));

    }
}
