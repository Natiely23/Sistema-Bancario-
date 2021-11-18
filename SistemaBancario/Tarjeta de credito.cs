using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class Tarjeta_de_credito
    {
        public static int limite = 15000;
        public static int Numerocredito { get; set; }
        public static int consumo { get; set; }
        public static int disponible { get; set; }
        public static int pago { get; set; }

        public static void Menucredito()
        {
            bool seguir = true;
            int op;
            Console.WriteLine("1- Expedicion  ");
            Console.WriteLine("2- Consumos  ");
            Console.WriteLine("3- Pagos  ");
            Console.WriteLine("4- Salir ");
            Console.WriteLine("ingrese el numero para elegir la opcion: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    //Expedicion 
                    Expedicion();
                    break;
                case 2:
                    // Consumos 
                    Consumos();
                    break;
                case 3:
                    // pagos 
                    pago1();
                    break;
                case 4:
                    seguir = false;
                    break;
                default:
                    break;
            } while (seguir) ;

        }
        public static void Expedicion()
        {
            Console.WriteLine("TARJETAS DE CREDITO");
            Console.WriteLine("----------------------------");
            Console.Write("Ingrese el numero de tarjeta: ");
            Numerocredito = int.Parse(Console.ReadLine());
            Console.WriteLine("SU LIMITE EN LA TARJETA ES DE " + limite);
            Console.WriteLine("----------------------------");
            Console.WriteLine("------------------------TARJETAS CREADA EXITOSAMENTE------------------------");
            Menucredito();
        }


        public static void Consumos()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad a consumir");
            consumo = int.Parse(Console.ReadLine());
            if (consumo <= limite)
            {
                disponible = consumo - limite;
                Console.WriteLine("Su balance disponible es " + disponible);
                Menucredito();
            }
            else
            {
                Console.WriteLine("No tiene esa cantidad, ingrese otra ");
                Menucredito();
            }
        }

        public static void pago1()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cantida a pagar");
            pago = int.Parse(Console.ReadLine());
            if (disponible >= limite)
            {
                disponible = disponible + pago;
                Console.WriteLine("Su balance disponible es " + disponible);
                Menucredito();
            }
            else
            {
            
                disponible = consumo - limite;
                Console.WriteLine("El monto actual disponible es " + disponible);
                Menucredito();
            }

        }
    }
}
