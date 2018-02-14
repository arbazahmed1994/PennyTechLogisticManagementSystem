IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetExpenceNameByID')
	DROP PROCEDURE GetExpenceNameByID
GO

CREATE PROCEDURE GetExpenceNameByID

@ExpenceNameID INT

AS

BEGIN

	SELECT 
		ExpenceName ,
		EC.ExpenceCategoryName,
		EN.ExpenceCategoryID
	FROM
		ExpenceName AS EN
	INNER JOIN ExpenceCategory AS EC
		ON EN.ExpenceCategoryID = EC.ExpenceCategoryID
	WHERE
		ExpenceNameID = @ExpenceNameID

END