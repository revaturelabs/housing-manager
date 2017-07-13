create table Apartment.ApartmentComplex(
    ApartmentComplexId int IDENTITY(1,1) not null,
    AddressId  int not null,
    ApartmentName nvarchar(50) not null,
    WalkingDistance bit default(1),
	constraint PK_Apartment_ApartmentComplex_ApartmentComplexId primary key clustered (ApartmentComplexId),
		CONSTRAINT FK_Apartment_ApartmentComplex_AddressId FOREIGN KEY (AddressId) REFERENCES Apartment.Address(AddressId)

);
