create table Exam(
Roll_No int,S_Name varchar(20),University varchar(20),marks int , grade char)
select * from Exam
insert into Exam values(101,'Rupali','SGBUA',87,'A')
insert into Exam values(102,'Shreya','RTMUN',98,'A')
insert into Exam values(103,'Mayuri','RTMUN',89,'A')
insert into Exam values(104,'Akansha','RTMUN',75,'B')
insert into Exam values(105,'Yasmin','RTMUN',72,'B')
insert into Exam values(106,'Tanmay','Autonomous',67,'C')
insert into Exam values(107,'Sahil','RTMUN',89,'A')
insert into Exam values(108,'Anjali','RTMUN',65,'C')
insert into Exam values(109,'Monali','RTMUN',78,'B')
insert into Exam values(110,'Tanushri','RTMUN',65,'C')
insert into Exam values(111,'Karishma','RTMUN',55,'D')
insert into Exam values(112,'Ashish','RTMUN',78,'B')
insert into Exam values(113,'Jayesh','SGBUA',86,'A')
insert into Exam values(114,'Mahima','RTMUN',98,'A')
select * from Exam
--top,distinct,in ,not,between,or, and,like,percent,order by
select * from exam where marks < 80 order by s_name
select * from exam where marks < 70 order by s_name desc;
select * from exam where grade ='C' order by s_name 
select * from exam where marks < 50 order by s_name desc;
select * from exam
alter table exam drop column last_name   
select * from exam
-- top 
select top 10 * from Exam where Marks > 90 Order By S_name
 --top percent 
 select top 80 percent * from Exam where marks < 60
 --Distinct
 select distinct university from Exam
 --between 
 select distinct * from Exam where grade between 'A' and 'D'
 --or
 select * from Exam where s_name ='Shreya' or s_name ='Mayuri'
 select * from Exam where university ='SGBUA' or university ='Autonomous'
  --IN
  select * from Exam where marks in(78,87,98)
  -- Not In
  select * from Exam where marks in (65,78,98)
  --and
  select * from Exam where s_name like 's%' and marks in(98,78,65)
  --Like
  select * from Exam where s_name like '%s' or s_name like 'Ru%' 