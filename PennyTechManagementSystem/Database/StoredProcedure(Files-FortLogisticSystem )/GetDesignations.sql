IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetDesignations')
	DROP PROCEDURE GetDesignations
GO

CREATE PROCEDURE GetDesignations

AS 

BEGIN
	
	SELECT
		DesignationID,
		DesignationName
	FROM 
		Designations

END