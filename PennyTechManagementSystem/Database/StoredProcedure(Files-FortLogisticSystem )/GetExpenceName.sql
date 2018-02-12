IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetExpenceName')
	DROP PROCEDURE GetExpenceName
GO

CREATE PROCEDURE GetExpenceName

AS

BEGIN

	SELECT 
		ExpenceNameID,
		ExpenceName ,
		EC.ExpenceCategoryName
	FROM
		ExpenceName AS EN
	INNER JOIN ExpenceCategory AS EC
		ON EN.ExpenceCategoryID = EC.ExpenceCategoryID

END