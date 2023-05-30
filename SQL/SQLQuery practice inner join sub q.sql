create database courses

create table course(courseid int primary key,coursename varchar (20))				--create Table
insert into course( courseid,coursename)values(101,'Dotnet'),			--data Insert
(102,'Java')

select * from course

create table studentdetails (rollno int,name varchar(20),
courseid int constraint s1 foreign key(courseid)references course (courseid))

insert into studentdetails(rollno,name,courseid) values(1,'Amit',101),				--Insert Data into Studentdetails 
(2,'Arti',101),(3,'Ankit',102),(4,'Abhi',102)
select * from studentdetails

select c1.courseid, c1.coursename,s1.name from course c1 inner join						--inner join
studentdetails s1 on c1.courseid = s1.courseid where c1.courseid = 101;

select c1.courseid, c1.coursename,s1.name from course c1 inner join						--inner join
studentdetails s1 on c1.courseid = s1.courseid where c1.courseid = 102;

																				