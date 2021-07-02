
using Fiap.Aula02.Exemplo.Models;

namespace Fiap.Aula02.Exemplo
{
    public class Produto
    {
        private int _id;

        //Getters e Setters (Propriedades) 
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Fabricante Fabricante { get; set; }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        //Métodos
        //Calcular o valor do produto com desconto
        public decimal CalcularDesconto(decimal porcentagem)
        {
            return Valor - Valor * porcentagem / 100;
        }
        public void Cadastrar()
        {
            System.Console.WriteLine("Produto sendo cadastrado..");
        }
    }
}
