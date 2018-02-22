IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateUser')
	DROP PROCEDURE CreateUser
GO

CREATE PROCEDURE CreateUser

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
@DepartmentCode VARCHAR(4),
@DesignationID INT,
@EOBINumber VARCHAR(20),
@NTSNumber VARCHAR(20),
@Username VARCHAR(25),
@Password VARCHAR(25)

AS 

BEGIN

	INSERT INTO EmployeeUser (
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
		Nationality,
		ReligionID,
		Salary,
		EducationID,
		Experiance,
		DepartmentCode,
		DesignationID,
		EOBINumber,
		NTSNumber,
		Username,
		Password,
		IsDeleted,
		IsUpdated )
	VALUES (
		--(( SELECT RIGHT('0000'+CAST(ISNULL(MAX(CONVERT(int,UserCode)),0)+1 AS VARCHAR),4) FROM EmployeeUser ),
		@FullName ,
		@FatherName ,
		@IdentityCardNumber ,
		@FatherIdentityCardNumber ,
		@DateOfBirth ,
		@MaritalStatusID ,
		@GenderID ,
		@Phone ,
		@Mobile ,
		@Address ,
		@CityID ,
		@Nationality ,
		@ReligionID ,
		@Salary ,
		@EducationID ,
		@Experiance ,
		@DepartmentCode ,
		@DesignationID ,
		@EOBINumber ,
		@NTSNumber ,
		@Username ,
		@Password ,
		0 ,
		0 )

END
GO


