CREATE TABLE [dbo].[Quote] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
	[Guid] UNIQUEIDENTIFIER NOT NULL UNIQUE, 
    [Content]   VARCHAR (250) NOT NULL,
    [Quotee]    VARCHAR (50)  NOT NULL,
    [DateAdded] DATETIME      NOT NULL,    
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

