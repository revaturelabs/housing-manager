Create table Person.ProviderContactInfo(
	ProviderId int not null, 
	ContactInfoId int not null,
	constraint PK_Person_ProviderContactInfo_ProviderId_ContactInfoId primary key clustered (ProviderId, ContactInfoId),
	CONSTRAINT FK_Person_ProviderContactInfo_ProviderId FOREIGN KEY (ProviderId) REFERENCES Person.Provider(ProviderId),
	CONSTRAINT FK_Person_ProviderContactInfo_ContactInfoId FOREIGN KEY (ContactInfoId) REFERENCES Person.ContactInfo(ContactInfoId)

	
);
