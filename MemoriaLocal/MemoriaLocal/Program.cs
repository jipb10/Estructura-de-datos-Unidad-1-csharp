using System;

namespace MemoriaLocal
{
    class Program
    {
        public class Metodo
        {

            public static int Potencia(int nBase, int nExponente)
            {
                int temporal = 1;  // Valor inicial que voy incrementando

                for (int i = 1; i <= nExponente; i++)  // Multiplico "n" veces
                    temporal *= nBase;            // Para aumentar el valor temporal

                return temporal; // Al final, obtengo el valor que buscaba
            }

        }




        static void Main(string[] args)
        {
            int opc = 0;
            do
            {

           

            int num1, num2;

            Console.Write("Introduzca la base : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            

            Console.Write("\nIntroduzca el exponente : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n{0} elevado a {1} vale {2}",
                num1, num2, Metodo.Potencia(num1, num2));

                Console.WriteLine("\n1. SI");

                Console.WriteLine("2.NO");



                Console.Write("Desea calcular otro numero? : ");
                opc = int.Parse(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();

            } while (opc==1);
        }

    }
}

