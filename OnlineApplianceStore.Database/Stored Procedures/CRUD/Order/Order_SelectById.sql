﻿CREATE PROCEDURE [dbo].[Order_SelectById]
	@OrderId bigint
AS
	SELECT
	O.Id, O.OperationDate, O.TotalAmount, O.PaymentTypeId,
	C.Id, C.[Name],
	P.Id, P.[Name],
	PT.Id, PT.[Name]
	FROM [dbo].[Order] as O
	join dbo.Customer as C on C.Id = O.CustomerId
	join dbo.Product as P on P.Id = O.ProductId
	join dbo.PaymentType as PT on PT.Id = O.PaymentTypeId
	WHERE (@OrderId = O.Id AND O.IsDeleted = 0)