IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateVehicle')
	DROP PROCEDURE UpdateVehicle
GO

CREATE PROCEDURE UpdateVehicle

@VehicleCode VARCHAR(4),
@VehicleNumber VARCHAR(20),
@VehicleTypeID INT,
@VehicleBusinessTypeID INT,
@VehicleCompanyID INT,
@VehicleLenght VARCHAR(10),
@ModelYear INT,
@CountryID INT,
@NumberOfWheels INT,
@ChasisNumber VARCHAR(50),
@EngineNumber VARCHAR(50),
@EngineHorsePower VARCHAR(15),
@StatusID INT,
@ColorID INT,
@PurchaseDate DATE,
@PurchaseFrom VARCHAR(30),
@ManufactureDate DATE,
@ManufacturedFrom NVARCHAR(50),
@VehicleModelName NVARCHAR(30)

AS

BEGIN
	
	UPDATE Fleet SET 
		VehicleNumber = @VehicleNumber,
		VehicleTypeID = @VehicleTypeID,
		VehicleBusinessTypeID = @VehicleBusinessTypeID,
		VehicleCompanyID = @VehicleCompanyID,
		VehicleLenght = @VehicleLenght,
		ModelYear = @ModelYear,
		CountryID = @CountryID,
		NumberOfWheels = @NumberOfWheels,
		ChasisNumber = @ChasisNumber,
		EngineNumber = @EngineNumber,
		EngineHorsePower = @EngineHorsePower,
		StatusID = @StatusID,
		ColorID = @ColorID,
		PurchaseDate = @PurchaseDate,
		PurchaseFrom = @PurchaseFrom,
		ManufactureDate = @ManufactureDate,
		ManufacturedFrom = @ManufacturedFrom,
		VehicleModelName = @VehicleModelName,
		IsUpdated = 1
	WHERE 
		VehicleCode = @VehicleCode

END


