Create table Person.TenantInfo(
	TenantInfo int primary key clustered IDENTITY(1,1)not null,
	PersonId int unique not null, 
	BatchId int not null,
	ApartmentUnitId int not null,
	Gender nvarchar(20) not null,
	MoveInDate datetime not null,
	MoveOutDate datetime not null, 
	HasCar bit,
	CONSTRAINT FK_Person_TenantInfo_PersonId FOREIGN KEY (PersonId) REFERENCES Person.Person(PersonId),
	CONSTRAINT FK_Person_TenantInfo_ApartmentUnitId FOREIGN KEY (ApartmentUnitId) REFERENCES Apartment.ApartmentUnit(ApartmentUnitId),
	CONSTRAINT FK_Person_TenantInfo_BatchId FOREIGN KEY (BatchId) REFERENCES Batch.Batch(BatchId)
);