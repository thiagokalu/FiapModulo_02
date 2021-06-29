using Fiap.Aula02.Exercicio01.Models;
using System;

namespace Fiap.Aula02.Exercicio01
{
    class Exercicio
    {
        static void Main(string[] args)
        {
           
           //Instanciando objetos

            Aviao aviao = new Aviao();
            Carro carro = new Carro();
            Cor cor = new Cor();
            Lancha lancha = new Lancha();

            Console.WriteLine("digite o modelo do carro");
            carro.Modelo = Console.ReadLine();
            
            Console.WriteLine("digite o ano do carro");            
            carro.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o comprimento do carro");
            carro.Comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a placa do carro");
            carro.Placa = Console.ReadLine();

            Console.WriteLine("digite o valor do carro");
            carro.Valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Possui ar condicionado?");
            carro.ArCondicionado = bool.Parse(Console.ReadLine());

            Console.WriteLine("digite a cor do carro");
            cor.Nome = Console.ReadLine();

            Console.WriteLine("Digite o R");
            cor.R = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o G");
            cor.G = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o B");
            cor.B = int.Parse(Console.ReadLine());

            //Atribuição do valor ao carro
            carro.Cor = cor;

            Console.WriteLine($"Modelo:{ carro.Modelo}, ano: { carro.Ano}," +
                $"comprimento: {carro.Comprimento}, placa: {carro.Placa}, " +
                $"valor:{carro.Valor}, ar-condicionado: {carro.ArCondicionado}," + 
                $"Cor: { carro.Cor.Nome} ({carro.Cor.R},{carro.Cor.G},{carro.Cor.B}) ");
        }
    }
}
