using System;
using System.Collections.Generic;
using System.Text;

namespace futebool.Models
{
    public class Tecnico : Pessoa
    {
        public string Descricao { get; set; }
        public string Nacionalidade { get; set; }

        public override string ToString()
        {
            return $"Técnico ({Id}): {Nome} , Nacionalidade: {Nacionalidade}, Descrição: {Descricao}";
        }
    }
}
