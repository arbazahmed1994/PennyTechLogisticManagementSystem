IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetEducation')
	DROP PROCEDURE GetEducation
GO

CREATE PROCEDURE GetEducation

AS 

BEGIN
	
	SELECT
		EducationID,
		EducationName
	FROM
		Education
	ORDER BY EducationID ASC

END