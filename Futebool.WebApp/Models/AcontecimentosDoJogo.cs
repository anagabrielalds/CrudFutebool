using System;
using System.Collections.Generic;
using System.Text;

namespace Futebool.WebApp.Models
{
   public class AcontecimentosDoJogo
    {
        public int Id { get; set; }
        public Jogo Jogo { get; set; }
        public Jogador Jogador { get; set; }
        public Times Time { get; set; }
        public string AcaoOcorrida { get; set; } //cartao, substituição, lesões
        public DateTime TempoDoOcorrido { get; set; }

        internal void update(AcontecimentosDoJogo acontecimentos)
        {
            this.Jogo = acontecimentos.Jogo;
            this.Jogador = acontecimentos.Jogador;
            this.Time = acontecimentos.Time;
            this.AcaoOcorrida = acontecimentos.AcaoOcorrida;
            this.TempoDoOcorrido = acontecimentos.TempoDoOcorrido;
        }
    }
}
