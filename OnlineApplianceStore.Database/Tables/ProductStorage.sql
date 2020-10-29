CREATE TABLE [dbo].[ProductStorage] (
	Id BIGINT PRIMARY KEY NOT NULL IDENTITY (1, 1),
	ProductId BIGINT FOREIGN KEY (ProductID) REFERENCES [dbo].[Product]([Id]) NOT NULL,
	StorageId INT FOREIGN KEY (StorageId) REFERENCES [dbo].[Storage]([Id]) NOT NULL,
	ProductCount INT NOT NULL
)