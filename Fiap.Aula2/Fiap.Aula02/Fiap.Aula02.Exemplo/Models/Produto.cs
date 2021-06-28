
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
    }
}
