IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateTripBegin')
	DROP PROCEDURE CreateTripBegin
GO

CREATE PROCEDURE CreateTripBegin

@ReferenceDate DATE,
@OrderCompanyName VARCHAR(100),
@VendorName VARCHAR(100),
@SourceLocation NVARCHAR(300),
@DestinationLocation NVARCHAR(300),
@VehicleCode VARCHAR(5),
@DriverCode VARCHAR(4),
@OrderPersonName VARCHAR(50),
@OrderPersonContact VARCHAR(50),
@BuiltyNumber VARCHAR(100),
@LoadedWeight DECIMAL(8,2),
@ShipmentName VARCHAR(100),
@StartingMeterReading DECIMAL(18,2),
@EstimatedTime FLOAT,
@EntryUser INT

AS

BEGIN

	INSERT INTO TripBegin (
		ReferenceDate,
		OrderCompanyName,
		VendorName,
		SourceLocation,
		DestinationLocation,
		VehicleCode,
		DriverCode,
		OrderPersonName,
		OrderPersonContact,
		BuiltyNumber,
		LoadedWeight,
		ShipmentName,
		StartingMeterReading,
		EstimatedTime,
		IsEnded,
		EntryDate,
		IsDeleted,
		EntryUser )
	VALUES (
		@ReferenceDate ,
		@OrderCompanyName ,
		@VendorName ,
		@SourceLocation ,
		@DestinationLocation ,
		@VehicleCode ,
		@DriverCode ,
		@OrderPersonName ,
		@OrderPersonContact ,
		@BuiltyNumber ,
		@LoadedWeight ,
		@ShipmentName ,
		@StartingMeterReading ,
		@EstimatedTime ,
		0 ,
		GETDATE() ,
		0,
		@EntryUser )

END

