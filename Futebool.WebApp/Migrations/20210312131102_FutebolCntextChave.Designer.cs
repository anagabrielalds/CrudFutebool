﻿// <auto-generated />
using System;
using Futebool.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Futebool.WebApp.Migrations
{
    [DbContext(typeof(FutebolContext))]
    [Migration("20210312131102_FutebolCntextChave")]
    partial class FutebolCntextChave
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Futebool.WebApp.Models.AcontecimentosDoJogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcaoOcorrida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JogadorId")
                        .HasColumnType("int");

                    b.Property<int?>("JogoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TempoDoOcorrido")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TimeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JogadorId");

                    b.HasIndex("JogoId");

                    b.HasIndex("TimeId");

                    b.ToTable("AcontecimentosDosJogos");
                });

            modelBuilder.Entity("Futebool.WebApp.Models.Campo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeGramado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Referencia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Campos");
                });

            modelBuilder.Entity("Futebool.WebApp.Models.Jogador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("NumeroCamisa")
                        .HasColumnType("int");

                    b.Property<string>("PeDeChute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<string>("Posicao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TimeId");

                    b.HasIndex("Nome", "NumeroCamisa")
                        .IsUnique()
                        .HasFilter("[Nome] IS NOT NULL");

                    b.ToTable("Jogadores");
                });

            modelBuilder.Entity("Futebool.WebApp.Models.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Acrescimo")
                        .HasColumnType("float");

                    b.Property<int?>("CampoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraJogo")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlacarCasa")
                        .HasColumnType("int");

                    b.Property<int>("PlacarVisitante")
                        .HasColumnType("int");

                    b.Property<int?>("TimeCasaId")
                        .HasColumnType("int");

                    b.Property<int?>("TimeVisitanteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CampoId");

                    b.HasIndex("TimeCasaId");

                    b.HasIndex("TimeVisitanteId");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("Futebool.WebApp.Models.Tecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("Futebool.WebApp.Models.Times", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brasão")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CampoId")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Derrotas")
                        .HasColumnType("int");

                    b.Property<string>("Mascote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TecnicoId")
                        .HasColumnType("int");

                    b.Property<int>("TotalGols")
                        .HasColumnType("int");

                    b.Property<int>("Vitorias")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CampoId");

                    b.HasIndex("TecnicoId");

                    b.ToTable("Times");
                });

            modelBuilder.Entity("Futebool.WebApp.Models.AcontecimentosDoJogo", b =>
                {
                    b.HasOne("Futebool.WebApp.Models.Jogador", "Jogador")
                        .WithMany()
                        .HasForeignKey("JogadorId");

                    b.HasOne("Futebool.WebApp.Models.Jogo", "Jogo")
                        .WithMany()
                        .HasForeignKey("JogoId");

                    b.HasOne("Futebool.WebApp.Models.Times", "Time")
                        .WithMany()
                        .HasForeignKey("TimeId");

                    b.Navigation("Jogador");

                    b.Navigation("Jogo");

                    b.Navigation("Time");
                });

            modelBuilder.Entity("Futebool.WebApp.Models.Jogador", b =>
                {
                    b.HasOne("Futebool.WebApp.Models.Times", "Time")
                        .WithMany()
                        .HasForeignKey("TimeId");

                    b.Navigation("Time");
                });

            modelBuilder.Entity("Futebool.WebApp.Models.Jogo", b =>
                {
                    b.HasOne("Futebool.WebApp.Models.Campo", "Campo")
                        .WithMany()
                        .HasForeignKey("CampoId");

                    b.HasOne("Futebool.WebApp.Models.Times", "TimeCasa")
                        .WithMany()
                        .HasForeignKey("TimeCasaId");

                    b.HasOne("Futebool.WebApp.Models.Times", "TimeVisitante")
                        .WithMany()
                        .HasForeignKey("TimeVisitanteId");

                    b.Navigation("Campo");

                    b.Navigation("TimeCasa");

                    b.Navigation("TimeVisitante");
                });

            modelBuilder.Entity("Futebool.WebApp.Models.Times", b =>
                {
                    b.HasOne("Futebool.WebApp.Models.Campo", "Campo")
                        .WithMany()
                        .HasForeignKey("CampoId");

                    b.HasOne("Futebool.WebApp.Models.Tecnico", "Tecnico")
                        .WithMany()
                        .HasForeignKey("TecnicoId");

                    b.Navigation("Campo");

                    b.Navigation("Tecnico");
                });
#pragma warning restore 612, 618
        }
    }
}