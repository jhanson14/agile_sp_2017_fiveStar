CREATE TABLE [dbo].[account] (
    [CustID]   INT          IDENTITY (1, 1) NOT NULL,
    [UserName] VARCHAR (50) NOT NULL,
    [Password] NCHAR (10)   NOT NULL,
    CONSTRAINT [PK_account] PRIMARY KEY CLUSTERED ([CustID] ASC)
);

