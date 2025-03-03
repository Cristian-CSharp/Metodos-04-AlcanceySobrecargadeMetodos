# Ámbito (alcance) de Variables y Métodos en C#
El **ámbito** o **alcance** de una variable o método define **dónde pueden ser accedidos y utilizados** dentro del código.

## 📌 Ámbito Local (Variables Locales)
Las **variables locales** son aquellas **declaradas dentro de un método o bloque** `{}`.

-   **Solo existen mientras el método se ejecuta.**
-   **No pueden ser accedidas fuera de ese método.**
```c#
class Ejemplo
{
    static void MostrarMensaje()
    {
        int numero = 10; // Variable local, solo existe dentro de este método
        Console.WriteLine(numero);
    }

    static void Main()
    {
        MostrarMensaje();
        // Console.WriteLine(numero); ❌ ERROR: "numero" no existe aquí.
    }
}
```

## 📌 Ámbito de Clase (Campos de Clase)
Las **variables declaradas fuera de los métodos**, pero dentro de la clase, son **campos de clase**.

-   **Pueden ser accedidas desde cualquier método de la misma clase.**
-   **Existen durante toda la vida del objeto.**
```c#
class Ejemplo
{
    static int contador = 0; // Campo de clase

    static void Incrementar()
    {
        contador++; // Se puede acceder desde cualquier método de la clase
    }

    static void Main()
    {
        Incrementar();
        Console.WriteLine(contador); // ✅ Funciona
    }
}
```
# Sobrecarga de Métodos en C#
La **sobrecarga de métodos** permite definir **varios métodos con el mismo nombre**, pero con **diferentes parámetros** (tipo o cantidad).

## 📌 **¿Para qué sirve la sobrecarga de métodos?**

1.  **Evita crear múltiples métodos con nombres diferentes**
    
    -   En lugar de crear `ImprimirEntero()`, `ImprimirDecimal()`, `ImprimirTexto()`, simplemente sobrecargamos `Imprimir()`.
2.  **Permite llamar al mismo método con diferentes tipos de datos**
```c#
Console.WriteLine(100);      // Llama a Console.WriteLine(int)
Console.WriteLine(3.14);     // Llama a Console.WriteLine(double)
Console.WriteLine("Hola");   // Llama a Console.WriteLine(string)
```
3.  **Reduce la repetición de código (DRY - Don't Repeat Yourself)**
    
    -   En lugar de escribir múltiples versiones de un método, simplemente cambiamos los parámetros.
4.  **Facilita la legibilidad y mantenimiento del código**
    
    -   El usuario del método no necesita memorizar múltiples nombres, solo uno con diferentes formas de uso.
###  📝  **Ejemplo Básico de Sobrecarga**

```c#
class Calculadora
{
    static int Sumar(int a, int b)
    {
        return a + b;
    }

    static double Sumar(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.WriteLine(Sumar(5, 3));    // Llama al primer método (int)
        Console.WriteLine(Sumar(2.5, 3.5)); // Llama al segundo método (double)
    }
}
```

###  📝 **Expresión Bodied Members**
En C#, se pueden definir métodos más cortos con `=>` (**expression-bodied methods**).

```c#
class Calculadora
{
    static int Sumar(int a, int b) => a + b;
    static double Sumar(double a, double b) => a + b;

    static void Main()
    {
        Console.WriteLine(Sumar(10, 20));
        Console.WriteLine(Sumar(2.5, 7.5));
    }
}
```


## 🏋 Ejercicios :
 **Ejercicio 1: Contador de Palabras con Sobrecarga**
 
Crea un programa en C# que cuente **cuántas palabras hay en un texto** ingresado por el usuario.

✅ **Requisitos:**

-   Usar **un método sobrecargado** llamado `ContarPalabras`.
-   La primera versión del método recibe un **string con un texto** y devuelve la cantidad de palabras.
-   La segunda versión no recibe parámetros y pide el texto **usando `Console.ReadLine()`**.

**Ejercicio 2: Calculadora con Sobrecarga**

Crea una clase `Calculadora` con métodos sobrecargados para:

-   Sumar **dos enteros**.
-   Sumar **tres enteros**.
-   Sumar **dos números decimales**.
-   Multiplicar **dos enteros**.
-   Multiplicar **tres enteros**.

**Ejercicio 3: Clases con Campos de Clase y Métodos**

Crea una clase `CuentaBancaria` que tenga:

-   Un **campo de clase** llamado `saldo` (privado).
-   Métodos para **depositar y retirar dinero** con validaciones.
-   Métodos sobrecargados para:
    -   Retirar dinero con cantidad específica.
    -   Retirar todo el saldo.

---
🔥 Importante
Estos ejercicios, ya están resueltos y los puedes encontrar en este repositorios, cada ejercicio esta en una carpeta...
---

