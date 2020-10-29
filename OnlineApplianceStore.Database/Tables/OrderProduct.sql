CREATE TABLE [dbo].[OrderProduct] (
	Id BIGINT PRIMARY KEY NOT NULL IDENTITY (1, 1),
	OrderId BIGINT FOREIGN KEY (OrderId) REFERENCES [dbo].[Order]([Id]) NOT NULL,
	ProductId BIGINT FOREIGN KEY (ProductId) REFERENCES [dbo].[Product]([Id]) NOT NULL,
	ProductAmount INT NOT NULL
	)