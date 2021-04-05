using Futebool.WebApp.Models;
using Futebool.WebApp.Models.dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Repositories
{
    public class AcontecimentosDoJogoRepository
    {
        private readonly FutebolContext contexto;
        protected readonly DbSet<AcontecimentosDoJogo> dbSet;

        public AcontecimentosDoJogoRepository(FutebolContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<AcontecimentosDoJogo>();
        }

        public IList<Times> ListarTimes()
        {
            var time = contexto.Times.ToList();
            return time;
        }
        public IList<Jogador> ListarJogadores()
        {
            return contexto.Jogadores.ToList();
        }
        public IList<Jogo> ListarJogos()
        {
            return contexto.Jogos.
                Include(j => j.TimeCasa)
                .Include(j => j.TimeVisitante)
                .Include(j => j.Campo)
                .ToList();
        }

        public IList<AcontecimentosDoJogo> ListaAcontecimento()
        {
            return contexto.AcontecimentosDosJogos.
                Include(a => a.Jogador)
                .Include(a => a.Jogo)
                .ThenInclude(f => f.TimeCasa)
                .Include(f => f.Jogo.TimeVisitante)
                .Include(a => a.Time)
                .ToList();
        }

        public bool CadastroAcontecimento(CadastroAcontecimentos acontecimentos)
        {
            if (acontecimentos == null)
            {
                return false;
                throw new ArgumentNullException("cadastroJogo");
            }

            var jogo = contexto.Jogos.Where(a => a.Id == acontecimentos.Acontecimento.Jogo.Id).FirstOrDefault();
            var time = contexto.Times.Where(a => a.Id == acontecimentos.Acontecimento.Time.Id).FirstOrDefault();
            var jogador = contexto.Jogadores.Where(a => a.Id == acontecimentos.Acontecimento.Jogador.Id).FirstOrDefault();


            acontecimentos.Acontecimento.Time = time;
            acontecimentos.Acontecimento.Jogo = jogo;
            acontecimentos.Acontecimento. Jogador = jogador;
            
            dbSet.Add(acontecimentos.Acontecimento);
            contexto.SaveChanges();
            return true;
        }
       
        public CadastroAcontecimentos GetAcontecimentos(int? id)
        {
            var acontecimentos = new CadastroAcontecimentos();
            var busca = contexto.AcontecimentosDosJogos.Where(a => a.Id == id)
                .Include(f => f.Time)
                .Include(f => f.Jogador)
                .Include(f => f.Jogo).FirstOrDefault();
            acontecimentos.Acontecimento = busca;
            acontecimentos.ListaJogadores = ListarJogadores();
            acontecimentos.ListaJogos = ListarJogos();
            acontecimentos.ListaTimes = ListarTimes();
            return acontecimentos;
        }

        
        public AcontecimentosDoJogo AtualizarAcontecimento(AcontecimentosDoJogo acontecimentos)
        {
            var busca = dbSet.Where(a => a.Id == acontecimentos.Id).First();

            var jogo = contexto.Jogos.Where(a => a.Id == acontecimentos.Jogo.Id).FirstOrDefault();
            var time = contexto.Times.Where(a => a.Id == acontecimentos.Time.Id).FirstOrDefault();
            var jogador = contexto.Jogadores.Where(a => a.Id == acontecimentos.Jogador.Id).FirstOrDefault();

            if (busca == null)
            {
                throw new ArgumentNullException("cadastro");
            }
            acontecimentos.Jogador = jogador;
            acontecimentos.Time = time;
            acontecimentos.Jogo = jogo;

            busca.update(acontecimentos);
            contexto.SaveChanges();

            return busca;
        }

        public bool DeletarAcontecimento(int? id)
        {
            if (id == null)
            {
                return false;
                throw new ArgumentNullException("Id");

            }
            var busca = contexto.AcontecimentosDosJogos.Where(a => a.Id == id).FirstOrDefault();
            dbSet.Remove(busca);
            contexto.SaveChanges();
            return true;
        }

    }
}
