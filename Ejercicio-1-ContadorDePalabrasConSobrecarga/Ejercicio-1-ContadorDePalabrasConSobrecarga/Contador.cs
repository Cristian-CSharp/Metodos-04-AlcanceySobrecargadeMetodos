using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_ContadorDePalabrasConSobrecarga
{
    internal class Contador // se creo la clase 
    {
        public static int ContarPalabras(string texto) // se crea un metodo con parametros para poder contar palabras de un texto  
        {
            int longitud = texto.Length; // primero se calcula la cantidad de caracteres que tiene el texto ingresado excluyendo espacios en blanco
            bool esPalabra = false; // se declara e inicializa un booleano para usarlo como ayuda para validar que realmente estamos en una palabra, usando su valor como palanca para poder acceder al conteo de palabras una sola vez
            int contador = 0; // se declara un variable entera que nos servira para contar la cantidad de palabra que tenga el texto

            for (int i = 0; i < longitud; i++) // se usa un for para poder recorrer el texto ingresado incluyendo letras como espacio vacios, simbolos y numeros
            {
                if (texto[i] != ' ') // esta condicional no verifica que no estemos en un espacio vacio
                {
                    if (!esPalabra) // y esta otra condicional nos ayuda a validar que estamos en una palabra y usamos el valor del booleano como una puerta que solo
                        // se ingresara una sola vez cuando detecte que estamos en una palabra, si en caso es un espacio, no ingresara en esta condicional ni el condicional anterior
                    {
                        contador++; // cuando se sepa que estamos en una palabra se empezara a contar pero solamente sera una vez por palabra  
                        esPalabra = true; // se contara solo una vez por palabra ya que al cambiar el valor del booleano a true significa que hasta que no encuentre 
                        // otra palabra no podra ingresar aqui por el simple hecho de que la condicional no lo permitira hasta que este no cambie de valor a false
                    }
                }
                else // si en caso no estamos en una palabra sino que es un espacio vacio este parte de la condicional se ejecutara
                { 
                    esPalabra = false; // se cambia el valor del booleano, este cambio nos servira para poder acceder a la condicional anidada del primer if ya que 
                    // con esto podremos contar otra palabra ni bien el if la detecte

                }
            }
            return contador; // al final retornaremos el valor final del contador al main
        }

        public static int ContarPalabras() // se crea otro metodo sin parametros para poder contar palabras de un texto  / teniendo ya dos metodos con el mismo nombre pero diferentes parametros
        {
            Console.Write("Ingrese un texto para el segundo metodo: "); // se pide al usuario que ingrese el texto desde el metodo ya que al no tener parametros no podra recibir un valor por ese medio para evaluarlo
            string texto = Console.ReadLine(); // el texto ingresado se guarda en este variable

            return ContarPalabras(texto); // y para ya no escribir le mismo codigo del primer metodo para hallar la cantidad de palabras, simplemente llamamos
            // al primer metodo y su resultado lo retornamos al main y asi reutilizamos el codigo del primer metodo en este segundo metodo
        }
    }

}
