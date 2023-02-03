CREATE TABLE [dbo].[Developer] (
    [idDev]             INT            NOT NULL,
    [DevName]           NVARCHAR (50)  NOT NULL,
    [DevFirstName]      NVARCHAR (50)  NOT NULL,
    [DevBirthDate]      DATETIME       NOT NULL,
    [DevPicture]        NVARCHAR (50)  NULL,
    [DevHourCost]       FLOAT (53)     NOT NULL,
    [DevDayCost]        FLOAT (53)     NOT NULL,
    [DevMonthCost]      FLOAT (53)     NOT NULL,
    [DevMail]           NVARCHAR (250) NOT NULL,
    [DevCategPrincipal] NVARCHAR (250) NULL,
    CONSTRAINT [PK_Developer] PRIMARY KEY CLUSTERED ([idDev] ASC)
);

