CREATE PROCEDURE [dbo].[Customer_SelectAll]
AS
	SELECT 
	Id, RoleId, Phone, [Name], LastName, [Address], Email, Birthday, RegistrationDate, LastUpdateDate, IsDeleted
	FROM
	[dbo].[Customer]
