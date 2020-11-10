CREATE PROCEDURE [dbo].[Product_Merge]
	@Id BIGINT,
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
	DECLARE 
	@result BIGINT
	MERGE dbo.Product P
	USING (SELECT @Id, @Name, @Price, @Length, @Width, @Height, @Weight, @Manufacturer, @ProductionYear, @MaxPower, @NumberOfPrograms, @Color,
	@BowlVolume, @ProductShape, @ProductLife, @NoiseLevel, @MinTemperature, @NumberOfToasts, @BatteryLife, @PowerRegulator, @Timer,
	@Defrost, @SuperFrost, @Backlight, @Display, @CarboneFilter, @WetCleaning, @GlassCase, @RemoteController, @WithBattery)
	AS
	source (Id, Name, Price, Length, Width, Height, Weight, Manufacturer, ProductionYear, MaxPower, NumberOfPrograms, Color,
	BowlVolume, ProductShape, ProductLife, NoiseLevel, MinTemperature, NumberOfToasts, BatteryLife, PowerRegulator, Timer,
	Defrost, SuperFrost, Backlight, Display, CarboneFilter, WetCleaning, GlassCase, RemoteController, WithBattery)
	ON (P.Id = source.Id)

	
	WHEN MATCHED THEN
	UPDATE
	SET
	Name = source.Name, 
	Price = source.Price, 
	Length = source.Length,
	Width = source.Width,
	Height = source.Height,
	Weight = source.Weight,
	Manufacturer = source.Manufacturer,
	ProductionYear = source.ProductionYear,
	MaxPower = source.MaxPower,
	NumberOfPrograms = source.NumberOfPrograms,
	Color = source.Color,
	BowlVolume = source.BowlVolume,
	ProductShape = source.ProductShape,
	ProductLife = source.ProductLife,
	NoiseLevel = source.NoiseLevel,
	MinTemperature = source.MinTemperature,
	NumberOfToasts = source.NumberOfToasts,
	BatteryLife = source.BatteryLife,
	PowerRegulator = source.PowerRegulator,
	Timer = source.Timer,
	Defrost	= source.Defrost,
	SuperFrost = source.SuperFrost,
	Backlight = source.Backlight,
	Display = source.Display,
	CarboneFilter = source.CarboneFilter,
	WetCleaning = source.WetCleaning,
	GlassCase = source.GlassCase,
	RemoteController = source.RemoteController,
	WithBattery = source.WithBattery

	WHEN NOT MATCHED THEN
	INSERT (Name, Price, Length, Width, Height, Weight, Manufacturer, ProductionYear, MaxPower, NumberOfPrograms, Color,
	BowlVolume, ProductShape, ProductLife, NoiseLevel, MinTemperature, NumberOfToasts, BatteryLife, PowerRegulator, Timer,
	Defrost, SuperFrost, Backlight, Display, CarboneFilter, WetCleaning, GlassCase, RemoteController, WithBattery)
	VALUES (
	source.Name, 
	source.Price, 
	source.Length,
	source.Width,
	source.Height, 
	source.Weight,
	source.Manufacturer, 
	source.ProductionYear,
	source.MaxPower,
	source.NumberOfPrograms,
	source.Color,
	source.BowlVolume,
	source.ProductShape, 
	source.ProductLife,
	source.NoiseLevel,
	source.MinTemperature,
	source.NumberOfToasts,
	source.BatteryLife, 
	source.PowerRegulator, 
	source.Timer,
	source.Defrost,
	source.SuperFrost,
	source.Backlight,
	source.Display, 
	source.CarboneFilter,
	source.WetCleaning, 
	source.GlassCase,
	source.RemoteController,
	source.WithBattery
	);

	exec Order_SelectById @result