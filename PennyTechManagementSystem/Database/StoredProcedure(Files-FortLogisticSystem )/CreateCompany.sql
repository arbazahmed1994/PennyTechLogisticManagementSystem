IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateCompany')
	DROP PROCEDURE CreateCompany
GO

CREATE PROCEDURE CreateCompany

@Username VARCHAR(25),
@Password VARCHAR(25),
@CompanyName VARCHAR(50),
@OwnerName VARCHAR(50),
@BusinessTypeID INT,
@NTNno NVARCHAR(30),
@RegistrationDate DATE,
@Website VARCHAR(30),
@Email1 NVARCHAR(50),
@Email2 NVARCHAR(50),
@Email3 NVARCHAR(50),
@ContactNumber1 VARCHAR(20),
@ContactNumber2 VARCHAR(20),
@ContactNumber3 VARCHAR(20),
@FaxNumber1 VARCHAR(30),
@FaxNumber2 VARCHAR(30)

AS

BEGIN

BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO [dbo].[CompanyProfile]
           ([Username]
           ,[Password]
		   ,[CompanyCode]
           ,[CompanyName]
           ,[OwnerName]
           ,[BusinessTypeID]
           ,[NTNno]
           ,[RegistrationDate]
           ,[Website]
           ,[Email1]
           ,[Email2]
           ,[Email3]
           ,[ContactNumber1]
           ,[ContactNumber2]
           ,[ContactNumber3]
           ,[FaxNumber1]
           ,[FaxNumber2]
           ,[CreatedOn]
           ,[IsDeleted]
           ,[IsUpdated])
     VALUES
           (@Username ,
			@Password ,
			( SELECT RIGHT('0000'+CAST(ISNULL(MAX(CONVERT(int,CompanyCode)),0)+1 AS VARCHAR),4) FROM CompanyProfile ),
			@CompanyName ,
			@OwnerName ,
			@BusinessTypeID ,
			@NTNno ,
			@RegistrationDate ,
			@Website ,
			@Email1 ,
			@Email2 ,
			@Email3 ,
			@ContactNumber1 ,
			@ContactNumber2 ,
			@ContactNumber3 ,
			@FaxNumber1 ,
			@FaxNumber2 , 
			GETDATE() ,
			0 ,
            0 )
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
	RAISERROR('Company cannot be Created Successfully. Please Contact Service Provider', 16, 1)
	RETURN
END CATCH
END
GO


