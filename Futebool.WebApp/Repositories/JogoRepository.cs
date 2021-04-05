using Futebool.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Repositories
{
    public class JogoRepository
    {
        private readonly FutebolContext contexto;
        protected readonly DbSet<Jogo> dbSet;

        public JogoRepository(FutebolContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<Jogo>();

        }

        public IList<Jogo> ListaJogo()
        {
            // ListaVazia
            var eii = dbSet;
            return dbSet.Include(f => f.Campo)
                .Include(d => d.TimeCasa)
                .Include(d => d.TimeVisitante)
                .ToList();
        }
        public IList<Campo> GetCampo()
        {
            return contexto.Campos.ToList();
        }
        public bool CadastroJogo(Jogo jogo)
        {

            if (jogo == null)
            {
                return false;
                throw new ArgumentNullException("cadastroJogo");
            }
            var campo = contexto.Campos.Where(a => a.Id == jogo.Campo.Id).FirstOrDefault();
            var timeCasa = contexto.Times.Where(a => a.Id == jogo.TimeCasa.Id).FirstOrDefault();
            var timeVisistante = contexto.Times.Where(a => a.Id == jogo.TimeVisitante.Id).FirstOrDefault();
           
            if(timeCasa.Id == timeVisistante.Id)
            {
                return false;
            }
            jogo.TimeCasa = timeCasa;
            jogo.TimeVisitante = timeVisistante;
            jogo.Campo = campo;
            dbSet.Add(jogo);
            contexto.SaveChanges();

            return true;

        }
        public IList<Times> ListarTimes()
        {
            var time = contexto.Times.ToList();
            return time;

        }

        public Jogo GetJogo(int? id)
        {
            var jogo = new Jogo();
            var buscaJogo = contexto.Jogos.Where(a => a.Id == id).FirstOrDefault();
            jogo = buscaJogo;
            return jogo;
        }

        public Jogo atualizarJogo(Jogo jogo)
        {
            var busca = dbSet.Where(a => a.Id == jogo.Id).Include(f => f.TimeCasa).Include(f => f.TimeVisitante).Include(f => f.Campo).FirstOrDefault();
            var timeCasa = contexto.Times.Where(a => a.Id == jogo.TimeCasa.Id).FirstOrDefault();
            var timeVisitante = contexto.Times.Where(a => a.Id == jogo.TimeVisitante.Id).FirstOrDefault();
            var campo = contexto.Campos.Where(a => a.Id == jogo.Campo.Id).FirstOrDefault();

            if (timeCasa.Id == timeVisitante.Id)
            {
                return null;
            }
            if (busca == null)
            {
                throw new ArgumentNullException("cadastro");
            }
            jogo.Campo = campo;
            jogo.TimeVisitante = timeVisitante;
            jogo.TimeCasa = timeCasa;

            busca.update(jogo);
            contexto.SaveChanges();

            return busca;
        }

        public bool DeletarJogo(int? id)
        {
            if (id == null)
            {
                return false;
                throw new ArgumentNullException("Id");

            }
            var buscaJogo = contexto.Jogos.Where(a => a.Id == id).FirstOrDefault();
            dbSet.Remove(buscaJogo);
            contexto.SaveChanges();
            return true;
        }
    }
}
