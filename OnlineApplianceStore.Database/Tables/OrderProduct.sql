CREATE TABLE [dbo].[OrderProduct] (
	Id bigint NOT NULL IDENTITY (1, 1),
	OrderId bigint NOT NULL,
	ProductId bigint NOT NULL,
	ProductAmount int NOT NULL,
  CONSTRAINT [PK_ORDERPRODUCT] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)
)
