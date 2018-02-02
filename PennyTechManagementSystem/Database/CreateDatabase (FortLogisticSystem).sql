--CREATE DATABASE FortLogisticSystem
--GO

--// BASE TABLES

CREATE TABLE Navbar(
	MenuID INT NOT NULL,
	LinkText VARCHAR(50) NOT NULL,
	ActionName VARCHAR(50) NULL,
	ControllerName VARCHAR(50) NULL,
	Icon VARCHAR(50) NULL,	
	ParentID INT NULL,
	ShowInMenu INT,
	IsParent INT,
	SequenceNumber INT,
	IsNested INT,
	CONSTRAINT PK_Navbar PRIMARY KEY CLUSTERED (MenuID),
	CONSTRAINT FK_Navbar_Menu FOREIGN KEY(ParentID) REFERENCES Navbar(MenuID)
)
GO

CREATE TABLE Countries(
	CountryID INT IDENTITY(1,1) NOT NULL,
	CountryName NVARCHAR(30) NOT NULL,
	CONSTRAINT PK_Countries PRIMARY KEY CLUSTERED (CountryID)
)
GO

CREATE TABLE Cities(
	CityID INT IDENTITY(1,1) NOT NULL,
	CityName NVARCHAR(30) NOT NULL,
	CountryID INT NOT NULL,
	CONSTRAINT PK_Cities PRIMARY KEY CLUSTERED (CityID),
	CONSTRAINT FK_Cities_CountryID FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
)
GO

CREATE TABLE Designations(
	DesignationID INT IDENTITY(1,1) NOT NULL,
	DesignationName NVARCHAR(30) NOT NULL,
	CONSTRAINT PK_Designations PRIMARY KEY CLUSTERED (DesignationID)
)
GO

CREATE TABLE Departments(
	DepartmentID INT IDENTITY(1,1) NOT NULL,
	DepartmentName NVARCHAR(30) NOT NULL,
	DepartmentShortName NVARCHAR(10) NOT NULL,
	DepartmentEmail VARCHAR(30) NOT NULL,
	DepartmentNumber VARCHAR(20) NOT NULL,
	DepartmentFax VARCHAR(30) NULL,
	CONSTRAINT PK_Department PRIMARY KEY CLUSTERED (DepartmentCode)
)
GO

CREATE TABLE VehicleType(
	VehicleTypeID INT IDENTITY(1,1) NOT NULL,
	VehicleTypeName VARCHAR(30) NOT NULL
	CONSTRAINT PK_VehicleType PRIMARY KEY CLUSTERED (VehicleTypeID)
)
GO

CREATE TABLE BranchOffice(
	BranchOfficeID INT IDENTITY(1,1) NOT NULL,
	BranchOfficeName VARCHAR(30) NOT NULL,
	Address VARCHAR(200) NOT NULL,
	BranchOfficeNumber VARCHAR(20)  NOT NULL,
	BranchOfficeEmail VARCHAR(30)  NOT NULL,
	CONSTRAINT PK_BranchOffice PRIMARY KEY CLUSTERED (BranchOfficeID)
)
GO

CREATE TABLE Education(
	EducationID INT IDENTITY(1,1) NOT NULL,
	EducationName VARCHAR(30) NOT NULL
	CONSTRAINT PK_Education PRIMARY KEY CLUSTERED (EducationID)
)
GO

CREATE TABLE Gender(
	GenderID INT IDENTITY(1,1) NOT NULL,
	GenderName VARCHAR(30) NOT NULL
	CONSTRAINT PK_Gender PRIMARY KEY CLUSTERED (GenderID)
)
GO

CREATE TABLE VehicleBusinessType(
	VehicleBusinessTypeID INT IDENTITY(1,1) NOT NULL,
	VehicleBusinessTypeName VARCHAR(30) NOT NULL
	CONSTRAINT PK_VehicleBusinessType PRIMARY KEY CLUSTERED (VehicleBusinessTypeID)
)
GO

CREATE TABLE CompanyBusinessType(
	CompanyBusinessTypeID INT IDENTITY(1,1) NOT NULL,
	CompanyBusinessTypeName VARCHAR(30) NOT NULL
	CONSTRAINT PK_CompanyBusinessType PRIMARY KEY CLUSTERED (CompanyBusinessTypeID)
)
GO

CREATE TABLE VehicleCompany(
	VehicleCompanyID INT IDENTITY(1,1) NOT NULL,
	VehicleCompanyName VARCHAR(25) NOT NULL
	CONSTRAINT PK_VehicleCompany PRIMARY KEY CLUSTERED (VehicleCompanyID)
)
GO

CREATE TABLE Status(
	StatusID INT IDENTITY(1,1) NOT NULL,
	StatusName VARCHAR(20) NOT NULL
	CONSTRAINT PK_Status PRIMARY KEY CLUSTERED (StatusID)
)
GO

CREATE TABLE Colors(
	ColorID INT IDENTITY(1,1) NOT NULL,
	ColorName VARCHAR(20) NOT NULL
	CONSTRAINT PK_Colors PRIMARY KEY CLUSTERED (ColorID)
)
GO

CREATE TABLE Religion(
	ReligionID INT IDENTITY(1,1) NOT NULL,
	ReligionName VARCHAR(20) NOT NULL
	CONSTRAINT PK_Religion PRIMARY KEY CLUSTERED (ReligionID)
)
GO

CREATE TABLE MaritalStatus(
	MaritalStatusID INT IDENTITY(1,1) NOT NULL,
	MaritalStatusName VARCHAR(20) NOT NULL
	CONSTRAINT PK_MaritalStatus PRIMARY KEY CLUSTERED (MaritalStatusID)
)
GO

CREATE TABLE TripExpence (
	TripExpenceID INT IDENTITY(1,1) NOT NULL,
	TripExpenceName VARCHAR(10) NOT NULL,
	CONSTRAINT PK_TripExpence PRIMARY KEY CLUSTERED (TripExpenceID)
)
GO


--// FUNCTIONAL TABLE


CREATE TABLE CompanyProfile(
	Username VARCHAR(25) NOT NULL,
	Password NVARCHAR(25) NOT NULL,
	CompanyID INT IDENTITY(1,1) NOT NULL,
	CompanyCode VARCHAR(4) NOT NULL,
	CompanyName VARCHAR(50) NOT NULL,
	OwnerName VARCHAR(50) NOT NULL,
	BusinessTypeID INT NOT NULL, 
	NTNno NVARCHAR(30) NULL,
	RegistrationDate DATE NULL,
	Website VARCHAR(30) NULL,
	Email1 NVARCHAR(50) NOT NULL,
	Email2 NVARCHAR(50) NULL,
	Email3 NVARCHAR(50) NULL,
	ContactNumber1 VARCHAR(20) NOT NULL,
	ContactNumber2 VARCHAR(20) NULL,
	ContactNumber3 VARCHAR(20) NULL,
	FaxNumber1 VARCHAR(30) NULL,
	FaxNumber2 VARCHAR(30) NULL,
	CreatedOn DATE NOT NULL,
	IsDeleted BIT NOT NULL,
	IsUpdated BIT NOT NULL,
	UpdatedDate DATE NULL,
	DeletedDate DATE NULL,
	UpdatedBy INT NULL,
	DeletedBy INT NULL,
	CONSTRAINT PK_CompanyProfile PRIMARY KEY CLUSTERED (CompanyID),
	CONSTRAINT UK_CompanyProfile UNIQUE (CompanyCode),
	CONSTRAINT FK_CompanyProfile_BusinessType FOREIGN KEY (BusinessTypeID) REFERENCES CompanyBusinessType(CompanyBusinessTypeID)
)
GO

CREATE TABLE EmployeeUser(
	UserCode VARCHAR(4) NOT NULL,
	FullName VARCHAR(50) NOT NULL,
	FatherName VARCHAR(50) NOT NULL,
	IdentityCardNumber VARCHAR(30) NOT NULL,
	FatherIdentityCardNumber VARCHAR(30) NULL,
	DateOfBirth DATE NOT NULL,
	MaritalStatusID INT NOT NULL,
	GenderID INT NOT NULL,
	Phone VARCHAR(30) NULL,
	Mobile VARCHAR(30) NULL,
	Address NVARCHAR(200) NULL,
	CityID INT NOT NULL,
	Nationality INT NOT NULL,
	ReligionID INT NOT NULL,
	Salary FLOAT NULL,
	EducationID INT NOT NULL,
	Experiance VARCHAR(2) NOT NULL,
	DepartmentCode VARCHAR(4) NOT NULL,
	DesignationID INT NOT NULL,
	EOBINumber VARCHAR(20) NULL,
	NTSNumber VARCHAR(20) NULL,
	Username VARCHAR(25) NOT NULL,
	Password VARCHAR(25) NOT NULL,
	IsDeleted BIT NOT NULL,
	IsUpdated BIT NOT NULL,
	UpdatedDate DATE NULL,
	DeletedDate DATE NULL,
	UpdatedBy INT NULL,
	DeletedBy INT NULL,
	CONSTRAINT PK_EmployeeUser PRIMARY KEY CLUSTERED (UserCode),
	CONSTRAINT FK_EmployeeUser_MaritalStatusID FOREIGN KEY (MaritalStatusID) REFERENCES MaritalStatus(MaritalStatusID),
	CONSTRAINT FK_EmployeeUser_GenderID FOREIGN KEY (GenderID) REFERENCES Gender(GenderID),
	CONSTRAINT FK_EmployeeUser_ReligionID FOREIGN KEY (ReligionID) REFERENCES Religion(ReligionID),
	CONSTRAINT FK_EmployeeUser_CityID FOREIGN KEY (CityID) REFERENCES Cities(CityID),
	CONSTRAINT FK_EmployeeUser_Nationality FOREIGN KEY (Nationality) REFERENCES Countries(CountryID),
	CONSTRAINT FK_EmployeeUser_EducationID FOREIGN KEY (EducationID) REFERENCES Education(EducationID),
	CONSTRAINT FK_EmployeeUser_DesignationID FOREIGN KEY (DesignationID) REFERENCES Designations(DesignationID),
	CONSTRAINT FK_EmployeeUser_DepartmentID FOREIGN KEY (DepartmentCode) REFERENCES Departments(DepartmentCode)
)
GO

CREATE TABLE Fleet(
	VehicleCode VARCHAR(4) NOT NULL,
	VehicleNumber VARCHAR(20) NOT NULL,
	VehicleTypeID INT NOT NULL,
	VehicleBusinessTypeID INT NOT NULL,
	VehicleCompanyID INT NOT NULL,
	VehicleLenght VARCHAR(10) NOT NULL,
	ModelYear INT NOT NULL,
	CountryID INT NOT NULL,
	NumberOfWheels INT NOT NULL,
	ChasisNumber VARCHAR(50) NOT NULL,
	EngineNumber VARCHAR(50) NOT NULL,
	EngineHorsePower VARCHAR(15) NOT NULL,
	StatusID INT NOT NULL,
	ColorID INT NOT NULL,
	PurchaseDate DATE NOT NULL,
	PurchaseFrom VARCHAR(30) NULL,
	ManufactureDate DATE NOT NULL,
	ManufacturedFrom NVARCHAR(50) NOT NULL,
	VehicleModelName NVARCHAR(30) NULL,
	IsDepreciated BIT NOT NULL,
	IsDeleted BIT NOT NULL,
	DeletedBy INT NULL,
	IsUpdated BIT NOT NULL,
	UpdatedBy INT NULL,
	DeletedDate DATE NULL,
	VehicleEntryDate DATE NOT NULL,
	CONSTRAINT PK_Fleets PRIMARY KEY CLUSTERED (VehicleCode),
	CONSTRAINT FK_Fleets_VehicleTypeID FOREIGN KEY (VehicleTypeID) REFERENCES VehicleType(VehicleTypeID),
	CONSTRAINT FK_Fleets_VehicleBusinessTypeID FOREIGN KEY (VehicleBusinessTypeID) REFERENCES VehicleBusinessType(VehicleBusinessTypeID),
	CONSTRAINT FK_Fleets_VehicleCompanyID FOREIGN KEY (VehicleCompanyID) REFERENCES VehicleCompany(VehicleCompanyID),
	CONSTRAINT FK_Fleets_StatusID FOREIGN KEY (StatusID) REFERENCES Status(StatusID),
	CONSTRAINT FK_Fleets_CountryID FOREIGN KEY (CountryID) REFERENCES Countries(CountryID),
	CONSTRAINT FK_Fleets_ColorID FOREIGN KEY (ColorID) REFERENCES Colors(ColorID)
)
GO

CREATE TABLE TripRoute (
	TripRouteID INT IDENTITY(1,1) NOT NULL,
	TripRouteName VARCHAR(100) NOT NULL,
	TripFrom VARCHAR(50) NOT NULL,
	TripTo VARCHAR(50) NOT NULL,
	ApproximateDay INT NOT NULL,
	TripAmount FLOAT NOT NULL,
	CONSTRAINT PK_TripRoute PRIMARY KEY CLUSTERED (TripRouteID)
)
GO

CREATE TABLE TripBeginning (
	TripBeginID INT IDENTITY(1,1) NOT NULL,
	TripRouteID INT NOT NULL,
	VehicleCode VARCHAR(4) NOT NULL,
	DriverCode VARCHAR(4) NOT NULL,
	StartingDate DATE NOT NULL,
	ApproxEndDate DATE NULL,
	TripVehicleAmount FLOAT NOT NULL,
	IsEnded BIT NOT NULL,
	EndDate DATE NULL,
	DetentionNeeded BIT NOT NULL,
	CONSTRAINT PK_TripBeginning PRIMARY KEY CLUSTERED (TripBeginID),
	CONSTRAINT FK_TripBeginning_TripRouteID FOREIGN KEY (TripRouteID) REFERENCES TripRoute(TripRouteID),
	CONSTRAINT FK_TripBeginning_VehicleCode FOREIGN KEY (VehicleCode) REFERENCES Fleet(VehicleCode),
	CONSTRAINT FK_TripBeginning_UserCode FOREIGN KEY (DriverCode) REFERENCES EmployeeUser(UserCode)
)
GO

CREATE TABLE TripExpences (
	TripExpencesID INT IDENTITY(1,1) NOT NULL,
	TripCode VARCHAR(8) NOT NULL,
	VehicleCode VARCHAR(4) NOT NULL,
	CONSTRAINT PK_TripExpences PRIMARY KEY CLUSTERED (TripExpencesID)
)
GO

CREATE TABLE TripExpenceDetail (
	TripExpenceDetailID INT IDENTITY(1,1) NOT NULL,
	TripExpencesID INT NOT NULL,
	TripExpenceID INT NOT NULL,
	Amount FLOAT NOT NULL,
	CONSTRAINT PK_TripExpenceDetail PRIMARY KEY CLUSTERED (TripExpenceDetailID),
	CONSTRAINT FK_TripExpenceDetail_TripExpenceID FOREIGN KEY (TripExpenceID) REFERENCES TripExpence(TripExpenceID),
	CONSTRAINT FK_TripExpenceDetail_TripExpencesID FOREIGN KEY (TripExpencesID) REFERENCES TripExpences(TripExpencesID)
)
GO

CREATE TABLE Driver (
	DriverCode VARCHAR(4) NOT NULL,
	DriverName VARCHAR(30) NOT NULL,
	DriverMobile VARCHAR(20) NULL,
	Salary FLOAT NULL,
	DailyPityCash FLOAT NULL,
	DriverCNIC VARCHAR(30) NOT NULL,
	DrivingLicenceNumber VARCHAR(30) NOT NULL,
	CONSTRAINT PK_Drivers PRIMARY KEY CLUSTERED (DriverCode)
)

CREATE TABLE ThirdPartyVehicle (
	VehicleCode VARCHAR(4) NOT NULL,
	VehicleNumber VARCHAR(10) NOT NULL,
	VehicleCompany INT NULL,
	VehicleType INT NOT NULL,
	VehicleBusinessType INT NULL,
	VehicleOwnerName VARCHAR(50) NOT NULL,
	RentInDate DATE NOT NULL,
	RentAmount FLOAT NULL,
	ExpenceMode BIT NOT NULL,
	Returned BIT NOT NULL,
	ReturnedDate Date NULL,
	CONSTRAINT PK_ThirdPartyVehicle PRIMARY KEY CLUSTERED (VehicleCode),
	CONSTRAINT FK_ThirdPartyVehicle_VehicleCompany FOREIGN KEY (VehicleCompany) REFERENCES VehicleCompany(VehicleCompanyID),
	CONSTRAINT FK_ThirdPartyVehicle_VehicleType FOREIGN KEY (VehicleType) REFERENCES VehicleType(VehicleTypeID),
	CONSTRAINT FK_ThirdPartyVehicle_VehicleBusinessType FOREIGN KEY (VehicleBusinessType) REFERENCES VehicleBusinessType(VehicleBusinessTypeID)
)