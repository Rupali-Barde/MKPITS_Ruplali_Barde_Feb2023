
---Create Table
create table emplog(LogID int IDENTITY(1,1)
NOT NULL,EmpID int NOT NULL,
Operation nvarchar(10) NOT NULL,
UpdatedDate Datetime NOT NULL)

create table employee(empid int primary key,
empname varchar(20))

drop employee

--Create Trigger
create trigger empt
on employee
for insert
as
insert into EmpLog(EmpId,Operation,
UpdatedDate)
select empid,'insert',GETDATE()
from inserted;

