using System;

namespace Fiap.Aula1.Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler uma string
            //cw -> tab tab
            Console.WriteLine("Digite o nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade");
            //Leer um número usando o parse para converter para inteiro
            int idade = int.Parse(Console.ReadLine());
            //Exibir um Dado
            Console.WriteLine("O nome digitado é " + nome + " e a idade é " + idade);
        }

    }
}
