create table Request.MaintenanceRequest(
    MaintenanceRequestId int IDENTITY(1,1) not null,
    MaintenanceTypeID int not null,
    ApartmentUnitId int not null,
	ManagerId int not null,
	Submitted datetime not null,
	Desctiption nvarchar not null,
	constraint PK_Request_MaintenanceRequest_MaintenanceRequestId primary key clustered (MaintenanceRequestId),
	CONSTRAINT FK_Request_MaintenanceRequest_MaintenanceRequestTypeID FOREIGN KEY (MaintenanceTypeID) REFERENCES Request.MaintenanceType(MaintenanceTypeID),
	CONSTRAINT FK_Request_MaintenanceRequest_ApartmentUnitId FOREIGN KEY (ApartmentUnitId) REFERENCES Request.MaintenanceType(MaintenanceTypeID),

  
);
