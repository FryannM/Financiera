using System;

namespace Financiera.Entidades.Simple.Anualidad
{
    /// <summary>Provee métodos estáticos para hacer cálculos de anualidad vencida simple en el formulario.</summary>
    public static class Vencida
    {
        /// <param name="tasaPeriodica">Tasa expresada en %</param>
        public static decimal CalcularMonto(decimal renta, decimal tasaPeriodica, decimal totalPeriodos)
        {
            var i = Convert.ToDouble(tasaPeriodica) / 100;
            var n = Convert.ToDouble(totalPeriodos);
            var r = renta;
            return r * Convert.ToDecimal((Math.Pow(1 + i, n) - 1) / i); // R[(1 + i)^n - 1]/i
        }

        /// <param name="tasaPeriodica">Tasa expresada en %</param>
        public static decimal CalcularValorActual(decimal renta, decimal tasaPeriodica, decimal totalPeriodos)
        {
            var i = Convert.ToDouble(tasaPeriodica) / 100;
            var n = Convert.ToDouble(totalPeriodos);
            var r = renta;
            return r * Convert.ToDecimal((1 - Math.Pow(1 + i, -n)) / i); // R[1 - (1 + i)^-n]/i
        }

        public static decimal CalcularInicial(decimal precioContado, decimal valorActual)
        {
            return precioContado - valorActual;
        }

        public static decimal CalcularPrecioContado(decimal inicial, decimal valorActual)
        {
            return inicial + valorActual;
        }

        public static decimal CalcularInteresTotalXMonto(decimal monto, decimal totalPeriodos, decimal renta)
        {
            return monto - totalPeriodos * renta;
        }

        public static decimal CalcularInteresTotalXValorActual(decimal totalPeriodos, decimal renta, decimal valorActual)
        {
            return totalPeriodos * renta - valorActual;
        }

        /// <param name="tasaPeriodica">Tasa expresada en %</param>
        public static decimal CalcularRentaXMonto(decimal monto, decimal tasaPeriodica, decimal totalPeriodos)
        {
            var i = Convert.ToDouble(tasaPeriodica) / 100;
            var n = Convert.ToDouble(totalPeriodos);
            var s = monto;
            return s * Convert.ToDecimal(i / (Math.Pow(1 + i, n) - 1)); // s * i/[(1 + i)^n - 1]
        }

        /// <param name="tasaPeriodica">Tasa expresada en %</param>
        public static decimal CalcularRentaXValorActual(decimal valorActual, decimal tasaPeriodica, decimal totalPeriodos)
        {
            var i = Convert.ToDouble(tasaPeriodica) / 100;
            var n = Convert.ToDouble(totalPeriodos);
            var a = valorActual;
            return a * Convert.ToDecimal(i / (1 - Math.Pow(1 + i, -n))); // a * i/[1 - (1 + i)^-n]
        }

        public static decimal CalcularPeriodosXMonto(decimal monto, decimal renta, decimal tasaPeriodica)
        {
            var s = Convert.ToDouble(monto);
            var r = Convert.ToDouble(renta);
            var i = Convert.ToDouble(tasaPeriodica) / 100;
            return Convert.ToDecimal(Math.Log10(s / r * i + 1) / Math.Log10(1 + i));
        }

        public static decimal CalcularPeriodosXValorActual(decimal valorActual, decimal renta, decimal tasaPeriodica)
        {
            var a = Convert.ToDouble(valorActual);
            var r = Convert.ToDouble(renta);
            var i = Convert.ToDouble(tasaPeriodica) / 100;
            return Convert.ToDecimal(-Math.Log10(1 - a / r * i) / Math.Log10(1 + i));
        }

    }
}
