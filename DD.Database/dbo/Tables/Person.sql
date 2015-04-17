CREATE TABLE [dbo].[Person] (
    [ID]        INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (20) NOT NULL,
    [LastName]  VARCHAR (20) NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([ID] ASC)
);

