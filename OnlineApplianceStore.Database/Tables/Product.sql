﻿CREATE TABLE [dbo].[Product] (
	Id BIGINT PRIMARY KEY NOT NULL IDENTITY (1, 1),
	[Name] NVARCHAR NOT NULL,
	Price decimal NOT NULL,
	[Length] FLOAT NOT NULL,
	Width FLOAT NOT NULL,
	Height FLOAT NOT NULL,
	[Weight] FLOAT NOT NULL,
	Manufacturer NVARCHAR(50) NOT NULL,
	ProductionYear DATE NOT NULL,
	MaxPower FLOAT NOT NULL,
	NumberOfPrograms INT,
	Color NVARCHAR(20),
	BowlVolume FLOAT,
	ProductShape NVARCHAR(20),
	ProductLife INT,
	NoiseLevel INT,
	MinTemperature INT,
	NumberOfToasts INT,
	BatteryLife INT,
	PowerRegulator BIT,
	Timer BIT,
	Defrost BIT,
	SuperFrost BIT,
	Backlight BIT,
	Display BIT,
	CarboneFilter BIT,
	WetCleaning BIT,
	GlassCase BIT,
	RemoteController BIT,
	WithBattery BIT
	)