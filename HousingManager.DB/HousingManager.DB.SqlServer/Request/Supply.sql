create table Request.Supply(
    SupplyId int not null,
	Type nvarchar(50) not null,
	constraint PK_Request_Supply_SupplyId primary key clustered (SupplyId),
		
);