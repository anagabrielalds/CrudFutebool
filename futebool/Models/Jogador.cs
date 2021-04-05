using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace futebool.Models
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
    }
}
