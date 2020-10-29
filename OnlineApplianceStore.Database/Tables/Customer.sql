CREATE TABLE [dbo].[Customer] (
	Id BIGINT PRIMARY KEY NOT NULL IDENTITY (1, 1),
	RoleId INT FOREIGN KEY (RoleId) REFERENCES [dbo].[Role]([Id]) NOT NULL,
	CityId INT FOREIGN KEY (CityId) REFERENCES [dbo].[City]([Id]) NOT NULL,
	[Name] NVARCHAR(30),
	LastName NVARCHAR(30),
	Phone NVARCHAR(20) NOT NULL,
	[Password] nvarchar(30) NOT NULL,
	[Address] NVARCHAR(100),
	Email NVARCHAR(50),
	Birthday DATE,
	RegistrationDate DATETIME2,
	LastUpdateDate DATETIME2,
	IsDeleted BIT NOT NULL
	)