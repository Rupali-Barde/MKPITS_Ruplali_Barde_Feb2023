create database institute
create table student1(admission_no int,first_name varchar(20),last_name varchar(20),age int,
city varchar(20))
insert into student1(admission_no,first_name,last_name,age,city)values
(1234,'Rupali','Barde',21,'Paratwada'),
(1235,'Mahima','Barde',21,'nagpur'),
(1236,'Shreya','Dhakale',22,'nagpur'),
(1237,'Mayuri','Pal',22,'nagpur'),
(1238,'Akansha','Wahane',22,'tumsar'),
(1239,'Aditya','Raut',22,'morshi'),
(1210,'Gopal','Rathod',21,'amrawati'),
(1211,'Vaibhav','Pawar',22,'warud'),
(1212,'Mohit','Jadhav',21,'saoner'),
(1213,'Harsh','Giri',22,'bhandara')
select * from student1

create table fees(addmisson_no varchar (20),course varchar(20),amount_paid int)
select * from fees
insert into fees(addmisson_no,course,amount_paid)values
('1234','C',20000),
('1235','Csharp',15000),
('1236','java',10000),
('1237','python',9000),
('1238','php',5000),
('1239','sql',5500),
('1210','dotnet',6000),
('1211','html',3000),
('1212','javascript',4000),
('1213','css',2500)
select * from fees


--JOINS--
select s.admission_no,s.first_name,s.last_name,
f.course,f.amount_paid from student1 s inner join fees f on s.admission_no = f.addmisson_no;--INNER JOIN

--OUTER JOIN
--LEFT OUTER JOIN

select s.admission_no,s.first_name,s.last_name ,f.course,f.amount_paid  from student1
s left outer join fees f on s.admission_no =f.addmisson_no;

--RIGHT OUTER JOIN


select student1.admission_no,student1.first_name,student1.last_name,
fees.course,fees.amount_paid from student1
RIGHT OUTER JOIN fees 
on student1.admission_no = fees.addmisson_no;



