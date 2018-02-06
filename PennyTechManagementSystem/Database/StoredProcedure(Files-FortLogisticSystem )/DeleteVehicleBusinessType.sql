IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteVehicleBusinessType')
	DROP PROCEDURE DeleteVehicleBusinessType
GO

CREATE PROCEDURE DeleteVehicleBusinessType

@VehicleBusinessTypeID INT

AS 

BEGIN

	DELETE FROM VehicleBusinessType
	WHERE VehicleBusinessTypeID = @VehicleBusinessTypeID

END