Create table Person.ContactInfo(
	ContactInfoId int IDENTITY(1,1) not null,
    EmailAddress nvarchar(50) not null,
    PhoneNumber nvarchar(50) not null,
	constraint PK_Person_ContactInfo_ContactInfoId primary key clustered (ContactInfoId),
   
);