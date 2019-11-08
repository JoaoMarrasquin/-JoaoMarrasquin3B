using System;
using JoaoMarrasquin3B.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoaoMarrasquin3B
{
    class Program
    {
        static void Main(string[] args)
        {
            int menugeneral;         
            do
            {
                Console.WriteLine("\n------MENÚ GENERAL------\n" +
                       "1.- Cola\n" +
                       "2.- Pila\n"+
                       "3.- Salir\n");
                Console.WriteLine("Escoja una de las opciones");
                menugeneral = int.Parse(Console.ReadLine());               
                switch (menugeneral)
                {
                    case 1:
                        Cola c = new Cola();
                        int menu;
                        do
                        {
                            Console.WriteLine("\n------MENÚ DE LA COLA-----\n" +
                               "1.- Insertar\n" +
                               "2.- Buscar\n" +
                               "3.- Modificar\n" +
                               "4.- Eliminar\n" +
                               "5.- Desplegar\n" +
                               "6.- Salir del menú\n");
                            Console.WriteLine("Escoja una de las opciones");
                            menu = int.Parse(Console.ReadLine());
                            switch (menu)
                            {
                                case 1:
                                    Console.WriteLine("\nINSERTAR NODO EN LA LISTA\n");
                                    c.InsertarNodo();
                                    break;
                                case 2:
                                    Console.WriteLine("\nBUSCAR NODO EN LA LISTA\n");
                                    c.buscarnodo();
                                    break;
                                case 3:
                                    Console.WriteLine("\nMODIFICAR NODO EN LA LISTA\n");
                                    c.modificarnodo();
                                    break;
                                case 4:
                                    Console.WriteLine("\nELIMINAR NODO EN LA LISTA\n");
                                    c.eliminarcola();
                                    break;
                                case 5:
                                    Console.WriteLine("\nDESPLEGAR NODOS DE LA LISTA\n");
                                    c.desplegarCola();
                                    break;
                                case 6:
                                    Console.WriteLine("\nFIN DEL PROGRAMA DE LA COLA\n");
                                    break;
                                default:
                                    Console.WriteLine("\nINGRESE OPCIÓN VÁLIDA\n");
                                    break;
                            }
                        } while (menu != 6);
                        break;
                    case 2:
                        Pila p = new Pila();
                        int menu2;
                        do
                        {
                            Console.WriteLine("\n------MENÚ DE LA PILA------\n" +
                               "1.- Insertar\n" +
                               "2.- Buscar\n" +
                               "3.- Modificar\n" +
                               "4.- Eliminar\n" +
                               "5.- Desplegar\n" +
                               "6.- Salir del menú\n");
                            Console.WriteLine("Escoja una de las opciones");
                            menu2 = int.Parse(Console.ReadLine());
                            switch (menu2)
                            {
                                case 1:
                                    Console.WriteLine("\nINSERTAR NODO EN LA LISTA\n");
                                    p.insertarNodoPila();
                                    break;
                                case 2:
                                    Console.WriteLine("\nBUSCAR NODO EN LA LISTA\n");
                                    p.BuscarNodoPila();
                                    break;
                                case 3:
                                    Console.WriteLine("\nMODIFICAR NODO EN LA LISTA\n");
                                    p.ModificarNodoPila();
                                    break;
                                case 4:
                                    Console.WriteLine("\nELIMINAR NODO EN LA LISTA\n");
                                    p.EliminarNodoPila();
                                    break;
                                case 5:
                                    Console.WriteLine("\nDESPLEGAR NODOS DE LA LISTA\n");
                                    p.DesplegarPila();
                                    break;
                                case 6:
                                    Console.WriteLine("\nFIN DEL PROGRAMA DE LA PILA\n");
                                    break;
                                default:
                                    Console.WriteLine("\nINGRESE OPCIÓN VÁLIDA\n");
                                    break;
                            }
                        } while (menu2 != 6);
                        break;
                    case 3:                       
                        break;
                    default:
                        Console.WriteLine("\nINGRESE OPCIÓN VÁLIDA\n");
                        break;
                }                
            } while (menugeneral!= 3);
        }
    }
}