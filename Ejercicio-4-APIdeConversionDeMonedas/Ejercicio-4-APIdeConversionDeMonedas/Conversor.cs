using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_APIdeConversionDeMonedas
{
    internal class Conversor
    {
        // metodo para convertir DOLARES a SOLES
        public static decimal ConversorMoneda(double CantidadDolares)
        {
            decimal tipoCambio = 3.67M; // el tipo de cambio 1 dolar equivale a 3.67 soles

            return (decimal)CantidadDolares * tipoCambio;
        }

        //metodo para convertir DOLARES a EURO
        public static decimal ConversorMoneda(decimal CantidadDolares)
        {
            decimal tipoCambio = 0.94M; // el tipo de cambio 1 dolar equivale a 0.94 euros
            return CantidadDolares * tipoCambio;
        }

        // metodo para convertir CUALQUIER MONEDA a OTRA
        public static decimal ConversorMoneda(decimal CantidadMoneda, decimal tipoCambio)
        {
            return CantidadMoneda * tipoCambio;
        }
    }
}
