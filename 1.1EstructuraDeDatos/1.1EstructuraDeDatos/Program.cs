using System;

namespace _1._1EstructuraDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();



            Console.Write("Ingrese los valores para la pila : ");

            pila.Push(int.Parse(Console.ReadLine()));

            pila.Push(int.Parse(Console.ReadLine()));

            pila.Push(int.Parse(Console.ReadLine()));




            pila.Transversa();

            Console.WriteLine("\n");

            Console.Write("Se elimino el numero : " + pila.Pop());

            Console.WriteLine("\n");





            pila.Transversa();
        }
    }
}
