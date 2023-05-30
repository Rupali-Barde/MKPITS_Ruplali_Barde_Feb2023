
create table salesCustomer(custid int primary key,firstName varchar(20),lastName varchar (20),
   phone bigint, email varchar(20),street varchar(20),city varchar (20),
   state varchar(20),zip_code int)
   select * from salesCustomer
   insert into salesCustomer(custid,firstName,lastName,phone,email,street,city,state,
   zip_code)
   values
   (101,'Aditya','Raut',8626065659,'aditya0@gmail.com','SBI Road','Morshi','Maharashtra',444745),
   (102,'Amit','kathe',7654635667,'amit@gmail.com','KalmanaMarket Road','Nagpur','Maharashtra',44123),
   (103,'Rupali','Barde',7057538168,'rupali@gmail.com','Bhandara Road Pardi','Nagpur','Maharashtra',444567),
   (104,'Ankita','Gupta',9325690904,'ankig@gmail.com','Betul Road','Indore','Madhya pradesh',444890),
   (105,'Shyam','Tiwari',9561451826,'Stiwari@gmail.com','Rajkot','Rajkot','Gujrat',444987)
   select * from salesCustomer

   create table salesOrder(orderid int primary key,custid int,							--foreign key
   orderstatus varchar(20),orderdate varchar(20),requireddate varchar(20),
   shippeddate varchar (20),storeid int,staffid int,
   constraint c1 foreign key (custid) references salesCustomer(custid));
   select * from salesOrder

   insert into salesorder(orderid,custid,orderstatus,orderdate,requireddate,shippeddate,storeid,
   staffid)values
   (1,101,'pending','12-3-2023','15-3-2023','16-3-2023',501,111),
   (2,102,'arrived','13-3-2023','13-3-2023','14-3-2023',502,112),
   (3,103,'Delivered','14-4-2023','15-4-2023','16-4-2023',503,113),
   (4,104,'pending','15-5-2023','16-5-2023','17-5-2023',504,114),
   (5,105,'arrived','16-6-2023','17-6-2023','18-6-2023',505,115)
   select * from salesorder

   --Subquery to display whrere the customer belongs from nagpur.
   select 
   orderid,orderdate,custid 
   from salesOrder
   where custid in (
   select custid from salesCustomer where
   city = 'Nagpur')

