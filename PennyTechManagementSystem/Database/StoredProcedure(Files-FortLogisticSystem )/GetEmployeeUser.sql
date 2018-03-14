IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetEmployeeUser')
	DROP PROCEDURE GetEmployeeUser
GO

CREATE PROCEDURE GetEmployeeUser

AS

BEGIN

	SELECT
		EU.UserCode,
		EU.FullName,
		EU.FatherName,
		EU.IdentityCardNumber,
		EU.FatherIdentityCardNumber,
		EU.DateOfBirth,
		MS.MaritalStatusName,
		G.GenderName,
		EU.Phone,
		EU.Mobile,
		EU.Address,
		CI.CityName,
		CO.CountryName,
		R.ReligionName,
		EU.Salary,
		E.EducationName,
		EU.Experiance,
		EU.EOBINumber,
		EU.NTSNumber,
		EU.Username,
		EU.Password,
		DP.DepartmentName,
		DS.DesignationName,
		EM.FullName AS NAME,
		EU.EntryDate
	FROM
		EmployeeUser AS EU
		INNER JOIN MaritalStatus AS MS ON MS.MaritalStatusID = EU.MaritalStatusID
	 	INNER JOIN Cities AS CI ON CI.CityID = EU.CityID
		INNER JOIN Countries AS CO ON CO.CountryID = EU.Nationality
		INNER JOIN Gender AS G ON G.GenderID = EU.GenderID
		INNER JOIN Religion AS R ON R.ReligionID = EU.ReligionID
		INNER JOIN Education AS E ON E.EducationID = EU.EducationID
		INNER JOIN Departments AS DP ON DP.DepartmentID = EU.DepartmentCode
		INNER JOIN Designations AS DS ON DS.DesignationID = EU.DesignationID
		LEFT OUTER JOIN EmployeeUser AS EM ON EM.UserCode = EU.EntryUser
	WHERE
		EU.IsDeleted = 0

END