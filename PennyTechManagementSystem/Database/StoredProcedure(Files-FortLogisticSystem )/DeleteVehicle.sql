IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteVehicle')
	DROP PROCEDURE DeleteVehicle
GO

CREATE PROCEDURE DeleteVehicle

@VehicleCode VARCHAR(4)

AS

BEGIN

	DELETE FROM Fleet
	WHERE VehicleCode = @VehicleCode

END