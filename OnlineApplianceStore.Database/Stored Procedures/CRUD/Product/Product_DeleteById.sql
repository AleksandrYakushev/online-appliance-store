CREATE PROCEDURE [dbo].[Product_DeleteById]
	@ID BIGINT
As
	UPDATE dbo.Product
	SET 
	IsDeleted = 1
	WHERE (Id = @ID)