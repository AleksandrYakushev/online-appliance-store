CREATE PROCEDURE [dbo].[Customer_SelectAll]
AS
	SELECT 
	C.Id, C.RoleId, C.Phone, C.[Name], C.LastName, C.[Address], C.Email, C.Birthday, C.RegistrationDate, C.LastUpdateDate, 
	R.Id, R.[Name],
	CY.Id, CY.[Name]
	FROM [dbo].[Customer] as C
	join dbo.City as CY on CY.Id = C.CityId
	join dbo.[Role] as R on R.Id = C.RoleId
	WHERE (IsDeleted = 0)
	