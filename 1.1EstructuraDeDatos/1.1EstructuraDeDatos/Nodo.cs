using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1EstructuraDeDatos
{
    public class Nodo
    {

        public int dato;

        public Nodo siguiente = null;

        public int Dato { get { return dato; } set { dato = value; } }

        internal Nodo Siguiente { get { return siguiente; } set { siguiente = value; } }

        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
