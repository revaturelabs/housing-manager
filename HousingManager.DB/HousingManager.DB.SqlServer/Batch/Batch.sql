create table Batch.Batch(
    BatchId int primary key clustered IDENTITY(1,1) not null,
    BatchTypeId int not null,
    StarDate DateTime not null,
	EndDate DateTime not null,
	Size int not null,

	CONSTRAINT FK_Batch_Batch_BatchType FOREIGN KEY (BatchTypeId) REFERENCES Batch.BatchType(BatchTypeId)

);
