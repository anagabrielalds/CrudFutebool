using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Models.dto
{
    public class CadastroAcontecimentos
    {
        public IList<Jogo> ListaJogos { get; set; }
        public IList<Jogador> ListaJogadores { get; set; }
        public IList<Times> ListaTimes { get; set; }
        public AcontecimentosDoJogo Acontecimento { get; set; }
    }
}
