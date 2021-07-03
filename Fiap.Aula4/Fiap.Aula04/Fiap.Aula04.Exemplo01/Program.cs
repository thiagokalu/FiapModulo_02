using Fiap.Aula04.Exemplo01.Models;
using System;

namespace Fiap.Aula04.Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exemplo de instanciar um carro utilizando o construtor padrao
            var celta = new Carro("Celta 1.0");
            var gol = new Carro("Gol", 2010);

            Console.WriteLine($"Modelo: { celta.Modelo}, Ano: { celta.Ano}");
            Console.WriteLine($"Modelo: { gol.Modelo}, Ano: { gol.Ano}");
            //Instanciar a moto com o construtor padrão, informando o valor para as propriedades
            var honda = new Moto()
            {
                Cilindrada = 100,
                Passageiros = 2
            };
            Console.Write($"Cilindrada: {honda.Cilindrada}, Passageiros: {honda.Passageiros}");
        }
    }
}
