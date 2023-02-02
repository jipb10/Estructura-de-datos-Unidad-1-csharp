using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4._1MemoriaDinamica
{
    public class Frutax
    {
        private int id;
        private string nombre;
        private string tipo;
        private double peso;
        private decimal precio;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
