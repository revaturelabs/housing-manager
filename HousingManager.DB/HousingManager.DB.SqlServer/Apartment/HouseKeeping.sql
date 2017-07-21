create table Apartment.HouseKeeping(
    HousekeepingId int primary key clustered IDENTITY(1,1) not null,
    ApartmentUnitId int unique not null,
    LastCleaning date not null,
	NextCleaning date not null,	
	[Guid] UNIQUEIDENTIFIER DEFAULT NEWID() not null

);