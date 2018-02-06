IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetVehicleCompany')
	DROP PROCEDURE GetVehicleCompany
GO

CREATE PROCEDURE GetVehicleCompany

AS 

BEGIN
	
	SELECT
		VehicleCompanyID,
		VehicleCompanyName
	FROM 
		VehicleCompany

END