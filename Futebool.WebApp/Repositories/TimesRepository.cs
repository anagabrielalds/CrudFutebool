using Futebool.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Repositories
{
    public class TimesRepository
    {
        private readonly FutebolContext contexto;
        protected readonly DbSet<Times> dbSet;

        public TimesRepository(FutebolContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<Times>();

        }

        public IList<Times> ListaTimes()
        {
            // ListaVazia
            var eii = dbSet;
            return dbSet.Include(f => f.Tecnico)
                .ToList();
        }
        public bool CadastroTime(Times times)
        {

            if (times == null)
            {
                return false;
                throw new ArgumentNullException("cadastroJogador");
            }
            var tecnico = contexto.Tecnicos.Where(a => a.Id == times.Tecnico.Id).FirstOrDefault();
            var campo = contexto.Campos.Where(a => a.Id == times.Campo.Id).FirstOrDefault();

            times.Tecnico = tecnico;
            times.Campo = campo;

            dbSet.Add(times);
            contexto.SaveChanges();

            return true;
        }
        public Times GetTime(int? id)
        {
            var time = new Times();
            var buscaTimes = contexto.Times.Where(a => a.Id == id).Include(f => f.Tecnico).Include(f => f.Campo).FirstOrDefault();
            time = buscaTimes;

            //dbSet.Update(campo);
            return time;
        }
        public Times AtualizarTime(Times time)
        {
            var busca = dbSet.Where(a => a.Id == time.Id).Include(f => f.Tecnico).Include(f => f.Campo).FirstOrDefault();


            if (busca == null)
            {
                throw new ArgumentNullException("cadastro");
            }
            var tecnico = contexto.Tecnicos.Where(a => a.Id == time.Tecnico.Id).FirstOrDefault();
            var campo = contexto.Campos.Where(a => a.Id == time.Campo.Id).FirstOrDefault();
            time.Campo = campo;
            time.Tecnico = tecnico;
            busca.update(time);
            contexto.SaveChanges();

            return busca;
        }
        public bool DeletarTime(int? id)
        {
            if (id == null)
            {
                return false;
                throw new ArgumentNullException("Id");

            }
            var buscaCampo = contexto.Times.Where(a => a.Id == id).Include(f => f.Tecnico).Include(f => f.Campo).FirstOrDefault();
            dbSet.Remove(buscaCampo);
            contexto.SaveChanges();
            return true;
        }

    }
}
