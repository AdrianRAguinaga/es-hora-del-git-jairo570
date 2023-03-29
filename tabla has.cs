
using System;
using System.Collections.Generic;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        // Creamos una tabla hash con un tamaño de 1,000,000
        TablaHash tabla = new TablaHash(1000000);
        // Generamos un conjunto aleatorio de 1,000,000 números enteros y los agregamos a  la tabla hash
        Random rnd = new Random();
        for (int i = 0; i < 1000000; i++)
        {
            int num = rnd.Next(1000000);
            tabla.Agregar(num.ToString(), num); // Agregamos el número a la tabla hash
        }
        // Realizamos una búsqueda aleatoria de 100,000 números y medimos el tiempo que tarda
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < 100000; i++)
        {
            int num = rnd.Next(1000000);
            tabla.Obtener(num.ToString()); // Buscamos el número en la tabla hash
        }
        stopwatch.Stop();
        // Imprimimos el tiempo de búsqueda en milisegundos
        Console.WriteLine($"Tiempo de búsqueda: {stopwatch.ElapsedMilliseconds} ms");
    }
}
