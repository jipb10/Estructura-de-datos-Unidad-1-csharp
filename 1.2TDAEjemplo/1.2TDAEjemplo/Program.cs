using System;
using System.Collections.Generic;

namespace _1._2TDAEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();

            nombres.Add("Jorge");
            nombres.Add("Mario");
            nombres.Add("Luis");




            Console.WriteLine("El nombre en la segunda posicion es : " + nombres[1]);
            Console.WriteLine("La cantidad de elementos es : " + nombres.Count);


            Console.Write("\nQue nombre desea buscar? ");
            string nombre = Console.ReadLine();
            bool res = nombres.Contains(nombre);

            if (res == true)
            {
                Console.WriteLine("Este elemento si esta en la lista");

            }

            else
            {
                Console.WriteLine("Este elemento no esta en la lista");
            }

            Console.ReadKey();
        }
    }
}
