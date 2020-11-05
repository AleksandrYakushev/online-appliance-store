CREATE PROCEDURE [dbo].[Product_Create]
	@Name NVARCHAR(50),
	@Price DECIMAL,
	@Length FLOAT,
	@Width FLOAT,
	@Height FLOAT, 
	@Weight FLOAT, 
	@Manufacturer NVARCHAR(50), 
	@ProductionYear DATE, 
	@MaxPower FLOAT, 
	@NumberOfPrograms INT, 
	@Color NVARCHAR(20),
	@BowlVolume INT, 
	@ProductShape NVARCHAR(20), 
	@ProductLife INT, 
	@NoiseLevel INT, 
	@MinTemperature INT, 
	@NumberOfToasts INT, 
	@BatteryLife INT, 
	@PowerRegulator BIT, 
	@Timer BIT,
	@Defrost BIT, 
	@SuperFrost BIT, 
	@Backlight BIT, 
	@Display BIT, 
	@CarboneFilter BIT, 
	@WetCleaning BIT, 
	@GlassCase BIT, 
	@RemoteController BIT, 
	@WithBattery BIT
AS
	Begin
	INSERT INTO dbo.Product(Name, Price, Length, Width, Height, Weight, Manufacturer, ProductionYear, MaxPower, NumberOfPrograms, Color,
	BowlVolume, ProductShape, ProductLife, NoiseLevel, MinTemperature, NumberOfToasts, BatteryLife, PowerRegulator, Timer,
	Defrost, SuperFrost, Backlight, Display, CarboneFilter, WetCleaning, GlassCase, RemoteController, WithBattery, IsDeleted)
	VALUES (@Name, @Price, @Length, @Width, @Height, @Weight, @Manufacturer, @ProductionYear, @MaxPower, @NumberOfPrograms, @Color,
	@BowlVolume, @ProductShape, @ProductLife, @NoiseLevel, @MinTemperature, @NumberOfToasts, @BatteryLife, @PowerRegulator, @Timer,
	@Defrost, @SuperFrost, @Backlight, @Display, @CarboneFilter, @WetCleaning, @GlassCase, @RemoteController, @WithBattery)
	DECLARE @ProductId BIGINT
	SET @ProductId = SCOPE_IdENTITY()
	exec [dbo].[Product_SelectById] @ProductId
	END