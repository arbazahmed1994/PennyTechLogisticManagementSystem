IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteExpenceCategory')
	DROP PROCEDURE DeleteExpenceCategory
GO

CREATE PROCEDURE DeleteExpenceCategory

@ExpenceCategoryID INT 

AS

BEGIN

	DELETE 
		ExpenceCategory 
	WHERE 
		ExpenceCategoryID = @ExpenceCategoryID

END