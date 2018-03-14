IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetColor')
	DROP PROCEDURE GetColor
GO

CREATE PROCEDURE GetColor

AS 

BEGIN
	
	SELECT
		ColorID,
		ColorName
	FROM
		Colors

END