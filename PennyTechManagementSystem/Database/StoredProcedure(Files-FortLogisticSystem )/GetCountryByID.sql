IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetCountryByID')
	DROP PROCEDURE GetCountryByID
GO

CREATE PROCEDURE GetCountryByID

@CountryID INT

AS

BEGIN

	SELECT
		CountryID,
		CountryName
	FROM
		Countries
	WHERE
		CountryID = @CountryID

END