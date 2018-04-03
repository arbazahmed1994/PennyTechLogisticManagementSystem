IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateEmployee')
	DROP PROCEDURE UpdateEmployee
GO

CREATE PROCEDURE UpdateEmployee

@UserCode INT,
@FullName VARCHAR(50),
@FatherName VARCHAR(50),
@IdentityCardNumber VARCHAR(30),
@FatherIdentityCardNumber VARCHAR(30),
@DateOfBirth DATE,
@MaritalStatusID INT,
@GenderID INT,
@Phone VARCHAR(30),
@Mobile VARCHAR(30),
@Address NVARCHAR(200),
@CityID INT,
@Nationality INT,
@ReligionID INT,
@Salary FLOAT,
@EducationID INT,
@Experiance VARCHAR(2),
@DepartmentCode INT,
@DesignationID INT,
@EOBINumber VARCHAR(20),
@NTSNumber VARCHAR(20),
@Username VARCHAR(25),
@Password VARCHAR(25) ,
@EntryUser INT

AS

BEGIN

	UPDATE EmployeeUser SET 
		FullName = @FullName,
		FatherName = @FatherName,
		IdentityCardNumber = @IdentityCardNumber,
		FatherIdentityCardNumber = @FatherIdentityCardNumber,
		DateOfBirth = @DateOfBirth,
		MaritalStatusID = @MaritalStatusID,
		GenderID = @GenderID,
		Phone = @Phone,
		Mobile = @Mobile,
		Address = @Address,
		CityID = @CityID,
		Nationality = @Nationality,
		ReligionID = @ReligionID,
		Salary = @Salary,
		EducationID = @EducationID,
		Experiance = @Experiance,
		DepartmentCode = @DepartmentCode,
		DesignationID = @DesignationID,
		EOBINumber = @EOBINumber,
		NTSNumber = @NTSNumber,
		Username = @Username,
		Password = @Password,
		IsUpdated = 1,
		UpdatedDate = GETDATE(),
		UpdatedBy = @EntryUser
	WHERE
		UserCode = @UserCode

END
GO