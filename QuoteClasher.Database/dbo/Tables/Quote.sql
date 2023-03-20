CREATE TABLE [dbo].[Quote]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Content] varchar(250) NOT NULL,
	[Quotee] varchar(50) NOT NULL,
	[DateAdded] datetime NOT NULL
)
