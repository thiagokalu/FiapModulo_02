using Fiap.Aula03.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Models
{
     class ContaPoupanca : Conta, IContaInvestimento
    {

        public decimal Rendimentos{ get; set; }

        public ContaPoupanca(
            double numero)
        {
           
            Numero = numero;
        }

        public bool Retirar(decimal valor)
        {
            //Valida se saldo é suficiente
            if (Saldo>= valor)
            {
                Saldo -= valor;
                return true;
            }
            throw new Exception("Saldo insuficiente");
        }

        public decimal CalcularRetornoInvestimento(decimal taxa)
        {
            return Saldo * taxa;
        }
    }
}
