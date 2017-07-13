USE Master;
GO

CREATE DATABASE HousingManagerDB;
GO

USE HousingManagerDB;
GO

SELECT * FROM sys.databases;

SELECT * FROM sys.schemas;


USE HousingManagerDB;
GO

SELECT * FROM Apartment.Address;

INSERT INTO Apartment.Address(StreetName, AptNum, City, [State], ZipCode)
values ('2121 Raven Tower Court', '504', 'Herndon', 'VA', 20170);