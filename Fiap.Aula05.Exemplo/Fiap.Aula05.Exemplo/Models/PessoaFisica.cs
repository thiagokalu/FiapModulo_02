﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula05.Exemplo.Models
{
   public  class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        public Genero Sexo { get; set; 
        }
        public override void CadastrarEndereco(string endereco)
        {
            Endereco = endereco;
        }
    }
}
