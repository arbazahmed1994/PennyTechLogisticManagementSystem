IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateCountry')
	DROP PROCEDURE CreateCountry
GO

CREATE PROCEDURE CreateCountry

@CountryID INT,
@CountryName NVARCHAR(30)

AS

BEGIN

	INSERT INTO Countries (
		CountryID,
		CountryName )
	VALUES (
		@CountryID,
		@CountryName )

END