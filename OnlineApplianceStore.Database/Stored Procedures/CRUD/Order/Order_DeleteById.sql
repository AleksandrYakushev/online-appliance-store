CREATE PROCEDURE [dbo].[Order_DeleteById]
	@Id BIGINT
As
	UPDATE dbo.[Order]
	SET 
	IsDeleted = 1
	WHERE (Id = @Id)