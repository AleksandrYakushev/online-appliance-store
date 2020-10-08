CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[Name] NVARCHAR(50) NOT NULL,
	[Price] FLOAT NOT NULL, --unsigned 
	[SizeFirst] CHAR,
	[SizeSecond] CHAR,
	[SizeThird] CHAR,
	[Weight] FLOAT NOT NULL,
	[Manufacturer] NVARCHAR(50) NOT NULL,
	[ProductionYear] DATETIME2 NOT NULL
)


