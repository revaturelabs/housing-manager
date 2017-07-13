Create table Request.ProviderSupplyRequest(
	SupplyRequestId int IDENTITY(1,1) not null,
	SupplyId int not null,
	ProviderId int not null,
	ManagerId int not null,
	Submitted datetime,
		constraint PK_Request_ProviderSupplyRequest_SupplyRequestId primary key clustered (SupplyRequestId),
		CONSTRAINT FK_Request_ProviderSupplyRequest_SupplyId FOREIGN KEY (SupplyId) REFERENCES Request.Supply(SupplyId),
		CONSTRAINT FK_Request_ProviderSupplyRequest_ManagerId FOREIGN KEY (ManagerId) REFERENCES Person.Person(PersonId),
		CONSTRAINT FK_Request_ProviderSupplyRequest_ProviderId FOREIGN KEY (ProviderId) REFERENCES Person.Provider(ProviderId),

);