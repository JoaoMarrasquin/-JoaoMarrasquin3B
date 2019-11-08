using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoaoMarrasquin3B.Clases
{
    public class Cola
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();
        public Cola()
        {
            Primero = null;
            Ultimo = null;
        }
        public void InsertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato del nodo");
            nuevo.dato = int.Parse(Console.ReadLine());
            if (Primero == null)
            {
                Primero = nuevo;
                Primero.siguiente = null;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.siguiente = nuevo;
                nuevo.siguiente = null;
                Ultimo = nuevo;
            }

        }
        public void desplegarCola()
        {
            Nodo actual = new Nodo();
            actual = Primero;
            if (Primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine(" " + actual.dato);
                    actual = actual.siguiente;
                }
            }
            else
            {
                Console.WriteLine("\nLa cola está vacía\n");
            }
        }
        public void buscarnodo()
        {
            Nodo actual = new Nodo();
            actual = Primero;
            bool encontrado = false;
            Console.WriteLine("Ingrese el valor del nodo a buscar");
            int nodoencontrado = int.Parse(Console.ReadLine());
            if (Primero != null && encontrado != true)
            {
                while (actual != null)
                {
                    if (actual.dato == nodoencontrado)
                    {
                        Console.WriteLine("\nEl nodo con el valor {0},fue encontrado\n ", nodoencontrado);                        
                        encontrado = true;
                    }
                    actual = actual.siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("\nNodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\nLa cola está vacía\n");
            }
        }
        public void modificarnodo()
        {
            Nodo actual = new Nodo();
            actual = Primero;
            bool encontrado = false;
            Console.WriteLine("Ingrese el valor del nodo a modificar");
            int nodoencontrado = int.Parse(Console.ReadLine());
            if (Primero != null && encontrado != true)
            {
                while (actual != null)
                {
                    if (actual.dato == nodoencontrado)
                    {
                        Console.WriteLine("\nEl nodo con el valor {0}, fue encontrado \n" , nodoencontrado);
                        Console.WriteLine("\nIngrese el nuevo dato del nodo\n");
                        actual.dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nEl nodo fue modificado\n");
                        encontrado = true;
                    }
                    actual = actual.siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("\nNodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\nLa cola está vacía\n");
            }
        }
        public void eliminarcola()
        {
            Nodo actual = new Nodo();
            actual = Primero;
            Nodo anterior = new Nodo();
            anterior = null;
            bool encontrado = false;
            Console.WriteLine("Ingrese el valor del nodo a buscar para eliminar");
            int nodoencontrado = int.Parse(Console.ReadLine());
            if (Primero != null && encontrado != true)
            {
                while (actual != null)
                {
                    if (actual.dato == nodoencontrado)
                    {
                        Console.WriteLine("\nEl nodo con el valor  {0} , fue encontrado\n ", nodoencontrado);

                        if (actual == Primero)
                        {
                            Primero = Primero.siguiente;
                        }
                        else if (actual == Ultimo)
                        {
                            anterior.siguiente = null;
                            Ultimo = anterior;
                        }
                        else
                        {
                            anterior.siguiente = actual.siguiente;
                        }
                        Console.WriteLine("Nodo eliminado");
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("\nNodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\nLa cola está vacía\n");
            }
        }
    }
    //--------------------------------------CLASES DE LA PILA -----------------------------------//
    public class Pila
    {
        private NodoPila PrimeroPila = new NodoPila();
        private NodoPila UltimoPila = new NodoPila();
        public Pila()
        {
            PrimeroPila = null;
            UltimoPila = null;
        }
        public void insertarNodoPila()
        {
            NodoPila Nuevo = new NodoPila();
            Console.Write("\nIngrese el dato del nuevo nodo\n");
            Nuevo.datopila = int.Parse(Console.ReadLine());

            Nuevo.siguientepila = PrimeroPila;
            PrimeroPila = Nuevo;

            Console.WriteLine("\n Nodo ingresado\n");
        }
        public void BuscarNodoPila()
        {
            NodoPila Actual = new NodoPila();
            Actual = PrimeroPila;
            bool Encontrado = false;

            Console.Write("Ingrese dato a buscar: ");
            int nodobuscado = int.Parse(Console.ReadLine());
            if (PrimeroPila != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.datopila == nodobuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato  {0}  ,fue encontrado\n", nodobuscado);
                        Encontrado = true;
                    }
                    Actual = Actual.siguientepila;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\nNodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n La pila se encuentra vacia\n\n");
            }
        }
        public void ModificarNodoPila()
        {
            NodoPila Actual = new NodoPila();
            Actual = PrimeroPila;
            bool Encontrado = false;

            Console.Write("Ingrese dato a buscar para modificar: ");
            int nodobuscado = int.Parse(Console.ReadLine());
            if (PrimeroPila != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.datopila == nodobuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato {0} ,fue encontrado\n", nodobuscado);
                        Console.WriteLine("\nIngrese el nuevo dato\n");
                        Actual.datopila = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nNodo Modificado\n");

                        Encontrado = true;

                    }
                    Actual = Actual.siguientepila;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\nNodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n La pila se encuentra vacia\n");
            }
        }
        public void DesplegarPila()
        {
            NodoPila Actual = new NodoPila();
            Actual = PrimeroPila;
            if (PrimeroPila != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine(" " + Actual.datopila);
                    Actual = Actual.siguientepila;
                }
            }
            else
            {
                Console.WriteLine("\nLa pila se encuentra vacia\n");
            }
        }
        public void EliminarNodoPila()
        {
            NodoPila Actual = new NodoPila();
            Actual = PrimeroPila;
            NodoPila Anterior = new NodoPila();
            Anterior = null;
            bool Encontrado = false;

            Console.Write("Ingrese dato a buscar para eliminar: ");
            int nodobuscado = int.Parse(Console.ReadLine());
            if (PrimeroPila != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.datopila == nodobuscado)
                    {
                        Console.WriteLine("\n El nodo con el dato {0} ,fue encontrado\n", nodobuscado);
                        if (Actual == PrimeroPila)
                        {
                            PrimeroPila = PrimeroPila.siguientepila;
                        }
                        else
                        {
                            Anterior.siguientepila = Actual.siguientepila;
                        }
                        Console.WriteLine("\n Nodo eliminado\n");

                        Encontrado = true;

                    }
                    Anterior = Actual;
                    Actual = Actual.siguientepila;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\nNodo no Encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n La pila se encuentra vacia\n");
            }
        }
    }
}