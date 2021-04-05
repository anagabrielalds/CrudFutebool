CREATE TABLE [Campos] (
    [Id] int NOT NULL IDENTITY,
    [CEP] nvarchar(max) NULL,
    [Referencia] nvarchar(max) NULL,
    [NomeGramado] nvarchar(max) NULL,
    [Endereco] nvarchar(max) NULL,
    [Estado] nvarchar(max) NULL,
    CONSTRAINT [PK_Campos] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Tecnicos] (
    [Id] int NOT NULL IDENTITY,
    [Descricao] nvarchar(max) NULL,
    [Nacionalidade] nvarchar(max) NULL,
    [Nome] nvarchar(max) NULL,
    [Peso] float NOT NULL,
    [Altura] float NOT NULL,
    CONSTRAINT [PK_Tecnicos] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Times] (
    [Id] int NOT NULL IDENTITY,
    [Codigo] nvarchar(max) NULL,
    [Nome] nvarchar(max) NULL,
    [Mascote] nvarchar(max) NULL,
    [Brasão] nvarchar(max) NULL,
    [Serie] nvarchar(max) NULL,
    [CampoId] int NULL,
    [TecnicoId] int NULL,
    [Derrotas] int NOT NULL,
    [Vitorias] int NOT NULL,
    [TotalGols] int NOT NULL,
    CONSTRAINT [PK_Times] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Times_Campos_CampoId] FOREIGN KEY ([CampoId]) REFERENCES [Campos] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Times_Tecnicos_TecnicoId] FOREIGN KEY ([TecnicoId]) REFERENCES [Tecnicos] ([Id]) ON DELETE NO ACTION
);
GO


CREATE TABLE [Jogadores] (
    [Id] int NOT NULL IDENTITY,
    [NumeroCamisa] int NOT NULL,
    [Status] nvarchar(max) NOT NULL,
    [Posicao] nvarchar(max) NOT NULL,
    [PeDeChute] nvarchar(max) NOT NULL,
    [TimeId] int NULL,
    [Nome] nvarchar(450) NOT NULL,
    [Peso] float NOT NULL,
    [Altura] float NOT NULL,
    CONSTRAINT [PK_Jogadores] PRIMARY KEY ([Id]),
    CONSTRAINT [AK_Jogadores_Nome_NumeroCamisa] UNIQUE ([Nome], [NumeroCamisa]),
    CONSTRAINT [FK_Jogadores_Times_TimeId] FOREIGN KEY ([TimeId]) REFERENCES [Times] ([Id]) ON DELETE NO ACTION
);
GO


CREATE TABLE [Jogos] (
    [Id] int NOT NULL IDENTITY,
    [TimeCasaId] int NULL,
    [TimeVisitanteId] int NULL,
    [CampoId] int NULL,
    [DataHoraJogo] datetime2 NOT NULL,
    [Acrescimo] float NOT NULL,
    [PlacarCasa] int NOT NULL,
    [PlacarVisitante] int NOT NULL,
    CONSTRAINT [PK_Jogos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Jogos_Campos_CampoId] FOREIGN KEY ([CampoId]) REFERENCES [Campos] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Jogos_Times_TimeCasaId] FOREIGN KEY ([TimeCasaId]) REFERENCES [Times] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Jogos_Times_TimeVisitanteId] FOREIGN KEY ([TimeVisitanteId]) REFERENCES [Times] ([Id]) ON DELETE NO ACTION
);
GO


CREATE TABLE [AcontecimentosDosJogos] (
    [Id] int NOT NULL IDENTITY,
    [JogoId] int NULL,
    [JogadorId] int NULL,
    [TimeId] int NULL,
    [AcaoOcorrida] nvarchar(max) NULL,
    [TempoDoOcorrido] datetime2 NOT NULL,
    CONSTRAINT [PK_AcontecimentosDosJogos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AcontecimentosDosJogos_Jogadores_JogadorId] FOREIGN KEY ([JogadorId]) REFERENCES [Jogadores] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_AcontecimentosDosJogos_Jogos_JogoId] FOREIGN KEY ([JogoId]) REFERENCES [Jogos] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_AcontecimentosDosJogos_Times_TimeId] FOREIGN KEY ([TimeId]) REFERENCES [Times] ([Id]) ON DELETE NO ACTION
);
GO


CREATE INDEX [IX_AcontecimentosDosJogos_JogadorId] ON [AcontecimentosDosJogos] ([JogadorId]);
GO


CREATE INDEX [IX_AcontecimentosDosJogos_JogoId] ON [AcontecimentosDosJogos] ([JogoId]);
GO


CREATE INDEX [IX_AcontecimentosDosJogos_TimeId] ON [AcontecimentosDosJogos] ([TimeId]);
GO


CREATE INDEX [IX_Jogadores_TimeId] ON [Jogadores] ([TimeId]);
GO


CREATE INDEX [IX_Jogos_CampoId] ON [Jogos] ([CampoId]);
GO


CREATE INDEX [IX_Jogos_TimeCasaId] ON [Jogos] ([TimeCasaId]);
GO


CREATE INDEX [IX_Jogos_TimeVisitanteId] ON [Jogos] ([TimeVisitanteId]);
GO


CREATE INDEX [IX_Times_CampoId] ON [Times] ([CampoId]);
GO


CREATE INDEX [IX_Times_TecnicoId] ON [Times] ([TecnicoId]);
GO


