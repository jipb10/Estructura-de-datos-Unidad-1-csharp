using System;

namespace ComplejidadEspacio
{
    public class Principal
    {

        Operaciones op = new Operaciones();
        Valores v = new Valores();
        public void Getsuma()
        {
            Console.WriteLine("Ingrese numero 1:");
            v.Valora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2:");
            v.Valorb = Convert.ToDouble(Console.ReadLine());


            op.Sumar(v);
            double suma = op.Sumar(v);
            Console.WriteLine("La suma es : "+suma);
        }

        public void Getresta()
        {
            Console.WriteLine("Ingrese numero 1:");
            v.Valora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2:");
            v.Valorb = Convert.ToDouble(Console.ReadLine());
            op.Restar(v);
            double resta = op.Restar(v);
            Console.WriteLine("La resta es : "+ resta);

        }

        public void GetMult()
        {
            Console.WriteLine("Ingrese numero 1:");
            v.Valora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2:");
            v.Valorb = Convert.ToDouble(Console.ReadLine());
            op.Multiplicar(v);
            double multi = op.Multiplicar(v);
            Console.WriteLine("La multiplicacion es : " +multi);

        }

        public void Getdivision()
        {
            Console.WriteLine("Ingrese numero 1:");
            v.Valora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2:");
            v.Valorb = Convert.ToDouble(Console.ReadLine());

            op.Dividir(v);
            double division = op.Dividir(v);
            Console.WriteLine("La suma es : "+division);

        }


      

      
    }
}
