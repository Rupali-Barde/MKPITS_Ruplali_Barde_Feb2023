select * from product
select product_name from product order by LEN(product_name)desc;
select product_name from product order by LEN(product_name)asc;
select * from product
select top 2 product_name ,price from product order by price desc;
select top 3 product_name ,quantity from product order by quantity asc;
select top 30 percent product_name , price from product order by price desc;
select top 50 percent product_name , price from product order by price desc;
select distinct product_name from product
select distinct quantity from product