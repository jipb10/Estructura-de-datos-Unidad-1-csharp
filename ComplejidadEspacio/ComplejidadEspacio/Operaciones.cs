using System;
using System.Collections.Generic;
using System.Text;

namespace ComplejidadEspacio
{
    public class Operaciones
    {

        public double Sumar(Valores v)

        {
            double suma = v.Valora + v.Valorb;


            return suma;

        }

        public double Restar(Valores v)
        {
            double resta = v.Valora - v.Valorb;
            return resta;
        }

        public double Multiplicar(Valores v)
        {
            double multiplicacion = v.Valora * v.Valorb;

            return multiplicacion;
        }

        public double Dividir(Valores v)
        {
            double division = v.Valora / v.Valorb;
            return division;
        }
    }
}
