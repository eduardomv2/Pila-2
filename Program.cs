using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creamos una instancia de Stack<int> llamada miPila para almacenar números enteros.
        Stack<int> miPila = new Stack<int>();

        // Agregamos elementos a la pila usando el método Push.
        miPila.Push(1);
        miPila.Push(2);
        miPila.Push(3);

        // Mostramos los elementos en la pila usando un bucle foreach.
        Console.WriteLine("Elementos en la pila:");
        foreach (int elemento in miPila)
        {
            Console.WriteLine(elemento);
        }

        // Eliminamos un elemento de la pila usando el método Pop.
        int elementoEliminado = miPila.Pop();

        // Mostramos el elemento eliminado.
        Console.WriteLine("\nElemento eliminado de la pila: " + elementoEliminado);

        // Mostramos los elementos restantes en la pila después de la eliminación.
        Console.WriteLine("\nElementos en la pila después de la eliminación:");
        foreach (int elemento in miPila)
        {
            Console.WriteLine(elemento);
            Console.ReadLine();
        }
    }
}