// Escribir un programa que almacene las asignaturas de un curso 
// (por ejemplo Matemáticas, Física, Química, Historia y Lengua) 
// en una lista y la muestre por pantalla el mensaje Yo estudio <asignatura>, 
//donde <asignatura> es cada una de las asignaturas de la lista.


using System;
using System.Collections.Generic;

class Ejercicio2
{
    static void Main()
    {
        // Creamos la lista de asignaturas
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        
        // Muestra el mensaje para cada asignatura
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}
