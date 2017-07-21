Create table Person.Provider(
	ProviderId int primary key clustered IDENTITY(1,1) not null,
	Name nvarchar(50) not null,	
	[Guid] UNIQUEIDENTIFIER DEFAULT NEWID() not null
);