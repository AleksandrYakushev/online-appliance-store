--CREATE PROCEDURE [dbo].[Customer_Merge]
--	@Id bigint,
--	@RoleId int,
--	@CityId int,
--	@Name nvarchar(30),
--	@LastName nvarchar(30),
--	@Phone nvarchar(20),
--	@Password nvarchar(30),
--	@Address nvarchar(100),
--	@Email nvarchar(50),
--	@Birthday date
	
--AS

--	DECLARE
--	@result bigint
--	MERGE dbo.Customer as C
--	USING (select @Id, @RoleId, @CityId, @Name, @LastName, @Phone, @Password,
--	@Address, @Email, @Birthday)
--	AS 
--	source (Id, RoleId, CityId, [Name], LastName, Phone, [Password],
--	[Address], Email, Birthday, RegistrationDate, LastUpdateDate) 
--	ON 
--	(C.Id = source.Id)

--	WHEN MATCHED THEN
--	UPDATE
--	SET
--	RoleId = source.RoleId,
--	CityId = source.CityId,
--	[Name] = source.[Name],
--	LastName = source.LastName,
--	Phone = source.Phone,
--	[Password] = source.[Password],
--	[Address] = source.[Address],
--	Email = source.Email,
--	Birthday = source.Birthday,								
--	LastUpdateDate = Sysdatetime()									

--	WHEN NOT MATCHED THEN
--	INSERT (RoleId, CityId, [Name], LastName, Phone, [Password], [Address], Email,
--	Birthday, RegistrationDate, LastUpdateDate)
--	VALUES (
--	source.RoleId,
--	source.CityId,
--	source.[Name],
--	source.LastName,
--	source.Phone,
--	source.[Password],
--	source.[Address],
--	source.Email,
--	source.Birthday,
--	Sysdatetime(),
--	Sysdatetime(),
--	source.LastUpdateDate
--	);

--	SET @result = SCOPE_IDENTITY()
--	exec Customer_SelectById @result



