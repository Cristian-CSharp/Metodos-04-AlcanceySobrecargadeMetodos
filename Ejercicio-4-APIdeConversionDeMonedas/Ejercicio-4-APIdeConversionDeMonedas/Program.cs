using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_APIdeConversionDeMonedas
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool esverdad = false;

            do
            {

                int eleccion;
                Console.WriteLine("1. Dolares a Soles \n2. Dolares a Euros \n3. Otros \n4. Salir");
                Console.Write("Elija el tipo de conversion que desea realizar: ");
                    //     hola -- fasle --- ! --- true                y           true    y  false
                while (!int.TryParse(Console.ReadLine(), out eleccion) || eleccion < 1 || eleccion > 4)
                {
                    Console.WriteLine("Error: debe ingresar un numero entre 1 y 4");
                    Console.Write("Ingrese nuevamente el tipo de conversion que desa realizar: ");
                }

                


                switch (eleccion)
                {
                    case 1:
                        Console.Write("Ingrese la cantidad de dolares a convertir: ");
                        double dolares = double.Parse(Console.ReadLine());

                        Console.WriteLine($"{dolares} dolares equivale a {Conversor.ConversorMoneda(dolares)} soles");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad de dolares a convertir: ");
                        decimal Dolares = decimal.Parse(Console.ReadLine());

                        Console.WriteLine($"{Dolares} dolares equivale a {Conversor.ConversorMoneda(Dolares)} euros");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Indique el nombre de la moneda que quiere convertir: ");
                        string moneda = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre de la moneda a convertir: ");
                        string Otramoneda = Console.ReadLine();

                        Console.WriteLine($"Ingrese la cantidad de {moneda} a convertir");
                        decimal CantidadMoneda = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Ahora indique el tipo de cambio de la conversion: ");
                        decimal tipoCambio = decimal.Parse(Console.ReadLine());

                        Console.WriteLine($"{CantidadMoneda} {moneda} equivale a {Conversor.ConversorMoneda(CantidadMoneda, tipoCambio)} {Otramoneda}");
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa.....");
                        esverdad = true;
                        break;       
                }
            }
            while (!esverdad);

        }
    }
}
