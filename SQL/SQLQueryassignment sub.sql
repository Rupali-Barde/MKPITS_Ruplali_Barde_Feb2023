create database Assignment
create a table student having columns rno,name,email,city,courseid     --Create Table
create table student(rno int primary key,name varchar (20),email varchar (20),city varchar (20),
courseid int)
select * from student

drop table student
--insert some records into student table	
insert into student (rno,name,email,city,courseid) values
(1,'Amit','amit@gmail.com','Nagpur',101),
(2,'Arti','arti@gmail.com','Amarawati',102),
(3,'Anup','anup@gmail.com','Wardha',103),
(4,'Aamr','amar@gmail.com','Pune',104),
(5,'Abhi','abhi@gmail.com','Nashik',105)
select * from student


--create a table fees having columns feesid,rno,feesdate,amount,courseid
create table fees(feesid int,rno int, --foeign key
feesdate varchar(20),amount int,courseid int primary key,
constraint r1 foreign key(rno) references student (rno));
select * from fees
--inset data into fees table
insert into fees(feesid,rno,feesdate,amount,courseid)values
(501,1,17-2-2023,5000,101),
(502,2,18-3-2023,6000,102),
(503,3,17-4-2023,6500,103),
(504,4,18-5-2023,7000,104),
(505,5,19-3-2023,4000,105)
select * from fees
--write a query to display fees details of those student whose city=nagpur
select
select s.rno,s.name,f.feesid,f.amount from student s
inner  join fees f on s.rno = f.rno where city ='Nagpur'

--write a query to display fees details of those student whose city=mumbai
--write a query to display fees details of those student whose city=delhi