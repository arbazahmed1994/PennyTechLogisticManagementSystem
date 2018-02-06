IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetDriver')
	DROP PROCEDURE GetDriver
GO

CREATE PROCEDURE GetDriver

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

END