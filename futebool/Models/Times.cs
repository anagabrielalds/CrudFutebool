using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace futebool.Models
{
    public class Times
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Mascote { get; set; }
        public string Brasão { get; set; }
        public string Serie { get; set; }
        [Required]
        public Campo Campo { get; set; }
        [Required]
        public Tecnico Tecnico { get; set; }
        public int Derrotas { get; set; }
        public int Vitorias { get; set; }
        public int TotalGols { get; set; }

        public override string ToString()
        {
            return $"Time ({Id}): {Nome} , Tecnico: {Tecnico}, Campo: {Campo}, Mascote: {Mascote}";
        }
    }
}
