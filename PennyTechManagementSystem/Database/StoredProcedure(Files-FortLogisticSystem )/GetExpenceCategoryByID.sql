IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetExpenceCategoryByID')
	DROP PROCEDURE GetExpenceCategoryByID
GO

CREATE PROCEDURE GetExpenceCategoryByID

@ExpenceCategoryID INT

AS

BEGIN

	SELECT 
		ExpenceCategoryID ,
		ExpenceCategoryName
	FROM
		ExpenceCategory
	WHERE
		ExpenceCategoryID = @ExpenceCategoryID

END