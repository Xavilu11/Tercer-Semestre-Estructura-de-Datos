//Escribir un programa que almacene en una lista los números del 1 al 10 
//y los muestre por pantalla en orden inverso separados por comas.

using System;
using System.Collections.Generic;

class Ejercicio5
{
    static void Main()
    {
        // Creamos una lista para almacenar los números del 1 al 10
        List<int> numeros = new List<int>();
        
        // Se agregan los números del 1 al 10 a la lista
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        // Invertimos el orden
        numeros.Reverse();
        Console.WriteLine("Números del 1 al 10 en orden inverso:");
        // Muestra los números en orden inverso
        Console.WriteLine(string.Join(", ", numeros));
    }
}
