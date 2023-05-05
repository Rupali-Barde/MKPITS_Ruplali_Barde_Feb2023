create table orders(order_id int,order_date varchar(20),cust_id int,prod_name varchar(20),
quantity int,rate int)
select * from orders
insert into orders(order_id,order_date,cust_id,prod_name,quantity,rate)values
(101,'10-2-2022',111,'Mouse',5,120),
(102,'11-2-2022',112,'Keyboard',6,150),
(103,'12-2-2022',113,'Desktop',7,600),
(104,'13-2-2022',114,'CPU',3,300),
(105,'14-2-2022',115,'Printer',4,3000)
select * from orders

create table customer(cust_id int,cust_name varchar(20),telno int) --Create Table
select * from customer
insert into customer(cust_id,cust_name,telno)values				--Insert Data Into Table
(111,'Amit',123456),
(112,'Arti',234567),
(113,'Ankit',345678),
(114,'Abhi',456789),
(115,'Shyam',567890)
select * from customer

--INNER JOINS ASSIGNMENT

select orders.order_id, orders.order_date, orders.prod_name,
orders.prod_name,orders.quantity,orders.rate,
customer.cust_id,customer.cust_name,customer.telno 
from orders 
inner join customer on orders.cust_id=customer.cust_id;
