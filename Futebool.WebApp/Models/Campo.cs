using System;
using System.Collections.Generic;
using System.Text;

namespace Futebool.WebApp.Models
{
    public class Campo
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Referencia { get; set; }
        public string NomeGramado { get; set; }
        public string Endereco { get; set; }
        public string Estado { get;set; }

        public override string ToString()
        {
            return $"Campo ({Id}): Nome: {NomeGramado}, Referencia: {Referencia}, Endereço: {Endereco} - {Estado}, CEP: {CEP}";
        }
        internal void update(Campo campo)
        {
            this.NomeGramado = campo.NomeGramado;
            this.Referencia = campo.Referencia;
            this.Endereco = campo.Endereco;
            this.Estado = campo.Estado;
            this.CEP = campo.CEP;

        }
    }
}
