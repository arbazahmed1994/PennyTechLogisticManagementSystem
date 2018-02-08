IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetVehicleByID')
	DROP PROCEDURE GetVehicleByID
GO

CREATE PROCEDURE GetVehicleByID

@VehicleCode VARCHAR(4)

AS

BEGIN

	SELECT
		VehicleCode,
		VehicleNumber,
		VehicleTypeID,
		VehicleBusinessTypeID,
		VehicleCompanyID,
		VehicleLenght,
		ModelYear,
		CountryID,
		NumberOfWheels,
		ChasisNumber,
		EngineNumber,
		EngineHorsePower,
		StatusID,
		ColorID,
		PurchaseDate,
		PurchaseFrom,
		ManufactureDate,
		ManufacturedFrom,
		VehicleModelName,
		VehicleEntryDate
	FROM
		Fleet
	WHERE
		VehicleCode = @VehicleCode AND
		IsDeleted = 0

END