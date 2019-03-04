using System;

namespace Financiera.Entidades.Simple.Anualidad
{
    /// <summary>Provee métodos estáticos para hacer cálculos de anualidad anticipada simple en el formulario.</summary>
    public static class Anticipada
    {
        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularMonto(decimal renta, decimal tasaXPeriodo, decimal totalPeriodos)
        {
            var i = Convert.ToDouble(tasaXPeriodo) / 100;
            var n = Convert.ToDouble(totalPeriodos);
            var r = renta;
            return r * Convert.ToDecimal((Math.Pow(1 + i, n + 1) - i - 1) / i); // R[(1 + i)^(n+1) - i - 1]/i
        }

        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularValorActual(decimal renta, decimal tasaXPeriodo, decimal totalPeriodos)
        {
            var i = Convert.ToDouble(tasaXPeriodo) / 100;
            var n = Convert.ToDouble(totalPeriodos);
            var r = renta;
            return r * Convert.ToDecimal((1 + i - Math.Pow(1 + i, -n + 1)) / i); // R[i + 1 - (1 + i)^(-n+1)]/i
        }

        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularRentaXMonto(decimal monto, decimal tasaXPeriodo, decimal totalPeriodos)
        {
            var i = Convert.ToDouble(tasaXPeriodo) / 100;
            var n = Convert.ToDouble(totalPeriodos);
            var s = monto;
            return s * Convert.ToDecimal(i / (Math.Pow(1 + i, n + 1) - i - 1)); // s * i/[(1 + i)^(n+1) - I - 1]
        }

        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularRentaXValorActual(decimal valorActual, decimal tasaXPeriodo, decimal totalPeriodos)
        {
            var i = Convert.ToDouble(tasaXPeriodo) / 100;
            var n = Convert.ToDouble(totalPeriodos);
            var a = valorActual;
            return a * Convert.ToDecimal(i / (1 + i - Math.Pow(1 + i, -n + 1))); // a * i/[1 - (1 + i)^-n]
        }

        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularPeriodosXMonto(decimal monto, decimal renta, decimal tasaXPeriodo)
        {
            var s = Convert.ToDouble(monto);
            var r = Convert.ToDouble(renta);
            var i = Convert.ToDouble(tasaXPeriodo) / 100;
            return Convert.ToDecimal(Math.Log10(s / r * i + i + 1) / Math.Log10(1 + i) - 1);
        }

        /// <param name="tasaXPeriodo">Tasa expresada en %</param>
        public static decimal CalcularPeriodosXValorActual(decimal valorActual, decimal renta, decimal tasaXPeriodo)
        {
            var a = Convert.ToDouble(valorActual);
            var r = Convert.ToDouble(renta);
            var i = Convert.ToDouble(tasaXPeriodo) / 100;
            return Convert.ToDecimal(1 - Math.Log10(i + 1 - a / r * i) / Math.Log10(1 + i));
        }

    }
}
