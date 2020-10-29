CREATE PROCEDURE [dbo].[Customer_SelectById]
	@ID int
AS
	SELECT 
	Id, RoleId, Phone, [Name], LastName, [Address], Email, Birthday, RegistrationDate, LastUpdateDate, IsDeleted
	FROM
	[dbo].[Customer]
	WHERE (Id = @ID)
