using ExemploHeranca3.Models;
using System;

namespace ExemploHeranca3
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar um produto e eletronico
            var produto = new Produto(1, "Produto1");

            var eletronico = new Eletronico(1, "Eletronico2")
            {
                Garantia = true,
                Preco = 100
            };

            var livro = new Livro(3, "harry potter", "JK Rowling")
            {
                Preco = 40
            };

            var arroz = new Perecivel(4, "Arroz", new DateTime(2022, 12, 25));


            Console.WriteLine($"O valor com desconto é {livro.CalcularDesconto(20)}");

            Console.WriteLine($"O valor da garantia estendida é {eletronico.CalcularGarantiaEstendida()}");


        }
    }
}
