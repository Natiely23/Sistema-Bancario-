using System;
using System.Collections.Generic;
using System.Text;


namespace SistemaBancario
{

    class CuentaAhorro 
    {

        public static double balance { get; set; }
        public static double balance1 { get; set; }
        public static int retiro { get; set; }
        public static int MONTOINICIAL { get; set; }
        public static int NUMEROCUENTA { get; set; }
        public static AtributoAhorro ahorro1 = new AtributoAhorro();
        public static void Menu()
        {
            bool seguir = true;
            int op;
            Console.WriteLine("1- AHORRO NORMAL ");
            Console.WriteLine("2- SUPER AHORRO ");
            Console.WriteLine("3- SALIR ");
            Console.WriteLine("ingrese el numero para elegir la opcion: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    //AHORRO NORMAL
                    int normal;
                  
                    Console.Clear();
                    Console.WriteLine("1- Apertura ");
                    Console.WriteLine("2- Depositos ");
                    Console.WriteLine("3- Retiros ");
                    Console.WriteLine("4- Consulta  ");
                    Console.WriteLine("ingrese el numero para elegir la opcion: ");
                    normal = int.Parse(Console.ReadLine());
                    switch (normal)
                    {
                        case 1:
                            //APERTURA
                            apertura();
                            break;
                        case 2:
                            //DEPOSITO
                            AtributoAhorro cuenta1 = new AtributoAhorro();
                            NUMEROCUENTA = cuenta1.Numerocuenta;
                            MONTOINICIAL = cuenta1.Montoinicial;
                            CuentaAhorro.Depositar();
                            break;
                        case 3:
                            // RETIROS
                            AdapterAhorro adapterAhorro = new AdapterAhorro();
                            adapterAhorro.validar();
                            break;
                        case 4:
                            // CONSULTA
                            consulta();
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    //SUPER AHORRO
                    int super;
                    Console.Clear();
                    Console.WriteLine("1- Apertura ");
                    Console.WriteLine("2- Depositos ");
                    Console.WriteLine("3- Retiros ");
                    Console.WriteLine("4- Consulta  ");
                    Console.WriteLine("ingrese el numero para elegir la opcion: ");
                    super = int.Parse(Console.ReadLine());
                    switch (super)
                    {
                        case 1:
                            //APERTURA
                            apertura();
                            break;
                        case 2:
                            // DEPOSITO
                            AtributoAhorro cuenta = new AtributoAhorro();
                            NUMEROCUENTA = cuenta.Numerocuenta;
                            MONTOINICIAL = cuenta.Montoinicial;
                            CuentaAhorro.Depositar();
                            
                            break;
                        case 3:
                            // RETIROS
                            AdapterAhorro adapterAhorro = new AdapterAhorro();
                            adapterAhorro.validar();
                            break;
                        case 4:
                            // CONSULTA
                            consulta();
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    seguir = false;
                    Program.Menuprincipal();
                    break;
                default:
                    break;
            } while (seguir) ;
        }

        public static void apertura()
        {

            string mensa;
            
            Console.WriteLine("PRESIONE 0 PARA CONTINUAR..");
            mensa = Console.ReadLine();
            if (mensa == "0")
            {
                Console.Clear();
                Console.WriteLine("CREAR CUENTA ");
                Console.WriteLine("-------------------------------");
                Console.WriteLine();

                Console.Write("Ingrese el numero de cuenta: ");
                ahorro1.Numerocuenta = int.Parse(Console.ReadLine());

                Console.Write("Su monto inicial es: "+ ahorro1.Montoinicial);
                
                Console.WriteLine();
                Console.WriteLine("CUENTA CREADA EXICTOSAMENTE.... ");
                Console.ReadKey();
                Console.WriteLine("PRECIONE 0 PARA VOLVER AL MENU.... ");
                Console.Clear();
                Menu();

            }
            else
            {
                Console.WriteLine("Opcion Incorrecta");
            }

        }
        public static void Depositar()
        {

            int deposito;
            string dinero;
            Console.WriteLine("Usted escojio deposito ");
            Console.WriteLine("Digite N para continuar ");
            dinero = Console.ReadLine();
            if (dinero == "N")
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("MONTO INICIAL: " + MONTOINICIAL);
                Console.WriteLine("Cuanto quiere depositar? ");
                deposito = int.Parse(Console.ReadLine());
                balance = MONTOINICIAL + deposito;
                Console.WriteLine("Su balance es " + balance);
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else
            {
                Console.WriteLine("Datos inmcorrectos");
            }
            
        }
        public static void Retiro()
        {
           
            Console.WriteLine("Cuanto quiere retirar? ");
            retiro = int.Parse(Console.ReadLine());
            if (retiro < balance)
            {
                Console.WriteLine("Su balance es " + balance);
                balance1 = balance - retiro;
                Console.WriteLine("Su balance actual es " + balance1);
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else
            {
                Console.WriteLine("No cuenta con saldo suficiente para hacer un retiro");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            
            
        }
        public static void consulta()
        {

            int cuenta;
            Console.Write("Ingrese el numero de cuenta: ");
            cuenta = int.Parse(Console.ReadLine());
            if (ahorro1.Numerocuenta == cuenta)
            {
                Console.WriteLine("Su balance actual es " + balance1);
                Console.Clear();
                Menu();
            }
            else
            {
                Console.WriteLine("Su numero de cuenta es incorrecto");
                Console.Clear();
                Menu();
            }
            
        }

        
    }
       
         

         
            
        

    
    
}
