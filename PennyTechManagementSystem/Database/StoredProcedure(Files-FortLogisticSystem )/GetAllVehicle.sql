IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetAllVehicle')
	DROP PROCEDURE GetAllVehicle
GO

CREATE PROCEDURE GetAllVehicle

AS

BEGIN

	SELECT 
		VehicleCode,
		VehicleNumber 
	FROM 
		Fleet
	UNION ALL
	SELECT 
		VehicleCode ,
		VehicleNumber + ' / Other'
	FROM 
		ThirdPartyVehicle
	WHERE 
		Returned = 0

END