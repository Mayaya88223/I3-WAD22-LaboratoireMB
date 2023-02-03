CREATE TABLE [dbo].[Client] (
    [idClient]     INT            NOT NULL,
    [CliName]      NVARCHAR (50)  NOT NULL,
    [CliFirstName] NVARCHAR (50)  NOT NULL,
    [CliMail]      NVARCHAR (250) NOT NULL,
    [CliCompany]   NVARCHAR (50)  NOT NULL,
    [CliLogin]     NVARCHAR (50)  NULL,
    [CliPassword]  NVARCHAR (250) NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([idClient] ASC)
);

