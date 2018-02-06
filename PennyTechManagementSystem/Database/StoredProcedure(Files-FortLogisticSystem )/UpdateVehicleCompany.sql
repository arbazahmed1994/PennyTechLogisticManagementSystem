IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateVehicleCompany')
	DROP PROCEDURE UpdateVehicleCompany
GO

CREATE PROCEDURE UpdateVehicleCompany

@VehicleCompanyID INT,
@VehicleCompanyName VARCHAR(25)

AS 

BEGIN
	
	UPDATE VehicleCompany SET
		VehicleCompanyName = @VehicleCompanyName
	WHERE
		VehicleCompanyID = @VehicleCompanyID

END