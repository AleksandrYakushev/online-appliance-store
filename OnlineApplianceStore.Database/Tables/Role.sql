﻿CREATE TABLE [dbo].[Role] (
	Id INT PRIMARY KEY NOT NULL IDENTITY (1, 1),
	[Name] NVARCHAR(20) UNIQUE NOT NULL,
)
