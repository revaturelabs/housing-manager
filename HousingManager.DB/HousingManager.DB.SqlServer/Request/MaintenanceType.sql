create table Request.MaintenanceType(
    MaintenanceTypeId int IDENTITY(1,1) not null,
    Issue nvarchar(50) not null,
	constraint PK_Request_MaintenanceRequest_MaintenanceTypeId primary key clustered (MaintenanceTypeId),
);