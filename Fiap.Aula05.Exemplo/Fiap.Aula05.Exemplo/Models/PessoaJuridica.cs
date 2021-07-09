using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula05.Exemplo.Models
{
     class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }

        public override void CadastrarEndereco(string endereco)
        {
            Console.WriteLine("Cadastrando pj..");
            Endereco = endereco;
        }
    }
}
