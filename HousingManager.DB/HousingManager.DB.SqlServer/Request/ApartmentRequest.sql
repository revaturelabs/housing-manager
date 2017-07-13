Create table Request.ApartmentRequest(
	ApartmentRequestId int IDENTITY(1,1)not null,
	ManagerId int not null, 
	ProviderId int not null, 
	Submitted datetime,
	Beds int not null
		constraint PK_Request_ApartmentRequest_ApartmentRequestId primary key clustered (ApartmentRequestId),
		CONSTRAINT FK_Request_ApartmentRequest_ManagerId FOREIGN KEY (ManagerId) REFERENCES Person.Person(PersonId),
		CONSTRAINT FK_Request_ApartmentRequest_ProviderId FOREIGN KEY (ProviderId) REFERENCES Person.Provider(ProviderId),

);