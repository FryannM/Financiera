using System;
using System.Collections.Generic;
using System.Linq;

namespace Financiera.Entidades.Compuesto
{
    /// <summary>Provee métodos estáticos para hacer cálculos de interés compuesto en el formulario.</summary>
    public static class Interes
    {

        /// <summary> Provee métodos estáticos para hacer cálculos de equivalencia con otra tasa de interés compuesto. </summary>
        public static class EquivalenciaCompuesta
        {
            /// <returns>Tasa nominal expresada en porcentaje.</returns>
            public static decimal CalcularTasaNominal(IReadOnlyDictionary<decimal, Frecuencia> tasaCompuesta, Frecuencia frecuencia)
            {
                var m1 = Convert.ToDouble(frecuencia);
                var j2 = Convert.ToDouble(tasaCompuesta.Keys.First());
                var m2 = Convert.ToDouble(tasaCompuesta.Values.First());
                return Convert.ToDecimal(m1 * (Math.Pow(1 + j2/m2, m2/m1) - 1) ) * 100; // m1[(1+j2/m2)^(m2/m1) - 1]
            }

            /// <returns>Tasa efectiva expresada en porcentaje.</returns>
            public static decimal CalcularTasaEfectiva(decimal tasaNominal, Frecuencia frecuencia)
            {
                var j2 = Convert.ToDouble(tasaNominal);
                var m2 = Convert.ToDouble(frecuencia);
                return Convert.ToDecimal(Math.Pow(1 + j2/m2, m2) - 1 ) * 100; // (1 + j2/m2)^m2 - 1
            }
        }

        /// <summary> Provee métodos estáticos para hacer cálculos de equivalencia con una tasa de interés simple. </summary>
        public static class EquivalenciaSimple
        {
            /// <returns>Tasa simple expresada en porcentaje.</returns>
            public static decimal CalcularTasaSimple(decimal tiempo, decimal tasa, decimal totalPeriodos)
            {
                var t = Convert.ToDouble(tiempo);
                var i = Convert.ToDouble(tasa);
                var n = Convert.ToDouble(totalPeriodos);

                return Convert.ToDecimal((Math.Pow(1 + i, n) - 1) / t) * 100; // [(1 + i)^n - 1]/t
            }

            /// <returns>Tasa nominal expresada en porcentaje.</returns>
            public static decimal CalcularTasaNominal(decimal tasa, decimal tiempo, Frecuencia frecuencia, decimal totalPeriodos)
            {
                var t = Convert.ToDouble(tiempo);
                var i = Convert.ToDouble(tasa);
                var m = Convert.ToDecimal(frecuencia);
                var n = Convert.ToDouble(totalPeriodos);

                return m * Convert.ToDecimal(Math.Pow(1 + i * t, 1/n) - 1) * 100; // m[(1 + it)^(1/n) - 1]
            }
        }

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
            => Convert.ToDecimal(periodo) * CalcularTasaXPeriodo(monto, capital, totalPeriodos);

        /// <returns>Tasa de interés por período expresada en porcentaje.</returns>
        public static decimal CalcularTasaXPeriodo(decimal monto, decimal capital, decimal totalPeriodos) 
            => Convert.ToDecimal(Math.Pow(Convert.ToDouble(monto / capital), Convert.ToDouble(1 / totalPeriodos)) - 1) * 100;

        /// <returns>Tasa de interés por período expresada en porcentaje.</returns>
        public static decimal CalcularTasaXPeriodo(Frecuencia periodo, decimal tasaNominal)
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
