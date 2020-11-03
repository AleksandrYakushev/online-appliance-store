CREATE PROCEDURE [dbo].[Customer_Create]
	@CityId int,
	@Name nvarchar (30),
	@LastName nvarchar (30),
	@Phone nvarchar (20),
	@Password nvarchar (30),
	@Address nvarchar (100),
	@Email nvarchar (50),
	@Birthday date
	
AS

	Begin
	INSERT INTO dbo.Customer(CityId, Name, LastName, Phone, Password, Address, Email, Birthday, RegistrationDate, LastUpdateDate)
	VALUES (@CityId, @Name, @LastName, @Phone, @Password, @Address, @Email,
	@Birthday, SYSDATETIME(), SYSDATETIME())
	DECLARE @CustomrerId bigint
	SET @CustomrerId = SCOPE_IdENTITY()
	exec [dbo].[Customer_SelectById] @CustomrerId
	END