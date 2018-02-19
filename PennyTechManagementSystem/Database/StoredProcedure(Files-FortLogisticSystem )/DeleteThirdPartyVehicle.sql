IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteThirdPartyVehicle')
	DROP PROCEDURE DeleteThirdPartyVehicle
GO

CREATE PROCEDURE DeleteThirdPartyVehicle

@VehicleCode VARCHAR(5)

AS

BEGIN
	
	DELETE
		ThirdPartyVehicle
	WHERE
		VehicleCode = @VehicleCode
	
END