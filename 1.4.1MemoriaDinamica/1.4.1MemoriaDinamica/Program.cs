using System;
using System.Collections.Generic;

namespace _1._4._1MemoriaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;

            do
            {



                // instanciacion
                Frutax fruta1 = new Frutax(); // Aqui se utiliza la memoria dinamica en la creacion del objeto

                fruta1.Id = 1;
                fruta1.Nombre = "Mango";
                fruta1.Tipo = "...";
                fruta1.Peso = 50;
                fruta1.Precio = 20.00m;

                Frutax fruta2 = new Frutax();

                fruta2.Id = 2;
                fruta2.Nombre = "manzana";
                fruta2.Tipo = "...";
                fruta2.Peso = 10;
                fruta2.Precio = 5.00m;

                Frutax fruta3 = new Frutax();

                fruta3.Id = 3;
                fruta3.Nombre = "naranja";
                fruta3.Tipo = "...";
                fruta3.Peso = 12;
                fruta3.Precio = 8.00m;




                RepoFruta Rf = new RepoFruta();

                Frutax[] frutas = { fruta1, fruta2, fruta3 };


                Console.WriteLine("------------------------------------------------");
                Rf.Venderfruta(frutas);





                Console.WriteLine("1. SI");
                Console.WriteLine("2. No");

                Console.Write("Desea revisar otra fruta? : ");




                opc = int.Parse(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();



            } while (opc == 1);



            Console.ReadKey();
        }
    }
}
