IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateBranchOffice')
	DROP PROCEDURE CreateBranchOffice
GO

CREATE PROCEDURE CreateBranchOffice

@BranchOfficeName VARCHAR(30),
@BranchOfficeNumber VARCHAR(20),
@BranchOfficeEmail VARCHAR(30),
@Address VARCHAR(200),
@CityID INT, 
@CountryID INT

AS

BEGIN
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO [dbo].[BranchOffice]
			([BranchOfficeName]
			,[BranchOfficeNumber]
			,[BranchOfficeEmail]
			,[Address]
			,[CityID]
			,[CountryID])
		VALUES
			(@BranchOfficeName ,
			@BranchOfficeNumber ,
			@BranchOfficeEmail ,
			@Address ,
			@CityID , 
			@CountryID )
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
	RAISERROR('Branch Office cannot be Created Successfully. Please Contact Service Provider', 16, 1)
	RETURN
END CATCH
END
GO


