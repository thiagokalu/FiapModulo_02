﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoExercicioProfessor.Models
{
     class Formacao
    {
        //atributos
        public string Nome {get; set; }
        public int Duracao { get; set; }
        public decimal Mensalidade { get; set; }
        public Instituicao Instituicao { get; set; }

        //construtor

        public Formacao(string nome)
        {
            Nome = nome;
            DefinirDuracao();
        }
        //Metodos
        protected virtual void DefinirDuracao()
        {
            //Verificar se o objeto é de um tipo específico
            if (GetType() == typeof(Tecnologo))
            {
                Duracao = 24;            
            }
            else if (GetType() == typeof(Bacharelado))
            {
                if (Nome.Contains("engenharia"))
                {
                    Duracao = 60;
                }
                else
                {
                    Duracao = 48;
                }
            }
        }
        public float CalcularMedia(float nota1, float nota2)
        {
            return (nota1 + nota2) / 2;
        }
        public float CalcularMedia(float nota1, float nota2, float nota3)
        {
            return (nota1 > nota3 && nota2 > nota3) ? CalcularMedia(nota1, nota2) :
                (nota1 > nota2 && nota2 < nota3) ? CalcularMedia(nota1, nota3) :
                CalcularMedia(nota2, nota3);
        }
        public virtual decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 400;
        }
        //sobrescrever o metodo toString de object
        public override string ToString()
        {
            return $"Nome: {Nome}, mensalidade: {Mensalidade}, Duracao: {Duracao}";
        }
    }
}
