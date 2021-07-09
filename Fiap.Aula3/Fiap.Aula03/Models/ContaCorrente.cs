using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Models
{
     class ContaCorrente : Conta
    {
       
        public bool Especial { get; set; }
        public decimal Limite { get; set; }
        public Cliente Cliente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public double Juros { get; set; }
        public ContaCorrente(
            Cliente cliente,
            ContaPoupanca poupanca,
            double numero,         
            bool especial
            )
        {
            Cliente = cliente;
            ContaPoupanca = poupanca;
            Numero = numero;
            Especial = especial;
   
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
                throw new Exception("Saldo Insuficiente");

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
    

