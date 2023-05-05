Select * from stores
insert into stores values(1,'Mahindra',1234567,'m@gmail.com','sadar line',
'nagpur','Maharashtra',444234)
insert into stores values(2,'Maroti',22345678,'ma@gmail.com','mahal',
'nagpur','Maharashtra',444235)
insert into stores values(3,'Thar',33456789,'m@gmail.com','itwara',
'nagpur','Maharashtra',444236)
insert into stores values(4,'Activa',44567890,'a@gmail.com','pardi',
'nagpur','Maharashtra',444237)
insert into stores values(5,'Nano',55678901,'m@gmail.com','ravi nagar',
'nagpur','Maharashtra',444238)
select * from stores

select * from category
insert into category values(101,'four wheelar')
insert into category values(102,'four wheelar')
insert into category values(103,'four wheelar')
insert into category values(104,'two wheelar')
insert into category values(105,'four wheelar')
select * from category
select * from stores

alter table stores add constraint city check(street = 'itwara')
select * from stores
