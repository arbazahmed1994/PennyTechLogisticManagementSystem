IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateTripBegin')
	DROP PROCEDURE UpdateTripBegin
GO

CREATE PROCEDURE UpdateTripBegin

@ReferenceID INT,
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

	UPDATE TripBegin SET 
		ReferenceDate = @ReferenceDate,
		OrderCompanyName = @OrderCompanyName,
		VendorName = @VendorName,
		SourceLocation = @SourceLocation,
		DestinationLocation = @DestinationLocation,
		VehicleCode = @VehicleCode,
		DriverCode = @DriverCode,
		OrderPersonName = @OrderPersonName,
		OrderPersonContact = @OrderPersonContact,
		BuiltyNumber = @BuiltyNumber,
		LoadedWeight = @LoadedWeight,
		ShipmentName = @ShipmentName,
		StartingMeterReading = @StartingMeterReading,
		EstimatedTime = @EstimatedTime,
		UpdateDate = GETDATE(),
		UpdateUser = @EntryUser
	WHERE
		ReferenceID = @ReferenceID

END