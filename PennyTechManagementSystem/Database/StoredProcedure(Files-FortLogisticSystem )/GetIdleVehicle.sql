IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetIdleVehicle')
	DROP PROCEDURE GetIdleVehicle
GO

CREATE PROCEDURE GetIdleVehicle

AS

BEGIN

-- EMPLOYEE DATA
	SELECT
		COUNT(VehicleNumber) AS VehicleCountPrivate
	FROM
		Fleet

	SELECT
		COUNT(VehicleNumber) AS VehicleCountOther
	FROM
		ThirdPartyVehicle

	SELECT
		COUNT(VehicleNumber) AS VehicleIdlePrivate
	FROM
		FLEET
	WHERE
		VehicleCode NOT IN (SELECT VehicleCode FROM TripBegin WHERE IsEnded = 0)

	SELECT
		COUNT(VehicleNumber) AS VehicleIdleOther
	FROM
		ThirdPartyVehicle
	WHERE
		VehicleCode NOT IN (SELECT VehicleCode FROM TripBegin WHERE IsEnded = 0)

-- DRIVER DATA

	SELECT
		COUNT(DriverName) AS DriverCount
	FROM
		Driver

	SELECT
		COUNT(DriverName) AS DriverIdle
	FROM
		Driver
	WHERE
		DriverCode NOT IN (SELECT DriverCode FROM TripBegin WHERE IsEnded = 0)

-- EMPLOYEE DATA

	SELECT
		COUNT(FullName) AS EmployeeCount
	FROM
		EmployeeUser

	SELECT
		COUNT(UserID) AS EmployeePresent
	FROM
		OnlineUser
	WHERE
		Deactive = 0

END