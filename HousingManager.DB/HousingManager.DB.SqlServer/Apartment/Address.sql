create table Apartment.Address(
    AddressId int IDENTITY(1,1) not null,
    StreetName nvarchar(50) not null,
    AptNum nvarchar not null,
    City nvarchar(30)  not null,
    State nvarchar(10) not null,
	ZipCode int not null,
	constraint PK_Apartment_Address_AddressId primary key clustered (AddressId),
);