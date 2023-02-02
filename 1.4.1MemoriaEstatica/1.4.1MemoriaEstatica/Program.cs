using System;

namespace _1._4._1MemoriaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {

                int opc = 0;


                Console.WriteLine("\n1.Cuadrado");
                Console.WriteLine("\n2.Triangulo");
                Console.WriteLine("\n3.Rectangulo");
                Console.Write("\nIngrese la opcion que desea calcular : ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {

                    case 1:
                        Console.WriteLine("Ingrese numero 1:");
                        float num1 = Convert.ToInt32(Console.ReadLine());


                        float areac = Operaciones.CalcularArea(num1);
                        Console.WriteLine("El area es: " + areac);
                        break;

                    case 2:
                        int valor = 2;
                        Console.WriteLine("Ingrese numero 1:");
                        float triangulo1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese numero 2:");
                        float triangulo2 = Convert.ToInt32(Console.ReadLine());
                        float areat = Operaciones.CalcularArea(triangulo1, triangulo2, valor);

                        Console.WriteLine("El area es: " + areat);
                        break;

                    case 3:
                        Console.WriteLine("Ingrese numero 1:");
                        float rec1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese numero 2:");
                        float rec2 = Convert.ToInt32(Console.ReadLine());

                        float arear = Operaciones.CalcularArea(rec1, rec2);
                        Console.WriteLine("El area es: " + arear);
                        break;
                }

                Console.WriteLine("\n");
                Console.WriteLine("1. SI");
                Console.WriteLine("2. No");

                Console.Write("Desea Calcular otra figura?  : ");




                opcion = int.Parse(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();
            } while (opcion == 1);


            Console.ReadKey();
        }
    }
}
