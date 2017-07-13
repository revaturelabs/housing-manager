/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
use master; 
go

create database HousingManagerDB2;
go

use HousingManagerDB2;
go 

--select * from sys.schemas;
--select * from person;



create schema Batch;
go

create schema Request;
go

create schema Apartment;
go

create schema Person;
go

--select * from BatchType;

--create table Batch.BatchType(
--    BatchTypeId int IDENTITY(1,1) not null,
--    Type nvarchar(50) not null,
--	constraint PK_Batch_BatchType_BatchTypeId primary key clustered (BatchTypeId),
--);
