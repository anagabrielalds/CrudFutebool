using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Futebool.WebApp.Models
{
    public class FutebolContext : DbContext
    {
        public FutebolContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Times> Times { get; set; }
        public DbSet<Campo> Campos { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<AcontecimentosDoJogo> AcontecimentosDosJogos { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Futebool;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //garantir a exclusividade dos dados usando uma chave alternativa da combinação NomeNCamisa

            modelBuilder.Entity<Jogador>().HasIndex(a => new { a.Nome, a.NumeroCamisa }).IsUnique();
             
        }
    }
}
