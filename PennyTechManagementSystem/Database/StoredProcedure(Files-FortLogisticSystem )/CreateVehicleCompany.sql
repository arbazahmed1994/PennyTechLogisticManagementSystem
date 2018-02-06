IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateVehicleCompany')
	DROP PROCEDURE CreateVehicleCompany
GO

CREATE PROCEDURE CreateVehicleCompany

@VehicleCompanyName VARCHAR(25)

AS 

BEGIN
	
	IF NOT EXISTS (SELECT VehicleCompanyName FROM VehicleCompany WHERE VehicleCompanyName = @VehicleCompanyName)
	BEGIN
		INSERT INTO VehicleCompany (
			VehicleCompanyName )
		VALUES (
			@VehicleCompanyName )
	END
	ELSE
	BEGIN
		RAISERROR('There is another entity with similar name' ,16 ,1)
	END

END