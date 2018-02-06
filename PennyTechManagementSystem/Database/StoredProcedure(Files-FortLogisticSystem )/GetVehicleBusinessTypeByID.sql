IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetVehicleBusinessTypeByID')
	DROP PROCEDURE GetVehicleBusinessTypeByID
GO

CREATE PROCEDURE GetVehicleBusinessTypeByID

@VehicleBusinessTypeID INT

AS 

BEGIN

	SELECT 
	 VehicleBusinessTypeID,
	 VehicleBusinessTypeName
	FROM
		VehicleBusinessType
	WHERE
		VehicleBusinessTypeID = @VehicleBusinessTypeID

END