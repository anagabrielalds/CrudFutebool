using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace futebool.Models
{
    public class FutebolContext : DbContext
    {

        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Times> Times { get; set; }
        public DbSet<Campo> Campos { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<AcontecimentosDoJogo> AcontecimentosDosJogos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Futebool;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //garantir a exclusividade dos dados usando uma chave alternativa da combinação NomeNCamisa
            modelBuilder.Entity<Jogador>().HasAlternateKey(a => new { a.Nome, a.NumeroCamisa });
            
            //modelBuilder.Entity<Jogador>().Property(j => j.Nome).IsRequired();
            //modelBuilder.Entity<Jogador>().Property(j => j.NumeroCamisa).IsRequired();
            //modelBuilder.Entity<Jogador>().Property(j => j.Status).IsRequired();
            //modelBuilder.Entity<Jogador>().Property(j => j.Posicao).IsRequired();
            //modelBuilder.Entity<Jogador>().Property(j => j.PeDeChute).IsRequired();
            //modelBuilder.Entity<Jogador>().Property(j => j.Time).IsRequired();
            //modelBuilder.Entity<Jogador>().HasOne(j => j.Time).WithOne();
            //modelBuilder.Entity<Times>().Property(t => t.Campo).IsRequired();
            //modelBuilder.Entity<Times>().Property(t => t.Tecnico).IsRequired();

            //modelBuilder.Entity<Jogo>().Property(jogo => jogo.Campo).IsRequired();
            //modelBuilder.Entity<Jogo>().Property(jogo => jogo.TimeCasa).IsRequired();
            //modelBuilder.Entity<Jogo>().Property(jogo => jogo.TimeVisitante).IsRequired();
            //modelBuilder.Entity<Jogo>().Property(jogo => jogo.DataHoraJogo).IsRequired();

            



            //modelBuilder.ApplyConfiguration(new TimeConfiguration());
            //modelBuilder.ApplyConfiguration(new JogadorConfiguration());
            //modelBuilder.ApplyConfiguration(new JogadorNoJogoConfiguration());
            //modelBuilder.ApplyConfiguration(new JogoConfiguration());
        }
    }
}
