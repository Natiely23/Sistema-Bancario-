using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class certificado
    {
        public static int Numerocuenta { get; set; }
        public static int Montoinicial { get; set; }
        public static int Tiempoduracion { get; set; }

       public static double interes1;
        public static void MenuCertificado()
        {
            bool seguir = true;
            int op;
            Console.WriteLine("1- Apertura  ");
            Console.WriteLine("2- Consulta de interes ");
            Console.WriteLine("3- Salir ");
            Console.WriteLine("ingrese el numero para elegir la opcion: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    aperturacertificado();
         
                    break;
                case 2:
                    interes();
                    break;
                case 3:
                    Program.Menuprincipal();
                    break;
                default:
                    break;
            } while (seguir) ;

        }

        public static void aperturacertificado()
        {
            Console.Clear();
            Console.WriteLine("CREAR CERTIFICADO FINANCIERO ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            Console.WriteLine("Ingrese el numero de cuenta: ");
            Numerocuenta = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el monto ");
            Montoinicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de tiempo ");
            Tiempoduracion = int.Parse(Console.ReadLine());
            Console.WriteLine("*****************CUENTA CREADA PERFECTAMENTE*******************");
            Console.WriteLine("***********************************");
            Console.WriteLine("PRECIONE ENTER PARA VOLVER AL MENU");
            MenuCertificado();
            Console.Clear();
        }

        public static void interes()
        {
            interes1 = Prestamo.Montoinicial * 0.3 * Tiempoduracion;
            Console.WriteLine("Usted tiene que pagar una tasa de interes: " + interes1);
            Console.WriteLine("***********************************");
            Console.WriteLine("PRECIONE ENTER PARA VOLVER AL MENU");
            MenuCertificado();
            Console.Clear();
        }
    }
}
