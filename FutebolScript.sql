USE [master]
GO
/****** Object:  Database [Futebool]    Script Date: 29/03/2021 15:50:58 ******/
CREATE DATABASE [Futebool]
 CONTAINMENT = NONE
GO
ALTER DATABASE [Futebool] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Futebool].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Futebool] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [Futebool] SET ANSI_NULLS ON 
GO
ALTER DATABASE [Futebool] SET ANSI_PADDING ON 
GO
ALTER DATABASE [Futebool] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [Futebool] SET ARITHABORT ON 
GO
ALTER DATABASE [Futebool] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Futebool] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Futebool] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Futebool] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Futebool] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [Futebool] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [Futebool] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Futebool] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [Futebool] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Futebool] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Futebool] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Futebool] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Futebool] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Futebool] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Futebool] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Futebool] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Futebool] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Futebool] SET RECOVERY FULL 
GO
ALTER DATABASE [Futebool] SET  MULTI_USER 
GO
ALTER DATABASE [Futebool] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Futebool] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Futebool] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Futebool] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Futebool] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Futebool] SET QUERY_STORE = OFF
GO
USE [Futebool]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Futebool]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 29/03/2021 15:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AcontecimentosDosJogos]    Script Date: 29/03/2021 15:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcontecimentosDosJogos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JogoId] [int] NOT NULL,
	[JogadorId] [int] NOT NULL,
	[TimeId] [int] NOT NULL,
	[AcaoOcorrida] [nvarchar](max) NULL,
	[TempoDoOcorrido] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AcontecimentosDosJogos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Campos]    Script Date: 29/03/2021 15:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CEP] [nvarchar](max) NULL,
	[Referencia] [nvarchar](max) NULL,
	[NomeGramado] [nvarchar](max) NULL,
	[Endereco] [nvarchar](max) NULL,
	[Estado] [nvarchar](max) NULL,
 CONSTRAINT [PK_Campos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jogadores]    Script Date: 29/03/2021 15:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jogadores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumeroCamisa] [int] NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[Posicao] [nvarchar](max) NOT NULL,
	[PeDeChute] [nvarchar](max) NOT NULL,
	[TimeId] [int] NOT NULL,
	[Nome] [nvarchar](450) NOT NULL,
	[Peso] [float] NOT NULL,
	[Altura] [float] NOT NULL,
 CONSTRAINT [PK_Jogadores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jogos]    Script Date: 29/03/2021 15:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jogos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TimeCasaId] [int] NOT NULL,
	[TimeVisitanteId] [int] NOT NULL,
	[CampoId] [int] NOT NULL,
	[DataHoraJogo] [datetime2](7) NOT NULL,
	[Acrescimo] [float] NOT NULL,
	[PlacarCasa] [int] NOT NULL,
	[PlacarVisitante] [int] NOT NULL,
 CONSTRAINT [PK_Jogos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tecnicos]    Script Date: 29/03/2021 15:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tecnicos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](max) NULL,
	[Nacionalidade] [nvarchar](max) NULL,
	[Nome] [nvarchar](max) NULL,
	[Peso] [float] NOT NULL,
	[Altura] [float] NOT NULL,
 CONSTRAINT [PK_Tecnicos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Times]    Script Date: 29/03/2021 15:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Times](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NULL,
	[Nome] [nvarchar](max) NULL,
	[Mascote] [nvarchar](max) NULL,
	[Brasão] [nvarchar](max) NULL,
	[Serie] [nvarchar](max) NULL,
	[CampoId] [int] NOT NULL,
	[TecnicoId] [int] NOT NULL,
	[Derrotas] [int] NOT NULL,
	[Vitorias] [int] NOT NULL,
	[TotalGols] [int] NOT NULL,
 CONSTRAINT [PK_Times] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210304161041_criacaoBd', N'5.0.3')
GO
SET IDENTITY_INSERT [dbo].[AcontecimentosDosJogos] ON 

INSERT [dbo].[AcontecimentosDosJogos] ([Id], [JogoId], [JogadorId], [TimeId], [AcaoOcorrida], [TempoDoOcorrido]) VALUES (3, 4, 1002, 2, N'Sofreu Falta', CAST(N'2021-03-16T00:45:00.0000000' AS DateTime2))
INSERT [dbo].[AcontecimentosDosJogos] ([Id], [JogoId], [JogadorId], [TimeId], [AcaoOcorrida], [TempoDoOcorrido]) VALUES (4, 1002, 4, 4, N'Cartão Vermelho', CAST(N'2021-03-16T00:45:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[AcontecimentosDosJogos] OFF
GO
SET IDENTITY_INSERT [dbo].[Campos] ON 

INSERT [dbo].[Campos] ([Id], [CEP], [Referencia], [NomeGramado], [Endereco], [Estado]) VALUES (1, N'05653-070', N'Estádio do Morumbi', N'Estádio Cícero Pompeu de Toledo', N'Praça Roberto Gomes Pedrosa, 1 - Morumbi.', N'São Paulo - SP')
INSERT [dbo].[Campos] ([Id], [CEP], [Referencia], [NomeGramado], [Endereco], [Estado]) VALUES (2, N'hahaha', N'Estádio da Gávea', N'Estágio da Alegria', N'to tentando po', NULL)
INSERT [dbo].[Campos] ([Id], [CEP], [Referencia], [NomeGramado], [Endereco], [Estado]) VALUES (3, NULL, N'Estádio da Gávea', N'Estádio da Gávea', NULL, NULL)
INSERT [dbo].[Campos] ([Id], [CEP], [Referencia], [NomeGramado], [Endereco], [Estado]) VALUES (1002, N'12344567899', N'Estádio da Gávea', N'Estádio da Gávea', N'Rua Ministro Raul Machado, Rio de Janeiro ', N'Rio de Janeiro - RJ')
INSERT [dbo].[Campos] ([Id], [CEP], [Referencia], [NomeGramado], [Endereco], [Estado]) VALUES (2002, N'9090', N'iteris', N'gramado da Iteris', N'kkkkkkkk', N'rio ')
SET IDENTITY_INSERT [dbo].[Campos] OFF
GO
SET IDENTITY_INSERT [dbo].[Jogadores] ON 

INSERT [dbo].[Jogadores] ([Id], [NumeroCamisa], [Status], [Posicao], [PeDeChute], [TimeId], [Nome], [Peso], [Altura]) VALUES (1, 9, N'Titular', N'Atacante', N'Destro', 2, N'Pablo Felipe Teixeira', 0, 0)
INSERT [dbo].[Jogadores] ([Id], [NumeroCamisa], [Status], [Posicao], [PeDeChute], [TimeId], [Nome], [Peso], [Altura]) VALUES (4, 2, N'Titular', N'Goleiro', N'Direito', 5, N'Jogador Bom', 0, 0)
INSERT [dbo].[Jogadores] ([Id], [NumeroCamisa], [Status], [Posicao], [PeDeChute], [TimeId], [Nome], [Peso], [Altura]) VALUES (5, 11, N'Reserva', N'Lateral Esquerdo', N'Esquerdo', 2, N'Testinho', 0, 0)
INSERT [dbo].[Jogadores] ([Id], [NumeroCamisa], [Status], [Posicao], [PeDeChute], [TimeId], [Nome], [Peso], [Altura]) VALUES (1002, 4, N'Titular', N'Goleiro', N'Esquerdo', 2, N'jogador10', 0, 0)
SET IDENTITY_INSERT [dbo].[Jogadores] OFF
GO
SET IDENTITY_INSERT [dbo].[Jogos] ON 

INSERT [dbo].[Jogos] ([Id], [TimeCasaId], [TimeVisitanteId], [CampoId], [DataHoraJogo], [Acrescimo], [PlacarCasa], [PlacarVisitante]) VALUES (4, 2, 4, 1, CAST(N'2021-03-05T10:08:03.4375428' AS DateTime2), 0, 0, 0)
INSERT [dbo].[Jogos] ([Id], [TimeCasaId], [TimeVisitanteId], [CampoId], [DataHoraJogo], [Acrescimo], [PlacarCasa], [PlacarVisitante]) VALUES (1002, 4, 5, 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 0, 0, 0)
INSERT [dbo].[Jogos] ([Id], [TimeCasaId], [TimeVisitanteId], [CampoId], [DataHoraJogo], [Acrescimo], [PlacarCasa], [PlacarVisitante]) VALUES (1003, 2, 5, 1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 0, 3, 0)
INSERT [dbo].[Jogos] ([Id], [TimeCasaId], [TimeVisitanteId], [CampoId], [DataHoraJogo], [Acrescimo], [PlacarCasa], [PlacarVisitante]) VALUES (2002, 2, 4, 2, CAST(N'2021-12-12T13:30:00.0000000' AS DateTime2), 0, 0, 0)
SET IDENTITY_INSERT [dbo].[Jogos] OFF
GO
SET IDENTITY_INSERT [dbo].[Tecnicos] ON 

INSERT [dbo].[Tecnicos] ([Id], [Descricao], [Nacionalidade], [Nome], [Peso], [Altura]) VALUES (2, N'muito bom ele kkkk', N'Brasileiro', N'Hérnan Crespo', 0, 0)
INSERT [dbo].[Tecnicos] ([Id], [Descricao], [Nacionalidade], [Nome], [Peso], [Altura]) VALUES (4, NULL, NULL, N'Hérnan Crespo', 0, 0)
INSERT [dbo].[Tecnicos] ([Id], [Descricao], [Nacionalidade], [Nome], [Peso], [Altura]) VALUES (5, N'Em 17 de fevereiro de 2021, foi anunciado que Ariel Holan aceitou a oferta do Santos para substituir o técnico Cuca que iria sair após o final do Campeonato Brasileiro de 2020. E o argentino deve chegar com uma comissão técnica pequena e sem multa rescisória. A tendência é que Holan trabalhe com o auxiliar Juan Esparis e o preparador físico Facundo Peralta. O treinador levou o preparador de goleiros Juan José Fariello à Universidad Católica, mas o responsável pela função no Santos é Arzul, uma unanimidade. Dessa forma, apenas dois podem vir além do comandante', N'Argentino', N'Ariel Holan', 0, 1.78)
INSERT [dbo].[Tecnicos] ([Id], [Descricao], [Nacionalidade], [Nome], [Peso], [Altura]) VALUES (1002, N'Destaca-se por ser o maior goleiro artilheiro na história do futebol mundial até hoje. Sua precisão nas cobranças, tanto de faltas quanto de pênaltis, fizeram dele, em agosto de 2006, o goleiro com o maior número de gols marcados na história do esporte, superando o paraguaio Chilavert.Chama a atenção também por ser o jogador com mais vitórias pelo mesmo time, superando o britânico Ryan Giggs, do Manchester United, que possui 589 vitórias. Ultrapassou essa marca no jogo contra o Goiás, em 27 de outubro de 2014, em jogo válido pelo Campeonato Brasileiro.', N'Brasileiro', N'Rogério Ceni', 0, 188)
SET IDENTITY_INSERT [dbo].[Tecnicos] OFF
GO
SET IDENTITY_INSERT [dbo].[Times] ON 

INSERT [dbo].[Times] ([Id], [Codigo], [Nome], [Mascote], [Brasão], [Serie], [CampoId], [TecnicoId], [Derrotas], [Vitorias], [TotalGols]) VALUES (2, NULL, N'São Paulo Futebol Clube', N'Paulo de Tarso', NULL, N'Serie B', 1, 2, 0, 0, 0)
INSERT [dbo].[Times] ([Id], [Codigo], [Nome], [Mascote], [Brasão], [Serie], [CampoId], [TecnicoId], [Derrotas], [Vitorias], [TotalGols]) VALUES (4, NULL, N'time ana 2', N'galinha', NULL, N'Serie A', 1, 4, 0, 0, 0)
INSERT [dbo].[Times] ([Id], [Codigo], [Nome], [Mascote], [Brasão], [Serie], [CampoId], [TecnicoId], [Derrotas], [Vitorias], [TotalGols]) VALUES (5, NULL, N'time5', NULL, NULL, N'Serie D', 1, 4, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[Times] OFF
GO
/****** Object:  Index [IX_AcontecimentosDosJogos_JogadorId]    Script Date: 29/03/2021 15:50:59 ******/
CREATE NONCLUSTERED INDEX [IX_AcontecimentosDosJogos_JogadorId] ON [dbo].[AcontecimentosDosJogos]
(
	[JogadorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AcontecimentosDosJogos_JogoId]    Script Date: 29/03/2021 15:50:59 ******/
CREATE NONCLUSTERED INDEX [IX_AcontecimentosDosJogos_JogoId] ON [dbo].[AcontecimentosDosJogos]
(
	[JogoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AcontecimentosDosJogos_TimeId]    Script Date: 29/03/2021 15:50:59 ******/
CREATE NONCLUSTERED INDEX [IX_AcontecimentosDosJogos_TimeId] ON [dbo].[AcontecimentosDosJogos]
(
	[TimeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [AK_Jogadores_Nome_NumeroCamisa]    Script Date: 29/03/2021 15:50:59 ******/
ALTER TABLE [dbo].[Jogadores] ADD  CONSTRAINT [AK_Jogadores_Nome_NumeroCamisa] UNIQUE NONCLUSTERED 
(
	[Nome] ASC,
	[NumeroCamisa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Jogadores_TimeId]    Script Date: 29/03/2021 15:50:59 ******/
CREATE NONCLUSTERED INDEX [IX_Jogadores_TimeId] ON [dbo].[Jogadores]
(
	[TimeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Jogos_CampoId]    Script Date: 29/03/2021 15:50:59 ******/
CREATE NONCLUSTERED INDEX [IX_Jogos_CampoId] ON [dbo].[Jogos]
(
	[CampoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Jogos_TimeCasaId]    Script Date: 29/03/2021 15:50:59 ******/
CREATE NONCLUSTERED INDEX [IX_Jogos_TimeCasaId] ON [dbo].[Jogos]
(
	[TimeCasaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Jogos_TimeVisitanteId]    Script Date: 29/03/2021 15:50:59 ******/
CREATE NONCLUSTERED INDEX [IX_Jogos_TimeVisitanteId] ON [dbo].[Jogos]
(
	[TimeVisitanteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Times_CampoId]    Script Date: 29/03/2021 15:50:59 ******/
CREATE NONCLUSTERED INDEX [IX_Times_CampoId] ON [dbo].[Times]
(
	[CampoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Times_TecnicoId]    Script Date: 29/03/2021 15:50:59 ******/
CREATE NONCLUSTERED INDEX [IX_Times_TecnicoId] ON [dbo].[Times]
(
	[TecnicoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AcontecimentosDosJogos]  WITH CHECK ADD  CONSTRAINT [FK_AcontecimentosDosJogos_Jogadores_JogadorId] FOREIGN KEY([JogadorId])
REFERENCES [dbo].[Jogadores] ([Id])
GO
ALTER TABLE [dbo].[AcontecimentosDosJogos] CHECK CONSTRAINT [FK_AcontecimentosDosJogos_Jogadores_JogadorId]
GO
ALTER TABLE [dbo].[AcontecimentosDosJogos]  WITH CHECK ADD  CONSTRAINT [FK_AcontecimentosDosJogos_Jogos_JogoId] FOREIGN KEY([JogoId])
REFERENCES [dbo].[Jogos] ([Id])
GO
ALTER TABLE [dbo].[AcontecimentosDosJogos] CHECK CONSTRAINT [FK_AcontecimentosDosJogos_Jogos_JogoId]
GO
ALTER TABLE [dbo].[AcontecimentosDosJogos]  WITH CHECK ADD  CONSTRAINT [FK_AcontecimentosDosJogos_Times_TimeId] FOREIGN KEY([TimeId])
REFERENCES [dbo].[Times] ([Id])
GO
ALTER TABLE [dbo].[AcontecimentosDosJogos] CHECK CONSTRAINT [FK_AcontecimentosDosJogos_Times_TimeId]
GO
ALTER TABLE [dbo].[Jogadores]  WITH CHECK ADD  CONSTRAINT [FK_Jogadores_Times_TimeId] FOREIGN KEY([TimeId])
REFERENCES [dbo].[Times] ([Id])
GO
ALTER TABLE [dbo].[Jogadores] CHECK CONSTRAINT [FK_Jogadores_Times_TimeId]
GO
ALTER TABLE [dbo].[Jogos]  WITH CHECK ADD  CONSTRAINT [FK_Jogos_Campos_CampoId] FOREIGN KEY([CampoId])
REFERENCES [dbo].[Campos] ([Id])
GO
ALTER TABLE [dbo].[Jogos] CHECK CONSTRAINT [FK_Jogos_Campos_CampoId]
GO
ALTER TABLE [dbo].[Jogos]  WITH CHECK ADD  CONSTRAINT [FK_Jogos_Times_TimeCasaId] FOREIGN KEY([TimeCasaId])
REFERENCES [dbo].[Times] ([Id])
GO
ALTER TABLE [dbo].[Jogos] CHECK CONSTRAINT [FK_Jogos_Times_TimeCasaId]
GO
ALTER TABLE [dbo].[Jogos]  WITH CHECK ADD  CONSTRAINT [FK_Jogos_Times_TimeVisitanteId] FOREIGN KEY([TimeVisitanteId])
REFERENCES [dbo].[Times] ([Id])
GO
ALTER TABLE [dbo].[Jogos] CHECK CONSTRAINT [FK_Jogos_Times_TimeVisitanteId]
GO
ALTER TABLE [dbo].[Times]  WITH CHECK ADD  CONSTRAINT [FK_Times_Campos_CampoId] FOREIGN KEY([CampoId])
REFERENCES [dbo].[Campos] ([Id])
GO
ALTER TABLE [dbo].[Times] CHECK CONSTRAINT [FK_Times_Campos_CampoId]
GO
ALTER TABLE [dbo].[Times]  WITH CHECK ADD  CONSTRAINT [FK_Times_Tecnicos_TecnicoId] FOREIGN KEY([TecnicoId])
REFERENCES [dbo].[Tecnicos] ([Id])
GO
ALTER TABLE [dbo].[Times] CHECK CONSTRAINT [FK_Times_Tecnicos_TecnicoId]
GO
USE [master]
GO
ALTER DATABASE [Futebool] SET  READ_WRITE 
GO
