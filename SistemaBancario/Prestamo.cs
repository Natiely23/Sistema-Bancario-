using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class Prestamo
    {
        public static double Tasa = 0.10;
        public static int Numeroprestamo { get; set; }
        public static int Montoinicial = 5000;
        public static double balance;
        public static double balance2 { get; set; }

        public static void MenuPrestamo()
        {
            bool seguir = true;
            int op;
            Console.WriteLine("1- Solicitud ");
            Console.WriteLine("2- Pago de prestamos ");
            Console.WriteLine("3- Salir ");
            Console.WriteLine("ingrese el numero para elegir la opcion: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    //SOLICITUD
                    Solicitud();
                    break;
                case 2:
                    // PRESTAMOS
                    pago();
                    break;
                case 3:
                    seguir = false;
                    break;
                default:
                    break;
            } while (seguir) ;

        }
        public static void Solicitud()
        {

            Console.WriteLine("---------SOLICITUD DE PRESTEMO-----------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Digite el numero del prestamo");
            Numeroprestamo = int.Parse(Console.ReadLine());
            Console.Write("Su monto inicial es: " + Montoinicial);
            balance = Montoinicial - Tasa;
            Console.WriteLine(" Menos la tasa que es 0.10% " + balance);


            Console.WriteLine();
            Console.WriteLine("SOLICITUD APROBADA.... ");
            Console.ReadKey();
            Console.WriteLine("*********************************************");
            Console.WriteLine("PRECIONE ENTER PARA VOLVER AL MENU.... ");
            MenuPrestamo();
        }

        public static void pago()
        {
            int paga;
            Console.WriteLine("Ingrese el pago");
            paga = int.Parse(Console.ReadLine());
            if (paga < balance)
            {
                balance2 = balance - paga;
                Console.WriteLine("A ustedes le queda " + balance2);

            }
            else
            {
                Console.WriteLine(" Opcion incorrecta ");
               
            }
            
        }
    }
}
