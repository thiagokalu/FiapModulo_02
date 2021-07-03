using Fiap.Aula03.Models;
using System;

namespace Fiap.Aula03
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ler os dados do cliente (nome, cpf, telefone)
            Console.WriteLine("Digite o nome do cliente");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf do cliente");
            var cpf = Console.ReadLine();
            Console.WriteLine("Digite o telefone do cliente");
            var telefone = Console.ReadLine();

            //Ler os dados da conta poupança (numero)
            Console.WriteLine("Digite o numero da conta poupança");
            var numeroPoupanca = double.Parse(Console.ReadLine());

            //Ler os dados da conta corrente (numero, especial (se sim, juros e limite)
            Console.WriteLine("Digite o numero da conta corrente"); 
            var numeroCc = double.Parse(Console.ReadLine());

            Console.WriteLine("A conta corrente é especial?");
            var especial = bool.Parse(Console.ReadLine());
            //passa o nome do parâmetro e o valor do método
            //instanciar os objetos e atribuir os valores aos seus atributos (propriedades)
            //var cliente = new Cliente(nome, cpf, telefone)
            var cliente = new Cliente(nome:nome, telefone: telefone, cpf:cpf );
            //cliente.Nome = nome;
            //cliente.Telefone = telefone;
            //cliente.CPF = cpf;

            var cp = new ContaPoupanca(numeroPoupanca);
            cp.Numero = numeroPoupanca;

            var cc = new ContaCorrente(cliente, cp, numeroCc, especial);
            //cc.cliente = cliente;
            //cc.ContaPoupanca = cp;
            //cc.Numero = numeroCc;
            //cc.Especial = especial;
            if(especial)
            {
                Console.WriteLine("Digite o limite");
                var limite = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite os juros");
                var juros = double.Parse(Console.ReadLine());
            cc.Limite = limite;
            cc.Juros = juros;

            }
            // Variavel que armazena a opcção do menu
            int opcao;

            do
            {
                //menu
                Console.WriteLine("1 - depositar \n2 - Retirar \n3 - Transferir \n4 -" +
                    "Calcular o valor da taxa de Juros \n0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor para depósito");
                        var valor = decimal.Parse(Console.ReadLine());
                        cc.Depositar(valor);
                        Console.WriteLine($"O saldo é {cc.Saldo} e o saldo total é {cc.RetornarSaldoTotal()}");
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor para saque");
                        valor = decimal.Parse(Console.ReadLine());
                        cc.Retirar(valor);
                        Console.WriteLine($"O saldo é {cc.Saldo} e o saldo total é {cc.RetornarSaldoTotal()}");
                        break;
                    case 3:
                        Console.WriteLine("Digite o valor para transferir");
                        valor = decimal.Parse(Console.ReadLine());
                        cc.TransferirParaPoupanca(valor);
                        Console.WriteLine($"O saldo é {cc.Saldo} e o saldo total é {cc.RetornarSaldoTotal()}");
                        Console.WriteLine($"O saldo da poupança é {cc.ContaPoupanca.Saldo}");
                        break;
                    case 4:
                        Console.WriteLine("Digite a quantidade de dias");
                        var dias = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O valor da taxa de juros é {cc.CalcularTaxaJuros(dias)}");
                        break;
                    case 0:
                        Console.WriteLine("Finalizando o Sistema..");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while     (opcao != 0);
                
            }
        }
    }

