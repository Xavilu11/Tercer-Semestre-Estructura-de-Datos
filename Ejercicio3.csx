// //Escribir un programa que almacene las asignaturas de un curso 
// (por ejemplo Matemáticas, Física, Química, Historia y Lengua) 
// en una lista, pregunte al usuario la nota que ha sacado en cada asignatura
//  y después las muestre por pantalla con el mensaje
//  En<asignatura> has sacado <nota> donde <asignatura> es cada una des las asignaturas
//  de la lista y <nota> cada una de las correspondientes notas introducidas por el usuario.



using System;
using System.Collections.Generic;

class Ejercicio3
{
    static void Main()
    {
        // Creamos una lista de asignaturas
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        // Creamos un diccionario para almacenar las notas
        Dictionary<string, float> notas = new Dictionary<string, float>();

        // Pedimos al usuario que ingrese las notas para cada asignatura
        foreach (var asignatura in asignaturas)
        {
            Console.Write($"¿Qué nota has sacado en {asignatura}? ");
            float nota = float.Parse(Console.ReadLine());
            notas[asignatura] = nota; // Almacenamos la nota en el diccionario
        }

        // Mostramos las notas ingresadas
        foreach (var item in notas)
        {
            Console.WriteLine($"En {item.Key} has sacado {item.Value}");
        }
    }
}
