IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateDepartment')
	DROP PROCEDURE CreateDepartment
GO

CREATE PROCEDURE CreateDepartment

@xml XML

AS

BEGIN

 SELECT  Node.Data.value('(Name)[1]', 'NVARCHAR(30)') AS Name
        , Node.Data.value('(ShortName)[1]', 'NVARCHAR(10)') AS ShortName
        , Node.Data.value('(Email)[1]', 'VARCHAR(30)') AS Email
        , Node.Data.value('(Contact)[1]', 'VARCHAR(20)') AS Contact
        , Node.Data.value('(Fax)[1]', 'VARCHAR(30)') AS Fax
    INTO #Dept
 FROM @xml.nodes('/Grid/Dept') Node(Data)

BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO [dbo].[Departments]
		([DepartmentName]
		,[DepartmentShortName]
		,[DepartmentEmail]
		,[DepartmentNumber]
		,[DepartmentFax])
	SELECT
		Name ,
		ShortName ,
		Email ,
		Contact ,
		Fax 
	FROM
		#Dept
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
	RAISERROR('Department cannot be Created Successfully. Please Contact Service Provider', 16, 1)
	RETURN
END CATCH
END
GO
