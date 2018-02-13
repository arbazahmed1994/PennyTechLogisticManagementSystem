IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetVehicle')
	DROP PROCEDURE GetVehicle
GO

CREATE PROCEDURE GetVehicle

AS

BEGIN

	SELECT
		VehicleCode,
		VehicleNumber,
		VT.VehicleTypeName,
		VBT.VehicleBusinessTypeName,
		VC.VehicleCompanyName,
		VehicleLenght,
		ModelYear,
		C.CountryName,
		NumberOfWheels,
		ChasisNumber,
		EngineNumber,
		EngineHorsePower,
		S.StatusName,
		Color.ColorName,
		PurchaseDate,
		PurchaseFrom,
		ManufactureDate,
		ManufacturedFrom,
		VehicleModelName,
		VehicleEntryDate
	FROM
		Fleet AS F
		INNER JOIN VehicleType AS VT ON VT.VehicleTypeID = F.VehicleTypeID
		INNER JOIN VehicleBusinessType AS VBT ON VBT.VehicleBusinessTypeID = F.VehicleBusinessTypeID
		INNER JOIN VehicleCompany AS VC ON VC.VehicleCompanyID = F.VehicleCompanyID
		INNER JOIN Countries AS C ON C.CountryID = F.CountryID
		INNER JOIN Colors AS Color ON Color.ColorID = F.ColorID
		INNER JOIN Status AS S ON S.StatusID = F.StatusID
	WHERE
		F.IsDeleted = 0

END