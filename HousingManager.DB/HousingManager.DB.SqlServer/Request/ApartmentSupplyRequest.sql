Create table Request.ApartmentSupplyRequest(
	SupplyRequestId int primary key clustered IDENTITY(1,1)not null,
	SupplyId int not null,
	ApartmentUnitId int not null,
	Submitted datetime,
		CONSTRAINT FK_Request_ApartmentSupplyRequest_SupplyId FOREIGN KEY (SupplyId) REFERENCES Request.Supply(SupplyId),
		CONSTRAINT FK_Request_ApartmentSupplyRequest_ApartmentUnitId FOREIGN KEY (ApartmentUnitId) REFERENCES Apartment.ApartmentUnit(ApartmentUnitId)
);