using Aula05.Exercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;


//Classe que captura os dados -> classe que cadastra no banco. 
namespace Aula05.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui vamos criar a lista de alunos::
            var lista = new List<Aluno>();
            do
            {
                //Ler os dados do aluno
                Console.WriteLine("Digite o nome do aluno:");
                var nome = Console.ReadLine();

                Console.WriteLine("Digite a nota do aluno:");
                var nota = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o genero do aluno");
                //Transformando uma string em um valor do Enum, (genero)
                Genero genero = (Genero)Enum.Parse(typeof(Genero), Console.ReadLine(), true);

                //Instanciar o aluno com os valores
                var aluno = new Aluno()
                {        
                    Nome = nome,
                    Nota = nota,
                    Genero = genero
                };
                //Adicionar o objeto aluno na lista
                lista.Add(aluno);
                Console.WriteLine("Deseja adicionar mais um aluno?");
            } while (bool.Parse(Console.ReadLine()));
            //percorrer a lista e exibir o nome dos alunos
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].Nome);
            }
            float somaNotas = 0;
            foreach(var item in lista)
            {
                Console.WriteLine(item.Nome);
                somaNotas += item.Nota;
            }
            //exibir o total de alunos cadastrados

            Console.WriteLine($"O total de alunos é: {lista.Count}");

            //exibir a média geral das notas
            Console.WriteLine($"A media geral das notas é: {somaNotas / lista.Count}");
            //Outra forma
            Console.WriteLine($"A media das notas é: {lista.Average(a => a.Nota)}");
            //exibir a porcentagem por genero 
            Console.WriteLine($"A porcentagem de alunas é {(float) lista.Count(a => a.Genero == Genero.Feminino) / lista.Count}%");
            Console.WriteLine($"A porcentagem de alunos é {(float)lista.Count(a => a.Genero == Genero.Masculino) / lista.Count}%");
            Console.WriteLine($"A porcentagem de alunos que se identificam como outros é {(float) lista.Count(a => a.Genero == Genero.Outros) / lista.Count}%");
            
            int opcao;
            do
            {
                Console.WriteLine("Digite: \n1-Exibir o nome e médias \n2-Alunos acima de 6 \n3-Aluno por Genero\n0-Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        foreach (var item in lista)
                        {
                            Console.WriteLine($"Nome: {item.Nome}, Média: {item.Nota} ");
                        }
                        break;
                    case 2:
                        var listaFiltrada = lista.Where(o => o.Nota > 6).ToList();
                        foreach(var item in listaFiltrada)
                        {
                            Console.WriteLine($"Nome: {item.Nome}, Nota: {item.Nota}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite o genero para pesquisa:");
                        Genero genero = (Genero) Enum.Parse(typeof(Genero), Console.ReadLine(), true);
                        listaFiltrada = lista.Where(o => o.Genero == genero).ToList();
                        foreach (var item in listaFiltrada)
                        {
                            Console.WriteLine($"Nome: {item.Nome}");
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!!");
                        break;
                }

            } while (opcao != 0);
        }//main
    }//classe
}//namespace
