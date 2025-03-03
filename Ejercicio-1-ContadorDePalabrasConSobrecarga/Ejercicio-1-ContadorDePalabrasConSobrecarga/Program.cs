using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_ContadorDePalabrasConSobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // llamando al primer metodo
            Console.Write("Ingrese un texto para el primer metodo: "); // se pide al usuario que ingrese el texto
            string texto = Console.ReadLine().Trim(); // el texto ingresado se guarda en este variable y ademas usamos el metodo Trim para poder eliminar los espacios en vacios al inicio y final del texto si en caso lo hubiese

            Console.WriteLine(Contador.ContarPalabras(texto)); // se manda a llamar al metodo con parametros y se imprime el resultado

            // llamando al segundo metodo
            Console.WriteLine(Contador.ContarPalabras()); // aqui simplemente se llama al metodo sin parametros y se imprime su resultado
        }
    }
}
