IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetThirdPartyVehicle')
	DROP PROCEDURE GetThirdPartyVehicle
GO

CREATE PROCEDURE GetThirdPartyVehicle

AS

BEGIN

	SELECT 
		VehicleCode,
		VehicleNumber,
		VT.VehicleTypeName,
		VBT.VehicleBusinessTypeName,
		VC.VehicleCompanyName,
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
		Returned = 0

END

GO


