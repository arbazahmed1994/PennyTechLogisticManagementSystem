IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetEndedTrips')
	DROP PROCEDURE GetEndedTrips
GO

CREATE PROCEDURE GetEndedTrips

AS 

BEGIN
	
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
		INNER JOIN Fleet AS F ON F.VehicleCode = TB.VehicleCode
		INNER JOIN Driver AS D ON D.DriverCode = TB.DriverCode
	WHERE 
		TB.IsEnded = 1

END