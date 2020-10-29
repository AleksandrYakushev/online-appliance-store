CREATE TABLE [dbo].[Order] (
	Id BIGINT PRIMARY KEY NOT NULL IDENTITY (1, 1),
	ProductId BIGINT FOREIGN KEY (ProductId) REFERENCES [dbo].[Product]([Id]) NOT NULL,
	CustomerId BIGINT FOREIGN KEY (CustomerId) REFERENCES [dbo].[Customer]([Id]) NOT NULL,
	OperationDate DATETIME2 NOT NULL,
	PaymentTypeId INT FOREIGN KEY (PaymentTypeId) REFERENCES [dbo].[PaymentType]([Id]) NOT NULL,
	TotalAmount DECIMAL NOT NULL,
)