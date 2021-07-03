﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca3.Models
{
    //propriedades

    public class Eletronico : Produto
    {
        public bool Garantia { get; set; }

        public Eletronico(int id, string nome) : base(id,nome)
        {

        }
     public decimal CalcularGarantiaEstendida()
        {
            if (!Garantia)
                return 0;
            return Preco * 10 / 100;

            //return !Garantia ? 0 : Preco * 0.1m;  <- m no final converte para decimal
        }
    }
}
