CREATE TABLE [dbo].[Customer] (
    [ID]               INT            IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (50)  NOT NULL,
    [Surname]          NVARCHAR (50)  NOT NULL,
    [Telephone_Number] NVARCHAR (20)  NOT NULL,
    [Address]          NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([ID] ASC)
);

