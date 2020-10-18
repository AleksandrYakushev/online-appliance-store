CREATE TABLE [dbo].[ProductStorage] (
	Id bigint NOT NULL Identity(1,1),
	ProductId bigint NOT NULL,
	StorageId int NOT NULL,
	ProductCount int NOT NULL,
  CONSTRAINT [PK_PRODUCTSTORAGE] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)
)