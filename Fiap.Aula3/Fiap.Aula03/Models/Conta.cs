using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Models
{
    abstract class Conta
    {
        public decimal Saldo { get; protected set; }
        public double Numero { get; set; }
        public bool Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }
            return false;
        }

    }
}

