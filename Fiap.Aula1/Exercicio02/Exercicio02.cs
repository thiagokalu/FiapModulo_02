using System;

namespace Exercicio02
{
    class Exercicio02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Salário");
            double salarioFixo =  double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as vendas totais");
    
            double vendas = double.Parse(Console.ReadLine());
            double totalAReceber;
            if(vendas>= 1500)
            {
             totalAReceber = salarioFixo + (vendas -1500)* 0.1 + 75;

            }
            else
            {
                totalAReceber = salarioFixo + vendas * 0.05;
            }

            Console.WriteLine("O total a receber é R$ " + totalAReceber);
        }
    }
}




//Console.WriteLine("Cálculo de comissão de Vendas.");

//double salario = 1500;
//double comissao;
//double venda;

//Console.WriteLine("Informe o valor final da venda:");
//venda = double.Parse(Console.ReadLine());

//if (venda <= 1500)
//{
//    comissao = venda * 0.05;
//    Console.WriteLine($"A comissão sobre a venda foi de R$ {comissao}");
//    comissao = salario + (venda * 0.05);
//    Console.WriteLine($"O Salário final será de R$ {comissao}");
//}
//else
//{
//    comissao = 75 + ((venda - 1500) * 0.1);
//    Console.WriteLine($"A comissão sobre a venda foi de R$ {comissao}");
//    comissao = salario + comissao;
//    Console.WriteLine($"O Salário final será de R$ {comissao}");
//}