using System;
using System.Collections.Generic;
using System.Text;

namespace futebool.Models
{
    public class Campo
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Referencia { get; set; }
        public string NomeGramado { get; set; }
        public string Endereco { get; internal set; }
        public string Estado { get; internal set; }

        public override string ToString()
        {
            return $"Campo ({Id}): Nome: {NomeGramado}, Referencia: {Referencia}, Endereço: {Endereco} - {Estado}, CEP: {CEP}";
        }
    }
}
