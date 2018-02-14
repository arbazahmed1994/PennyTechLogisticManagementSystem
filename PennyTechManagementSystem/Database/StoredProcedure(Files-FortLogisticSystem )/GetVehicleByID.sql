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
		VT.VehicleTypeName,
		F.VehicleTypeID,
		VBT.VehicleBusinessTypeName,
		F.VehicleBusinessTypeID,
		VC.VehicleCompanyName,
		F.VehicleCompanyID,
		VehicleLenght,
		ModelYear,
		C.CountryName,
		F.CountryID,
		NumberOfWheels,
		ChasisNumber,
		EngineNumber,
		EngineHorsePower,
		S.StatusName,
		F.StatusID,
		Color.ColorName,
		F.ColorID,
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
		VehicleCode = @VehicleCode AND
		IsDeleted = 0

END