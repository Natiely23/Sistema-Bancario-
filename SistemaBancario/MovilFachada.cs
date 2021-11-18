using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class MovilFachada
    {

        public static AtributoAhorro atributo = new AtributoAhorro();
        public static double balance;
        public static int Numerocuenta { get; set; }
        public static void MenuMovil()
        {
            bool seguir = true;
            int op;
            Console.WriteLine("1- Cuentas de ahorro");
            Console.WriteLine("2- Prestamos ");
            Console.WriteLine("3- Certificados Financieros");
            Console.WriteLine("4- SALIR ");
            Console.WriteLine("ingrese el numero para elegir la opcion: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    //Cuentas de ahorro
                    Console.Clear();
                    Console.WriteLine("1- Consulta  ");
                    CuentaAhorro.consulta();
                    break;
                case 2:
                    // Prestamos
                    Console.Clear();
                    Console.WriteLine("2- Pago de prestamos  ");
                    Prestamo.pago();
                    break;
                case 3:
                    // Certificados Financieros
                    Console.Clear();
                    Console.WriteLine("3- Certificados Financieros  ");
                    consultainteres();
                    break;
                case 4:
                    Program.Menuprincipal();
                    break;
                default:
                    break;
            } while (seguir);

        }
      public static void consultainteres()
      {
            Console.WriteLine("Usted tiene que pagar una tasa de interes: " + certificado.interes1);
      }

    }
}
