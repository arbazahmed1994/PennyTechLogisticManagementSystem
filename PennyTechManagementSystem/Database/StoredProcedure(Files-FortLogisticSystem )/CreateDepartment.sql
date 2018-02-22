IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateDepartment')
	DROP PROCEDURE CreateDepartment
GO

CREATE PROCEDURE CreateDepartment

@DepartmentName NVARCHAR(30),
@DepartmentShortName NVARCHAR(10),
@DepartmentEmail NVARCHAR(30),
@DepartmentNumber VARCHAR(20),
@DepartmentFax VARCHAR(30)

AS

BEGIN

BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO Departments (
		DepartmentName,
		DepartmentShortName,
		DepartmentEmail,
		DepartmentNumber,
		DepartmentFax )
	VALUES (
		@DepartmentName,
		@DepartmentShortName,
		@DepartmentEmail,
		@DepartmentNumber,
		@DepartmentFax )
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
	RAISERROR('Department cannot be Created Successfully. Please Contact Service Provider', 16, 1)
	RETURN
END CATCH
END
GO
