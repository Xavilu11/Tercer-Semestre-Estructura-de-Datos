//Escribir un programa que pregunte al usuario los números ganadores de la lotería primitiva, 
// los almacene en una lista y los muestre por pantalla ordenados de menor a mayor.

using System;
using System.Collections.Generic;

class Ejercicio4

{
    static void Main()
    {
        // Crea una lista para almacenar los números ganadores
        List<int> numerosGanadores = new List<int>();
        Console.WriteLine("Introduce los números ganadores de la lotería (separados por comas):");
        string input = Console.ReadLine();
        // Separa los números por comas
        string[] numeros = input.Split(',');

        // Convierte a cada número a entero y lo agrega a la lista
        foreach (var numero in numeros)
        {
            numerosGanadores.Add(int.Parse(numero.Trim()));
        }

        // Ordena la lista de números ganadores
        numerosGanadores.Sort();
        Console.WriteLine("Números ganadores ordenados:");
        // Muestra los números ganadores ordenados
        foreach (var numero in numerosGanadores)
        {
            Console.WriteLine(numero);
        }
    }
}
