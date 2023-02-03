CREATE TABLE [dbo].[ClientEndorseDev] (
    [idClient]      INT              NOT NULL,
    [idDev]         INT              NOT NULL,
    [BeginDate]     DATETIME         NOT NULL,
    [EndDate]       DATETIME         NOT NULL,
    [EndorseNumber] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_ClientEndorseDev] PRIMARY KEY CLUSTERED ([EndorseNumber] ASC),
    CONSTRAINT [FK_ClientEndorseDev_Client] FOREIGN KEY ([idClient]) REFERENCES [dbo].[Client] ([idClient]),
    CONSTRAINT [FK_ClientEndorseDev_Developer] FOREIGN KEY ([idDev]) REFERENCES [dbo].[Developer] ([idDev])
);

