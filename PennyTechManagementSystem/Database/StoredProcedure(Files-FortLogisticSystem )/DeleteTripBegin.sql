IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteTripBegin')
	DROP PROCEDURE DeleteTripBegin
GO

CREATE PROCEDURE DeleteTripBegin

@ReferenceID INT

AS

BEGIN

	UPDATE TripBegin SET 
		IsDeleted = 1,
		UpdateDate = GETDATE()
	WHERE
		ReferenceID = @ReferenceID

END