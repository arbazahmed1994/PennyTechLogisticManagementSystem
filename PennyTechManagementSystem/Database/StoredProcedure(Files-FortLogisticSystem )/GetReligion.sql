IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetReligion')
	DROP PROCEDURE GetReligion
GO

CREATE PROCEDURE GetReligion

AS 

BEGIN
	
	SELECT
		ReligionID,
		ReligionName
	FROM
		Religion

END