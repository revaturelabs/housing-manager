create procedure testSetup
as
begin
	begin transaction
		begin try
			insert into Apartment.[Address] (StreetName, AptNum, City, [State], ZipCode)
			values ('100 Test Street', '100', 'Testville', 'Test', 12345);
			commit tran;
		end try
		begin catch
			rollback transaction;
		end catch
end;
go

create procedure testTeardown
as
begin
	begin transaction
		begin try
			delete from Apartment.[Address] where City = 'TestVille';
			commit tran;
		end try
		begin catch
			rollback transaction;
		end catch
end;
go