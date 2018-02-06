IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateDesignations')
	DROP PROCEDURE CreateDesignations
GO

CREATE PROCEDURE CreateDesignations

@DesignationName NVARCHAR(30)

AS 

BEGIN
	
	INSERT INTO Designations (
		DesignationName )
	VALUES (
		@DesignationName )

END