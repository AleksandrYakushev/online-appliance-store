﻿--CREATE PROCEDURE [dbo].[Product_UpdateById]
--	@Id BIGINT,
--	@Name NVARCHAR(50),
--	@Price DECIMAL,
--	@Length FLOAT,
--	@Width FLOAT,
--	@Height FLOAT, 
--	@Weight FLOAT, 
--	@Manufacturer NVARCHAR(50), 
--	@ProductionYear DATE, 
--	@MaxPower FLOAT, 
--	@NumberOfPrograms INT, 
--	@Color NVARCHAR(20),
--	@BowlVolume INT, 
--	@ProductShape NVARCHAR(20), 
--	@ProductLife INT, 
--	@NoiseLevel INT, 
--	@MinTemperature INT, 
--	@NumberOfToasts INT, 
--	@BatteryLife INT, 
--	@PowerRegulator BIT, 
--	@Timer BIT,
--	@Defrost BIT, 
--	@SuperFrost BIT, 
--	@Backlight BIT, 
--	@Display BIT, 
--	@CarboneFilter BIT, 
--	@WetCleaning BIT, 
--	@GlassCase BIT, 
--	@RemoteController BIT, 
--	@WithBattery BIT, 
--	@IsDeleted BIT
--AS
--	UPDATE dbo.Customer
--	SET
--	Name = @Name,		
--	Price = @Price,		
--	Length = @Length,			
--	Width = @Width,		
--	Height  =@Height,	
--	Weight = @Weight,			
--	Manufacturer = @Manufacturer,	
--	ProductionYear = @ProductionYear,
--	MaxPower = @MaxPower,
--	NumberOfPrograms = @NumberOfPrograms,
--	Color = @Color,
--	BowlVolume = @BowlVolume,
--	ProductShape = @ProductShape,	
--	ProductLife = @ProductLife,	
--	NoiseLevel = @NoiseLevel,		
--	MinTemperature = @MinTemperature,	
--	NumberOfToasts = @NumberOfToasts,
--	BatteryLife = @BatteryLife,
--	PowerRegulator = @PowerRegulator,
--	Timer = @Timer,
--	Defrost = @Defrost,		
--	SuperFrost = @SuperFrost,		
--	Backlight = @Backlight,	
--	Display = @Display,
--	CarboneFilter = @CarboneFilter,
--	WetCleaning = @WetCleaning,	
--	GlassCase = @GlassCase,	
--	RemoteController = @RemoteController,
--	WithBattery = @WithBattery,
--	IsDeleted = @IsDeleted

--	WHERE (Id = @Id)
