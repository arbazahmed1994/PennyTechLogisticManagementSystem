IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='AuthenticateUser')
	DROP PROCEDURE AuthenticateUser
GO

CREATE PROCEDURE AuthenticateUser

@Username VARCHAR(25),
@Password VARCHAR(25),
@MachineName VARCHAR(50),
@SessionID VARCHAR(200)

AS

BEGIN

	IF EXISTS ( SELECT UserCode FROM EmployeeUser WHERE Username = @Username AND Password = @Password )
	BEGIN
		DECLARE @Code AS INT = ( SELECT UserCode FROM EmployeeUser 
										WHERE Username = @Username AND Password = @Password )
		IF NOT EXISTS ( SELECT UserID FROM OnlineUser WHERE Deactive = 0 AND UserID = @Code )
		BEGIN
			SELECT 
				Username,
				Password,
				UserCode,
				FullName
			FROM	
				EmployeeUser

			INSERT INTO OnlineUser (
				UserID,
				MachineName,
				EntryDate,
				SessionID,
				Deactive )
			VALUES (
				( SELECT UserCode FROM EmployeeUser WHERE Username = @Username AND Password = @Password ),
				@MachineName,
				GETDATE(),
				@SessionID,
				0 )
		END
		ELSE
		BEGIN
			RAISERROR('This User is already Logged In', 16, 1)
		END
	END
	ELSE
	BEGIN
		RAISERROR('Username or Password is Incorrect', 16, 1)
	END

END