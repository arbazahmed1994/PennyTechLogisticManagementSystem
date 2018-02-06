IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateVehicleType')
	DROP PROCEDURE CreateVehicleType
GO

CREATE PROCEDURE CreateVehicleType

@VehicleTypeName VARCHAR(30)

AS

BEGIN

	IF NOT EXISTS (SELECT VehicleTypeName FROM VehicleType WHERE VehicleTypeName = @VehicleTypeName)
	BEGIN
		INSERT INTO VehicleType (
			VehicleTypeName)
		VALUES (
			@VehicleTypeName)
	END
	ELSE
	BEGIN
		RAISERROR('There is another entity with similar name', 16, 1)
	END

END