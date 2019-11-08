using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoaoMarrasquin3B.Clases
{
    public class Nodo
    {
        private Nodo Siguiente;
        public Nodo siguiente
        {
            get { return Siguiente; }
            set { Siguiente = value; }
        }
        private int Dato;

        public int dato
        {
            get { return Dato; }
            set { Dato = value; }
        }
    }

    //------------------------ATRIBUTOS DE LA PILA----------------------------------//
    public class NodoPila
    {
        private NodoPila Siguientepila;

        public NodoPila siguientepila
        {
            get { return Siguientepila; }
            set { Siguientepila = value; }
        }
        private int Datopila;

        public int datopila
        {
            get { return Datopila; }
            set { Datopila = value; }
        }
    }
}
