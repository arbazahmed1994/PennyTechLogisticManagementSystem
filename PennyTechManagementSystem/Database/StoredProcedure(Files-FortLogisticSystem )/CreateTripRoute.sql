IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateTripRoute')
	DROP PROCEDURE CreateTripRoute
GO

CREATE PROCEDURE CreateTripRoute

@TripRouteName VARCHAR(100),
@TripFrom VARCHAR(50),
@TripTo VARCHAR(50),
@ApproximateDay INT,
@TripAmount FLOAT

AS

BEGIN

		INSERT INTO [dbo].[TripRoute]
			   ([TripRouteName]
			   ,[TripFrom]
			   ,[TripTo]
			   ,[ApproximateDay]
			   ,[TripAmount])
		 VALUES
			   (@TripRouteName ,
				@TripFrom ,
				@TripTo ,
				@ApproximateDay ,
				@TripAmount )

END
GO


