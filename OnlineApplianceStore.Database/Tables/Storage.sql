CREATE TABLE [dbo].[Storage] (
	Id int NOT NULL IDENTITY (1, 1),
	[Name] nvarchar(20) UNIQUE NOT NULL,
)