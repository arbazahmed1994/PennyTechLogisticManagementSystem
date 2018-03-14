IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetStatus')
	DROP PROCEDURE GetStatus
GO

CREATE PROCEDURE GetStatus

AS 

BEGIN
	
	SELECT
		StatusID,
		StatusName
	FROM
		Status

END