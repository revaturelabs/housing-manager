
Create table Person.ContactInfo(
	ContactInfoId int primary key clustered IDENTITY(1,1) not null,
    EmailAddress nvarchar(50) not null,
    PhoneNumber nvarchar(50) not null
);