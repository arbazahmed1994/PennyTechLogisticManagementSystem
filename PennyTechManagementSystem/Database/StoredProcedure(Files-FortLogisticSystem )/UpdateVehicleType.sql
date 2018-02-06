IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateVehicleType')
	DROP PROCEDURE UpdateVehicleType
GO

CREATE PROCEDURE UpdateVehicleType

@VehicleTypeID INT,
@VehicleTypeName VARCHAR(30)

AS 

BEGIN

	UPDATE VehicleType SET 
		VehicleTypeName = @VehicleTypeName
	WHERE
		VehicleTypeID = @VehicleTypeID

END