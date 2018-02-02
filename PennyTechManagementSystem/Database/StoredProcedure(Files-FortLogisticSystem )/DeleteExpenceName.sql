IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteExpenceName')
	DROP PROCEDURE DeleteExpenceName
GO

CREATE PROCEDURE DeleteExpenceName

@ExpenceNameID INT

AS

BEGIN

	DELETE FROM ExpenceName
	WHERE ExpenceNameID = @ExpenceNameID

END