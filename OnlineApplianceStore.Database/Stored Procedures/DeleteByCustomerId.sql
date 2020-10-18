CREATE Procedure [dbo].[DeleteCustomerById]
  @ID BIGINT
  as
	UPDATE dbo.[Customer] 
	SET IsDeleted = 1
	WHERE (@ID = ID)	