using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Entidades
{
    /// <summary>
    /// Construyo esta clase estática para almacenar los métodos estáticos que utilizaré para hacer cálculos en el formulario
    /// descuentos.
    /// </summary>
    public static class DescuentoSimple
    {
        public static decimal CalcularDescuento(decimal sumaSolicitada, decimal tasaDescuento, decimal tiempo)
        {
            var descuento = (sumaSolicitada * tasaDescuento / 100 * tiempo);
            return descuento;
        }

        public static decimal CalcularSumaSolicitada(decimal descuento, decimal tasaDescuento, decimal tiempo)
        {
            var tasaDescuentoxTiempo = (tasaDescuento / 100) * (tiempo);
            var sumaSolicitada = descuento / tasaDescuentoxTiempo;
            return sumaSolicitada;
        }


        public static decimal CalcularTasaDescuento(decimal descuento, decimal sumaSolicitada, decimal tiempo)
        {
            var sumaSolicitadaxTiempo = sumaSolicitada * tiempo;
            var Tdescuento = (descuento / sumaSolicitadaxTiempo);
            return Tdescuento;
        }

        public static decimal CalcularTiempo(decimal descuento, decimal sumaSolicitada, decimal tasaDescuento)
        {
            var sumaSolicitadaxTasaInteres = sumaSolicitada * tasaDescuento;
            var Tinteres = (descuento / sumaSolicitadaxTasaInteres);
            return Tinteres;
        }

    }
}
