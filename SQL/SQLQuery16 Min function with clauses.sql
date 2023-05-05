create database worker
create table emp1(name varchar (20),occupation varchar (20),date varchar(20),
working_hr int,salary int)
select * from emp1
insert into emp1 values('johny Evans','HR','2020-10-4',9,25000)
insert into emp1 values('Braydon Simmons','Engineer','2020-10-4',12,65000)
insert into emp1 values('Rose Huges','writer','2020-10-4',13,35000)
insert into emp1 values('Laura Paul','Manager','2020-10-4',10,45000)
insert into emp1 values('Diego Simmons','Teacher','2020-10-4',12,30000)
insert into emp1 values('Antonic Bennet','Writer','2020-10-4',13,35000)
insert into emp1 values('Laura Paul','Manager','2020-10-5',10,42000)
insert into emp1 values('Antonic Bennet','Writer','2020-10-5',9,38000)
insert into emp1 values('Rose Huges','Writer','2020-10-5',12,36000)
insert into emp1 values('jolly Evans','HR','2020-10-5',11,30000)
select * from emp1

		--MIN Function With Group By,Having Clauses
select MIN (working_hr) AS "minimum working_hr"from emp1 
select min (working_hr) from emp1
select name,salary from emp1 where salary=(select min (salary) as "minimum salary" from emp1)					--Where Clause

select name,occupation,min(working_hr) as "MINIMUM WORKING HOURS"
from emp1															--Having Clause
group by name,occupation
having min(working_hr)>5

select * from emp1

