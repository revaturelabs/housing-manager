Create table Person.PersonContactInfo(
	PersonId int not null, 
	ContactInfoId int not null,
	constraint PK_Person_PersonContactInfo_PersonId_ContactInfoId primary key clustered (PersonId, ContactInfoId),
	CONSTRAINT FK_Person_PersonContactInfo_PersonId FOREIGN KEY (PersonId) REFERENCES Person.Person(PersonId),
	CONSTRAINT FK_Person_PersonContactInfo_ContactInfoId FOREIGN KEY (ContactInfoId) REFERENCES Person.ContactInfo(ContactInfoId)

);