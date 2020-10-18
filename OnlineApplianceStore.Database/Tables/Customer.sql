CREATE TABLE [dbo].[Customer] (
	Id bigint NOT NULL Identity(1,1),
	RoleId int NOT NULL,
	Phone bigint NOT NULL,
	[Name] nvarchar(20),
	LastName nvarchar(20),
	[Address] nvarchar(100),
	Email nvarchar(50),
	Birthday date,
	FirstOrderDate datetime2,
	LastOrderDate datetime2,
	IsDeleted bit NOT NULL,
  CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)
)