using System;

namespace Fiap.Aula01.Exercicios
{
    class Exercicio01
    {
        static void Main(string[] args) {
            //{
            //        O custo de um carro novo ao consumidor é a soma do custo de fabrica,
            //        com a porcentagem do distribuidor e dos impostos (aplicados ao custo de fabrica)
            //        Supondo que o percentual do distribuidor seja de 29% e os impostos
            //        de 46%, escrever um algoritmo para ler o custo de fabrica de um carro, calcular e
            //        escrever o custo final ao consumidor. 


            Console.WriteLine("Digite o valor");
            double custoFabrica = double.Parse(Console.ReadLine());
  
            double porcentagemDistribuidor = custoFabrica * 0.29;
            double impostos = custoFabrica * 0.46;
            double valorFinal = custoFabrica + porcentagemDistribuidor + impostos;

            Console.WriteLine($"O valor final é {valorFinal}");

       }
    }
}
