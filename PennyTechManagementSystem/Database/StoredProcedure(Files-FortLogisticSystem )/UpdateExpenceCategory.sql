IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateExpenceCategory')
	DROP PROCEDURE UpdateExpenceCategory
GO

CREATE PROCEDURE UpdateExpenceCategory

@ExpenceCategoryID INT ,
@ExpenceCategoryName VARCHAR(100)

AS

BEGIN

	IF NOT EXISTS (SELECT ExpenceCategoryName FROM ExpenceCategory WHERE ExpenceCategoryName = @ExpenceCategoryName)
	BEGIN
		UPDATE ExpenceCategory 
		SET 
			ExpenceCategoryName = @ExpenceCategoryName 
		WHERE 
			ExpenceCategoryID = @ExpenceCategoryID
	END
	ELSE
	BEGIN
		RAISERROR ('You have another Expence Category having same Name', 16, 1)
	END

END