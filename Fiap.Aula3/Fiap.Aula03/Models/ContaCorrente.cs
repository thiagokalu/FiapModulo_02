using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Models
{
    public class ContaCorrente
    {
        public decimal Saldo { get; private set; }
        public double Numero { get; set; }
        public bool Especial { get; set; }
        public decimal Limite { get; set; }
        public Cliente cliente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public double Juros { get; set; }

        public bool Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }
            return false;
        }
        public bool Retirar(decimal valor)
        {
            if (Especial)
            {
                if (valor <= Saldo + Limite)
                {
                    Saldo -= valor;
                    return true;
                }
            }
            else
            {
                if (valor <= Saldo)
                {
                    Saldo -= valor;
                    return true;
                }
            }
            return false;
        }
        public decimal RetornarSaldoTotal()
        {
            if (Especial)
                return Saldo + Limite;
            else
                return Saldo;

            // return Especial? Saldo + Limite : Saldo;  // <- este é um exemplo de ternário
            /*
             if ((Especial && valor <= Saldo + Limite) || (valor <= Saldo))
        {
            Saldo -= valor;
            return true;
            }
            return false
             
             
             */
        }
        public bool TransferirParaPoupanca(decimal valor)
        {
            //retira da conta corrente, se conseguir adiciona na poupaça
            //Chama ometodo e valida se foi possivel
            if(Retirar(valor))
            {
                ContaPoupanca.Depositar(valor);
                return true;
            }
            return false;

        }
        public decimal CalcularTaxaJuros(int dias)
        {
            if (Saldo < 0)
                return dias * Convert.ToDecimal(Juros) * Saldo * -1;
            return 0;
        }

   }
}    
    

