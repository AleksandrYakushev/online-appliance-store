CREATE PROCEDURE [dbo].[Customer_SelectById]
	@CustomerId bigint
AS
	SELECT
	C.Id, C.[Name], C.LastName, C.RegistrationDate, C.Birthday, C.[Address], C.Email, C.Phone,
	R.Id, R.[Name],
	CY.Id, CY.[Name]
	FROM [dbo].[Customer] as C
	join dbo.City as CY on CY.Id = C.CityId
	join dbo.[Role] as R on R.Id = C.RoleId
	WHERE (@CustomerId = C.Id AND IsDeleted = 0)
