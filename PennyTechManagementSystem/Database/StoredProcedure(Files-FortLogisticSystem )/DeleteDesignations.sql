IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteDesignations')
	DROP PROCEDURE DeleteDesignations
GO

CREATE PROCEDURE DeleteDesignations

@DesignationID INT

AS 

BEGIN
	
	DELETE FROM Designations
	WHERE DesignationID = @DesignationID

END