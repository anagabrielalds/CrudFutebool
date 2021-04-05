using Futebool.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Repositories
{

    public class TecnicosRepository
    {
        private readonly FutebolContext contexto;
        protected readonly DbSet<Tecnico> dbSet;

        public TecnicosRepository(FutebolContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<Tecnico>();

        }

        public IList<Tecnico> ListaTecnicos()
        {
            // ListaVazia
            var eii = dbSet;
            return dbSet.ToList();
        }
        public bool CadastroTecnicos(Tecnico tecnico)
        {

            if (tecnico == null)
            {
                return false;
                throw new ArgumentNullException("cadastroJogador");
            }

            dbSet.Add(tecnico);
            contexto.SaveChanges();

            return true;

        }
        public Tecnico GetTecnico(int? id)
        {
            var tecnico = new Tecnico();
            var buscaTecnico = contexto.Tecnicos.Where(a => a.Id == id).FirstOrDefault();
            tecnico = buscaTecnico;

            //dbSet.Update(campo);
            return tecnico;
        }
        public Tecnico AtualizarTecnico(Tecnico tecnico)
        {
            var busca = dbSet.Where(a => a.Id == tecnico.Id).FirstOrDefault();

            if (busca == null)
            {
                throw new ArgumentNullException("cadastro");
            }
            busca.update(tecnico);
            contexto.SaveChanges();

            return busca;
        }
        public bool DeletarTecnico(int? id)
        {
            if (id == null)
            {
                return false;
                throw new ArgumentNullException("Id");

            }
            var buscaCampo = contexto.Tecnicos.Where(a => a.Id == id).FirstOrDefault();
            dbSet.Remove(buscaCampo);
            contexto.SaveChanges();
            return true;
        }
    }
}