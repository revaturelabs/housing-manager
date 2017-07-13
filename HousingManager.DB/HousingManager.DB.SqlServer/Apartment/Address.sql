create table Apartment.Address(
    AddressId int primary key clustered IDENTITY(1,1) not null,
    StreetName nvarchar(200) not null,
    AptNum nvarchar(5) not null,
    City nvarchar(30)  not null,
    [State] nvarchar(10) not null,
	ZipCode int not null
);