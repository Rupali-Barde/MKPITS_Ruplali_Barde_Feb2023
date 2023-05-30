create database Assignment2
create table salesmen(salesman_id int primary key,
name varchar (20),city varchar(20),
commision dec(10,2))

select * from salesmen

insert into salesmen(salesman_id,name,city,commision)
values
(5001,'James Hoog','New York',0.15),
(5002,'Nail Knite','Paris',0.13),
(5003,'Pit Alex','London',0.11),
(5004,'Mc Lyon','Paris',0.14),
(5005,'Paul Adam','Rome',0.13),
(5006,'Lauson Hen','San Jose',0.12)
select * from salesmen

--Write a SQL statement to display specific columns like name and commission for all the salesmen.
select  name , commision from salesmen;

--Write a query to display the columns in a specific order like order date, salesman id, order number and
--purchase amount from for all the orders.
create table orders(orderno int primary key,purch_amt dec(10,2),
ord_date varchar(20),cust_id int,salesman_id int
constraint s1 foreign key (salesman_id) references
salesmen(salesman_id));

select * from orders

insert into orders(orderno,purch_amt,ord_date,
cust_id,salesman_id) values
(70001,150.5,'2012-10-5',3005,5002),
(70009,270.65,'2012-09-10',3001,5005),
(70002,65.26,'2012-10-05',3002,5001),
(70004,100.5,'2012-08-17',3009,5003),
(70007,948.5,'2012-07-10',3005,5002),
(70005,2400.6,'2012-07-27',3007,5001),
(70008,5760,'2012-09-10',3002,5001)
select * from orders

--Query
select ord_date,salesman_id,orderno,
purch_amt from orders;

--4- From the following table, write a SQL query to find the unique salespeople ID. Return salesman_id.
create table salesmanInfo(ord_no  int primary key,
purch_amt dec(10,2),ord_date varchar (20),
cust_id int,salesmen_id int constraint t2
foreign key (salesmen_id)references salesmen(salesman_id));
select * from salesmanInfo
insert into salesmanInfo (ord_no,purch_amt,ord_date,cust_id,salesmen_id) values
(70001,150.5, '2012-10-05', 3005, 5002),
(70009, 270.65, '2012-09-10', 3001, 5005),
(70002, 65.26, '2012-10-05', 3002, 5001),
(70004, 110.5 ,'2012-08-17', 3009, 5003),
(70007, 948.5, '2012-09-10', 3005 ,5002),
(70005, 2400.6, '2012-07-27', 3007, 5001),
(70008, 5760, '2012-09-10', 3002, 5001)
select * from salesmanInfo
select distinct salesman_id from salesmanInfo