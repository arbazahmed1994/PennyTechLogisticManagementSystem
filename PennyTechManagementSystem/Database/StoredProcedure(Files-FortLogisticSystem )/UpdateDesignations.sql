IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateDesignations')
	DROP PROCEDURE UpdateDesignations
GO

CREATE PROCEDURE UpdateDesignations

@DesignationID INT,
@DesignationName NVARCHAR(30)

AS 

BEGIN
	
	UPDATE Designations SET
		DesignationName = @DesignationName
	WHERE 
		DesignationID = @DesignationID

END