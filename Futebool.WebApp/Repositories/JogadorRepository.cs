using Futebool.WebApp.Models;
using Futebool.WebApp.Models.dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Repositories
{
    public class JogadorRepository
    {
        private readonly FutebolContext contexto;
        protected readonly DbSet<Jogador> dbSet;

        public JogadorRepository(FutebolContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<Jogador>();
          
        }

        public IList<Jogador> ListaJogadores()
        {
            // ListaVazia
            var eii = dbSet;
            return dbSet.Include(f => f.Time)
                .ThenInclude(f => f.Campo)
                .Include(j => j.Time.Tecnico)
                .ToList();
        }

        public bool Cadastro(CadastroJogador jogador)
        {
            
            if(jogador == null)
            {
                return false;
                throw new ArgumentNullException("cadastroJogador");
            }
            var time1 = contexto.Times.Where(a => a.Id == jogador.Jogador.Time.Id).FirstOrDefault();
            
            jogador.Jogador.Time = time1;

            dbSet.Add(jogador.Jogador);
            contexto.SaveChanges();

            return true;

        }
        public IList<Times> ListarTimeDeJogador()
        {
            var time = contexto.Times.ToList();
            return time;

        }

        public Jogador GetJogador(int? id)
        {
            var jogador = new Jogador();
            var buscaJogador = contexto.Jogadores.Where(a => a.Id == id).FirstOrDefault();
            jogador = buscaJogador;

            //dbSet.Update(campo);
            return jogador;
        }
        public Jogador atualizarJogador(Jogador jogador)
        {
            var busca = dbSet.Where(a => a.Id == jogador.Id).Include(f => f.Time).ThenInclude(f=> f.Campo).FirstOrDefault();


            if (busca == null)
            {
                throw new ArgumentNullException("cadastro");
            }
            busca.update(jogador);
            contexto.SaveChanges();

            return busca;
        }
        public bool DeletarJogador(int? id)
        {
            if (id == null)
            {
                return false;
                throw new ArgumentNullException("Id");

            }
            var buscaCampo = contexto.Jogadores.Where(a => a.Id == id).FirstOrDefault();
            dbSet.Remove(buscaCampo);
            contexto.SaveChanges();
            return true;
        }
    }
}
