IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetDepartments')
	DROP PROCEDURE GetDepartments
GO

CREATE PROCEDURE GetDepartments

AS

BEGIN

	SELECT 
		DepartmentID,
		DepartmentName,
		DepartmentShortName,
		DepartmentEmail,
		DepartmentNumber,
		DepartmentFax
	FROM 
		Departments

END
GO


