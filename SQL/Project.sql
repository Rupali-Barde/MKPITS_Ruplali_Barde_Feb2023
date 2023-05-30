create database Project;				--Create Datbase
create table Table_ProductGSTDetails(Product_Gst_Id int primary key,Gst_Detail_Name varchar(500),CGST decimal
(10,2),SGST decimal(10,2),IGST decimal(10,2));			--Create Table Table_productGSTDetails
select * from Table_ProductGSTDetails;						--Insert Record
insert into Table_ProductGSTDetails values(601,'AC and Fridge',14,14,14),
(602,'Computers',9,9,9),(603,'Printers',9,9,9),(604,'Mobiles',6,6,6);

create table TableProductCategory(Product_Category_ID int primary key,
Product_Type_Name varchar (500),
Product_Gst_ID int,constraint c1 foreign key
(Product_Gst_ID)references Table_ProductGSTDetails
(Product_Gst_ID));
select * from TableProductCategory
insert into TableProductCategory values(1001,'Computers',602),(1002,'Mobile',604),
(1003,'Printers',603),(1004,'AC and fridge',601);

create  table TableProduct(ProductID int primary key,ProductTypeID int,ProductName varchar(500),ProductPrice int,
Constraint c2 foreign key (ProductTypeID)references
TableProductCategory(Product_Category_ID));
select * from TableProduct
insert into TableProduct values(210,1002,'Apple',90000),(211,1002,'Lenovo',50000),
(212,1003,'Samsung',47000),(213,1004,'IFB',29000),(214,1004,'LG',65000),(215,1001,'Sony',80000);


