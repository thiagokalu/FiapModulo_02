using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula05.Exemplo.Models
{
    //Classe abstrata -> não pode ser instanciada e pode definir métodos abstratos (sem implementação) 
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get;set;}

        //Métodos
        public abstract void CadastrarEndereco(string endereco);
        public void InformarNome(string nome)
        {
            Console.WriteLine("Informe o nome");
            Nome = Console.ReadLine();
        }
    }
}
