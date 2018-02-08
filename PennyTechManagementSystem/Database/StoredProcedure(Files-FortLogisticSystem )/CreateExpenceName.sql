IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateExpenceName')
	DROP PROCEDURE CreateExpenceName
GO

CREATE PROCEDURE CreateExpenceName

@ExpenceName VARCHAR(100),
@ExpenceCategoryID INT

AS

BEGIN

	IF NOT EXISTS (SELECT ExpenceName FROM ExpenceName WHERE ExpenceName = @ExpenceName AND ExpenceCategoryID = @ExpenceCategoryID)
	BEGIN
		INSERT INTO ExpenceName (
			ExpenceName,
			ExpenceCategoryID )
		VALUES (
			@ExpenceName,
			@ExpenceCategoryID )
	END
	ELSE
	BEGIN
		RAISERROR ('Expence already Exist', 16, 1)
	END

END