IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetCountry')
	DROP PROCEDURE GetCountry
GO

CREATE PROCEDURE GetCountry

AS 

BEGIN
	
	SELECT
		CountryID,
		CountryName
	FROM
		Countries

END