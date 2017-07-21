Create table Request.ApartmentRequest(
	ApartmentRequestId int primary key clustered IDENTITY(1,1)not null,
	ManagerId int not null, 
	ProviderId int not null, 
	Submitted datetime,
	Beds int not null,	
	[Guid] UNIQUEIDENTIFIER DEFAULT NEWID() not null
		CONSTRAINT FK_Request_ApartmentRequest_ManagerId FOREIGN KEY (ManagerId) REFERENCES Person.Person(PersonId),
		CONSTRAINT FK_Request_ApartmentRequest_ProviderId FOREIGN KEY (ProviderId) REFERENCES Person.Provider(ProviderId)
);