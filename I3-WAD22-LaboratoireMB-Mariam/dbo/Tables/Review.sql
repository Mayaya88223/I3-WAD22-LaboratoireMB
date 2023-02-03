CREATE TABLE [dbo].[Review] (
    [idReview]   INT            IDENTITY (1, 1) NOT NULL,
    [ReviewName] NVARCHAR (50)  NOT NULL,
    [ReviewText] NVARCHAR (MAX) NOT NULL,
    [ReviewMail] NVARCHAR (256) NOT NULL,
    [ReviewDate] DATETIME       CONSTRAINT [DF_Review_ReviewDate] DEFAULT (getdate()) NOT NULL,
    [idDev]      INT            NOT NULL,
    CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED ([idReview] ASC),
    CONSTRAINT [FK_Review_Developer] FOREIGN KEY ([idDev]) REFERENCES [dbo].[Developer] ([idDev])
);

