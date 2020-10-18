CREATE TABLE [dbo].[Order] (
	Id bigint NOT NULL Identity (1, 1),
	ProductId bigint NOT NULL,
	CustomerId bigint NOT NULL,
  CONSTRAINT [PK_ORDER] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)
)