IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteVehicleCompany')
	DROP PROCEDURE DeleteVehicleCompany
GO

CREATE PROCEDURE DeleteVehicleCompany

@VehicleCompanyID INT

AS 

BEGIN
	
	DELETE FROM VehicleCompany
	WHERE VehicleCompanyID = @VehicleCompanyID

END