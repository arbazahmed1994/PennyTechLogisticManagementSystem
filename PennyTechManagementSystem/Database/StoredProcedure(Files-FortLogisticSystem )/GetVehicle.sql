IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetVehicle')
	DROP PROCEDURE GetVehicle
GO

CREATE PROCEDURE GetVehicle

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
		IsDeleted = 0

END