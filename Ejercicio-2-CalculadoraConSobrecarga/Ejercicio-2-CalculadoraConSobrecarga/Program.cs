using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_CalculadoraConSobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // aqui se llaman a todos los metodos y se mandan a imprimir
            Console.WriteLine(Calculadora.sumar(5, 7)); // suma de dos enteros 
            Console.WriteLine(Calculadora.sumar(5, 7, 10)); // suma de tres enteros
            Console.WriteLine(Calculadora.sumar(2.5, 6.2)); // suma de dos decimales
            Console.WriteLine(Calculadora.multiplicar(3, 7)); // multiplicar dos enteros
            Console.WriteLine(Calculadora.multiplicar(3, 7, 2)); // multiplicar tres enteros
        }
    }
}
