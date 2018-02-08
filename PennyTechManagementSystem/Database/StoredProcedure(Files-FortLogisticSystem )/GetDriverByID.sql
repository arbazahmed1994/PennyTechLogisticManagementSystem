IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetDriverByID')
	DROP PROCEDURE GetDriverByID
GO

CREATE PROCEDURE GetDriverByID

@DriverCode VARCHAR(4)

AS 

BEGIN
	
	SELECT
		DriverCode,
		DriverName,
		DriverMobile,
		DriverCNIC,
		DrivingLicenceNumber,
		Salary,
		DailyPityCash
	FROM
		Driver
	WHERE 
		DriverCode = @DriverCode

END