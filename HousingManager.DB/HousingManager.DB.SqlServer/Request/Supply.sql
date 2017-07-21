create table Request.Supply(
    SupplyId int primary key clustered not null,
	[Type] nvarchar(100) not null,	
	[Guid] UNIQUEIDENTIFIER DEFAULT NEWID() not null
);