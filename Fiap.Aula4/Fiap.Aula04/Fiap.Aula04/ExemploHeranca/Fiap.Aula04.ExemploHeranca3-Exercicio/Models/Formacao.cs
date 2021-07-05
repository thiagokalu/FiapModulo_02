using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.ExemploHeranca3_Exercicio.Models
{
    public class Formacao
    {
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public decimal Mensalidade { get; set; }
        public Instituicao Instituicao { get; set; }
        public bool Bacharelado { get; set; }
        public bool Tecnologo { get; set; }

        public Formacao(string nome)
        {
            Nome = nome;
        }
        public float CalcularMedia(float nota1, float nota2)
        {
            return (nota1 + nota2) / 2;
        }
        public float CalcularMedia(float nota1, float nota2, float nota3)
        {
            if (nota1 > nota3 && nota2 > nota3)
            {
                return CalcularMedia(nota1, nota2);

            }
            else if (nota1 > nota2 && nota2 < nota3)
            {
                return CalcularMedia(nota1, nota3);
            }
            else
            {
                return CalcularMedia(nota2, nota3);
            }
        }
        public void DefinirDuracao()
        {
            if (Tecnologo)
            {
                Duracao = 24;
            }
            else if (Bacharelado)
            {
                if (Nome.ToLower().Contains("engenharia"))
                {
                    Duracao = 60;
                }
                else
                {
                    Duracao = 48;
                }
            }
            else
            {
                Duracao = 48;
            }
        }
        public virtual decimal CalcularMensalidade()
        {
            DefinirDuracao();
            return Mensalidade = Duracao * 400;
        }
    }
}

