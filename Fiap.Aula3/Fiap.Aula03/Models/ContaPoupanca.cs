using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Models
{
    public class ContaPoupanca
    {
        public decimal Saldo { get; private set; }
        public double Numero { get; set; }
        public decimal Rendimentos{ get; set; }
        public bool Depositar(decimal valor) 
        {         //Valida se é um deposito posivito
            if (valor > 0)
            {
                Saldo += valor;
                return true;

            }
            return false;
        }
        public bool Retirar(decimal valor)
        {
            //Valida se saldo é suficiente
            if (Saldo>= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
