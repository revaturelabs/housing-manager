create table Apartment.ApartmentUnit(
    ApartmentUnitId int IDENTITY(1,1) not null,
    ApartmentComplexId int not null,
    AddressId int unique not null,
    ProviderId int not null,
    Capacity int not null,
	constraint PK_Apartment_ApartmentUnit_ApartmentUnitId primary key clustered (ApartmentUnitId),
		CONSTRAINT FK_Apartment_ApartmentUnit_ApartmentComplexId FOREIGN KEY (ApartmentComplexId) REFERENCES Apartment.ApartmentComplex(ApartmentComplexId),
			CONSTRAINT FK_Apartment_ApartmentUnit_ApartmentId FOREIGN KEY (AddressId) REFERENCES Apartment.Address(AddressId),
			CONSTRAINT FK_Apartment_ApartmentUnit_ProviderId FOREIGN KEY (ProviderId) REFERENCES Person.Provider(ProviderId)
);