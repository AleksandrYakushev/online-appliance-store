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
	@Birthday date,
	@RegistrationDate datetime2,
	@LastUpdateDate datetime2
AS
	UPDATE dbo.Customer
	SET
	RoleId = @RoleId,
	CityId = @CityId,
	[Name] = @Name,
	LastName = @LastName,
	Phone = @Phone,
	[Password] = @Password,
	[Address] = @Address, 
	Email = @Email,
	Birthday = @Birthday,
	RegistrationDate = @RegistrationDate,
	LastUpdateDate = @LastUpdateDate

	WHERE (Id = @Id)
