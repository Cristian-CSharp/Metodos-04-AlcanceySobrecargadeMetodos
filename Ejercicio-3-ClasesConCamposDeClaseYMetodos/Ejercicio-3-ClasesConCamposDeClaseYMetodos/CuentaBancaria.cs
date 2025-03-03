using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_ClasesConCamposDeClaseYMetodos
{
    internal class CuentaBancaria
    {
        // Campo privado para almacenar el saldo
        private double saldo;

        // Constructor que inicializa el saldo con el ahorro inicial
        public CuentaBancaria(double ahorro)
        {
            saldo = ahorro; // Inicializamos el saldo correctamente
        }

        // Método para depositar dinero
        public double Depositar(double deposito)
        {
            saldo += deposito; // Se suma al saldo actual
            return saldo;
        }

        // Método para retirar una cantidad específica
        public double Retirar(double cantidad)
        {
            if (cantidad > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                return saldo;
            }

            saldo -= cantidad;
            return saldo;
        }

        // Método para consultar el saldo
        public double ObtenerSaldo()
        {
            return saldo;
        }
    }

}
