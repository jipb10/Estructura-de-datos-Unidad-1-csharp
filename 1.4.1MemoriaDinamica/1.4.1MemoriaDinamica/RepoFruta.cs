using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4._1MemoriaDinamica
{
    public class RepoFruta
    {


        int opc = 0;
        public void Venderfruta(Frutax[] fruitv)
        {


            for (int i = 0; i < fruitv.Length; i++)
            {
                Console.WriteLine(fruitv[i].Id + " " + fruitv[i].Nombre);
            }

            Console.WriteLine("\n");

            Console.Write("Cual fruta desea comprar? : ");

            opc = int.Parse(Console.ReadLine());




            switch (opc)
            {
                case 1:
                    {
                        Console.WriteLine(fruitv[0].Id + "\n" + fruitv[0].Nombre + " \n" +"Precio : "+ fruitv[0].Precio);
                        Console.ReadKey();

                        Console.Clear();
                        break;

                    }

                case 2:
                    {
                        Console.WriteLine(fruitv[1].Id + "\n" + fruitv[1].Nombre + " \n" +"Precio : " + fruitv[1].Precio);
                        Console.ReadKey();

                        Console.Clear();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(fruitv[2].Id + "\n" + fruitv[2].Nombre + " \n" +"Precio : " + fruitv[2].Precio);
                        Console.ReadKey();

                        Console.Clear();
                        break;
                    }


            }





        }
        public void Listarfruta(Frutax[] fruitl)
        {
            for (int i = 0; i < fruitl.Length; i++)
            {
                Console.WriteLine(fruitl[i].Id + "," + fruitl[i].Nombre + "," + fruitl[i].Tipo + "," + fruitl[i].Peso + "," + fruitl[i].Precio);
            }
        }
        public void Mostrarfruta(Frutax fruitm)
        {
            Console.WriteLine(fruitm.Id + "," + fruitm.Nombre + "," + fruitm.Tipo + "," + fruitm.Peso + "," + fruitm.Precio);



        }
    }
}
