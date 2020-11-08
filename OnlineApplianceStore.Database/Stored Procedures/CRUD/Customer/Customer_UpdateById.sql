CREATE PROCEDURE [dbo].[Customer_UpdateById]
	@Id bigint,
	@RoleId int,
	@CityId int,
	@Name nvarchar(30),
	@LastName nvarchar(30),
	@Phone nvarchar(20),
	@Password nvarchar(30),
	@Address nvarchar(100),
	@Email nvarchar(50),
	@Birthday date
AS
	begin
	UPDATE dbo.Customer
	SET
	CityId = @CityId,
	RoleId = @RoleId,
	[Name] = @Name,
	LastName = @LastName,
	Phone = @Phone,
	[Password] = @Password,
	[Address] = @Address, 
	Email = @Email,
	Birthday = @Birthday,
	LastUpdateDate = SYSDATETIME()

	WHERE (Id = @Id)

	DECLARE @CustomrerId bigint
	SET @CustomrerId = SCOPE_IdENTITY()
	exec [dbo].[Customer_SelectById] @CustomrerId
	END

