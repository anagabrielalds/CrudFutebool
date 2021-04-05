using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Models.dto
{
    public class CadastroJogo
    {
        public IList<Times> ListaTimes { get; set; }
        public IList<Campo> Campo { get; set; }
        public Jogo Jogo { get; set; }
    }
}
