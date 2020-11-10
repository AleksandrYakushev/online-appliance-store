CREATE PROCEDURE [dbo].[Order_Merge]
	@Id BIGINT,			
	@ProductId BIGINT,
	@CustomerId BIGINT,
	@PaymentTypeId INT,
	@TotalAmount DECIMAL,
	@OperationDate DATETIME2
AS
	DECLARE
	@result BIGINT
	SET @result = @Id
	MERGE dbo.[Order] O
	USING (select @Id, @ProductId, @CustomerId, @PaymentTypeId, @TotalAmount, @OperationDate)
	AS 
	source (Id, ProductId, CustomerId, PaymentTypeId, TotalAmount, OperationDate) 
	ON 
	(O.Id = source.Id)

	WHEN MATCHED THEN
	UPDATE
	SET
	ProductId = source.ProductId,
	CustomerId	= source.CustomerId,
	PaymentTypeId = source.PaymentTypeId,
	TotalAmount = source.TotalAmount,		
	OperationDate = Sysdatetime()									

	WHEN NOT MATCHED THEN
	INSERT (ProductId, CustomerId, PaymentTypeId, TotalAmount, OperationDate)
	VALUES (
	ProductId,
	CustomerId,
	PaymentTypeId,
	TotalAmount,
	Sysdatetime()
	);

	if(@result is null)set @result = SCOPE_IDENTITY()
	exec Order_SelectById @result
