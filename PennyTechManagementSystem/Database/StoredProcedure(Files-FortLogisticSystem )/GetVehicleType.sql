IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetVehicleType')
	DROP PROCEDURE GetVehicleType
GO

CREATE PROCEDURE GetVehicleType

AS

BEGIN

	SELECT
		VehicleTypeID,
		VehicleTypeName
	FROM
		VehicleType

END