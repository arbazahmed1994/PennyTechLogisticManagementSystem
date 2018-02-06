IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteVehicleType')
	DROP PROCEDURE DeleteVehicleType
GO

CREATE PROCEDURE DeleteVehicleType

@VehicleTypeID INT

AS

BEGIN

	DELETE FROM VehicleType
	WHERE VehicleTypeID = @VehicleTypeID

END