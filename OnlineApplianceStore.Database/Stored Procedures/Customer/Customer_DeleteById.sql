CREATE Procedure [dbo].[Customer_DeleteById]
	@ID BIGINT
As
	UPDATE dbo.Customer
	SET 
	IsDeleted = 1
	WHERE (Id = @ID)