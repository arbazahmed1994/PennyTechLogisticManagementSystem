IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetEmployeeUserByID')
	DROP PROCEDURE GetEmployeeUserByID
GO

CREATE PROCEDURE GetEmployeeUserByID

@UserCode INT

AS

BEGIN

	SELECT
		UserCode,
		FullName,
		FatherName,
		IdentityCardNumber,
		FatherIdentityCardNumber,
		DateOfBirth,
		MaritalStatusID,
		GenderID,
		Phone,
		Mobile,
		Address,
		CityID,
		ReligionID,
		Salary,
		EducationID,
		Experiance,
		EOBINumber,
		NTSNumber,
		Username,
		Password,
		DepartmentCode,
		DesignationID,
		FullName
		EntryDate
	FROM
		EmployeeUser  
	WHERE
		IsDeleted = 0 AND
		UserCode = @UserCode

END