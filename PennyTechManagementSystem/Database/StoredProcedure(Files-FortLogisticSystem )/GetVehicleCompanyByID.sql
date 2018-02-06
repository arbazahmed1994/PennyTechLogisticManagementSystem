IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetVehicleCompanyByID')
	DROP PROCEDURE GetVehicleCompanyByID
GO

CREATE PROCEDURE GetVehicleCompanyByID

@VehicleCompanyID INT

AS 

BEGIN
	
	SELECT
		VehicleCompanyID,
		VehicleCompanyName
	FROM 
		VehicleCompany
	WHERE
		VehicleCompanyID = @VehicleCompanyID

END