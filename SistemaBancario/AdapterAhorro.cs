using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
   class AdapterAhorro: IretiroVerifica
    {
        
        public int balance { get; set; }
        public int retiro { get; set; }

        public void validar()
        {
            balance = Convert.ToInt32(CuentaAhorro.retiro * 0.40);
            if (CuentaAhorro.balance < balance)
            {
                Console.WriteLine("Saldo insuficiente, no pude retirar mas del 40% de su balance,+" +
                    " intente introducir otra cantidad");
             
            }
            else
            {
                CuentaAhorro.Retiro();

            }
        }
    }
}
