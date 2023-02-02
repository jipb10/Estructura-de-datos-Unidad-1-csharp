using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1EstructuraDeDatos
{
    public class Stack
    {
        Nodo ancla;

        Nodo trabajo;

        public Stack()
        {
            ancla = new Nodo();
            ancla.Siguiente = null;
        }

        public void Push(int pDato)
        {
            Nodo temp = new Nodo();
            temp.Dato = pDato;

            temp.siguiente = ancla.siguiente;

            ancla.siguiente = temp;


        }

        public int Pop()
        {
            int valor = 0;

            if (ancla.siguiente != null)
            {
                trabajo = ancla.siguiente;
                valor = trabajo.Dato;

                ancla.siguiente = trabajo.siguiente;
                trabajo.siguiente = null;
            }

            else
            {
                Console.WriteLine("El stack esta vacio");
            }

            return valor;

        }

        public int Peek()
        {
            int valor = 0;

            if (ancla.siguiente != null)
            {
                trabajo = ancla.siguiente;
                valor = trabajo.Dato;
            }
            else
            {
                Console.WriteLine("El stack esta vacio");
            }

            return valor;

        }

        public void Transversa()
        {
            trabajo = ancla;
            while (trabajo.siguiente != null)
            {
                trabajo = trabajo.siguiente;

                int d = trabajo.Dato;

                Console.WriteLine("[{0}]", d);
            }
        }
    }
}
