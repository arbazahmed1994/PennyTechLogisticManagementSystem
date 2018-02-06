IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetVehicleBusinessType')
	DROP PROCEDURE GetVehicleBusinessType
GO

CREATE PROCEDURE GetVehicleBusinessType

AS 

BEGIN
	
	SELECT 
		VehicleBusinessTypeID,
		VehicleBusinessTypeName
	FROM
		VehicleBusinessType

END