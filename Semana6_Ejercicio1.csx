// Función que calcule el número de elementos de una lista:
// La idea de este algoritmo es bastante sencilla, lo que tendremos q hacer para ver la longitud de
// una lista es simplemente recorrer la lista hasta el final e ir contando el número de saltos. El
// principal motivo por el que deberíamos implementar es que nos permite aprender y comprender
// el manejo de los nodos.

using System;

// Definimos el Nodo que almacena dato y referencia al siguiente nodo
public class Nodo
{
    public int Dato { get; set; }
    public Nodo Siguiente { get; set; }

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

// Clase Lista Enlazada para implementar las operaciones básicas
public class ListaEnlazada
{
    private Nodo cabeza; // Este es el puntero del primer elemento

    // Método para agregar elementos al final de la lista
    public void Agregar(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato);

        if (cabeza == null) 
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null) // Se traslada hasta el último nodo
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo; // Une el nuevo nodo al último
        }
    }

    // Método para contar elementos, esto busca en toda la lista
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = cabeza;
        
        while (actual != null) 
        {
            contador++; // Va aumentando el contador
            actual = actual.Siguiente; // Avanza al siguiente nodo
        }

        return contador;
    }
}

// Programa de prueba
class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        // Agregamos otros elementos
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);

        // Muestra el tamaño de la lista
        Console.WriteLine($"La lista tiene {lista.ContarElementos()} elementos.");
    }
}
