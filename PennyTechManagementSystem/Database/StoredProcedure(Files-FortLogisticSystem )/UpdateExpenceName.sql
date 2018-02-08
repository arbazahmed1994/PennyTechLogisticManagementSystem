IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateExpenceName')
	DROP PROCEDURE UpdateExpenceName
GO

CREATE PROCEDURE UpdateExpenceName

@ExpenceNameID INT,
@ExpenceName VARCHAR(100),
@ExpenceCategoryID INT

AS

BEGIN

	IF NOT EXISTS (SELECT ExpenceName FROM ExpenceName WHERE ExpenceName= @ExpenceName AND ExpenceCategoryID = @ExpenceCategoryID)
	BEGIN
		UPDATE ExpenceName
		SET 
			ExpenceName = @ExpenceName ,
			ExpenceCategoryID = @ExpenceCategoryID
		WHERE 
			ExpenceNameID = @ExpenceNameID
	END
	ELSE
	BEGIN
		RAISERROR ('You have another Expence Name similar to this', 16, 1)
	END

END