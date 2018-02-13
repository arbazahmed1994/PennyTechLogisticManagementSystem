IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateTripEnd')
	DROP PROCEDURE CreateTripEnd
GO

CREATE PROCEDURE CreateTripEnd

@TripReferenceID INT,
@FuelLitre DECIMAL(18,2),
@FuelRate DECIMAL(10,2),
@FuelAmount DECIMAL(18,2),
@EndDate DATE,
@TripExpenceListXML XML

AS

BEGIN

	SELECT * INTO #ExpencesList FROM(
		SELECT
			t.x.value('ExpenceNameID[1]','int') AS ExpenceNameID,
			t.x.value('Amount[1]','decimal(18,0)') AS Amount,
			t.x.value('Comments[1]','varchar(500)') AS Comments
		FROM @TripExpenceListXML.nodes('/TripExpenceLists/TripExpenceList') t(x)) AS A

	UPDATE TripBegin SET 
		IsEnded = 1
	WHERE 
		ReferenceID = @TripReferenceID

	INSERT INTO TripEnd (
		TripReferenceID ,
		FuelLitre ,
		FuelRate , 
		FuelAmount ,
		EndDate , 
		EntryDate , 
		IsDeleted )
	VALUES (
		@TripReferenceID ,
		@FuelLitre ,
		@FuelRate ,
		@FuelAmount ,
		@EndDate ,
		GETDATE() ,
		0 )

	DECLARE @MainTripID AS INT = (SELECT MainTripID FROM TripEnd WHERE TripReferenceID = @TripReferenceID)

	INSERT INTO TripExpenceDetail (
		MainTripID ,
		ExpenceNameID ,
		Amount ,
		Comments )
	SELECT
		@MainTripID ,
		ExpenceNameID ,
		Amount ,
		Comments
	FROM 
		#ExpencesList

END
