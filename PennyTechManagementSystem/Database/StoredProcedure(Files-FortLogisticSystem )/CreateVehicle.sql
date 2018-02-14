IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateVehicle')
	DROP PROCEDURE CreateVehicle
GO

CREATE PROCEDURE CreateVehicle

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

	INSERT INTO dbo.Fleet
			   (VehicleCode
			   ,VehicleNumber
			   ,VehicleTypeID
			   ,VehicleBusinessTypeID
			   ,VehicleCompanyID
			   ,VehicleLenght
			   ,ModelYear
			   ,CountryID
			   ,NumberOfWheels
			   ,ChasisNumber
			   ,EngineNumber
			   ,EngineHorsePower
			   ,StatusID
			   ,ColorID
			   ,PurchaseDate
			   ,PurchaseFrom
			   ,ManufactureDate
			   ,ManufacturedFrom
			   ,VehicleModelName
			   ,IsDepreciated
			   ,IsDeleted
			   ,DeletedBy
			   ,IsUpdated
			   ,UpdatedBy
			   ,DeletedDate
			   ,VehicleEntryDate)
		 VALUES
			   ( ( SELECT RIGHT('0000'+CAST(ISNULL(MAX(CONVERT(int,VehicleCode)),0)+1 AS VARCHAR),4) as code from Fleet ),
				@VehicleNumber,
			    @VehicleTypeID,
				@VehicleBusinessTypeID,
				@VehicleCompanyID,
				@VehicleLenght,
				@ModelYear,
				@CountryID,
				@NumberOfWheels,
				@ChasisNumber,
				@EngineNumber,
				@EngineHorsePower,
				@StatusID,
				@ColorID,
				@PurchaseDate,
				@PurchaseFrom,
				@ManufactureDate,
				@ManufacturedFrom,
				@VehicleModelName,
				0,
				0,
				NULL,
				0,
				NULL,
				NULL,
				GETDATE())

END


