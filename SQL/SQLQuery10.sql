create table Products(order_no int  primary key,order_date varchar(20),prod_id int,
rate int, quantity int)
select* from products

drop table products

create table Delivery_Detail(order_no int primary key,order_date varchar(20),cust_id int)
select * from Delivery_Detail
insert into Delivery_Detail values(1,'12/12/2022',211)
insert into Delivery_Detail values(2,'12/1/2023',212)
insert into Delivery_Detail values(3,'10/2/2023',213)
select * from Delivery_Detail

create table Prod_Detail (order_no int,prod_id int,rate int,quantity int,
constraint t2 foreign key (order_no) references Delivery_Detail (order_no))
select * from Prod_Detail

insert into Prod_Detail values(1,123,200,2)
insert into Prod_Detail values(1,124,500,4)
insert into Prod_Detail values(2,123,200,3)
insert into Prod_Detail values(2,125,600,5)
insert into Prod_Detail values(3,125,600,1)
select * from Prod_Detail