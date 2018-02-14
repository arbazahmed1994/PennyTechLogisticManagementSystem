IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetThirdPartyVehicleByID')
	DROP PROCEDURE GetThirdPartyVehicleByID
GO

CREATE PROCEDURE GetThirdPartyVehicleByID

@VehicleCode VARCHAR(4)

AS

BEGIN

	SELECT 
		VehicleCode,
		VehicleNumber,
		VT.VehicleTypeName,
		TPV.VehicleType,
		VBT.VehicleBusinessTypeName,
		TPV.VehicleBusinessType,
		VC.VehicleCompanyName,
		TPV.VehicleCompany,
		VehicleBusinessType,
		VehicleOwnerName,
		RentInDate,
		RentAmount,
		ExpenceMode,
		Returned,
		ReturnedDate
	FROM 
		ThirdPartyVehicle AS TPV
		INNER JOIN VehicleType AS VT ON VT.VehicleTypeID = TPV.VehicleType
		INNER JOIN VehicleBusinessType AS VBT ON VBT.VehicleBusinessTypeID = TPV.VehicleBusinessType
		INNER JOIN VehicleCompany AS VC ON VC.VehicleCompanyID = TPV.VehicleCompany
	WHERE
		VehicleCode = @VehicleCode

END

GO


