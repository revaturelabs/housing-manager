create table Batch.Batch(
    BatchId int IDENTITY(1,1) not null,
    BatchTypeId int not null,
    StarDate DateTime not null,
	EndDate DateTime not null,
    constraint PK_Batch_Batch_BatchId primary key clustered (BatchId),
	CONSTRAINT FK_Batch_Batch_BatchType FOREIGN KEY (BatchTypeId) REFERENCES Batch.BatchType(BatchTypeId)

);
