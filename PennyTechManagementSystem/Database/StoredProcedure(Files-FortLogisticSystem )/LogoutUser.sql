IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='LogoutUser')
	DROP PROCEDURE LogoutUser
GO

CREATE PROCEDURE LogoutUser

@SessionID VARCHAR(200)

AS

BEGIN

	UPDATE OnlineUser SET
		Deactive = 1
	WHERE 
		SessionID = @SessionID

END