create database ado
create table city(cityid int primary key,cityname varchar(30));
select * from city;
insert into city values(1,'Pune'),(2,'Nagpur'),(3,'Mumbai');

create table employee(empid int primary key,empname varchar(30),gender varchar(20),
Mobile bigint,email varchar(30),DOB date,city varchar(30));
select * from employee;
