CREATE TABLE [dbo].[DevLang] (
    [idDev] INT      NOT NULL,
    [idIT]  INT      NOT NULL,
    [Since] DATETIME NULL,
    CONSTRAINT [PK_DevLang] PRIMARY KEY CLUSTERED ([idDev] ASC, [idIT] ASC),
    CONSTRAINT [FK_DevLang_Developer] FOREIGN KEY ([idDev]) REFERENCES [dbo].[Developer] ([idDev]),
    CONSTRAINT [FK_DevLang_ITLang] FOREIGN KEY ([idIT]) REFERENCES [dbo].[ITLang] ([idIT])
);

