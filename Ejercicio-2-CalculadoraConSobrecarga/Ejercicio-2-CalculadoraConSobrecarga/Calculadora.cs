using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_CalculadoraConSobrecarga
{
    internal class Calculadora // se creo la clase calculadora
    {
        public static int sumar(int n1, int n2) => n1 + n2; // se creo este metodo sumar con 2 parametros del tipo entero y usando la expresion Bodied Members
        public static int sumar(int n1, int n2, int n3) => n1 + n2 + n3; // se creo este metodo sumar con 3 parametros del tipo entero y usando la expresion Bodied Members

        public static double sumar(double n1, double n2) => n1 + n2; // se creo este metodo sumar con 2 parametros del tipo double y usando la expresion Bodied Members

        public static int multiplicar(int n1, int n2) => n1 * n2; // se creo este metodo multiplicar con 2 parametros del tipo entero y usando la expresion Bodied Members
        public static int multiplicar(int n1, int n2, int n3) => n1 * n2 * n3; // se creo este metodo multiplicar con 3 parametros del tipo entero y usando la expresion Bodied Members

    }
}
