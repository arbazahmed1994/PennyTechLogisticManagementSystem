IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateExpenceCategory')
	DROP PROCEDURE CreateExpenceCategory
GO

CREATE PROCEDURE CreateExpenceCategory

@ExpenceCategoryName VARCHAR(100)

AS

BEGIN

	IF NOT EXISTS (SELECT ExpenceCategoryName FROM ExpenceCategory WHERE ExpenceCategoryName = @ExpenceCategoryName)
	BEGIN
		INSERT INTO ExpenceCategory (
			ExpenceCategoryName )
		VALUES (
			@ExpenceCategoryName )
	END
	ELSE
	BEGIN
		RAISERROR ('Expence Category already Exist', 16, 1)
	END

END