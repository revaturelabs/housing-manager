create table Batch.BatchType(
    BatchTypeId int IDENTITY(1,1) not null,
    Type nvarchar(50) not null,
	constraint PK_Batch_BatchType_BatchTypeId primary key clustered (BatchTypeId),
);
