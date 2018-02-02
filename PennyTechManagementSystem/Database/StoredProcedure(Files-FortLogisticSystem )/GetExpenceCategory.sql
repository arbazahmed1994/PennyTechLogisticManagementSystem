IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetExpenceCategory')
	DROP PROCEDURE GetExpenceCategory
GO

CREATE PROCEDURE GetExpenceCategory

AS

BEGIN

	SELECT 
		ExpenceCategoryID ,
		ExpenceCategoryName
	FROM
		ExpenceCategory

END