IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetDesignationsByID')
	DROP PROCEDURE GetDesignationsByID
GO

CREATE PROCEDURE GetDesignationsByID

@DesignationID INT

AS 

BEGIN
	
	SELECT
		DesignationID,
		DesignationName
	FROM 
		Designations
	WHERE
		DesignationID = @DesignationID

END