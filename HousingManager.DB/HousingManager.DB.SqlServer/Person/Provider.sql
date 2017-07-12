Create table Person.Provider(
	ProviderId int IDENTITY(1,1) not null,
	Name nvarchar(50) not null,
	constraint PK_Person_Provider_ProviderId primary key clustered (ProviderId),
    
);