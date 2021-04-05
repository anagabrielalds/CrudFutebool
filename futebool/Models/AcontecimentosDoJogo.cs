using System;
using System.Collections.Generic;
using System.Text;

namespace futebool.Models
{
   public class AcontecimentosDoJogo
    {
        public int Id { get; set; }
        public Jogo Jogo { get; set; }
        public Jogador Jogador { get; set; }
        public Times Time { get; set; }
        public string AcaoOcorrida { get; set; } //cartao, substituição, lesões
        public DateTime TempoDoOcorrido { get; set; }
    }
}
