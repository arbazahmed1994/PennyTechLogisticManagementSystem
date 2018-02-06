IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateVehicleBusinessType')
	DROP PROCEDURE UpdateVehicleBusinessType
GO

CREATE PROCEDURE UpdateVehicleBusinessType

@VehicleBusinessTypeID INT,
@VehicleBusinessTypeName VARCHAR(30)

AS 

BEGIN

	UPDATE VehicleBusinessType SET
		VehicleBusinessTypeName = @VehicleBusinessTypeName
	WHERE
		VehicleBusinessTypeID = @VehicleBusinessTypeID

END