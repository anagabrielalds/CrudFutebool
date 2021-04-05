using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Models.dto
{
    public class CadastroJogador
    {
        

        public Jogador Jogador { get; set; }
        public IList<Times> ListaDeTimes { get; set; }

    }
}
