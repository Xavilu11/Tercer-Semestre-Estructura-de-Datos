// Escribir un programa que almacene las asignaturas de un curso 
// (por ejemplo Matemáticas, Física, Química, Historia y Lengua) 
// en una lista y la muestre por pantalla.



using System;
using System.Collections.Generic;

class Ejercicio1
{
    static void Main()
    {
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        Console.WriteLine("Asignaturas del curso:");
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}
