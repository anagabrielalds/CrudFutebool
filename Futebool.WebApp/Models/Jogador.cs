using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Futebool.WebApp.Models
{
   public class Jogador : Pessoa
    {
        public int NumeroCamisa { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Posicao { get; set; }
        [Required]
        public string  PeDeChute { get; set; }
        [Required]
        public Times Time { get; set; }

        public override string ToString()
        {
            return $"Jogador ({Id}): {Nome} , Status: {Status}, N°_Camisa: {NumeroCamisa}, Posição: {Posicao}, Pé de Chute:  {PeDeChute}";
        }

        internal void update(Jogador jogador)
        {
            this.Nome = jogador.Nome;
            this.NumeroCamisa = jogador.NumeroCamisa;
            this.PeDeChute = jogador.PeDeChute;
            this.Peso = jogador.Peso;
            this.Posicao = jogador.Posicao;
            this.Status = jogador.Status;
            this.Time = jogador.Time;
            this.Altura = jogador.Altura;
        }

    }
}
