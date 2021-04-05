using Futebool.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Repositories
{
    public class CampoRepository
    {
        private readonly FutebolContext contexto;
        protected readonly DbSet<Campo> dbSet;

        public CampoRepository(FutebolContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<Campo>();
        }

        public IList<Campo> ListaCampos()
        {
            // ListaVazia
            var eii = dbSet;
            return dbSet.ToList();
        }
        public bool CadastroCampo(Campo campo)
        {

            if (campo == null)
            {
                return false;
                throw new ArgumentNullException("CadastroCampo");
            }

            dbSet.Add(campo);
            contexto.SaveChanges();

            return true;

        }
        public Campo GetCampo(int? id)
        {
            Campo campo = new Campo();
            var buscaCampo = contexto.Campos.Where(a => a.Id == id).FirstOrDefault();
            campo = buscaCampo;

            dbSet.Update(campo);
            return campo;
        }
        public Campo atualizaCampo(Campo campo)
        {
            var busca = dbSet.Where(a => a.Id == campo.Id).FirstOrDefault();


            if (busca == null)
            {
                throw new ArgumentNullException("cadastro");
            }
            busca.update(campo);
            contexto.SaveChanges();

            return busca;
        }
        public bool DeletarCampo(int? id)
        {
            if(id == null)
            {
                return false;
                throw new ArgumentNullException("Id");
                
            }
            var buscaCampo = contexto.Campos.Where(a => a.Id == id).FirstOrDefault();
            dbSet.Remove(buscaCampo);
            contexto.SaveChanges();
            return true;
        }

    }
}
