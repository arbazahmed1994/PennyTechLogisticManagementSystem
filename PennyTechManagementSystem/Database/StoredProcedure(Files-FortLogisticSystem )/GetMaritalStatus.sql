IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetMaritalStatus')
	DROP PROCEDURE GetMaritalStatus
GO

CREATE PROCEDURE GetMaritalStatus

AS 

BEGIN
	
	SELECT
		MaritalStatusID,
		MaritalStatusName
	FROM
		MaritalStatus

END