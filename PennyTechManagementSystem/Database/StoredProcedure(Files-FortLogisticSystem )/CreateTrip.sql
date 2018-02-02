IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateTrip')
	DROP PROCEDURE CreateTrip
GO

CREATE PROCEDURE CreateTrip

@TripRouteID INT,
@VehicleCode VARCHAR(4),
@DriverCode VARCHAR(4),
@StartingDate DATE,
@ApproxEndDate DATE,
@TripAmount FLOAT,
@IsEnded BIT,
@DetentionNeeded BIT

AS

BEGIN

	INSERT INTO [dbo].[TripBeginning]
           ([TripRouteID]
           ,[VehicleCode]
           ,[DriverCode]
           ,[StartingDate]
           ,[ApproxEndDate]
           ,[TripVehicleAmount]
           ,[IsEnded]
           ,[DetentionNeeded])
     VALUES
           (@TripRouteID ,
			@VehicleCode ,
			@DriverCode ,
			@StartingDate ,
			@ApproxEndDate ,
			@TripAmount ,
			@IsEnded ,
			@DetentionNeeded )

END
GO


