using System;
using System.Diagnostics;

namespace ComplejidadEspacio
{
    class Program
    {
        static void Main(string[] args)
        {

            int opc = 0;
            Principal p = new Principal();

            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------");

                

                Console.WriteLine("\n1.Suma");
                Console.WriteLine("2.Resta");
                Console.WriteLine("3.Multiplicacion");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Cerrar programa");
                Console.Write("\nInserte la operacion que desee realizar : ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        p.Getsuma();
                        Console.ReadKey();
                        break;

                    case 2:
                        p.Getresta();
                        Console.ReadKey();
                        break;

                    case 3:
                        p.GetMult();
                        Console.ReadKey();
                        break;

                    case 4:
                        p.Getdivision();
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Cerrando programa...");
                        Console.WriteLine("\nMemoria Utilizada : " + GC.GetTotalMemory(true) + " " + "bytes");
                        break;
                }

            } while (opc != 5);
        }
    }
}
