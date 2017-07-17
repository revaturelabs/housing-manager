create table Request.MaintenanceType(
    MaintenanceTypeId int primary key clustered IDENTITY(1,1) not null,
    Issue nvarchar(200) not null

);
