IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateDriver')
	DROP PROCEDURE CreateDriver
GO

CREATE PROCEDURE CreateDriver

@DriverName VARCHAR(30),
@DriverMobile VARCHAR(20),
@Salary FLOAT,
@DailyPityCash FLOAT,
@DriverCNIC VARCHAR(30),
@DrivingLicenceNumber VARCHAR(30)

AS

BEGIN

	INSERT INTO [dbo].[Driver]
           ([DriverCode]
           ,[DriverName]
           ,[DriverMobile]
           ,[Salary]
           ,[DailyPityCash]
           ,[DriverCNIC]
           ,[DrivingLicenceNumber])
     VALUES
           (( SELECT RIGHT('0000'+CAST(ISNULL(MAX(CONVERT(int,DriverCode)),0)+1 AS VARCHAR),4) FROM Driver ),
			@DriverName,
			@DriverMobile,
			@Salary,
			@DailyPityCash,
			@DriverCNIC,
			@DrivingLicenceNumber )

END