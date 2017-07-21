create table Apartment.ApartmentComplex(
    ApartmentComplexId int  primary key clustered IDENTITY(1,1) not null,
    AddressId  int not null,
    ApartmentName nvarchar(50) not null,
    WalkingDistance bit default(1),	
	[Guid] UNIQUEIDENTIFIER not null DEFAULT NEWID()
		CONSTRAINT FK_Apartment_ApartmentComplex_AddressId FOREIGN KEY (AddressId) REFERENCES Apartment.Address(AddressId)

);