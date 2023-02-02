using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ComplejidadTiempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
            Random aleatorio = new Random();
            int[] registro = new int[15];

            for (int i = 0; i < registro.Length; i++)
            {
                registro[i] = aleatorio.Next(0, 10) + 1;
            }

            for (int i = 0; i < registro.Length; i++)
            {
                Console.WriteLine(registro[i]);
            }
            timeMeasure.Stop();
            Console.WriteLine($"\nTiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");

            Console.WriteLine($"Precision: {(1.0 / Stopwatch.Frequency).ToString("E")} segundos");
            if (Stopwatch.IsHighResolution)
                Console.WriteLine("Alta precisión");
            else
                Console.WriteLine("Baja precisión");

            Console.WriteLine("\nMemoria Utilizada : " + GC.GetTotalMemory(true) + " " + "bytes");

            Console.ReadKey();
        }
    }
}
