IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetCities')
	DROP PROCEDURE GetCities
GO

CREATE PROCEDURE GetCities

AS 

BEGIN
	
	SELECT
		CityID,
		CityName,
		CI.CountryID,
		CO.CountryName
	FROM
		Cities AS CI 
		INNER JOIN Countries AS CO ON CO.CountryID = CI.CountryID

END