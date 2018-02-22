IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetTripBeginByID')
	DROP PROCEDURE GetTripBeginByID
GO

CREATE PROCEDURE GetTripBeginByID

@ReferenceID INT

AS

BEGIN

	CREATE TABLE #TEMP (
		VehicleCode VARCHAR(5), 
		VehicleNumber VARCHAR(20)
	)

	INSERT INTO #TEMP 
	SELECT VehicleCode , VehicleNumber
	FROM
		Fleet
	UNION ALL 
	SELECT VehicleCode , VehicleNumber
	FROM
		ThirdPartyVehicle

	SELECT 
		ReferenceID
		,ReferenceDate
		,OrderCompanyName
		,VendorName
		,SourceLocation
		,DestinationLocation
		,F.VehicleNumber
		,D.DriverName
		,OrderPersonName
		,OrderPersonContact
		,BuiltyNumber
		,LoadedWeight
		,ShipmentName
		,StartingMeterReading
		,EstimatedTime
		,IsEnded
		,EntryUser
		,EntryDate
		,UpdateUser
		,UpdateDate
		,TB.IsDeleted
	FROM 
		TripBegin AS TB
		INNER JOIN #TEMP AS F ON F.VehicleCode = TB.VehicleCode
		INNER JOIN Driver AS D ON D.DriverCode = TB.DriverCode
	WHERE
		ReferenceID = @ReferenceID

END


