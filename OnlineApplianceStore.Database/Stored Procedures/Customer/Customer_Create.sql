CREATE PROCEDURE [dbo].[Customer_Create]
	@RoleId int,
	@CityId int,
	@Name nvarchar (30),
	@LastName nvarchar (30),
	@Phone nvarchar (20),
	@Password nvarchar (30),
	@Address nvarchar (100),
	@Email nvarchar (50),
	@Birthday date,
	@RegistrationDate datetime2,
	@LastUpdateDate datetime2
AS
	INSERT INTO dbo.Customer
	VALUES (@RoleId, @CityId, @Name, @LastName, @Phone, @Password, @Address, @Email, @Birthday, SYSDATETIME(), SYSDATETIME())

	SELECT SCOPE_IDENTITY()
