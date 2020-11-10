CREATE PROCEDURE [dbo].[Customer_Merge]
	@Id BIGINT,
	@RoleId INT,
	@CityId INT,
	@Name NVARCHAR(30),
	@LastName NVARCHAR(30),
	@Phone NVARCHAR(20),
	@Password NVARCHAR(30),
	@Address NVARCHAR(100),
	@Email NVARCHAR(50),
	@Birthday DATE
AS
	DECLARE
	@result BIGINT
	SET @result = @Id
	MERGE dbo.Customer C
	USING (SELECT @Id, @RoleId, @CityId, @Name, @LastName, @Phone, @Password,
	@Address, @Email, @Birthday)
	AS 
	source (Id, RoleId, CityId, [Name], LastName, Phone, [Password],
	[Address], Email, Birthday) 
	ON 
	(C.Id = source.Id)

	WHEN MATCHED THEN
	UPDATE
	SET
	[Name] = source.[Name],
	LastName = source.LastName,
	Phone = source.Phone,
	[Password] = source.[Password],
	[Address] = source.[Address],
	Email = source.Email,
	Birthday = source.Birthday,								
	RoleId = source.RoleId,
	CityId = source.CityId,
	LastUpdateDate = Sysdatetime()									

	WHEN NOT MATCHED THEN
	INSERT (RoleId, CityId, [Name], LastName, Phone, [Password], [Address], Email,
	Birthday, RegistrationDate, LastUpdateDate)
	VALUES (
	source.RoleId,
	source.CityId,
	source.[Name],
	source.LastName,
	source.Phone,
	source.[Password],
	source.[Address],
	source.Email,
	source.Birthday,
	Sysdatetime(),
	Sysdatetime()
	);
	
	exec Customer_SelectById @result
