using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBebidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("------ BIENVENIDO ------");
            Console.WriteLine("Cual es su edad: ");
            cliente.edad = Convert.ToInt32(Console.ReadLine());
            if(cliente.edad > 17)
            {
                Console.Clear();
                Console.WriteLine("MENU COMPLETO");
                int i = 5;
                while (i > 4)
                {
                    Console.WriteLine("------------ Bienvenido ------------");
                    Console.WriteLine("Seleccione la categoria de la que desea adquirir su bebida: ");
                    Console.WriteLine("1. Bebidas Alcoholicas \n" + "2. Jugos Naturales \n " + "3.Gaseosas \n" + "4. Bebidas Calientes \n");
                    Categoria cate = new Categoria();
                    cate.opc = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    i = cate.opc;
                    if (i > 4)
                    {
                        Console.WriteLine("Escoja una opcion valida porfavor.");
                    }
                    switch (cate.opc)
                    {
                        case 1:
                            cliente.DatosC();
                            cate.Alcoholicas();
                            //insertar aca el metodo de pedir datos del empleado
                            cate.MostrarB();
                            cliente.imprimirCliente();
                            //insertar aca el metodo de mostrar datos del empleado
                            //hacer lo mismo en todos los demas casos
                            break;

                        case 2:

                            cate.Jugos();
                            cate.MostrarB();
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        default:
                            break;
                    }
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("MENU -18");
                Console.WriteLine("Este menu no contiene ninguna bebida alcoholica");
                int i = 5;
                while (i > 4)
                {
                    Console.WriteLine("------------ Bienvenido ------------");
                    Console.WriteLine("Seleccione la categoria de la que desea adquirir su bebida: ");
                    Console.WriteLine("1. Jugos Naturales \n " + "2.Gaseosas \n" + "3. Bebidas Calientes \n");
                    Categoria cate = new Categoria();
                    cate.opc = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    i = cate.opc;
                    switch (cate.opc)
                    {
                        case 1:
                            cliente.DatosC();
                            cate.Jugos();
                            //insertar aca el metodo de pedir datos del empleado
                            cate.MostrarB();
                            cliente.imprimirCliente();
                            //insertar aca el metodo de mostrar datos del empleado
                            //hacer lo mismo en todos los demas casos
                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        default:
                            break;
                    }
                    if (i > 4)
                    {
                        Console.WriteLine("Escoja una opcion valida porfavor.");
                    }
                }
                Console.ReadLine();
            }
            

        }
    }

    class TipoBebida
    {
        public string nombreB;
        public string preparacionB;
        public double precio;
        public string codigo;
        public int opcT;
    }

    class Categoria : TipoBebida
    {
        public string categoria;
        public int opc;

        public void Alcoholicas()
        {
            categoria = "Bebidas Alcoholicas";
            //bebidas alcoholicas
            Console.WriteLine("Seleccione el tipo de bebida que desea: ");
            Console.WriteLine("1. Margarita");
            Console.WriteLine("Precio: $4.00");
            Console.WriteLine("2. Moscow Mule");
            Console.WriteLine("Precio: $8.00");
            Console.WriteLine("3. Martini");
            Console.WriteLine("Precio: $6.00");
            opcT = Convert.ToInt32(Console.ReadLine());

            switch (opcT)
            {
                case 1:
                    nombreB = "Margarita";
                    precio = 4.00;
                    codigo = "jkerr2";
                    Console.Clear();
                    Console.WriteLine("Como desea la preparacion de su bebida");
                    preparacionB = Console.ReadLine();
                    break;

                case 2:

                    nombreB = "Moscow Mule";
                    precio = 8.00;
                    codigo = "ksjsy4";
                    Console.Clear();
                    Console.WriteLine("Como desea la preparacion de su bebida");
                    preparacionB = Console.ReadLine();
                    break;

                case 3:
                    nombreB = "Martini";
                    precio = 6.00;
                    codigo = "mqkl3";
                    Console.Clear();
                    Console.WriteLine("Como desea la preparacion de su bebida");
                    preparacionB = Console.ReadLine();
                    break;


                default:
                    Console.Clear();
                    Alcoholicas();
                    break;
            }
        }

        public void Jugos()
        {
            categoria = "Jugos Naturales";
            //bebidas alcoholicas
            Console.WriteLine("Seleccione el tipo de bebida que desea: ");
            Console.WriteLine("1. Jugo de Naranja");
            Console.WriteLine("Precio: $2.00");
            Console.WriteLine("2. Jugo de Melon");
            Console.WriteLine("Precio: $2.50");
            Console.WriteLine("3. Jugo de Coco");
            Console.WriteLine("Precio: $3.00");
            opcT = Convert.ToInt32(Console.ReadLine());

            switch (opcT)
            {
                case 1:
                    nombreB = "Jugo de Naranja";
                    precio = 2.00;
                    codigo = "c001";
                    Console.Clear();
                    Console.WriteLine("Como desea la preparacion de su bebida");
                    preparacionB = Console.ReadLine();
                    break;

                case 2:

                    nombreB = "Jugo de Melon";
                    precio = 2.50;
                    codigo = "f231";
                    Console.Clear();
                    Console.WriteLine("Como desea la preparacion de su bebida");
                    preparacionB = Console.ReadLine();
                    break;

                case 3:
                    nombreB = "Jugo de Coco";
                    precio = 3.00;
                    codigo = "p093";
                    Console.Clear();
                    Console.WriteLine("Como desea la preparacion de su bebida");
                    preparacionB = Console.ReadLine();
                    break;

                default:
                    Console.Clear();
                    Jugos();
                    break;
            }

            
        }

        public void MostrarB()
        {
            Console.Clear();
            Console.WriteLine("-----> RECIBO BEBIDA <----- \n \n");
            Console.WriteLine("***** BEBIDA *****");
            Console.WriteLine("Bebida: " + nombreB);
            Console.WriteLine("Precio: $" + precio);
            Console.WriteLine("Codigo: " + codigo);
            Console.WriteLine("Preparacion: " + preparacionB);
            Console.WriteLine("Categoria: " + categoria);
            Console.WriteLine("\n");
        }
    }

    abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int telefono;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }

    class Cliente : Persona
    {
        public string duiC;
        public int edad;

        public void DatosC()
        {
            if( edad > 17)
            {
                Console.Clear();
                Console.WriteLine("Informacion Cliente: ");
                Console.WriteLine("Nombre: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("Apellido: ");
                Apellido = Console.ReadLine();
                Console.WriteLine("Telefono: ");
                Telefono = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Documento Identificacion: ");
                duiC = Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Informacion Cliente: ");
                Console.WriteLine("Nombre: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("Apellido: ");
                Apellido = Console.ReadLine();
                Console.WriteLine("Telefono: ");
                Console.Clear();
            }
        }

        public void imprimirCliente()
        {
            Console.WriteLine("**** DATOS CLIENTE ****");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido );
            if ( duiC == null )
            {
                Console.WriteLine("Menor de edad.");
            }
            else
            {
                Console.WriteLine("Documento identificacion: " + duiC);
            }
            Console.WriteLine("\n");
            Console.ReadLine();

        }
        
    }

    


}
