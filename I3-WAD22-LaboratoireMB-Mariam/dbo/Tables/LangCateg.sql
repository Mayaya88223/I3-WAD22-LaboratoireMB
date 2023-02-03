CREATE TABLE [dbo].[LangCateg] (
    [idIT]       INT NOT NULL,
    [idCategory] INT NOT NULL,
    CONSTRAINT [PK_LangCateg] PRIMARY KEY CLUSTERED ([idIT] ASC, [idCategory] ASC),
    CONSTRAINT [FK_LangCateg_Categories] FOREIGN KEY ([idCategory]) REFERENCES [dbo].[Categories] ([idCategory]),
    CONSTRAINT [FK_LangCateg_ITLang] FOREIGN KEY ([idIT]) REFERENCES [dbo].[ITLang] ([idIT])
);

