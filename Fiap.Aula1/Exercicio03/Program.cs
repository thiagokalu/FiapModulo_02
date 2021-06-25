using System;

namespace Exercicio03
{
    class Exercicio03


        //Uma faculdade possui turmas A e B de um curso. Crie um programa para ler o número de alunos existentes no curso e,
        // após isto, ler a turma que o aluno pertence a as notas destes alunos. Calcule e escreva a média aritmética das notas do curso 
        // e das turmas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de alunos");
            int qtd = int.Parse(Console.ReadLine());

            float totalNotasA = 0;
            float totalNotasB = 0;
            int totalAlunosA = 0;
            int totalAlunosB = 0;
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite a turma (a ou b)");
                string turma = Console.ReadLine();
                Console.WriteLine("digite a nota");
                float nota = float.Parse(Console.ReadLine());

                switch (turma)
                {
                    case "a":
                        totalAlunosA++;
                        totalNotasA += nota;
                        break;
                    case "b":
                        totalAlunosB++;
                        totalNotasB += nota;
                        break;
                    default:
                        Console.WriteLine("Curso inválido");
                        i--;
                        break;
                } 

            }
            Console.WriteLine($"A média da turma A é {totalNotasA/totalAlunosA}");
            Console.WriteLine($"A média da turma B é {totalNotasB / totalAlunosB}");
            Console.WriteLine($"A média do curso é {(totalNotasA + totalNotasB)/(totalAlunosA/totalAlunosB)}");

        }
    }
}
