CREATE PROCEDURE [dbo].[Product_SelectById]
	@ProductId BIGINT
AS
	SELECT 
	P.Id, P.Name, P.Price, P.Length, P.Width, P.Height, P.Weight, P.Manufacturer, P.ProductionYear, P.MaxPower, P.NumberOfPrograms, P.Color,
	P.BowlVolume, P.ProductShape, P.ProductLife, P.NoiseLevel, P.MinTemperature, P.NumberOfToasts, P.BatteryLife, P.PowerRegulator, P.Timer,
	P.Defrost, P.SuperFrost, P.Backlight, P.Display, P.CarboneFilter, P.WetCleaning, P.GlassCase, P.RemoteController, P.WithBattery, P.IsDeleted
	FROM [dbo].[Product] as P
	
	WHERE (@ProductId = P.Id AND IsDeleted = 0)
