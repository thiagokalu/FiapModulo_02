using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoExercicioProfessor.Models
{
    class Bacharelado : Formacao
    {
        //Propriedade

        public string ProjetoConclusao { get; set; }
        public int CargaHorariaEstagio { get; set; }
        // construtor
        // 

        public Bacharelado(string nome, int cargaHoraria) : base (nome)
        {
            CargaHorariaEstagio = cargaHoraria;
        }

        //Métodos

        public override decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 600 * CargaHorariaEstagio * 12;
        }
        public decimal CalcularMensalidade(decimal desconto)
        {
            return Mensalidade = CalcularMensalidade() - desconto;
        }
        protected override void DefinirDuracao()
        {
            if(Nome.ToLower().Contains("engenharia"))
            {
                Duracao = 60;
            }
            else
            {
                Duracao = 48;
            }
               
         }
        public override string ToString()
        {
            return base.ToString() + $"Projeto: {ProjetoConclusao}, Carga horaria estagio: {CargaHorariaEstagio}";
        }
    }
}
