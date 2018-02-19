IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateThirdPartyVehicle')
	DROP PROCEDURE CreateThirdPartyVehicle
GO

CREATE PROCEDURE CreateThirdPartyVehicle

@VehicleCode varchar(5),
@VehicleNumber varchar(10),
@VehicleCompany int,
@VehicleType int,
@VehicleBusinessType int,
@VehicleOwnerName varchar(50),
@RentInDate date,
@RentAmount float,
@ExpenceMode bit

AS

BEGIN

INSERT INTO ThirdPartyVehicle ( 
	VehicleCode,
	VehicleNumber,
	VehicleCompany,
	VehicleType,
	VehicleBusinessType,
	VehicleOwnerName,
	RentInDate,
	RentAmount,
	ExpenceMode,
	Returned )
VALUES (
	( SELECT RIGHT('99999'+CAST(ISNULL(MAX(CONVERT(int,VehicleCode)),0)+1 AS VARCHAR),5) as code from ThirdPartyVehicle ),
	@VehicleNumber,
	@VehicleCompany,
	@VehicleType,
	@VehicleBusinessType,
	@VehicleOwnerName ,
	@RentInDate ,
	@RentAmount ,
	@ExpenceMode ,
	0 ) -- Expence Mode : '0' = Our AND '1' = Owner 

END
GO


