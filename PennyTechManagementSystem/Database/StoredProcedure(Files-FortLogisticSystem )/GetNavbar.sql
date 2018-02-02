IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetNavbar')
	DROP PROCEDURE GetNavbar
GO

CREATE PROCEDURE GetNavbar

AS

BEGIN
	
	SELECT
		*
	FROM
		Navbar
	WHERE
		NestedParent = 0 AND
		IsNested = 0

END