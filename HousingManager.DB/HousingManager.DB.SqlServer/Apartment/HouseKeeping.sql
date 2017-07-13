create table Apartment.HouseKeeping(
    HousekeepingId int IDENTITY(1,1) not null,
    ApartmentUnitId int unique NOT null,
    LastCleaning date not null,
	NextCleaning date not null,
	constraint PK_Apartment_HouseKeeping_HouseKeepingId primary key clustered (HousekeepingId),

);