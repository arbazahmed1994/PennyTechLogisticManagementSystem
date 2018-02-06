IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetVehicleTypeByID')
	DROP PROCEDURE GetVehicleTypeByID
GO

CREATE PROCEDURE GetVehicleTypeByID

@VehicleTypeID INT

AS

BEGIN
	
	SELECT
		VehicleTypeID,
		VehicleTypeName
	FROM
		VehicleType
	WHERE
		VehicleTypeID = @VehicleTypeID

END