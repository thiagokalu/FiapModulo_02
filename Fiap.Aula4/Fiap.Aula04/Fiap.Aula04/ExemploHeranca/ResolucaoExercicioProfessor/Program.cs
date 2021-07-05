using ResolucaoExercicioProfessor.Models;
using System;

namespace ResolucaoExercicioProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            // ler o tipo de formação criada
            Console.WriteLine("Escolha 1-Tecnologo ou 2-Bacharelado");
            int opFormacao = int.Parse(Console.ReadLine());

            //ler o nome
            Console.WriteLine("Digite o nome da formacao");
            string nomeFormacao = Console.ReadLine();

            //Definir a variavel que armazena o objeto da formacao 
            Formacao formacao;
              
            //ler o trabalho conclusao e carga horaria estágio, se for bacharelado 
            if(opFormacao ==2)
            {
                Console.WriteLine("Digite o titulo do TCC");
                string tcc = Console.ReadLine();
                Console.WriteLine( "Digite a carga horária do estágio");
                int cargaHoraria = int.Parse(Console.ReadLine());
                //Instanciar a classe
                formacao = new Bacharelado(nomeFormacao, cargaHoraria)
                {
                    ProjetoConclusao = tcc
                };
            }
            else
            {
                formacao = new Tecnologo(nomeFormacao);
            }

            //Exibir os dados do objeto

            Console.WriteLine(formacao);
            //Chamar os metodos, calcular a mensalidade, media e sair
            int opcao;
            do
            {
                Console.WriteLine("Digite 1-Calcular mensalidade \n2-Calcular Média \n0-Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"A mensalidade é {formacao.CalcularMensalidade()}");
                        break;
                    case 2:
                        //ler as 3 notas e exibir a media
                        Console.WriteLine("digite a nota 1");
                        float nota1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("digite a nota 2");
                        float nota2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("digite a nota 3");
                        float nota3 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"A média é {formacao.CalcularMedia(nota1, nota2, nota3)}");
                        break;
                    case 0:
                        Console.WriteLine("Finalizando o sistema..");
                        break;
                    default:
                        Console.WriteLine("Opcao Inválida");
                        break;
                }

            } while (opcao != 0);

        }//main
    }//classe
}//namespace
