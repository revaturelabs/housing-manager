create table Request.SupplyRequest(
    SupplyRequestId int IDENTITY(1,1) not null,
    SupplyId int not null,
    ApartmentUnitId int not null,
	Submitted datetime not null,
	constraint PK_Request_SupplyRequest_SupplyRequestId primary key clustered (SupplyRequestId),
	CONSTRAINT FK_Request_SupplyRequest FOREIGN KEY (SupplyId) REFERENCES Request.Supply(SupplyId),
	CONSTRAINT FK_Apartment_ApartmentUnit FOREIGN KEY (ApartmentUnitId) REFERENCES Apartment.ApartmentUnit(ApartmentUnitId)

  
);
