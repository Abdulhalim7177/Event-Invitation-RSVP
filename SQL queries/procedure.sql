create procedure saveData

@Fullname varchar(50),
@PhoneNumber varchar(50)

As 

insert into ATTENDERS (FullName, PhoneNumber) values (@Fullname, @PhoneNumber)

go
