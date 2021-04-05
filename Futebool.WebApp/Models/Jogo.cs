using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Futebool.WebApp.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        [Required]
        public Times TimeCasa { get; set; }
        [Required]
        public Times TimeVisitante { get; set; }
        [Required]
        public Campo Campo { get; set; }
        public DateTime DataHoraJogo { get; set; }
        public Double Acrescimo { get; set; }
        public int PlacarCasa { get; set; }
        public int PlacarVisitante { get; set; }

        public override string ToString()
        {
            return $"Jogo ({Id}): Time da Casa: {TimeCasa} \n \n" +
                $" Time Visitante: {TimeVisitante} \n" +
                $"\n Campo: {Campo} \n" ;
        }
        internal void update(Jogo jogo)
        {
            this.TimeCasa = jogo.TimeCasa;
            this.TimeVisitante = jogo.TimeVisitante;
            this.Campo = jogo.Campo;
            this.DataHoraJogo = jogo.DataHoraJogo;
            this.Acrescimo = jogo.Acrescimo ;
            this.PlacarCasa = jogo.PlacarCasa;
            this.PlacarVisitante = jogo.PlacarVisitante;
        }
    }
}
