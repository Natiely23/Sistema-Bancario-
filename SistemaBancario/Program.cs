using System;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Menuprincipal();
        }
       public static void Menuprincipal()
        {

            bool seguir = true;
            int op;

            Console.WriteLine("1- LA APP DE ESCRITORIO ");
            Console.WriteLine("2- LA APP MOVIL. ");
            Console.WriteLine("ingrese el numero para elegir la opcion: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    do
                    {
                        int n;
                        Console.Clear();

                        Console.WriteLine("---------------SISTEMA BANCARIO------------");
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("BIENVENIDO");
                        Console.WriteLine();
                        Console.WriteLine("1- Cuentas de ahorro");
                        Console.WriteLine("2- Prestamos ");
                        Console.WriteLine("3- Tarjetas de credito");
                        Console.WriteLine("4- Certificados Financieros");
                        Console.WriteLine("5- SALIR ");
                        Console.WriteLine();
                        Console.WriteLine("ingrese el numero para elegir la opcion: ");
                        n = int.Parse(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                                Console.Clear();
                                //CUENTA DE AHORRO
                                CuentaAhorro.Menu();
                                break;
                            case 2:
                                Console.Clear();
                                //PRESTAMOS
                                Prestamo.MenuPrestamo();
                                break;
                            case 3:
                                Console.Clear();
                                // TARJETAS DE CREDITOS
                                Tarjeta_de_credito.Menucredito();
                                break;
                            case 4:
                                Console.Clear();
                                // CERTIFICADOS FINANCIEROS 
                                certificado.MenuCertificado();
                                break;
                            case 5:
                                seguir = false;
                                break;
                            default:
                                break;
                        }

                    } while (seguir);
                    break;
                case 2:
                    //LA APP MOVIL 
                    do
                    {
                        int n;
                        Console.Clear();

                        Console.WriteLine("---------------SISTEMA BANCARIO------------");
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("BIENVENIDO");
                        Console.WriteLine();
                        Console.WriteLine("1- Cuentas de ahorro");
                        Console.WriteLine("2- Prestamos ");
                        Console.WriteLine("3- Certificados Financieros");
                        Console.WriteLine("4- SALIR ");
                        Console.WriteLine();
                        Console.WriteLine("ingrese el numero para elegir la opcion: ");
                        n = int.Parse(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                                Console.Clear();
                                //CUENTA DE AHORRO
                                MovilFachada.MenuMovil();
                                break;
                            case 2:
                                Console.Clear();
                                //PRESTAMOS
                                MovilFachada.MenuMovil();
                                break;
                            case 3:
                                Console.Clear();
                                // CERTIFICADOS FINANCIEROS 
                                MovilFachada.MenuMovil();
                                break;  
                            case 4:
                                seguir = false;
                                break;
                            default:
                                break;
                        }

                    } while (seguir);
                    break;
                default:
                    break;
            }
        }
    }
}
