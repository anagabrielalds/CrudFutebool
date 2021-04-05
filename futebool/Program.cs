using futebool.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace futebool
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            InserirJogo();
        }
        public static void ListarJogo()
        {
            using (var context = new FutebolContext())
            {
                Console.WriteLine("________________Jogos_____________________");
                var jogos = context.Jogos
                    .Include(j => j.TimeCasa)
                    .ThenInclude(j => j.Campo)
                    .Include(j => j.TimeVisitante);
                foreach (var jgo in jogos)
                {
                    Console.WriteLine(jgo);
                }
            }
        }

        public static void InserirJogo()
        {
            using (var context = new FutebolContext())
            {
                var jogo = new Jogo();
                var time1 = context.Times.First();
                var time2 = context.Times.Where(a => a.Id != time1.Id).FirstOrDefault();

                jogo.TimeCasa = time1;
                jogo.TimeVisitante = time2;
                    jogo.DataHoraJogo = DateTime.Now;
                jogo.Campo = context.Campos.First(); ;

                if(time1.Id == time2.Id)
                {
                    Console.WriteLine( "Não foi possível adicionar!! times iguais não podem se enfrentar");
                }
                else
                {
                    context.Jogos.Add(jogo);
                    context.SaveChanges();
                }
            }
        }
        public static void ListarCampo()
        {
            using (var context = new FutebolContext())
            {
                Console.WriteLine("________________Campos_____________________");
                foreach (var campo in context.Campos)
                {
                    Console.WriteLine(campo);
                }
            }
        }
        public static void InserirCampo()
        {
            using (var context = new FutebolContext())
            {
                var campo = new Campo();

                campo.NomeGramado = "Estádio Cícero Pompeu de Toledo";
                campo.Referencia = "Estádio do Morumbi";
                campo.Endereco = "Praça Roberto Gomes Pedrosa, 1 - Morumbi.";
                campo.Estado = "São Paulo - SP";
                campo.CEP = "05653-070";


                context.Campos.Add(campo);
                context.SaveChanges();

            }
        }
        public static void ListarJogadores()
        {
            using (var context = new FutebolContext())
            {
                Console.WriteLine("________________Jogadores_____________________");
                foreach (var jogador in context.Jogadores)
                {
                    Console.WriteLine(jogador);
                }
            }
        }
        public static void InserirJogador()
        {
            using (var context = new FutebolContext())
            {
                var jogador = new Jogador();

                var time = context.Times.First();

                jogador.Nome = "Pablo Felipe Teixeira";
                jogador.NumeroCamisa = 9;
                jogador.PeDeChute = "Destro";
                jogador.Posicao = "Atacante";
                jogador.Status = "Titular";
                jogador.Time = time;
                context.Jogadores.Add(jogador);
                context.SaveChanges();
            }
        }
        public static void ListarTimeETecnico()
        {
            using(var context = new FutebolContext())
            {
                Console.WriteLine("________________Times_____________________");
                foreach (var time in context.Times)
                {
                    Console.WriteLine(time);
                }
                Console.WriteLine("________________Técnicos__________________");
                foreach (var tecnico in context.Tecnicos)
                {
                    Console.WriteLine(tecnico);
                }
            }
           
        }
        public static void InserirTimeETecnico()
        {
            using (var context = new FutebolContext())
            {
                var tecnico = new Tecnico();
                tecnico.Nome = "Hérnan Crespo";

                var time = new Times();

                time.Mascote = "Paulo de Tarso";
                time.Nome = "São Paulo Futebol Clube";
                time.Tecnico = tecnico;
                time.Mascote = "Paulo de Tarso";
                time.Campo = context.Campos.First();

                context.Tecnicos.AddRange(tecnico);
                context.Times.Add(time);
                int idTecnico = tecnico.Id;
                context.SaveChanges();

                //Segundo Tecnico e Time

                var tecnico1 = new Tecnico();
                tecnico1.Nome = "Ariel Holan";
                tecnico1.Nacionalidade = "Argentino";
                tecnico1.Descricao = "Em 17 de fevereiro de 2021, foi anunciado que Ariel Holan aceitou a oferta do Santos para substituir o técnico Cuca que iria sair após o final do Campeonato Brasileiro de 2020. E o argentino deve chegar com uma comissão técnica pequena e sem multa rescisória. A tendência é que Holan trabalhe com o auxiliar Juan Esparis e o preparador físico Facundo Peralta. O treinador levou o preparador de goleiros Juan José Fariello à Universidad Católica, mas o responsável pela função no Santos é Arzul, uma unanimidade. Dessa forma, apenas dois podem vir além do comandante";
                tecnico1.Altura = 1.78;

                var time1 = new Times();

                time1.Mascote = "Baleia";
                time1.Nome = "Santos Futebol Clube";
                time1.Tecnico = tecnico;
                time1.Serie = "Serie A";
                time1.Campo = context.Campos.First();


                context.Tecnicos.AddRange(tecnico1);
                context.Times.Add(time1);
                int idTecnico1 = tecnico.Id;
                context.SaveChanges();

            }
        }
    }
}
