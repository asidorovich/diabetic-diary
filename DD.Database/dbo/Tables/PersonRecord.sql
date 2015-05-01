CREATE TABLE [dbo].[PersonRecord] (
    [ID]                  INT            IDENTITY (1, 1) NOT NULL,
    [PersonId]            INT            NOT NULL,
    [RecordTime]          DATETIMEOFFSET(2)       NOT NULL,
    [Insulin]             DECIMAL (4, 2) NULL,
    [Carbohydrates]       DECIMAL (4, 2) NULL,
    [BloodGloucoseBgm]    DECIMAL (4, 2) NULL,
    [BloodGloucoseCgm]    DECIMAL (4, 2) NULL,
    [BloodGloucoseCgmRaw] DECIMAL (4, 2) NULL,
    [Note]                VARCHAR (256)  NULL,
    CONSTRAINT [PK_PersonRecord] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_PersonRecord_Person] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([ID])
);

