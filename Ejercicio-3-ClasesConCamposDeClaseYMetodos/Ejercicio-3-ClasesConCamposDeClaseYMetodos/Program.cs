using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_ClasesConCamposDeClaseYMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una cuenta con 100 de saldo inicial
            CuentaBancaria cuentaPersonal = new CuentaBancaria(100);


            // Depositar 50
            Console.WriteLine("Saldo después de depositar: " + cuentaPersonal.Depositar(50));

            // Retirar 30
            Console.WriteLine("Saldo después de retirar 30: " + cuentaPersonal.Retirar(30));

            // Consultar saldo sin retirar todo
            Console.WriteLine("Saldo actual: " + cuentaPersonal.ObtenerSaldo());

            // Intentar retirar más de lo que hay en el saldo
            Console.WriteLine("Intentando retirar 200: " + cuentaPersonal.Retirar(200));
        }
    }
}
