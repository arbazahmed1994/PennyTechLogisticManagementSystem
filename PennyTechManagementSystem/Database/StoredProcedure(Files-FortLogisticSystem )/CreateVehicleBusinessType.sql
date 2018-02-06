IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateVehicleBusinessType')
	DROP PROCEDURE CreateVehicleBusinessType
GO

CREATE PROCEDURE CreateVehicleBusinessType

@VehicleBusinessTypeName VARCHAR(30)

AS 

BEGIN

	INSERT INTO VehicleBusinessType (
		VehicleBusinessTypeName )
	VALUES (
		@VehicleBusinessTypeName )

END