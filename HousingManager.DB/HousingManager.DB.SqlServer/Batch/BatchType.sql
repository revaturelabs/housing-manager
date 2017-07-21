create table Batch.BatchType(
    BatchTypeId int primary key clustered  IDENTITY(1,1) not null,
    Type nvarchar(50) not null,	
	[Guid] UNIQUEIDENTIFIER DEFAULT NEWID() not null
);