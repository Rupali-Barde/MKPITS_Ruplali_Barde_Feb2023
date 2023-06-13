create table Item_Master(Item_Id int  identity primary key ,Item_Name varchar(250) not null,
Category varchar (250) not null,Rate decimal(10,0),Balance_Quantity int not null);
select * from Item_Master;

Create table Department_Mast(Department_Id  int identity primary key,Department_Name varchar(250) not null);
select * from Department_Mast;

Create table Vendor_Mast(Vendor_Id int  identity primary key,Vendor_Name varchar(250) not null);
select * from Vendor_Mast;

create table Transaction_Process(
Transation_id int identity primary key,
Item_Id int, --foreign key Item_Id (from table Item_master)
transaction_date date not null,
Department_Id int, --foreign key Department_id (from table Department_mast)
Vendor_Id int, --foreign key Vendor_id (from table Vendor_mast)
Quantity int not null
constraint c1 foreign key(Item_Id) references Item_master(Item_Id),
constraint c2 foreign key(Department_Id) references Department_mast(Department_id),
constraint c3 foreign key(Vendor_Id) references Vendor_mast(Vendor_id)
)
select * from Transaction_Process;
drop table Transaction_Process;

create table Transaction_Process(
Transation_id int identity primary key,
item_id int, --foreign key Item_Id (from table Item_master)
transaction_date date not null,
Department_id int, --foreign key Department_id (from table Department_mast)
Vendor_Id int, --foreign key Vendor_id (from table Vendor_mast)
Quantity int not null
constraint c1 foreign key(Item_Id) references Item_Master(Item_Id),
constraint c2 foreign key(Department_Id) references Department_Mast(Department_Id),
constraint c3 foreign key(Vendor_Id) references Vendor_Mast(Vendor_Id)
)

select * from Transaction_Process;

select  * from Department_Mast;