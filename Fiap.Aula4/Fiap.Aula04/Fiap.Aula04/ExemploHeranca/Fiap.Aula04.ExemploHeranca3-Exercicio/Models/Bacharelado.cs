using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.ExemploHeranca3_Exercicio.Models
{
    public class Bacharelado : Formacao
    {
        public string ProjetoConclusao { get; set; }
        public int CargaHorariaEstagio { get; set; }

        public Bacharelado(string nome, int carga) : base(nome)
        {
            CargaHorariaEstagio = carga;
        }
        public override decimal CalcularMensalidade()
        {
            DefinirDuracao();
            return Mensalidade = Duracao * 600 +  CargaHorariaEstagio * 12;
        }
        public decimal CalcularMensalidade(decimal desconto)
        {
            return CalcularMensalidade() - (Mensalidade * desconto) / 100;
        }
    }
}