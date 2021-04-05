using System;
using System.Collections.Generic;
using System.Text;

namespace Futebool.WebApp.Models
{
    public class Tecnico : Pessoa
    {
        public string Descricao { get; set; }
        public string Nacionalidade { get; set; }

        public override string ToString()
        {
            return $"Técnico ({Id}): {Nome} , Nacionalidade: {Nacionalidade}, Descrição: {Descricao}";
        }
        internal void update(Tecnico tecnico)
        {
            this.Nome = tecnico.Nome;
            this.Altura = tecnico.Altura;
            this.Peso = tecnico.Peso;
            this.Descricao = tecnico.Descricao;
            this.Nacionalidade = tecnico.Nacionalidade;
        }
    }
}
