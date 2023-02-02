using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4._1MemoriaEstatica
{
    public class Operaciones
    {
        public static float CalcularArea(float Ladoa)
        {
            float area = Ladoa * Ladoa;
            return area;
        }

        public static float CalcularArea(float Ladoa, float Ladob, int valor)
        {
            valor = 2;
            float area = (Ladoa * Ladob) / valor;
            return area;
        }

        public static float CalcularArea(float Ladoa, float Ladob)
        {
            float area = Ladoa * Ladob;
            return area;
        }

    }
}
