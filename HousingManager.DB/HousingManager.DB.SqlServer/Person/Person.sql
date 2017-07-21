﻿Create table Person.Person(
	PersonId int PRIMARY KEY CLUSTERED IDENTITY(1,1) not null,
    FirstName nvarchar(50) not null,
    LastName nvarchar(50) not null,
    Active bit default(1),	
	[Guid] UNIQUEIDENTIFIER DEFAULT NEWID() not null
);
